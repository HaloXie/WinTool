using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace NeuSoft.ServiceInterface.Common.Helper
{
    public static class ExpressionHelper
    {
        public static Expression<Func<TTarger, bool>> ConvertExpression<TSources, TTarger>(Expression<Func<TSources, bool>> sourcesLambda)
        {
            ReadOnlyCollection<ParameterExpression> readOnlyCollection = sourcesLambda.Parameters;


            //UnaryExpression unaryExpression = Expression.Convert(  Expression.Call(  Expression.Parameter(typeof(TTarger), readOnlyCollection[0].Name),typeof(TTarger)));

            //Expression expressionForBody = Expression.Convert(sourcesLambda.Body,typeof(TTarger));







            Expression expressionForBody = sourcesLambda.Body;
            Func<TTarger, bool> funForReturn = null;
            Expression<Func<TTarger, bool>> expressionForReturn = null;
            for (int i = 0; i < readOnlyCollection.Count; i++)
            {
                string Name = readOnlyCollection[i].Name;
                ParameterExpression expression = Expression.Parameter(typeof(TTarger), Name);
                expressionForReturn = Expression.Lambda<Func<TTarger, bool>>(expressionForBody, expression);
                funForReturn = Expression.Lambda<Func<TTarger, bool>>(expressionForBody, expression).Compile();
            }
            return expressionForReturn;
        }
        public static Expression<Func<TTarger, object>> ConvertExpression<TSources, TTarger>(Expression<Func<TSources, object>> sourcesLambda)
        {
            ReadOnlyCollection<ParameterExpression> readOnlyCollection = sourcesLambda.Parameters;
            Expression expressionForBody = sourcesLambda.Body;
            Expression<Func<TTarger, object>> expressionForReturn = null;
            for (int i = 0; i < readOnlyCollection.Count; i++)
            {
                string Name = readOnlyCollection[i].Name;
                ParameterExpression expression = Expression.Parameter(typeof(TTarger), Name);
                expressionForReturn = Expression.Lambda<Func<TTarger, object>>(expressionForBody, expression);
            }
            return expressionForReturn;
        }

        public static Expression ConvertExpressionType(Expression expression, Type typeSources, Type typetarget)
        {
            PropertyInfo[] propertyInfoArray = expression.GetType().GetProperties();
            Expression expressionForLeft = null;
            foreach (var propertyInfo in propertyInfoArray)
            {
                if (propertyInfo.Name == "Left")
                {

                    expressionForLeft = (Expression)propertyInfo.GetValue(expression, null);
                    if (expressionForLeft.Type == typeSources)
                    {

                    }
                    return ConvertExpressionType(expressionForLeft, typeSources, typetarget);
                }
            }
            return expressionForLeft;
        }

        #region gw

        public static IEnumerable<T> Concat<T>(this IEnumerable<IEnumerable<T>> source)
        {
            var concat = Enumerable.Empty<T>();
            foreach (var local in source)
            {
                concat = concat.Concat(local);
            }
            return concat;
        }

        public static IEnumerable<Expression> Visit(this Expression expression)
        {
            if (expression == null)
            {
                return Enumerable.Empty<Expression>();
            }
            var self = Enumerable.Repeat(expression, 1);
            if (expression is ConstantExpression
                || expression is ParameterExpression)
            {
                return self;
            }
            if (expression is UnaryExpression)
            {
                return self.Concat((expression as UnaryExpression).Operand.Visit());
            }
            if (expression is BinaryExpression)
            {
                var expr = expression as BinaryExpression;
                return self.Concat(expr.Left.Visit()).Concat(expr.Right.Visit());
            }
            if (expression is TypeBinaryExpression)
            {
                return self.Concat((expression as TypeBinaryExpression).Expression.Visit());
            }
            if (expression is ConditionalExpression)
            {
                var expr = expression as ConditionalExpression;
                return self.Concat(expr.Test.Visit()).Concat(expr.IfTrue.Visit()).Concat(expr.IfFalse.Visit());
            }
            if (expression is MemberExpression)
            {
                return self.Concat((expression as MemberExpression).Expression.Visit());
            }
            if (expression is MethodCallExpression)
            {
                var expr = expression as MethodCallExpression;
                return self.Concat(expr.Object.Visit()).Concat(expr.Arguments.Select(arg => arg.Visit()).Concat());
            }
            if (expression is NewExpression)
            {
                return self.Concat((expression as NewExpression).Arguments.Select(arg => arg.Visit()).Concat());
            }
            if (expression is NewArrayExpression)
            {
                return self.Concat((expression as NewArrayExpression).Expressions.Select(expr => expr.Visit()).Concat());
            }
            if (expression is InvocationExpression)
            {
                var expr = expression as InvocationExpression;
                return self.Concat(expr.Expression.Visit()).Concat(expr.Arguments.Select(arg => arg.Visit()).Concat());
            }
            if (expression is MemberInitExpression)
            {
                var expr = expression as MemberInitExpression;
                return self.Concat(expr.NewExpression.Visit()).Concat(expr.Bindings.Cast<MemberAssignment>().Select(bind => bind.Expression.Visit()).Concat());
            }
            if (expression is ListInitExpression)
            {
                var expr = expression as ListInitExpression;
                return self.Concat(expr.NewExpression.Visit()).Concat(expr.Initializers.Select(init => init.Arguments.Select(arg => arg.Visit()).Concat()).Concat());
            }
            if (expression is LambdaExpression)
            {
                var expr = expression as LambdaExpression;
                return self.Concat(expr.Parameters.Select(param => param.Visit()).Concat()).Concat(expr.Body.Visit());
            }
            throw new NotSupportedException();
        }

        public static Expression<Func<TResult, bool>> ReplaceMember<TSource, TResult>(this Expression<Func<TSource, bool>> expression)
        {
            var body = expression.Body;
            var obj = Expression.Parameter(typeof(TResult), "obj");
            foreach (var expr in body.Visit())
            {
                var member = expr as MemberExpression;
                if (member == null || member.Expression != expression.Parameters[0])
                {
                    continue;
                }
                var type = member.GetType();
                type.GetField("expr", (BindingFlags)0x24).SetValue(member, obj);
                type.GetField("member", (BindingFlags)0x24).SetValue(member, member.Member);
            }
            return Expression.Lambda<Func<TResult, bool>>(body, obj);
        }

        #endregion
    }
}

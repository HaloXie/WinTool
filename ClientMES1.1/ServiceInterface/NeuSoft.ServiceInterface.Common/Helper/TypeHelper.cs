using System;
using System.Reflection;

namespace NeuSoft.ServiceInterface.Common.Helper
{
    public class TypeHelper
    {
        public static TTarget SetNewObjectModel<TTarget, TSources>(TSources tSources)
        {
            PropertyInfo[] sourcesPropertyInfoArray = tSources.GetType().GetProperties();
            Type targetType = typeof(TTarget);
            object sourcesObject = tSources;
            object targetObject = targetType.Assembly.CreateInstance(targetType.FullName);
            PropertyInfo[] targetTypePropertyInfoArray = targetType.GetProperties();
            foreach (PropertyInfo targetPropertyInfo in targetTypePropertyInfoArray)
            {
                foreach (PropertyInfo sourcesPropertyInfo in sourcesPropertyInfoArray)
                {
                    if (targetPropertyInfo.Name == sourcesPropertyInfo.Name)
                    {
                        targetPropertyInfo.SetValue(targetObject, sourcesPropertyInfo.GetValue(sourcesObject, null), null);
                    }
                }
            }
            return (TTarget)targetObject;
        }




        //public static T SetNewObjectList<T>(Type type)
        //{
        //    PropertyInfo[] sourcesPropertyInfoArray = type.GetProperties();
        //    Type targetType = typeof(T);
        //    object sourcesObject = type.Assembly.CreateInstance(type.FullName);
        //    object targetObject = targetType.Assembly.CreateInstance(targetType.FullName);
        //    PropertyInfo[] targetTypePropertyInfoArray = targetType.GetProperties();
        //    foreach (PropertyInfo targetPropertyInfo in targetTypePropertyInfoArray)
        //    {
        //        foreach (PropertyInfo sourcesPropertyInfo in sourcesPropertyInfoArray)
        //        {
        //            if (targetPropertyInfo.Name == sourcesPropertyInfo.Name)
        //            {
        //                targetPropertyInfo.SetValue(targetObject, sourcesPropertyInfo.GetValue(sourcesObject, null), null);
        //            }
        //        }
        //    }
        //    return (T)targetObject;
        //}
    }
}

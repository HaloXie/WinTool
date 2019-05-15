//using Dos.ORM;
//using System.Collections.Generic;
//using System;

//namespace NeuSoft.ServiceInterface.Common.Data
//{
//    public class DataField : Field
//    {
//        public Field field { get; set; }

//        public string ProprtyName { get; set; }
//        public string ObjectName { get; set; }
//        public DataWhere(string proprtyName, string objectName):Base()
//        {
//            if (string.IsNullOrEmpty(objectName))
//            {
//                throw new NotImplementedException("ObjectName参数为空或null");
//            }
//            this.ProprtyName = proprtyName;
//            this.ObjectName = objectName;
//            string tableName = objectName.Remove(objectName.IndexOf("DTO"));
//            this.ObjectName = tableName;
//            field = new Field(proprtyName, tableName, proprtyName);
//        }

//        public DataWhere(DataWhere dataWhere, int value, OperatorEnum operatorEnum)
//        {
//            ProprtyName = dataWhere.ProprtyName;
//            ObjectName = dataWhere.ObjectName;
//            field = dataWhere.field;
//        }
//        public static DataWhere operator >(DataWhere left, int right)
//        {
//            return new DataWhere(left, right, OperatorEnum.Greater);
//        }
//        public static DataWhere operator <(DataWhere left, int right)
//        {
//            return new DataWhere(left, right, OperatorEnum.Less);
//        }
//        public static DataWhere operator >=(DataWhere left, int right)
//        {
//            return new DataWhere(left, right, OperatorEnum.GreaterAndEqual);
//        }
//        public static DataWhere operator <=(DataWhere left, int right)
//        {
//            return new DataWhere(left, right, OperatorEnum.LessAndEqual);
//        }
//    }

//    public enum OperatorEnum
//    {
//        Greater,
//        GreaterAndEqual,
//        Less,
//        LessAndEqual
//    }

//    public class test
//    {
//        public void a()
//        {
//            DataWhere dataWhere = new DataWhere("abc", "abcDTO");
//            DataWhere datawhere2 = new DataWhere("abc", "abcDTO");
//            var datawhere = dataWhere > 1;
//        }
//    }
//}

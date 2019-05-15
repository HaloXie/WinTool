using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NeuSoft.ServiceInterface.Common.Helper
{
    public class SqlHelper
    {
        private static string _ConnectionString;
        private static string ConnectionString
        {
            get
            {
                if (_ConnectionString == null)
                {
                    SQLiteConnectionStringBuilder sqLiteConnectionStringBuilder = new SQLiteConnectionStringBuilder();
                    sqLiteConnectionStringBuilder.DataSource = System.IO.Directory.GetCurrentDirectory() + "\\ClientMES.db";
                    sqLiteConnectionStringBuilder.Pooling = true;
                    sqLiteConnectionStringBuilder.FailIfMissing = false;
                    _ConnectionString = sqLiteConnectionStringBuilder.ToString();
                }
                return _ConnectionString;
            }
        }
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sqlCommandText"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sqlCommandText)
        {
            using (SQLiteConnection sqliteConnection = new SQLiteConnection(ConnectionString))
            {
                Console.WriteLine(sqliteConnection.Database);
                Console.WriteLine(sqliteConnection.ConnectionString);
                Console.WriteLine(ConnectionString);
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(sqlCommandText, sqliteConnection))
                {
                    try
                    {
                        sqliteConnection.Open();
                        return sqliteCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        return -1;
                    }
                }
            }
        }
        /// <summary>
        /// 读取数据 
        /// </summary>
        /// <param name="sqlCommandText"></param>
        /// <returns></returns>
        public static SQLiteDataReader ExecuteReader(string sqlCommandText)
        {
            SQLiteConnection sqliteConnection = new SQLiteConnection(ConnectionString);
            using (SQLiteCommand sqliteCommand = new SQLiteCommand(sqlCommandText, sqliteConnection))
            {
                try
                {
                    sqliteConnection.Open();
                    return sqliteCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return null;
                }
            }
        }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sqlCommandText"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sqlCommandText, CommandType commandType, params SQLiteParameter[] sqliteParameters)
        {
            using (SQLiteConnection sqliteConnection = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(sqlCommandText, sqliteConnection))
                {
                    try
                    {
                        sqliteCommand.CommandType = commandType;
                        if (sqliteParameters != null)
                        {
                            sqliteCommand.Parameters.AddRange(sqliteParameters);
                        }
                        sqliteConnection.Open();
                        return sqliteCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        return -1;
                    }
                }
            }
        }

        /// <summary>
        /// 读取数据 
        /// </summary>
        /// <param name="sqlCommandText"></param>
        /// <returns></returns>
        public static SQLiteDataReader ExecuteReader(string sqlCommandText, CommandType commandType, params SQLiteParameter[] sqliteParameters)
        {
            SQLiteConnection sqliteConnection = new SQLiteConnection(ConnectionString);
            using (SQLiteCommand sqliteCommand = new SQLiteCommand(sqlCommandText, sqliteConnection))
            {
                try
                {
                    sqliteCommand.CommandType = commandType;
                    if (sqliteParameters != null)
                    {
                        sqliteCommand.Parameters.AddRange(sqliteParameters);
                    }
                    sqliteConnection.Open();
                    return sqliteCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return null;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlCommandText"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sqlCommandText)
        {
            using (SQLiteConnection sqliteConnection = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(sqlCommandText, sqliteConnection))
                {
                    try
                    {
                        sqliteConnection.Open();
                        return sqliteCommand.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        return null;
                    }
                }
            }
        }
    }
}

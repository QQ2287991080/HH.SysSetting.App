using Dapper;
using HH.SysSetting.App.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HH.SysSetting.App.Data
{
    public class DataHelper
    {
        private static string connectionStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        public DataHelper()
        {
            SqlConnection conn = new SqlConnection();
        }

        public static IDbConnection GetConnection()
        {
            return new SqlConnection(connectionStr);
        }
        #region 没有数据库连接的情况下
        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int Excute(string sql, object obj = null)
        {
            using (var conn= GetConnection())
            {
                return conn.Execute(sql, obj);
            }
        }
        /// <summary>
        /// 返回单个对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T QueryFirstOrDefault<T>(string sql,object obj=null)
        {
            using (var conn=GetConnection())
            {
                return conn.QueryFirstOrDefault<T>(sql, obj);
            }
        }
        /// <summary>
        /// 根据表命返回单个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="where"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T FirstOrDefault<T>(string where,object obj=null)
        {
            var sql = ModelsExtensions.Select<T>() + where;
            using (var conn = GetConnection())
            {
                return conn.QueryFirst<T>(sql, obj);
            }
           
        }
        /// <summary>
        /// 根据id返回实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public static T Get<T>(object id )
        {
            using (var conn = GetConnection())
            {
                return conn.Get<T>(id);
            }
        }
        /// <summary>
        /// 根据id是
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int Delete<T>(object id, object obj = null)
        {
            using (var conn = GetConnection())
            {
                return conn.Delete<T>(id);
            }
        }

        public static int Delete<T>(T t)
        {
            using (var conn = GetConnection())
            {
                return conn.Delete(t);
            }
        }
        public static int Insert<T>(T t)
        {
            var func = ModelsExtensions.InsertDelegate(t);
            var data = func.Invoke(t);
            return GetConnection().Execute(data.Item1, data.Item2);
        }
        public static List<T> Query<T>(string where="true")
        {
            using (var conn=GetConnection())
            {
               return conn.Query<T>(where).ToList();
            }
        }
        #endregion
        #region 有数据库连接的情况下
        public static int Insert<T>(T t,IDbConnection connection,IDbTransaction transaction=null)
        {
            var func = ModelsExtensions.InsertDelegate(t);
            var data= func.Invoke(t);
            return connection.Execute(data.Item1, data.Item2, transaction);
        }
        public static int Update<T>(T t, IDbConnection connection, IDbTransaction transaction = null)
        {
            var func = ModelsExtensions.UpdateDelegate(t);
            var data = func.Invoke(t);
            return connection.Execute(data.Item1, data.Item2, transaction);
        }
        #endregion
    }
}

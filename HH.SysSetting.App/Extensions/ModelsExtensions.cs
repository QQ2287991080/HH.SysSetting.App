using Dapper;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HH.SysSetting.App.Extensions
{
    public static class ModelsExtensions
    {
        public static Dictionary<string,string> GetModelDic<T>()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (var p in typeof(T).GetProperties())
            {
                var attribute = p.GetCustomAttribute<ColumnAttribute>();
                if (attribute == null) dic.Add(p.Name, p.Name);
                else dic.Add(p.Name, attribute.Name);
            }
            return dic;
        }
        public static string Select<T>()
        {
            var type = typeof(T);
            string wheresql = string.Empty;
            StringBuilder builder = new StringBuilder($"select   ");
            List<string> column = new List<string>();
            object obj = new ExpandoObject();
            foreach (var item in type.GetProperties())
            {
                var cName = item.GetCustomAttribute<ColumnAttribute>();
                var name = cName == null ? item.Name : cName.Name;
                column.Add(" [" + name + "] ");
            }
            builder.Append(" " + string.Join(",", column) + " from " + type.Name);
            return builder.ToString();
        }

        public static Func<T, (string, object)> InsertDelegate<T>(T t)
        {
            Func<T, (string, object)> func = p =>
            {
                p = t;
                var type = p.GetType();
                StringBuilder builder = new StringBuilder($"Insert into  {type.Name} ");
                List<string> column = new List<string>();
                List<string> value = new List<string>();
                object obj = new ExpandoObject();
                foreach (var item in type.GetProperties())
                {
                    if (item.IsDefined(typeof(KeyAttribute),true)&&item.Name.ToLower()=="id")
                    {
                        continue;
                    }
                    var cName = item.GetCustomAttribute<ColumnAttribute>();
                    var name = cName == null ? item.Name : cName.Name;
                    column.Add(" [" + name + "] ");
                    value.Add(" @" + name + " ");
                    ((IDictionary<string, object>)obj).Add(name, item.GetValue(p));
                }

                builder.Append(" ( " + string.Join(",", column) + " ) ");
                builder.Append("values ( " + string.Join(",", value) + " )");
                return (builder.ToString(), obj);
            };
            return func;
        }
        public static Func<T, (string, object)> UpdateDelegate<T>(T t)
        {
            Func<T, (string, object)> func = p =>
            {
                p = t;
                var type = p.GetType();
                string wheresql = string.Empty;
                StringBuilder builder = new StringBuilder($"Update {type.Name} ");
                List<string> column = new List<string>();
                object obj = new ExpandoObject();
                foreach (var item in type.GetProperties())
                {

                    //if (item.Name == "Id")
                    //{
                    //    wheresql = " Where Id=@Id ";
                    //    continue;
                    //}
                    var cName = item.GetCustomAttribute<ColumnAttribute>();
                    var name = cName == null ? item.Name : cName.Name;
                    ((IDictionary<string, object>)obj).Add(name, item.GetValue(p));
                    if (item.IsDefined(typeof(KeyAttribute), true))
                    {
                        wheresql = $" Where {name}=@{name} ";
                        continue;
                    }
                    column.Add(" [" + name + "]= @" + name + " ");
                }
                builder.Append(" Set " + string.Join(",", column) + wheresql);
                Console.WriteLine(builder);
                return (builder.ToString(), obj);
            };
            return func;
        }
    }
}

using Dapper;
using HH.SysSetting.App.Data;
using HH.SysSetting.App.Extensions;
using HH.SysSetting.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.SysSetting.App.Factory
{
    public class MenuStripFactory
    {
        /// <summary>
        /// 判断是否有常规功能
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static bool IsHaveCommand(string code)
        {
          var count=  DataHelper.QueryFirstOrDefault<int>("SELECT COUNT(Id) FROM  dbo.BA_FunctionAuth WHERE  MenuCode=@code AND (Code='Update'OR Code='Create'OR Code='Delete')", new { code });
            return count > 0;
        }


        /// <summary>
        /// 初始化功能
        /// </summary>
        /// <param name="code"></param>
        public static void InItFunc(string code)
        {
            string[] curd = new[] { "新增", "修改", "删除" };
            string[] curdCode = new[] { "Add", "Update", "Delete" };
            using (var conn = DataHelper.GetConnection())
            {
                for (int i = 0; i < curd.Length; i++)
                {
                    var name = curd[i];
                    var incode = curdCode[i];
                    BA_FunctionAuth bA = new BA_FunctionAuth
                    {
                        Code = incode,
                        Description = name,
                        MenuCode = code,
                        InIdCode = code.CombineCode(incode),
                        FuncName = name
                    };
                    conn.Insert(bA);
                }
            }
        }
    }
}

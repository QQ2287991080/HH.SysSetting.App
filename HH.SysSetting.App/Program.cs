using HH.SysSetting.App.EnType;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HH.SysSetting.App
{
    static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var connectionStr = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            if (connectionStr==null)
            {
                MessageBox.Show("未配置数据库，请联系管理员！");
                return;
            }
            //SqlConnection sqlConnection = new SqlConnection(connectionStr.ToString());
            //sqlConnection.Open();
            //if (sqlConnection.State!=System.Data.ConnectionState.Open)
            //{
            //    MessageBox.Show("连接数据库失败，请开发人员检查数据库连接字符串能否正确！");
            //    return;
            //}
            Application.Run(new EnTypeForm());
        }
    }
}

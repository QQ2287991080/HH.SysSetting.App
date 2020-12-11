using HH.SysSetting.App.EnType;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
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
            if (connectionStr == null)
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
            //Application.Run(new Form1());
            var list = LoadList(out bool ok);
            if (!ok)
            {
                Application.Run(new LoginForm.Login(list));
            }
            else
            {
                Application.Run(new Form1(list.First()));
            }

        }

        static List<DataSource> LoadList(out bool ok)
        {

            var jsonPath = AppDomain.CurrentDomain.BaseDirectory + "data.json";
            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Not Found data.json File.Please contact 【ZhangLi】to  QQ2287991080");
            }
            string key = "DataSource";
            using (System.IO.StreamReader file = new System.IO.StreamReader(jsonPath, Encoding.UTF8))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject obj = (JObject)JToken.ReadFrom(reader);
                    var node = obj[key];
                    if (node == null)
                    {
                        MessageBox.Show($"Not Found node({key}) in data.json File。");
                    }
                    var list = JsonConvert.DeserializeObject<List<DataSource>>(node.ToString());
                    if (list.Count == 1)
                    {
                         ok=true;
                    }
                    else
                    {
                        ok = false;
                       
                    }
                    return list;
                }
            }
        }

    }
}

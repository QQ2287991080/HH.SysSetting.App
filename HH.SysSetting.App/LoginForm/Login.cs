using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HH.SysSetting.App.LoginForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //LoadList();
        }

        public Login(List<DataSource> datas)
        {
            InitializeComponent();
            this.cmb_projlist.DataSource = datas;
            this.cmb_projlist.ValueMember = "Value";
            this.cmb_projlist.DisplayMember = "Name";
        }
        //void LoadList()
        //{
            
        //    var jsonPath = AppDomain.CurrentDomain.BaseDirectory + "data.json";
        //    if (!File.Exists(jsonPath))
        //    {
        //        MessageBox.Show("Not Found data.json File.Please contact 【ZhangLi】to  QQ2287991080");
        //    }
        //    string key = "DataSource";
        //    using (System.IO.StreamReader file = new System.IO.StreamReader(jsonPath,Encoding.UTF8))
        //    {
        //        using (JsonTextReader reader=new JsonTextReader(file))
        //        {
        //            JObject obj = (JObject)JToken.ReadFrom(reader);
        //            var node = obj[key];
        //            if (node == null)
        //            {
        //                MessageBox.Show($"Not Found node({key}) in data.json File。");
        //                Dis();
        //            }
        //            var list = JsonConvert.DeserializeObject<List<DataSource>>(node.ToString());
        //            if (list.Count == 1)
        //            {
        //                GoForm(list.First());
        //            }
        //            else
        //            {
                       
        //                this.cmb_projlist.DataSource = list;
        //                this.cmb_projlist.ValueMember = "Value";
        //                this.cmb_projlist.DisplayMember = "Name";
        //            }
        //        }
        //    }
        //}
        void Dis()
        {
            if (this.IsDisposed)
            {
                //this.Close();
            }
            else {
                this.Close();
                this.Dispose();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //获取下拉选择的数据
            var com = (DataSource)this.cmb_projlist.SelectedItem;
            GoForm(com);
            //this.Hide();
        }

        void GoForm(DataSource source)
        {
            this.Hide();
            var form1 = new Form1(source);
            form1.Show();
        }

        
    }
}

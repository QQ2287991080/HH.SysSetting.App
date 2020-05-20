using Dapper;
using HH.SysSetting.App.Data;
using HH.SysSetting.App.Extensions;
using HH.SysSetting.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HH.SysSetting.App.CURD
{
    public partial class AddFunc : Form
    {
        public AddFunc()
        {
            InitializeComponent();
        }

        //新增
        public AddFunc(string code)
        {
            InitializeComponent();
            this.txt_menuCode.Text = code;//菜单
            this.lab_inIdCode.Visible = false;
            this.txt_InIdCode.Visible = false;
        }
        public AddFunc(decimal id, bool look=false)
        {
            InitializeComponent();
            if (look)
            {
                this.txt_iconColor.ReadOnly = false;
             System.Reflection.FieldInfo[] fieldInfo = this.GetType().GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
             
                foreach (var c in fieldInfo.Where(p=>p.FieldType.Name=="TextBox"))
                {
                    var txt = ((TextBox)c.GetValue(this));
                    txt.ReadOnly = true;
                }
                this.btn_save.Enabled = false;
            }
            this.cbk_isEdit.Checked = true;//编辑启用
            var info = DataHelper.Get<BA_FunctionAuth>(id);
            this.txt_id.Value = info.Id;
            this.txt_menuCode.Text = info.MenuCode;
            this.txt_InIdCode.Text = info.InIdCode;
            this.txt_code.Text = info.Code;
            this.txt_name.Text = info.FuncName;
            this.txt_description.Text = info.Description;
            this.txt_icon.Text = info.FuncIcon;
            this.txt_iconType.Text = info.IconType.ToString();
            this.txt_iconColor.Text = info.IconColor;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var Id= this.txt_id.Value;//id
            var MenuCode=this.txt_menuCode.Text.Trim() ;//菜单编号
            var InIdCode= this.txt_InIdCode.Text.Trim();//功能唯一标识码
            var Code= this.txt_code.Text.Trim();//功能编号
            if (IsSuccess(Code, "功能编码不能为空！")) return;
            var FuncName = this.txt_name.Text;//功能名称
            if (IsSuccess(FuncName, "功能名称不能为空！")) return;
            var Descrition= this.txt_description.Text.Trim();//功能描述
            var icon = this.txt_icon.Text.Trim();//图标
            var isbyte = byte.TryParse(this.txt_iconType.Text.Trim(), out byte iconType);//图标类型
            var iconColor = this.txt_iconColor.Text.Trim();//图标颜色
            bool isEdit = this.cbk_isEdit.Checked;
            try
            {
                using (var conn = DataHelper.GetConnection())
                {
                    var func = new BA_FunctionAuth
                    {
                        Code = Code,
                        Description = Descrition,
                        FuncIcon = icon,
                        FuncName = FuncName,
                        IconColor = iconColor,
                        IconType = iconType,
                        InIdCode = MenuCode.CombineCode(Code),
                        MenuCode = MenuCode
                    };
                    if (isEdit)
                    {
                        func.Id = Id;
                        conn.Update(func);
                    }
                    else
                    {
                        var info = conn.QueryFirstOrDefault<BA_FunctionAuth>("select * from BA_FunctionAuth where MenuCode=@MenuCode and Code=@Code", new { MenuCode, Code });
                        if (IsSuccess(info, "该功能编码已存在，请重新输入！")) return;
                        conn.Insert(func);
                    }
                    MessageBox.Show("操作成功");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

       
        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsSuccess(object obj, string msg)
        {
            bool ok = true;
            if (obj != null) MessageBox.Show(msg);
            else ok = false;
            return ok;
        }

        private bool IsSuccess(string obj, string msg)
        {
            bool ok = true;
            if (string.IsNullOrEmpty(obj)) MessageBox.Show(msg);
            else ok = false;
            return ok;
        }
    }
}

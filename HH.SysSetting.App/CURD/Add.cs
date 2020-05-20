using Dapper;
using HH.SysSetting.App.Data;
using HH.SysSetting.App.Extensions;
using HH.SysSetting.App.Models;
using HH.SysSetting.App.Models.Enums;
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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        public Add(string code,NodeMenu menu)
        {
            InitializeComponent();
            this.cb_menuType.SelectedIndex = 0;//默认值
            //默认选中checkbox
            {
                ckb_isSysDefined.Checked = true;
                ckb_isvisible.Checked = true;
                ckb_isEnd.Checked = true;
                txt_url.Text = "#";
            }
            this.txt_codeParent.Text = code;
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="code"></param>
        public Add(string code)
        {
            InitializeComponent();
            var info= DataHelper.Get<BA_SysMenu>(code);
            if (info == null) return;
            ckb_isEdit.Checked = true;
            txt_code.Text = info.BaseMenuCode;
            txt_code.ReadOnly = true;
            txt_codeParent.Text = info.BaseCodeParent;
            txt_description.Text = info.BaseDescription;
            txt_url.Text = info.Url;
            txt_name.Text = info.BaseMenuName;
            ckb_isSysDefined.Checked = info.IsSysDefine ?? true;
            ckb_isvisible.Checked = info.IsVisibled;
            ckb_isEnd.Checked = info.IsEndGrade;
            ckb_IsAuthority.Checked = info.IsAuthority;
            txt_order.Value = Convert.ToDecimal(info.MenuOrder == null ? 0 : info.MenuOrder);
            cb_menuType.SelectedIndex = Convert.ToInt32(info.MenuType);
            txt_icontype.Text = info.MenuType.ToString();
            txt_iconColor.Text = info.BaseIconColor;
            txt_icon.Text = info.BaseIcon;
        }
        private void btn_out_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            string Code = txt_code.Text.Trim();//编码
            if (IsSuccess(Code, "编码标识不能为空！")) return;
            string CodeParent = txt_codeParent.Text.Trim();//父级编码
            string Name = txt_name.Text.Trim();//名称
            if (IsSuccess(Name, "名称不能为空！")) return;
            string Description = txt_description.Text.Trim();//描述
            if (IsSuccess(Description, "描述不能为空！")) return;
            string url = txt_url.Text;//跳转url
            bool?  IsSysDefined = ckb_isSysDefined.Checked;//是否系统预置
            bool IsVisibled = ckb_isvisible.Checked;//是否可见
            bool IsEndGrade = ckb_isEnd.Checked;//是否末级
            bool IsAuthority = ckb_IsAuthority.Checked;//是否权限控制
            short? Order = (short)this.txt_order.Value;//排序
            byte MenuType = (byte)this.cb_menuType.SelectedIndex;//菜单类型
            bool isByte = byte.TryParse(this.txt_icontype.Text.Trim(), out byte IconType);//图标类型
            string IconColor = this.txt_iconColor.Text.Trim();//图标颜色
            string icon = this.txt_icon.Text.Trim();//图标
            var menu = new BA_SysMenu
            {
                BaseMenuCode = Code,
                BaseCodeParent = CodeParent.IsNull(),
                BaseDescription = Description,
                BaseIcon = icon,
                BaseIconColor = IconColor,
                BaseIconType = IconType,
                BaseMenuName = Name,
                CreateTime = DateTime.Now,
                IsAuthority = IsAuthority,
                IsEndGrade = IsEndGrade,
                IsSysDefine = IsSysDefined,
                IsVisibled = IsVisibled,
                MenuOrder = Order,
                MenuType = MenuType,
                Url = url
            };
            try
            {
                using (var conn = DataHelper.GetConnection())
                {
                    conn.Open();
                    if (this.ckb_isEdit.Checked)
                    {
                        DataHelper.Update(menu, conn);
                        MessageBox.Show("修改成功");
                    }
                    else
                    {
                        var info = conn.QueryFirstOrDefault<BA_SysMenu>("select * from BA_SysMenu where Code=@Code", new { Code });
                        if (IsSuccess(info, "编码标识已存在！")) return;
                        DataHelper.Insert(menu, conn);
                        //初始化菜单权限
                        var func = new BA_FunctionAuth()
                        {
                            Code = "Read",
                            FuncName = "查看",
                            InIdCode = Code.CombineCode("Read"),
                            MenuCode = Code
                        };
                        DataHelper.Insert(func, conn);
                        MessageBox.Show("新增成功");
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private bool IsSuccess(string obj,string msg)
        {
            bool ok = true;
            if (string.IsNullOrEmpty(obj)) MessageBox.Show(msg);
            else ok = false;
            return ok;
        }

        private bool IsSuccess(object obj, string msg)
        {
            bool ok = true;
            if (obj!=null) MessageBox.Show(msg);
            else ok = false;
            return ok;
        }
    }
}

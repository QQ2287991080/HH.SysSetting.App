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

namespace HH.SysSetting.App.EnType
{
    public partial class EnTypeForm : Form
    {
        public EnTypeForm()
        {
            InitializeComponent();
        }

        private void EnTypeForm_Load(object sender, EventArgs e)
        {

            LoadTree();
            

            //隐藏按钮
            Btn_Visible(false);
        }
        void Btn_Visible(bool ok)
        {
            this.btn_save.Visible = ok;
            this.button1.Visible = ok;
        }
        void LoadTree()
        {
            this.tv_enType.Nodes.Clear();
            //获取枚举表数据
            var list = DataHelper.Query<BA_SysEnType>("select * from ba_sysEntype");
            TreeNode node = new TreeNode("菜单树");
            Resolver(list, null, node);
            this.tv_enType.Nodes.Add(node);
            tv_enType.ExpandAll();
        }

        void Resolver(List<BA_SysEnType> list, decimal? where, TreeNode tree)
        {
            foreach (var item in list.Where(p=>p.IdParent==where))
            {
                TreeNode node = new TreeNode();
                node.Text = item.Name;//文本名称
                node.Tag = item.IdParent;//父级id
                node.Name = item.Id.ToString();//当前枚举id
                ContextMenuStrip menuStrip = new ContextMenuStrip();//动态生成菜单
                menuStrip.Items.Add(NodeEnType.add.GetEnumDesciption());
                menuStrip.Items.Add(NodeEnType.update.GetEnumDesciption());
                //menuStrip.Items.Add("修改");
                //menuStrip.Items.Add("批量新增");
                if (list.Where(p=>p.IdParent==item.Id).Count()==0)
                {
                    //menuStrip.Items.Add("删除");
                    menuStrip.Items.Add(NodeEnType.delete.GetEnumDesciption());
                }
                menuStrip.ItemClicked += MenuStrip_ItemClicked;//菜单节点点击事件
                node.ContextMenuStrip = menuStrip;
                tree.Nodes.Add(node);
                Resolver(list, item.Id, node);
            }
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var now = (ContextMenuStrip)sender;
            now.Close();
            var node = this.tv_enType.SelectedNode;
            if (node == null|| string.IsNullOrEmpty(node.Name))
            {
                MessageBox.Show("请选择菜单");
                return;
            }
            var itemText = e.ClickedItem.Text.GetEunmInDesciption(typeof(NodeEnType));
            var id = node.Name.ToDecimal();
            switch ((NodeEnType)itemText)
            {
                case NodeEnType.add:
                    InitFrom();
                    this.txt_parent.Text = node.Tag==null?null:node.Tag.ToString();
                    this.lbl_ver.Text = "0";
                    this.btn_save.Visible = true;
                    break;
                case NodeEnType.update:
                    var entype = DataHelper.Get<BA_SysEnType>(id);
                    MapFrom(entype);
                   this.lbl_ver.Text = "1";
                    break;
                case NodeEnType.delete:
                    break;
                case NodeEnType.builk:
                    break;
                default:
                    break;
            }
            

        }

        void InitFrom()
        {
            txt_desc.Text = null;
            txt_id.Text = null;
            txt_level.Text = null;
            txt_memo.Text = null;
            txt_name.Text = null;
            txt_parent.Text = null;
            txt_refsource.Text = null;
            cb_end.Checked = true;
            cb_sys.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitFrom();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var typeid = this.lbl_ver.Text;
            var desc = this.txt_desc.Text;
            var name = this.txt_name.Text;
            bool isSys = this.cb_sys.Checked;
            bool isEnd = this.cb_end.Checked;
            var level = Convert.ToByte(txt_level.Text);
            var memo = txt_memo.Text;
            decimal? parent = txt_parent.Text.ToNullDecimal();
            var refsource = txt_refsource.Text;
            //实体数据
            var enType = new BA_SysEnType
            {

                Describe = desc,
                IdParent = parent,
                IsEnd = isEnd,
                IsSys = isSys,
                Level = level,
                Memo = memo,
                Name = name,
                RefSource = refsource
            };
            if (typeid=="0")//新增
            {
                DataHelper.Insert(enType);
            }

            MessageBox.Show("操作成功");
            InitFrom();
            LoadTree();
        }
        /// <summary>
        /// 单击书节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tv_enType_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Node.Name)) return;
            var id = e.Node.Name.ToDecimal();

            var entype = DataHelper.Get<BA_SysEnType>(id);
            MapFrom(entype);
        }

        void MapFrom(BA_SysEnType enType)
        {
            txt_desc.Text = enType.Describe;
            txt_id.Text = enType.Id.ToString();
            txt_level.Text = enType.Level.ToString();
            txt_memo.Text = enType.Memo;
            txt_name.Text = enType.Name;
            txt_parent.Text = enType.IdParent.ToString();
            txt_refsource.Text = enType.RefSource;
            cb_end.Checked = enType.IsEnd.ToBoolean();
            cb_sys.Checked = enType.IsSys.ToBoolean();
        }
    }
}

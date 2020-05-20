using Dapper;
using HH.SysSetting.App.CURD;
using HH.SysSetting.App.Data;
using HH.SysSetting.App.Extensions;
using HH.SysSetting.App.Models;
using HH.SysSetting.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace HH.SysSetting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //加载树
            LoadTree();
        }
        #region 窗体加载时
        /// <summary>
        /// 加载树
        /// </summary>
        private void LoadTree()
        {
            tv_menu.Nodes.Clear();
            TreeNode treeNode = new TreeNode("菜单树");
            var conn = DataHelper.GetConnection();
            var list = conn.GetList<BA_SysMenu>().ToList();
            resolver(list, null, treeNode);
            tv_menu.Nodes.Add(treeNode);
            tv_menu.LabelEdit = true;
            tv_menu.ExpandAll();
        }
        /// <summary>
        /// 递归菜单
        /// </summary>
        /// <param name="list"></param>
        /// <param name="code"></param>
        /// <param name="treeNode"></param>
        private void resolver(List<BA_SysMenu> list, string code, TreeNode treeNode)
        {
            foreach (var item in list.Where(p => p.BaseCodeParent == code).OrderBy(o => o.MenuOrder))
            {
                TreeNode t1 = new TreeNode(item.BaseDescription);
                t1.Name = item.BaseCodeParent;
                t1.Tag = item.BaseMenuCode;
                ContextMenuStrip newStrip = new ContextMenuStrip();//动态创建右键菜单
                newStrip.Items.Add(NodeMenu.add.GetEnumDesciption());//新增平级菜单
                newStrip.Items.Add(NodeMenu.update.GetEnumDesciption());//修改
                newStrip.Items.Add(NodeMenu.addchildren.GetEnumDesciption());//新增子菜单
                newStrip.Items.Add(NodeMenu.addFunc.GetEnumDesciption());//新增功能
                newStrip.Items.Add(NodeMenu.initFunc.GetEnumDesciption());//初始化功能

                if (list.Where(p => p.BaseCodeParent == item.BaseMenuCode).Count() == 0)//如果没有子节点，允许删除
                {
                    newStrip.Items.Add(NodeMenu.remove.GetEnumDesciption());//删除
                }
                newStrip.ItemClicked += NewStrip_ItemClicked;//动态实现右键菜单点击事件
               
                t1.ContextMenuStrip = newStrip;//将菜单绑定到树节点
                treeNode.Nodes.Add(t1);
                resolver(list, item.BaseMenuCode, t1);
            }
        }

        /// <summary>
        /// 加载功能列表
        /// </summary>
        private void LoadFuncList()
        {
            //this.dgv_funclist.Rows.Clear();
            var tree = this.tv_menu.SelectedNode;//当前选择树节点
            if (tree == null) return;
            var code = tree.Tag;//功能对应的菜单code
            var conn = DataHelper.GetConnection();
            var list = conn.GetList<BA_FunctionAuth>("where MenuCode=@code", new { code }).ToList();
            this.dgv_funclist.DataSource = list;
        }
        /// <summary>
        /// 公共单元格启用事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = e.RowIndex;
            var column = e.ColumnIndex;
            var cell = ((DataGridView)sender).Rows[row].Cells[column];//启用编辑的单元格
            var value = cell.Value;//单元格的值
            cell.Tag = value;//把值赋值给tag，在编辑完之后作比较
        }
        /// <summary>
        /// 列表结束编辑公共方法
        /// </summary>
        /// <typeparam name="T">对应数据实体类</typeparam>
        /// <param name="sender">控件事件sender</param>
        /// <param name="e"></param>
        /// <param name="info">更新字段名称</param>
        /// <param name="code">唯一标识</param>
        /// <param name="value">需要更新的值</param>
        private void gridViewEndEdit<T>(object sender, DataGridViewCellEventArgs e, out string info, out object code, out object value)
        {
            var grid = (DataGridView)sender;
            var columnList = ColumnList(sender);//获取当前菜单列表中的column的信息
            var row = e.RowIndex;
            var column = e.ColumnIndex;
            var cell = grid.Rows[row].Cells[column];//单元格信息
            value = cell.Value;//单元格值
            var columnName = columnList.FirstOrDefault(p => p.Index == column).DataPropertyName;//根据column的索引找到被编辑的单元格的属性名称
                                                                                                //获取唯一标识code
            code = grid.Rows[row].Cells[0].Value;
            var dic = ModelsExtensions.GetModelDic<T>();
            info = dic[columnName];//获取对应的数据库字段名称
            if (cell.Tag.Equals(value) || value == null) return;
            if (code == null) return;
            if (string.IsNullOrEmpty(info)) return;
        }
        /// <summary>
        /// 菜单列表加载
        /// </summary>
        /// <param name="code"></param>
        private void LoadMenuList(object code)
        {
            var conn = DataHelper.GetConnection();
            //菜单信息
            var menu = conn.GetList<BA_SysMenu>("where Code=@Code", new { code });
            this.dgv_menulist.DataSource = menu;
            //功能
            var list = conn.GetList<BA_FunctionAuth>("where MenuCode=@Code", new { code });
            //创建右键菜单
            ContextMenuStrip strip = new ContextMenuStrip();
            strip.Items.Add("修改");
            strip.Items.Add("删除");
            strip.Items.Add("查看");
            strip.ItemClicked += Strip_ItemClicked;
            this.dgv_funclist.ContextMenuStrip = strip;
            this.dgv_funclist.DataSource = list;
        }

        private void Strip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var strip = (ContextMenuStrip)sender;
            strip.Close();
            //获取选中的数据
            var selected = this.dgv_funclist.SelectedRows;
            if (selected.Count == 0) return;
            var row = selected[0];
            var id = row.Cells[0].Value;
            AddFunc func = null;
            switch (e.ClickedItem.Text)
            {
                case "修改":
                    func = new AddFunc(Convert.ToDecimal(id));
                    break;
                case "删除":
                    DataHelper.Delete<BA_FunctionAuth>(id);
                    MessageBox.Show("删除成功");
                    break;
                case "查看":
                    func = new AddFunc(Convert.ToDecimal(id),true);
                    break;
                default:
                    break;
            }
            if (func != null)
            {
                func.StartPosition = FormStartPosition.CenterScreen;
                var result = func.ShowDialog();
            }
            LoadFuncList();
        }
        #endregion
        #region 菜单树
        /// <summary>
        /// 动态右键菜单，选择菜单之后执行对应功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var now = (ContextMenuStrip)sender;
            now.Close();
            Console.WriteLine("测试");
            var node = this.tv_menu.SelectedNode;
            if (node == null)
            {
                MessageBox.Show("请选择菜单");
                return;
            }
            var stripText = e.ClickedItem.Text.GetEunmInDesciption(typeof(NodeMenu));
            var descrition = node.Text;//描述
            var code = node.Tag;//code编码
            var codeParent = node.Name;//父级编号
            Add add = null;
            var _code = code == null ? null : code.ToString();
            switch ((NodeMenu)stripText)
            {
                case NodeMenu.addchildren:
                    add= new Add(_code, NodeMenu.addchildren);
                    break;
                case NodeMenu.update:
                    add = new Add(_code);
                    break;
                case NodeMenu.remove:
                    Remove(code);
                    break;
                case NodeMenu.add:
                    add = new Add(codeParent == null ? null : codeParent.ToString(), NodeMenu.add);
                    break;
                case NodeMenu.addFunc:
                    AddFunc addFunc = new AddFunc(_code);
                    addFunc.StartPosition = FormStartPosition.CenterScreen;
                    var result = addFunc.ShowDialog();
                    addFunc.Dispose();
                    break;
                case NodeMenu.initFunc:
                    InItFunc(_code);
                    MessageBox.Show("操作成功");
                    break;
                default:
                    break;
            }
            if (add!=null)
            {
                add.StartPosition = FormStartPosition.CenterScreen;
                var result = add.ShowDialog();
                add.Dispose();
            }
            LoadTree();
            LoadMenuList(code);
            this.tv_menu.SelectedNode = node;
        }
        /// <summary>
        /// 初始化功能
        /// </summary>
        /// <param name="code"></param>
        private void InItFunc(string code)
        {
            string[] curd = new[] { "新增", "修改", "删除" };
            string[] curdCode = new[] { "Add", "Update", "Delete" };
            using (var conn=DataHelper.GetConnection())
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
        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="code"></param>
        private void Remove(object code)
        {
            DataHelper.Delete<BA_SysMenu>(code);
            MessageBox.Show("删除成功");
        }
        /// <summary>
        /// 树节点双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tv_menu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = tv_menu.SelectedNode;
            //node.BeginEdit();
        }
        /// <summary>
        /// 树节点编辑完成事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tv_menu_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            //e.Node.Text = "555";
            var node = tv_menu.SelectedNode;
            node.EndEdit(true);
        }
        /// <summary>
        /// 单击📕节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tv_menu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var Code = e.Node.Tag;
            LoadMenuList(Code);
        }
        #endregion
        #region 菜单列表
        /// <summary>
        /// 点击单元格内容触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_menulist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            //获取唯一标识code
            var code = this.dgv_menulist.Rows[e.RowIndex].Cells[0].Value;
            if (code == null) return;
            object before, after;
            var checkboxenumValue = EnumExtensions.GetEnumValues(typeof(CheckBoxEnum))
                .FirstOrDefault(w => w.Value == e.ColumnIndex);//根据checkbox的索引找到他的名称做更改
            if (checkboxenumValue == null) return;
            before = CheckBoxValue(checkboxenumValue.Name, out after);
            DataHelper.Excute($"update Ba_SysMenu set [{checkboxenumValue.Name}]=@after where code=@code", new { after, code });
        }
        /// <summary>
        /// checkbox值的更迭
        /// </summary>
        /// <param name="column">字段名称</param>
        /// <param name="after">更改之后的值</param>
        /// <returns>更改之前的值</returns>
        private object CheckBoxValue(string column, out object after)
        {
            var before = dgv_menulist.Rows[0].Cells[dgv_menulist.Columns[column].Index].Value;//编辑之前的值
            this.dgv_menulist.EndEdit();//关闭修改
            after = dgv_menulist.Rows[0].Cells[dgv_menulist.Columns[column].Index].Value;//编辑之后的值
            return before;
        }
        /// <summary>
        /// 启用编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_menulist_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            gridViewBeginEdit(dgv_menulist, e);
        }
        /// <summary>
        /// /结束编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_menulist_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            gridViewEndEdit<BA_SysMenu>(this.dgv_menulist, e, out string info, out object code, out object value);
            var cell = this.dgv_menulist.Rows[e.RowIndex].Cells[e.ColumnIndex];//单元格信息
            DataHelper.Excute($"update BA_SysMenu set [{info}]=@value  where Code=@Code", new { code, value });
            cell.Tag = null;

            LoadTree();//刷新树
        }
        private List<DataGridViewColumn> ColumnList(object sender)
        {
            var columnList = new List<DataGridViewColumn>();
            foreach (DataGridViewColumn item in ((DataGridView)sender).Columns)
            {
                columnList.Add(item);
            }
            return columnList;
        }
        #endregion
        #region 功能列表
        /// <summary>
        /// 功能列表启用编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_funclist_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            gridViewBeginEdit(dgv_funclist, e);
        }
        /// <summary>
        /// 功能列表结束编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_funclist_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            gridViewEndEdit<BA_FunctionAuth>(this.dgv_funclist, e, out string info, out object Id, out object value);
            var cell = this.dgv_funclist.Rows[e.RowIndex].Cells[e.ColumnIndex];//单元格信息
            DataHelper.Excute($"update BA_FunctionAuth set [{info}]=@value  where Id=@Id ", new { Id, value });
            cell.Tag = null;

            //LoadFuncList(); //加载列表
        }


        #endregion

    }
}

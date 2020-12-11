namespace HH.SysSetting.App
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_menulist = new System.Windows.Forms.DataGridView();
            this.BaseMenuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseCodeParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseMenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSysDefine = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsAuthority = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsVisibled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsEndGrade = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MenuOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseIcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseIconType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseIconColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_funclist = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InIdCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncIcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IconType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IconColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tv_menu = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menulist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funclist)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_menulist);
            this.panel2.Controls.Add(this.dgv_funclist);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(527, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 620);
            this.panel2.TabIndex = 1;
            // 
            // dgv_menulist
            // 
            this.dgv_menulist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menulist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BaseMenuCode,
            this.BaseCodeParent,
            this.BaseMenuName,
            this.CreateTime,
            this.BaseDescription,
            this.Url,
            this.IsSysDefine,
            this.IsAuthority,
            this.IsVisibled,
            this.IsEndGrade,
            this.MenuOrder,
            this.MenuType,
            this.BaseIcon,
            this.BaseIconType,
            this.BaseIconColor});
            this.dgv_menulist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_menulist.Location = new System.Drawing.Point(0, 0);
            this.dgv_menulist.Name = "dgv_menulist";
            this.dgv_menulist.RowHeadersWidth = 51;
            this.dgv_menulist.RowTemplate.Height = 27;
            this.dgv_menulist.Size = new System.Drawing.Size(707, 88);
            this.dgv_menulist.TabIndex = 1;
            this.dgv_menulist.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_menulist_CellBeginEdit);
            this.dgv_menulist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_menulist_CellContentClick);
            this.dgv_menulist.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_menulist_CellEndEdit);
            // 
            // BaseMenuCode
            // 
            this.BaseMenuCode.DataPropertyName = "BaseMenuCode";
            this.BaseMenuCode.HeaderText = "编码标识";
            this.BaseMenuCode.MinimumWidth = 6;
            this.BaseMenuCode.Name = "BaseMenuCode";
            this.BaseMenuCode.ReadOnly = true;
            this.BaseMenuCode.Width = 125;
            // 
            // BaseCodeParent
            // 
            this.BaseCodeParent.DataPropertyName = "BaseCodeParent";
            this.BaseCodeParent.HeaderText = "上级菜单编码";
            this.BaseCodeParent.MinimumWidth = 6;
            this.BaseCodeParent.Name = "BaseCodeParent";
            this.BaseCodeParent.ReadOnly = true;
            this.BaseCodeParent.Width = 125;
            // 
            // BaseMenuName
            // 
            this.BaseMenuName.DataPropertyName = "BaseMenuName";
            this.BaseMenuName.HeaderText = "菜单名称";
            this.BaseMenuName.MinimumWidth = 6;
            this.BaseMenuName.Name = "BaseMenuName";
            this.BaseMenuName.Width = 125;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.MinimumWidth = 6;
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.Width = 125;
            // 
            // BaseDescription
            // 
            this.BaseDescription.DataPropertyName = "BaseDescription";
            this.BaseDescription.HeaderText = "描述";
            this.BaseDescription.MinimumWidth = 6;
            this.BaseDescription.Name = "BaseDescription";
            this.BaseDescription.Width = 125;
            // 
            // Url
            // 
            this.Url.DataPropertyName = "Url";
            this.Url.HeaderText = "跳转路径";
            this.Url.MinimumWidth = 6;
            this.Url.Name = "Url";
            this.Url.Width = 125;
            // 
            // IsSysDefine
            // 
            this.IsSysDefine.DataPropertyName = "IsSysDefine";
            this.IsSysDefine.HeaderText = "系统预置";
            this.IsSysDefine.MinimumWidth = 6;
            this.IsSysDefine.Name = "IsSysDefine";
            this.IsSysDefine.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsSysDefine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsSysDefine.Width = 125;
            // 
            // IsAuthority
            // 
            this.IsAuthority.DataPropertyName = "IsAuthority";
            this.IsAuthority.HeaderText = "是否权限控制";
            this.IsAuthority.MinimumWidth = 6;
            this.IsAuthority.Name = "IsAuthority";
            this.IsAuthority.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsAuthority.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsAuthority.Width = 125;
            // 
            // IsVisibled
            // 
            this.IsVisibled.DataPropertyName = "IsVisibled";
            this.IsVisibled.HeaderText = "是否显示在菜单";
            this.IsVisibled.MinimumWidth = 6;
            this.IsVisibled.Name = "IsVisibled";
            this.IsVisibled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsVisibled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsVisibled.Width = 125;
            // 
            // IsEndGrade
            // 
            this.IsEndGrade.DataPropertyName = "IsEndGrade";
            this.IsEndGrade.HeaderText = "是否末级";
            this.IsEndGrade.MinimumWidth = 6;
            this.IsEndGrade.Name = "IsEndGrade";
            this.IsEndGrade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsEndGrade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsEndGrade.Width = 125;
            // 
            // MenuOrder
            // 
            this.MenuOrder.DataPropertyName = "MenuOrder";
            this.MenuOrder.HeaderText = "排序标识";
            this.MenuOrder.MinimumWidth = 6;
            this.MenuOrder.Name = "MenuOrder";
            this.MenuOrder.Width = 125;
            // 
            // MenuType
            // 
            this.MenuType.DataPropertyName = "MenuType";
            this.MenuType.HeaderText = "菜单类型";
            this.MenuType.MinimumWidth = 6;
            this.MenuType.Name = "MenuType";
            this.MenuType.Width = 125;
            // 
            // BaseIcon
            // 
            this.BaseIcon.DataPropertyName = "BaseIcon";
            this.BaseIcon.HeaderText = "图标";
            this.BaseIcon.MinimumWidth = 6;
            this.BaseIcon.Name = "BaseIcon";
            this.BaseIcon.Width = 125;
            // 
            // BaseIconType
            // 
            this.BaseIconType.DataPropertyName = "BaseIconType";
            this.BaseIconType.HeaderText = "图标类型";
            this.BaseIconType.MinimumWidth = 6;
            this.BaseIconType.Name = "BaseIconType";
            this.BaseIconType.Width = 125;
            // 
            // BaseIconColor
            // 
            this.BaseIconColor.DataPropertyName = "BaseIconColor";
            this.BaseIconColor.HeaderText = "图标颜色";
            this.BaseIconColor.MinimumWidth = 6;
            this.BaseIconColor.Name = "BaseIconColor";
            this.BaseIconColor.Width = 125;
            // 
            // dgv_funclist
            // 
            this.dgv_funclist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funclist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MenuCode,
            this.InIdCode,
            this.Code,
            this.FuncName,
            this.Description,
            this.FuncIcon,
            this.IconType,
            this.IconColor});
            this.dgv_funclist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_funclist.Location = new System.Drawing.Point(0, 88);
            this.dgv_funclist.Name = "dgv_funclist";
            this.dgv_funclist.RowHeadersWidth = 51;
            this.dgv_funclist.RowTemplate.Height = 27;
            this.dgv_funclist.Size = new System.Drawing.Size(707, 532);
            this.dgv_funclist.TabIndex = 0;
            this.dgv_funclist.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_funclist_CellBeginEdit);
            this.dgv_funclist.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_funclist_CellEndEdit);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "编号";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // MenuCode
            // 
            this.MenuCode.DataPropertyName = "MenuCode";
            this.MenuCode.HeaderText = "所属菜单编码";
            this.MenuCode.MinimumWidth = 6;
            this.MenuCode.Name = "MenuCode";
            this.MenuCode.ReadOnly = true;
            this.MenuCode.Width = 125;
            // 
            // InIdCode
            // 
            this.InIdCode.DataPropertyName = "InIdCode";
            this.InIdCode.HeaderText = "功能唯一标识码";
            this.InIdCode.MinimumWidth = 6;
            this.InIdCode.Name = "InIdCode";
            this.InIdCode.ReadOnly = true;
            this.InIdCode.Width = 125;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "功能码";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 125;
            // 
            // FuncName
            // 
            this.FuncName.DataPropertyName = "FuncName";
            this.FuncName.HeaderText = "功能名";
            this.FuncName.MinimumWidth = 6;
            this.FuncName.Name = "FuncName";
            this.FuncName.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "功能描述";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // FuncIcon
            // 
            this.FuncIcon.DataPropertyName = "FuncIcon";
            this.FuncIcon.HeaderText = "图标码";
            this.FuncIcon.MinimumWidth = 6;
            this.FuncIcon.Name = "FuncIcon";
            this.FuncIcon.Width = 125;
            // 
            // IconType
            // 
            this.IconType.DataPropertyName = "IconType";
            this.IconType.HeaderText = "图标类型";
            this.IconType.MinimumWidth = 6;
            this.IconType.Name = "IconType";
            this.IconType.Width = 125;
            // 
            // IconColor
            // 
            this.IconColor.DataPropertyName = "IconColor";
            this.IconColor.HeaderText = "图标颜色";
            this.IconColor.MinimumWidth = 6;
            this.IconColor.Name = "IconColor";
            this.IconColor.Width = 125;
            // 
            // tv_menu
            // 
            this.tv_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_menu.Location = new System.Drawing.Point(0, 0);
            this.tv_menu.Name = "tv_menu";
            this.tv_menu.Size = new System.Drawing.Size(527, 362);
            this.tv_menu.TabIndex = 0;
            this.tv_menu.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tv_menu_AfterLabelEdit);
            this.tv_menu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_menu_NodeMouseClick);
            this.tv_menu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_menu_NodeMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 620);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tv_menu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(527, 362);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 258);
            this.panel3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "菜单功能设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menulist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funclist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_funclist;
        private System.Windows.Forms.TreeView tv_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_menulist;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseMenuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseCodeParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseMenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSysDefine;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAuthority;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsVisibled;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsEndGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseIconType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseIconColor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn InIdCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IconType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IconColor;
        private System.Windows.Forms.Panel panel4;
    }
}


namespace HH.SysSetting.App.CURD
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_menuType = new System.Windows.Forms.ComboBox();
            this.txt_order = new System.Windows.Forms.NumericUpDown();
            this.ckb_IsAuthority = new System.Windows.Forms.CheckBox();
            this.ckb_isEnd = new System.Windows.Forms.CheckBox();
            this.ckb_isvisible = new System.Windows.Forms.CheckBox();
            this.ckb_isEdit = new System.Windows.Forms.CheckBox();
            this.ckb_isSysDefined = new System.Windows.Forms.CheckBox();
            this.txt_iconColor = new System.Windows.Forms.TextBox();
            this.txt_icontype = new System.Windows.Forms.TextBox();
            this.txt_icon = new System.Windows.Forms.TextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_codeParent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_order)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(256, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 38);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_out
            // 
            this.btn_out.Location = new System.Drawing.Point(78, 3);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(75, 38);
            this.btn_out.TabIndex = 0;
            this.btn_out.Text = "取消";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(173, 12);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(158, 25);
            this.txt_code.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "编码标识：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "上级菜单编码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "菜单名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "描述：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "跳转路径：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "是否系统预置：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "是否显示在菜单：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "是否末级：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "排序标识：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "菜单类型：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 412);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "图标：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_out);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 49);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_menuType);
            this.panel2.Controls.Add(this.txt_order);
            this.panel2.Controls.Add(this.ckb_IsAuthority);
            this.panel2.Controls.Add(this.ckb_isEnd);
            this.panel2.Controls.Add(this.ckb_isvisible);
            this.panel2.Controls.Add(this.ckb_isEdit);
            this.panel2.Controls.Add(this.ckb_isSysDefined);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_iconColor);
            this.panel2.Controls.Add(this.txt_icontype);
            this.panel2.Controls.Add(this.txt_icon);
            this.panel2.Controls.Add(this.txt_url);
            this.panel2.Controls.Add(this.txt_description);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.txt_codeParent);
            this.panel2.Controls.Add(this.txt_code);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 525);
            this.panel2.TabIndex = 4;
            // 
            // cb_menuType
            // 
            this.cb_menuType.FormattingEnabled = true;
            this.cb_menuType.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cb_menuType.Location = new System.Drawing.Point(173, 364);
            this.cb_menuType.Name = "cb_menuType";
            this.cb_menuType.Size = new System.Drawing.Size(158, 23);
            this.cb_menuType.TabIndex = 5;
            // 
            // txt_order
            // 
            this.txt_order.Location = new System.Drawing.Point(173, 327);
            this.txt_order.Name = "txt_order";
            this.txt_order.Size = new System.Drawing.Size(158, 25);
            this.txt_order.TabIndex = 4;
            // 
            // ckb_IsAuthority
            // 
            this.ckb_IsAuthority.AutoSize = true;
            this.ckb_IsAuthority.Location = new System.Drawing.Point(173, 298);
            this.ckb_IsAuthority.Name = "ckb_IsAuthority";
            this.ckb_IsAuthority.Size = new System.Drawing.Size(44, 19);
            this.ckb_IsAuthority.TabIndex = 3;
            this.ckb_IsAuthority.Text = "是";
            this.ckb_IsAuthority.UseVisualStyleBackColor = true;
            // 
            // ckb_isEnd
            // 
            this.ckb_isEnd.AutoSize = true;
            this.ckb_isEnd.Location = new System.Drawing.Point(173, 263);
            this.ckb_isEnd.Name = "ckb_isEnd";
            this.ckb_isEnd.Size = new System.Drawing.Size(44, 19);
            this.ckb_isEnd.TabIndex = 3;
            this.ckb_isEnd.Text = "是";
            this.ckb_isEnd.UseVisualStyleBackColor = true;
            // 
            // ckb_isvisible
            // 
            this.ckb_isvisible.AutoSize = true;
            this.ckb_isvisible.Location = new System.Drawing.Point(173, 228);
            this.ckb_isvisible.Name = "ckb_isvisible";
            this.ckb_isvisible.Size = new System.Drawing.Size(44, 19);
            this.ckb_isvisible.TabIndex = 3;
            this.ckb_isvisible.Text = "是";
            this.ckb_isvisible.UseVisualStyleBackColor = true;
            // 
            // ckb_isEdit
            // 
            this.ckb_isEdit.AutoSize = true;
            this.ckb_isEdit.Location = new System.Drawing.Point(354, 193);
            this.ckb_isEdit.Name = "ckb_isEdit";
            this.ckb_isEdit.Size = new System.Drawing.Size(44, 19);
            this.ckb_isEdit.TabIndex = 3;
            this.ckb_isEdit.Text = "是";
            this.ckb_isEdit.UseVisualStyleBackColor = true;
            this.ckb_isEdit.Visible = false;
            // 
            // ckb_isSysDefined
            // 
            this.ckb_isSysDefined.AutoSize = true;
            this.ckb_isSysDefined.Location = new System.Drawing.Point(173, 193);
            this.ckb_isSysDefined.Name = "ckb_isSysDefined";
            this.ckb_isSysDefined.Size = new System.Drawing.Size(44, 19);
            this.ckb_isSysDefined.TabIndex = 3;
            this.ckb_isSysDefined.Text = "是";
            this.ckb_isSysDefined.UseVisualStyleBackColor = true;
            // 
            // txt_iconColor
            // 
            this.txt_iconColor.Location = new System.Drawing.Point(173, 480);
            this.txt_iconColor.Name = "txt_iconColor";
            this.txt_iconColor.Size = new System.Drawing.Size(158, 25);
            this.txt_iconColor.TabIndex = 1;
            // 
            // txt_icontype
            // 
            this.txt_icontype.Location = new System.Drawing.Point(173, 440);
            this.txt_icontype.Name = "txt_icontype";
            this.txt_icontype.Size = new System.Drawing.Size(158, 25);
            this.txt_icontype.TabIndex = 1;
            // 
            // txt_icon
            // 
            this.txt_icon.Location = new System.Drawing.Point(173, 402);
            this.txt_icon.Name = "txt_icon";
            this.txt_icon.Size = new System.Drawing.Size(158, 25);
            this.txt_icon.TabIndex = 1;
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(173, 152);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(158, 25);
            this.txt_url.TabIndex = 1;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(173, 117);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(158, 25);
            this.txt_description.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(173, 82);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(158, 25);
            this.txt_name.TabIndex = 1;
            // 
            // txt_codeParent
            // 
            this.txt_codeParent.Location = new System.Drawing.Point(173, 47);
            this.txt_codeParent.Name = "txt_codeParent";
            this.txt_codeParent.ReadOnly = true;
            this.txt_codeParent.Size = new System.Drawing.Size(158, 25);
            this.txt_codeParent.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 490);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "图标颜色：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "图标类型(数字)：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "是否权限控制：";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Add";
            this.Text = "菜单";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_menuType;
        private System.Windows.Forms.NumericUpDown txt_order;
        private System.Windows.Forms.CheckBox ckb_isEnd;
        private System.Windows.Forms.CheckBox ckb_isvisible;
        private System.Windows.Forms.CheckBox ckb_isSysDefined;
        private System.Windows.Forms.TextBox txt_icon;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_codeParent;
        private System.Windows.Forms.CheckBox ckb_IsAuthority;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_iconColor;
        private System.Windows.Forms.TextBox txt_icontype;
        private System.Windows.Forms.CheckBox ckb_isEdit;
    }
}
namespace HH.SysSetting.App.CURD
{
    partial class AddFunc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_out = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_inIdCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_menuCode = new System.Windows.Forms.TextBox();
            this.txt_InIdCode = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_icon = new System.Windows.Forms.TextBox();
            this.txt_iconType = new System.Windows.Forms.TextBox();
            this.txt_iconColor = new System.Windows.Forms.TextBox();
            this.cbk_isEdit = new System.Windows.Forms.CheckBox();
            this.txt_id = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.cbk_isEdit);
            this.panel1.Controls.Add(this.txt_iconColor);
            this.panel1.Controls.Add(this.txt_iconType);
            this.panel1.Controls.Add(this.txt_icon);
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.txt_code);
            this.panel1.Controls.Add(this.txt_InIdCode);
            this.panel1.Controls.Add(this.txt_menuCode);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lab_inIdCode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 434);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.btn_out);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 68);
            this.panel2.TabIndex = 0;
            // 
            // btn_out
            // 
            this.btn_out.Location = new System.Drawing.Point(69, 18);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(75, 38);
            this.btn_out.TabIndex = 0;
            this.btn_out.Text = "取消";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(247, 18);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 38);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "所属菜单编码：";
            // 
            // lab_inIdCode
            // 
            this.lab_inIdCode.AutoSize = true;
            this.lab_inIdCode.Location = new System.Drawing.Point(17, 318);
            this.lab_inIdCode.Name = "lab_inIdCode";
            this.lab_inIdCode.Size = new System.Drawing.Size(127, 15);
            this.lab_inIdCode.TabIndex = 0;
            this.lab_inIdCode.Text = "功能唯一标识码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "功能码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "功能名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "功能描述：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "图标🐎：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "图标类型：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "图标颜色：";
            // 
            // txt_menuCode
            // 
            this.txt_menuCode.Location = new System.Drawing.Point(164, 31);
            this.txt_menuCode.Name = "txt_menuCode";
            this.txt_menuCode.ReadOnly = true;
            this.txt_menuCode.Size = new System.Drawing.Size(158, 25);
            this.txt_menuCode.TabIndex = 1;
            // 
            // txt_InIdCode
            // 
            this.txt_InIdCode.Location = new System.Drawing.Point(164, 308);
            this.txt_InIdCode.Name = "txt_InIdCode";
            this.txt_InIdCode.ReadOnly = true;
            this.txt_InIdCode.Size = new System.Drawing.Size(158, 25);
            this.txt_InIdCode.TabIndex = 1;
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(164, 72);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(158, 25);
            this.txt_code.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(164, 111);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(158, 25);
            this.txt_name.TabIndex = 1;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(164, 150);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(158, 25);
            this.txt_description.TabIndex = 1;
            // 
            // txt_icon
            // 
            this.txt_icon.Location = new System.Drawing.Point(164, 189);
            this.txt_icon.Name = "txt_icon";
            this.txt_icon.Size = new System.Drawing.Size(158, 25);
            this.txt_icon.TabIndex = 1;
            // 
            // txt_iconType
            // 
            this.txt_iconType.Location = new System.Drawing.Point(164, 228);
            this.txt_iconType.Name = "txt_iconType";
            this.txt_iconType.Size = new System.Drawing.Size(158, 25);
            this.txt_iconType.TabIndex = 1;
            // 
            // txt_iconColor
            // 
            this.txt_iconColor.Location = new System.Drawing.Point(164, 267);
            this.txt_iconColor.Name = "txt_iconColor";
            this.txt_iconColor.Size = new System.Drawing.Size(158, 25);
            this.txt_iconColor.TabIndex = 1;
            // 
            // cbk_isEdit
            // 
            this.cbk_isEdit.AutoSize = true;
            this.cbk_isEdit.Location = new System.Drawing.Point(347, 4);
            this.cbk_isEdit.Name = "cbk_isEdit";
            this.cbk_isEdit.Size = new System.Drawing.Size(44, 19);
            this.cbk_isEdit.TabIndex = 2;
            this.cbk_isEdit.Text = "是";
            this.cbk_isEdit.UseVisualStyleBackColor = true;
            this.cbk_isEdit.Visible = false;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(164, -2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(158, 25);
            this.txt_id.TabIndex = 3;
            this.txt_id.Visible = false;
            // 
            // AddFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddFunc";
            this.Text = "功能";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_inIdCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_menuCode;
        private System.Windows.Forms.TextBox txt_iconColor;
        private System.Windows.Forms.TextBox txt_iconType;
        private System.Windows.Forms.TextBox txt_icon;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_InIdCode;
        private System.Windows.Forms.CheckBox cbk_isEdit;
        private System.Windows.Forms.NumericUpDown txt_id;
    }
}
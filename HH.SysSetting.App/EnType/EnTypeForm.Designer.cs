namespace HH.SysSetting.App.EnType
{
    partial class EnTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnTypeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tv_enType = new System.Windows.Forms.TreeView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_parent = new System.Windows.Forms.TextBox();
            this.txt_level = new System.Windows.Forms.TextBox();
            this.txt_memo = new System.Windows.Forms.TextBox();
            this.txt_refsource = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_sys = new System.Windows.Forms.CheckBox();
            this.cb_end = new System.Windows.Forms.CheckBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tv_enType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 609);
            this.panel1.TabIndex = 0;
            // 
            // tv_enType
            // 
            this.tv_enType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_enType.Location = new System.Drawing.Point(0, 0);
            this.tv_enType.Name = "tv_enType";
            this.tv_enType.Size = new System.Drawing.Size(306, 609);
            this.tv_enType.TabIndex = 0;
            this.tv_enType.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_enType_NodeMouseClick);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(145, 403);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(158, 25);
            this.txt_id.TabIndex = 9;
            this.txt_id.Visible = false;
            // 
            // txt_parent
            // 
            this.txt_parent.Location = new System.Drawing.Point(145, 358);
            this.txt_parent.Name = "txt_parent";
            this.txt_parent.ReadOnly = true;
            this.txt_parent.Size = new System.Drawing.Size(158, 25);
            this.txt_parent.TabIndex = 8;
            // 
            // txt_level
            // 
            this.txt_level.Location = new System.Drawing.Point(145, 313);
            this.txt_level.Name = "txt_level";
            this.txt_level.Size = new System.Drawing.Size(158, 25);
            this.txt_level.TabIndex = 7;
            // 
            // txt_memo
            // 
            this.txt_memo.Location = new System.Drawing.Point(145, 190);
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.Size = new System.Drawing.Size(158, 25);
            this.txt_memo.TabIndex = 4;
            // 
            // txt_refsource
            // 
            this.txt_refsource.Location = new System.Drawing.Point(145, 145);
            this.txt_refsource.Name = "txt_refsource";
            this.txt_refsource.Size = new System.Drawing.Size(158, 25);
            this.txt_refsource.TabIndex = 3;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(145, 100);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(158, 25);
            this.txt_desc.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(145, 55);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(158, 25);
            this.txt_name.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "父级：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "id：";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "级别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "系统配置：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "是否末级：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "备注：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "参考：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "描述：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "名称：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_ver);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.cb_end);
            this.panel2.Controls.Add(this.cb_sys);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_parent);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_level);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_memo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_refsource);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_desc);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(306, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 609);
            this.panel2.TabIndex = 20;
            // 
            // cb_sys
            // 
            this.cb_sys.AutoSize = true;
            this.cb_sys.Location = new System.Drawing.Point(145, 274);
            this.cb_sys.Name = "cb_sys";
            this.cb_sys.Size = new System.Drawing.Size(44, 19);
            this.cb_sys.TabIndex = 6;
            this.cb_sys.Text = "是";
            this.cb_sys.UseVisualStyleBackColor = true;
            // 
            // cb_end
            // 
            this.cb_end.AutoSize = true;
            this.cb_end.Location = new System.Drawing.Point(145, 235);
            this.cb_end.Name = "cb_end";
            this.cb_end.Size = new System.Drawing.Size(44, 19);
            this.cb_end.TabIndex = 5;
            this.cb_end.Text = "是";
            this.cb_end.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(211, 502);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 38);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "重置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_ver
            // 
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.Location = new System.Drawing.Point(197, 18);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(15, 15);
            this.lbl_ver.TabIndex = 12;
            this.lbl_ver.Text = "0";
            this.lbl_ver.Visible = false;
            // 
            // EnTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnTypeForm";
            this.Text = "EnTypeForm";
            this.Load += new System.EventHandler(this.EnTypeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tv_enType;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_parent;
        private System.Windows.Forms.TextBox txt_level;
        private System.Windows.Forms.TextBox txt_memo;
        private System.Windows.Forms.TextBox txt_refsource;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cb_sys;
        private System.Windows.Forms.CheckBox cb_end;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_ver;
    }
}
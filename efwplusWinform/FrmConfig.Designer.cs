namespace EFWCoreLib.WinformFrame
{
    partial class FrmConfig
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
            this.basetabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtfileurl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtwcfurl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtupdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCannel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.basetabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // basetabControl
            // 
            this.basetabControl.Controls.Add(this.tabPage1);
            this.basetabControl.Controls.Add(this.tabPage3);
            this.basetabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basetabControl.Location = new System.Drawing.Point(0, 0);
            this.basetabControl.Name = "basetabControl";
            this.basetabControl.SelectedIndex = 0;
            this.basetabControl.Size = new System.Drawing.Size(352, 189);
            this.basetabControl.TabIndex = 0;
            this.basetabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtfileurl);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtwcfurl);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(344, 163);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "中间件通讯";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtfileurl
            // 
            this.txtfileurl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtfileurl.Location = new System.Drawing.Point(13, 97);
            this.txtfileurl.Name = "txtfileurl";
            this.txtfileurl.Size = new System.Drawing.Size(311, 23);
            this.txtfileurl.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(10, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "文件传输地址：";
            // 
            // txtwcfurl
            // 
            this.txtwcfurl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtwcfurl.Location = new System.Drawing.Point(13, 45);
            this.txtwcfurl.Name = "txtwcfurl";
            this.txtwcfurl.Size = new System.Drawing.Size(311, 23);
            this.txtwcfurl.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(10, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "业务请求地址：";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtupdate);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(344, 163);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "升级地址";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtupdate
            // 
            this.txtupdate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtupdate.Location = new System.Drawing.Point(13, 43);
            this.txtupdate.Name = "txtupdate";
            this.txtupdate.Size = new System.Drawing.Size(311, 23);
            this.txtupdate.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(10, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "客户端升级地址：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCannel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnTestConn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 56);
            this.panel1.TabIndex = 1;
            // 
            // btnCannel
            // 
            this.btnCannel.Location = new System.Drawing.Point(253, 16);
            this.btnCannel.Name = "btnCannel";
            this.btnCannel.Size = new System.Drawing.Size(75, 28);
            this.btnCannel.TabIndex = 2;
            this.btnCannel.Text = "取  消";
            this.btnCannel.UseVisualStyleBackColor = true;
            this.btnCannel.Click += new System.EventHandler(this.btnCannel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(172, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保  存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTestConn
            // 
            this.btnTestConn.Location = new System.Drawing.Point(17, 16);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(75, 28);
            this.btnTestConn.TabIndex = 0;
            this.btnTestConn.Text = "测试连接";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Visible = false;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 245);
            this.Controls.Add(this.basetabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置连接";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.basetabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl basetabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCannel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.TextBox txtfileurl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtwcfurl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtupdate;
        private System.Windows.Forms.Label label7;
    }
}
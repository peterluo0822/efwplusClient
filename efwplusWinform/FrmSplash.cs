using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//using EFWCoreLib.WinformFrame.Properties;

namespace EFWCoreLib.WinformFrame
{
    public delegate bool LoadingHandler();
	/// <summary>
	/// frmSplash 的摘要说明。
	/// </summary>
    public class FrmSplash : Form, ILoading
    {
        private Timer timer1;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 主界面ToolStripMenuItem;
        private ToolStripMenuItem 切换用户ToolStripMenuItem;
        private ToolStripMenuItem 消息面板ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private PictureBox pictureBox1;
        private LinkLabel btnConfig;
        private LinkLabel btnclose;
        private IContainer components;


        public FrmSplash()
        {
            //
            // Windows 窗体设计器支持所必需的
            //
            InitializeComponent();

            //
            // TODO: 在 InitializeComponent 调用后添加任何构造函数代码
            //
        }

        private LoadingHandler _handler;
        public FrmSplash(LoadingHandler handler)
        {
            InitializeComponent();
            _handler = handler;
        }

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.切换用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.消息面板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.LinkLabel();
            this.btnclose = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主界面ToolStripMenuItem,
            this.切换用户ToolStripMenuItem,
            this.消息面板ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 98);
            // 
            // 主界面ToolStripMenuItem
            // 
            this.主界面ToolStripMenuItem.Name = "主界面ToolStripMenuItem";
            this.主界面ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.主界面ToolStripMenuItem.Text = "主界面";
            this.主界面ToolStripMenuItem.Click += new System.EventHandler(this.主界面ToolStripMenuItem_Click);
            // 
            // 切换用户ToolStripMenuItem
            // 
            this.切换用户ToolStripMenuItem.Name = "切换用户ToolStripMenuItem";
            this.切换用户ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.切换用户ToolStripMenuItem.Text = "切换用户";
            this.切换用户ToolStripMenuItem.Visible = false;
            // 
            // 消息面板ToolStripMenuItem
            // 
            this.消息面板ToolStripMenuItem.Name = "消息面板ToolStripMenuItem";
            this.消息面板ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.消息面板ToolStripMenuItem.Text = "消息面板";
            this.消息面板ToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfig
            // 
            this.btnConfig.AutoSize = true;
            this.btnConfig.BackColor = System.Drawing.Color.White;
            this.btnConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnConfig.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfig.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnConfig.Location = new System.Drawing.Point(12, 327);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(106, 18);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.TabStop = true;
            this.btnConfig.Text = "设置通讯连接";
            this.btnConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnConfig_LinkClicked);
            // 
            // btnclose
            // 
            this.btnclose.AutoSize = true;
            this.btnclose.BackColor = System.Drawing.Color.White;
            this.btnclose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnclose.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnclose.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnclose.Location = new System.Drawing.Point(550, 327);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(58, 18);
            this.btnclose.TabIndex = 3;
            this.btnclose.TabStop = true;
            this.btnclose.Text = "关  闭";
            this.btnclose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnclose_LinkClicked);
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(620, 350);
            this.ControlBox = false;
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Red;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSplash_FormClosing);
            this.Load += new System.EventHandler(this.FrmSplash_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private void FrmSplash_Load(object sender, EventArgs e)
        {
            this.btnConfig.Visible = false;
            this.btnclose.Visible = false;

            this.timer1.Enabled = true;
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Icon = efwplusWinform.Common.CommonResource.msn;
            this.notifyIcon1.Text = "客户端程序";
        }

        private void FrmSplash_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            if (_handler != null)
            {
                if (_handler.Invoke())
                    this.Hide();
                else
                {
                    //显示连接失败，配置连接
                    btnConfig.Visible = true;
                    btnclose.Visible = true;
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (MainForm != null)
                MainForm.Show();
        }

        private void 主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainForm != null)
                MainForm.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region ILoading 成员

        private Form _mainform;
        public Form MainForm
        {
            get
            {
                return _mainform;
            }
            set
            {
                _mainform = value;
            }
        }

        #endregion

        private void btnclose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void btnConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WinformGlobal.AppConfig();
        }
    }

    public interface ILoading
    {
        Form MainForm { get; set; }
    }
}

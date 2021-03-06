﻿namespace ToxicantDB
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi2_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_Version = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbFrmMainButtons = new System.Windows.Forms.GroupBox();
            this.btnDetailInput = new System.Windows.Forms.Button();
            this.btnInfoInput = new System.Windows.Forms.Button();
            this.btnInfoManage = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnUserManage = new System.Windows.Forms.Button();
            this.btnInfoMaintenance = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.tssl_AdminName = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbFrmMainButtons.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi1,
            this.tsmi2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi1
            // 
            this.tsmi1.Enabled = false;
            this.tsmi1.Name = "tsmi1";
            this.tsmi1.Size = new System.Drawing.Size(44, 21);
            this.tsmi1.Text = "开始";
            // 
            // tsmi2
            // 
            this.tsmi2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi2_1});
            this.tsmi2.Name = "tsmi2";
            this.tsmi2.Size = new System.Drawing.Size(44, 21);
            this.tsmi2.Text = "帮助";
            // 
            // tsmi2_1
            // 
            this.tsmi2_1.Name = "tsmi2_1";
            this.tsmi2_1.Size = new System.Drawing.Size(100, 22);
            this.tsmi2_1.Text = "关于";
            this.tsmi2_1.Click += new System.EventHandler(this.tsmi2_1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.BackgroundImage")));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblCurrent);
            this.splitContainer1.Panel1.Controls.Add(this.lblTitle);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.gbFrmMainButtons);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip2);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 656);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // lblCurrent
            // 
            this.lblCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrent.Location = new System.Drawing.Point(62, 556);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(110, 31);
            this.lblCurrent.TabIndex = 4;
            this.lblCurrent.Text = "欢迎使用";
            this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(51, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 28);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "毒物管理系统";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Version});
            this.statusStrip1.Location = new System.Drawing.Point(0, 634);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(238, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_Version
            // 
            this.tssl_Version.Name = "tssl_Version";
            this.tssl_Version.Size = new System.Drawing.Size(164, 17);
            this.tssl_Version.Text = "毒物数据库系统 版本号V0.10";
            // 
            // gbFrmMainButtons
            // 
            this.gbFrmMainButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFrmMainButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbFrmMainButtons.Controls.Add(this.btnDetailInput);
            this.gbFrmMainButtons.Controls.Add(this.btnInfoInput);
            this.gbFrmMainButtons.Controls.Add(this.btnInfoManage);
            this.gbFrmMainButtons.Controls.Add(this.btnQuit);
            this.gbFrmMainButtons.Controls.Add(this.btnUserManage);
            this.gbFrmMainButtons.Controls.Add(this.btnInfoMaintenance);
            this.gbFrmMainButtons.Location = new System.Drawing.Point(0, 87);
            this.gbFrmMainButtons.Name = "gbFrmMainButtons";
            this.gbFrmMainButtons.Size = new System.Drawing.Size(238, 429);
            this.gbFrmMainButtons.TabIndex = 8;
            this.gbFrmMainButtons.TabStop = false;
            // 
            // btnDetailInput
            // 
            this.btnDetailInput.Location = new System.Drawing.Point(68, 164);
            this.btnDetailInput.Name = "btnDetailInput";
            this.btnDetailInput.Size = new System.Drawing.Size(104, 41);
            this.btnDetailInput.TabIndex = 1;
            this.btnDetailInput.Text = "详细信息管理";
            this.btnDetailInput.UseVisualStyleBackColor = true;
            this.btnDetailInput.Click += new System.EventHandler(this.btnDetailInput_Click);
            // 
            // btnInfoInput
            // 
            this.btnInfoInput.Location = new System.Drawing.Point(68, 29);
            this.btnInfoInput.Name = "btnInfoInput";
            this.btnInfoInput.Size = new System.Drawing.Size(104, 41);
            this.btnInfoInput.TabIndex = 0;
            this.btnInfoInput.Text = "基本信息录入";
            this.btnInfoInput.UseVisualStyleBackColor = true;
            this.btnInfoInput.Click += new System.EventHandler(this.btnInput_Click_1);
            // 
            // btnInfoManage
            // 
            this.btnInfoManage.Location = new System.Drawing.Point(68, 95);
            this.btnInfoManage.Name = "btnInfoManage";
            this.btnInfoManage.Size = new System.Drawing.Size(104, 41);
            this.btnInfoManage.TabIndex = 2;
            this.btnInfoManage.Text = "基本信息管理";
            this.btnInfoManage.UseVisualStyleBackColor = true;
            this.btnInfoManage.Click += new System.EventHandler(this.btnAidInput_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(68, 363);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(104, 41);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "退出系统";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnUserManage
            // 
            this.btnUserManage.Location = new System.Drawing.Point(68, 230);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Size = new System.Drawing.Size(104, 41);
            this.btnUserManage.TabIndex = 7;
            this.btnUserManage.Text = "用户管理";
            this.btnUserManage.UseVisualStyleBackColor = true;
            this.btnUserManage.Click += new System.EventHandler(this.btnUserManage_Click);
            // 
            // btnInfoMaintenance
            // 
            this.btnInfoMaintenance.Location = new System.Drawing.Point(68, 294);
            this.btnInfoMaintenance.Name = "btnInfoMaintenance";
            this.btnInfoMaintenance.Size = new System.Drawing.Size(104, 41);
            this.btnInfoMaintenance.TabIndex = 6;
            this.btnInfoMaintenance.Text = "信息维护";
            this.btnInfoMaintenance.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_AdminName});
            this.statusStrip2.Location = new System.Drawing.Point(0, 634);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1022, 22);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // tssl_AdminName
            // 
            this.tssl_AdminName.Name = "tssl_AdminName";
            this.tssl_AdminName.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "毒物数据库系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbFrmMainButtons.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi1;
        private System.Windows.Forms.ToolStripMenuItem tsmi2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnInfoInput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnUserManage;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnInfoMaintenance;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Version;
        private System.Windows.Forms.ToolStripStatusLabel tssl_AdminName;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button btnInfoManage;
        private System.Windows.Forms.Button btnDetailInput;
        private System.Windows.Forms.GroupBox gbFrmMainButtons;
        private System.Windows.Forms.ToolStripMenuItem tsmi2_1;
    }
}


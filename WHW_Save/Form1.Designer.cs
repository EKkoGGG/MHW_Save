namespace WHW_Save
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.GameStartButton = new DevExpress.XtraEditors.SimpleButton();
            this.GamePathButton = new DevExpress.XtraEditors.SimpleButton();
            this.GamePath = new DevExpress.XtraEditors.TextEdit();
            this.GameLabel = new DevExpress.XtraEditors.LabelControl();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.UploadButton = new DevExpress.XtraEditors.SimpleButton();
            this.ReviceButton = new DevExpress.XtraEditors.SimpleButton();
            this.SavePathButton = new DevExpress.XtraEditors.SimpleButton();
            this.RecviceMail = new DevExpress.XtraEditors.TextEdit();
            this.EmailLabel = new DevExpress.XtraEditors.LabelControl();
            this.SavePath = new DevExpress.XtraEditors.TextEdit();
            this.SaveLabel = new DevExpress.XtraEditors.LabelControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecviceMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavePath.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.Controls.Add(this.GameStartButton);
            this.panelControl1.Controls.Add(this.GamePathButton);
            this.panelControl1.Controls.Add(this.GamePath);
            this.panelControl1.Controls.Add(this.GameLabel);
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Controls.Add(this.UploadButton);
            this.panelControl1.Controls.Add(this.ReviceButton);
            this.panelControl1.Controls.Add(this.SavePathButton);
            this.panelControl1.Controls.Add(this.RecviceMail);
            this.panelControl1.Controls.Add(this.EmailLabel);
            this.panelControl1.Controls.Add(this.SavePath);
            this.panelControl1.Controls.Add(this.SaveLabel);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(361, 278);
            this.panelControl1.TabIndex = 0;
            // 
            // GameStartButton
            // 
            this.GameStartButton.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.GameStartButton.Appearance.Options.UseFont = true;
            this.GameStartButton.Image = ((System.Drawing.Image)(resources.GetObject("GameStartButton.Image")));
            this.GameStartButton.Location = new System.Drawing.Point(192, 220);
            this.GameStartButton.Name = "GameStartButton";
            this.GameStartButton.Size = new System.Drawing.Size(160, 44);
            this.GameStartButton.TabIndex = 8;
            this.GameStartButton.Text = "启动游戏";
            this.GameStartButton.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // GamePathButton
            // 
            this.GamePathButton.Location = new System.Drawing.Point(277, 109);
            this.GamePathButton.Name = "GamePathButton";
            this.GamePathButton.Size = new System.Drawing.Size(75, 23);
            this.GamePathButton.TabIndex = 7;
            this.GamePathButton.Text = "选择";
            this.GamePathButton.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // GamePath
            // 
            this.GamePath.Location = new System.Drawing.Point(97, 109);
            this.GamePath.Name = "GamePath";
            this.GamePath.Size = new System.Drawing.Size(174, 20);
            this.GamePath.TabIndex = 6;
            // 
            // GameLabel
            // 
            this.GameLabel.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.GameLabel.Appearance.Options.UseFont = true;
            this.GameLabel.Location = new System.Drawing.Point(7, 109);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(84, 20);
            this.GameLabel.TabIndex = 5;
            this.GameLabel.Text = "选择游戏路径";
            // 
            // SaveButton
            // 
            this.SaveButton.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.SaveButton.Appearance.Options.UseFont = true;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(7, 156);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(160, 44);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "保存配置";
            this.SaveButton.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // UploadButton
            // 
            this.UploadButton.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.UploadButton.Appearance.Options.UseFont = true;
            this.UploadButton.Image = ((System.Drawing.Image)(resources.GetObject("UploadButton.Image")));
            this.UploadButton.Location = new System.Drawing.Point(5, 220);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(160, 44);
            this.UploadButton.TabIndex = 3;
            this.UploadButton.Text = "上传存档";
            this.UploadButton.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // ReviceButton
            // 
            this.ReviceButton.Location = new System.Drawing.Point(277, 64);
            this.ReviceButton.Name = "ReviceButton";
            this.ReviceButton.Size = new System.Drawing.Size(75, 23);
            this.ReviceButton.TabIndex = 2;
            this.ReviceButton.Text = "确定";
            this.ReviceButton.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // SavePathButton
            // 
            this.SavePathButton.Location = new System.Drawing.Point(277, 19);
            this.SavePathButton.Name = "SavePathButton";
            this.SavePathButton.Size = new System.Drawing.Size(75, 23);
            this.SavePathButton.TabIndex = 2;
            this.SavePathButton.Text = "选择";
            this.SavePathButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // RecviceMail
            // 
            this.RecviceMail.Location = new System.Drawing.Point(97, 65);
            this.RecviceMail.Name = "RecviceMail";
            this.RecviceMail.Size = new System.Drawing.Size(174, 20);
            this.RecviceMail.TabIndex = 1;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.EmailLabel.Appearance.Options.UseFont = true;
            this.EmailLabel.Location = new System.Drawing.Point(7, 64);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(84, 20);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "存档接收邮箱";
            // 
            // SavePath
            // 
            this.SavePath.Location = new System.Drawing.Point(97, 20);
            this.SavePath.Name = "SavePath";
            this.SavePath.Size = new System.Drawing.Size(174, 20);
            this.SavePath.TabIndex = 1;
            // 
            // SaveLabel
            // 
            this.SaveLabel.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.SaveLabel.Appearance.Options.UseFont = true;
            this.SaveLabel.Location = new System.Drawing.Point(7, 19);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(84, 20);
            this.SaveLabel.TabIndex = 0;
            this.SaveLabel.Text = "选择存档路径";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "存档文件|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "游戏文件|*.*";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MHW_Save";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 301);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MHW_Save";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecviceMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavePath.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl SaveLabel;
        private DevExpress.XtraEditors.TextEdit SavePath;
        private DevExpress.XtraEditors.SimpleButton SavePathButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.TextEdit RecviceMail;
        private DevExpress.XtraEditors.LabelControl EmailLabel;
        private DevExpress.XtraEditors.SimpleButton ReviceButton;
        private DevExpress.XtraEditors.SimpleButton UploadButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton GamePathButton;
        private DevExpress.XtraEditors.TextEdit GamePath;
        private DevExpress.XtraEditors.LabelControl GameLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private DevExpress.XtraEditors.SimpleButton GameStartButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}


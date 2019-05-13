namespace HeDieuHanh
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn = new System.Windows.Forms.ToolStrip();
            this.btnTaskManager = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMusic = new System.Windows.Forms.ToolStripButton();
            this.btnUtility = new System.Windows.Forms.ToolStripButton();
            this.tlpDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.btnSystemInfor = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.btn.SuspendLayout();
            this.tlpDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpDisplay, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 573);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.btn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTaskManager,
            this.toolStripSeparator1,
            this.btnMusic,
            this.btnUtility,
            this.btnSystemInfor});
            this.btn.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(124, 573);
            this.btn.TabIndex = 0;
            this.btn.Text = "toolStrip1";
            // 
            // btnTaskManager
            // 
            this.btnTaskManager.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskManager.Image")));
            this.btnTaskManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaskManager.Margin = new System.Windows.Forms.Padding(0, 30, 0, 2);
            this.btnTaskManager.Name = "btnTaskManager";
            this.btnTaskManager.Size = new System.Drawing.Size(122, 24);
            this.btnTaskManager.Text = "TaskManager";
            this.btnTaskManager.Click += new System.EventHandler(this.btnTaskManager_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // btnMusic
            // 
            this.btnMusic.Image = ((System.Drawing.Image)(resources.GetObject("btnMusic.Image")));
            this.btnMusic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusic.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(122, 24);
            this.btnMusic.Text = "Music";
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnUtility
            // 
            this.btnUtility.Image = ((System.Drawing.Image)(resources.GetObject("btnUtility.Image")));
            this.btnUtility.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUtility.Name = "btnUtility";
            this.btnUtility.Size = new System.Drawing.Size(122, 24);
            this.btnUtility.Text = "Tiện ích";
            this.btnUtility.Click += new System.EventHandler(this.btnUtility_Click);
            // 
            // tlpDisplay
            // 
            this.tlpDisplay.ColumnCount = 1;
            this.tlpDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDisplay.Controls.Add(this.pnDisplay, 0, 0);
            this.tlpDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDisplay.Location = new System.Drawing.Point(127, 3);
            this.tlpDisplay.Name = "tlpDisplay";
            this.tlpDisplay.RowCount = 1;
            this.tlpDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpDisplay.Size = new System.Drawing.Size(702, 567);
            this.tlpDisplay.TabIndex = 1;
            // 
            // pnDisplay
            // 
            this.pnDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDisplay.Location = new System.Drawing.Point(3, 3);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(696, 561);
            this.pnDisplay.TabIndex = 1;
            // 
            // btnSystemInfor
            // 
            this.btnSystemInfor.Image = ((System.Drawing.Image)(resources.GetObject("btnSystemInfor.Image")));
            this.btnSystemInfor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSystemInfor.Name = "btnSystemInfor";
            this.btnSystemInfor.Size = new System.Drawing.Size(122, 24);
            this.btnSystemInfor.Text = "SystemInfor";
            this.btnSystemInfor.Click += new System.EventHandler(this.btnSystemInfor_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(850, 620);
            this.MinimumSize = new System.Drawing.Size(850, 620);
            this.Name = "frmMain";
            this.Text = "Hệ điều hành";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.btn.ResumeLayout(false);
            this.btn.PerformLayout();
            this.tlpDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip btn;
        private System.Windows.Forms.ToolStripButton btnTaskManager;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnMusic;
        private System.Windows.Forms.ToolStripButton btnUtility;
        private System.Windows.Forms.TableLayoutPanel tlpDisplay;
        private System.Windows.Forms.Panel pnDisplay;
        private System.Windows.Forms.ToolStripButton btnSystemInfor;
    }
}


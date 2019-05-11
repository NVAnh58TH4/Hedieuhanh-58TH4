namespace HeDieuHanh.GUI
{
    partial class ucTaskManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEndProcess = new System.Windows.Forms.Button();
            this.btnNewProcess = new System.Windows.Forms.Button();
            this.labelNumOfProccess = new System.Windows.Forms.Label();
            this.labelProcessCount = new System.Windows.Forms.Label();
            this.labelNumOfThreads = new System.Windows.Forms.Label();
            this.labelThreadCount = new System.Windows.Forms.Label();
            this.lvProcess = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lvProcess, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(833, 573);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.btnEndProcess, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNewProcess, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelNumOfProccess, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelProcessCount, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelNumOfThreads, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelThreadCount, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 518);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(827, 52);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnEndProcess
            // 
            this.btnEndProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEndProcess.Location = new System.Drawing.Point(581, 3);
            this.btnEndProcess.Name = "btnEndProcess";
            this.btnEndProcess.Size = new System.Drawing.Size(118, 46);
            this.btnEndProcess.TabIndex = 0;
            this.btnEndProcess.Text = "End Process";
            this.btnEndProcess.UseVisualStyleBackColor = true;
            this.btnEndProcess.Click += new System.EventHandler(this.btnEndProcess_Click);
            // 
            // btnNewProcess
            // 
            this.btnNewProcess.Location = new System.Drawing.Point(705, 3);
            this.btnNewProcess.Name = "btnNewProcess";
            this.btnNewProcess.Size = new System.Drawing.Size(119, 46);
            this.btnNewProcess.TabIndex = 1;
            this.btnNewProcess.Text = "New Process";
            this.btnNewProcess.UseVisualStyleBackColor = true;
            this.btnNewProcess.Click += new System.EventHandler(this.btnNewProcess_Click);
            // 
            // labelNumOfProccess
            // 
            this.labelNumOfProccess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNumOfProccess.AutoSize = true;
            this.labelNumOfProccess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNumOfProccess.Location = new System.Drawing.Point(9, 17);
            this.labelNumOfProccess.Name = "labelNumOfProccess";
            this.labelNumOfProccess.Size = new System.Drawing.Size(147, 17);
            this.labelNumOfProccess.TabIndex = 2;
            this.labelNumOfProccess.Text = "Number of processes:";
            this.labelNumOfProccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProcessCount
            // 
            this.labelProcessCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProcessCount.AutoSize = true;
            this.labelProcessCount.Location = new System.Drawing.Point(219, 17);
            this.labelProcessCount.Name = "labelProcessCount";
            this.labelProcessCount.Size = new System.Drawing.Size(16, 17);
            this.labelProcessCount.TabIndex = 3;
            this.labelProcessCount.Text = "0";
            this.labelProcessCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumOfThreads
            // 
            this.labelNumOfThreads.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNumOfThreads.AutoSize = true;
            this.labelNumOfThreads.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNumOfThreads.Location = new System.Drawing.Point(306, 17);
            this.labelNumOfThreads.Name = "labelNumOfThreads";
            this.labelNumOfThreads.Size = new System.Drawing.Size(130, 17);
            this.labelNumOfThreads.TabIndex = 4;
            this.labelNumOfThreads.Text = "Number of threads:";
            this.labelNumOfThreads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelThreadCount
            // 
            this.labelThreadCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelThreadCount.AutoSize = true;
            this.labelThreadCount.Location = new System.Drawing.Point(508, 17);
            this.labelThreadCount.Name = "labelThreadCount";
            this.labelThreadCount.Size = new System.Drawing.Size(16, 17);
            this.labelThreadCount.TabIndex = 5;
            this.labelThreadCount.Text = "0";
            this.labelThreadCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvProcess
            // 
            this.lvProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProcess.FullRowSelect = true;
            this.lvProcess.Location = new System.Drawing.Point(3, 3);
            this.lvProcess.Name = "lvProcess";
            this.lvProcess.Size = new System.Drawing.Size(827, 509);
            this.lvProcess.TabIndex = 1;
            this.lvProcess.UseCompatibleStateImageBehavior = false;
            this.lvProcess.View = System.Windows.Forms.View.Details;
            this.lvProcess.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvProcess_ColumnClick);
            this.lvProcess.Click += new System.EventHandler(this.lvProcess_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucTaskManager";
            this.Size = new System.Drawing.Size(833, 573);
            this.Load += new System.EventHandler(this.ucTaskManager_Load);
            this.Click += new System.EventHandler(this.lvProcess_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lvProcess;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnEndProcess;
        private System.Windows.Forms.Button btnNewProcess;
        private System.Windows.Forms.Label labelNumOfProccess;
        private System.Windows.Forms.Label labelProcessCount;
        private System.Windows.Forms.Label labelNumOfThreads;
        private System.Windows.Forms.Label labelThreadCount;
        private System.Windows.Forms.Timer timer1;
    }
}

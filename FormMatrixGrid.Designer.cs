using System.Threading;
namespace MatrixGrid2
{
    partial class FormMatrixGrid
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatrixGrid));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem44 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem55 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem66 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem77 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem88 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonResume = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(440, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem33,
            this.toolStripMenuItem44,
            this.toolStripMenuItem55,
            this.toolStripMenuItem66,
            this.toolStripMenuItem77,
            this.toolStripMenuItem88});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolStripMenuItem33
            // 
            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
            this.toolStripMenuItem33.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem33.Text = "3*3";
            this.toolStripMenuItem33.Click += new System.EventHandler(this.toolStripMenuItem33_Click_1);
            // 
            // toolStripMenuItem44
            // 
            this.toolStripMenuItem44.Name = "toolStripMenuItem44";
            this.toolStripMenuItem44.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem44.Text = "4*4";
            this.toolStripMenuItem44.Click += new System.EventHandler(this.toolStripMenuItem44_Click_1);
            // 
            // toolStripMenuItem55
            // 
            this.toolStripMenuItem55.Name = "toolStripMenuItem55";
            this.toolStripMenuItem55.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem55.Text = "5*5";
            this.toolStripMenuItem55.Click += new System.EventHandler(this.toolStripMenuItem55_Click_1);
            // 
            // toolStripMenuItem66
            // 
            this.toolStripMenuItem66.Name = "toolStripMenuItem66";
            this.toolStripMenuItem66.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem66.Text = "6*6";
            this.toolStripMenuItem66.Click += new System.EventHandler(this.toolStripMenuItem66_Click_1);
            // 
            // toolStripMenuItem77
            // 
            this.toolStripMenuItem77.Name = "toolStripMenuItem77";
            this.toolStripMenuItem77.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem77.Text = "7*7";
            this.toolStripMenuItem77.Click += new System.EventHandler(this.toolStripMenuItem77_Click_1);
            // 
            // toolStripMenuItem88
            // 
            this.toolStripMenuItem88.Name = "toolStripMenuItem88";
            this.toolStripMenuItem88.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem88.Text = "8*8";
            this.toolStripMenuItem88.Click += new System.EventHandler(this.toolStripMenuItem88_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripButtonStart,
            this.toolStripSeparator4,
            this.toolStripButtonPause,
            this.toolStripSeparator3,
            this.toolStripButtonResume,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(440, 73);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.AutoSize = false;
            this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(80, 70);
            this.toolStripButtonStart.Text = "Start";
            this.toolStripButtonStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripButtonPause
            // 
            this.toolStripButtonPause.AutoSize = false;
            this.toolStripButtonPause.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPause.Image")));
            this.toolStripButtonPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPause.Name = "toolStripButtonPause";
            this.toolStripButtonPause.Size = new System.Drawing.Size(80, 70);
            this.toolStripButtonPause.Text = "Pause";
            this.toolStripButtonPause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonPause.Click += new System.EventHandler(this.toolStripButtonPause_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripButtonResume
            // 
            this.toolStripButtonResume.AutoSize = false;
            this.toolStripButtonResume.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonResume.Image")));
            this.toolStripButtonResume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResume.Name = "toolStripButtonResume";
            this.toolStripButtonResume.Size = new System.Drawing.Size(80, 70);
            this.toolStripButtonResume.Text = "Resume";
            this.toolStripButtonResume.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonResume.Click += new System.EventHandler(this.toolStripButtonResume_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 73);
            // 
            // FormMatrixGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(440, 300);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormMatrixGrid";
            this.Text = "MatrixGrid";
            this.Load += new System.EventHandler(this.FormMatrixGrid_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem33;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem44;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem55;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem66;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem77;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem88;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public Thread MatrixGrid;
        public bool bThreadStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonPause;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonResume;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
        
    }



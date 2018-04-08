namespace USB_Autorun_Blocker
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.autorun_listener = new System.Windows.Forms.Timer(this.components);
            this.nI1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.driveSafeStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatMuchAutorunFileDeletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status_listener = new System.Windows.Forms.Timer(this.components);
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.hide_application = new System.Windows.Forms.Timer(this.components);
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.lbl_window_text = new System.Windows.Forms.Label();
            this.cms1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(158, 145);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(142, 24);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Safe : Unknown";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3.ForeColor = System.Drawing.Color.Red;
            this.lbl3.Location = new System.Drawing.Point(90, 232);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(279, 31);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Deleted Autorun(s) : 0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.ForeColor = System.Drawing.Color.Red;
            this.lbl2.Location = new System.Drawing.Point(158, 194);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(162, 20);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Safe Drive : Unknown";
            // 
            // autorun_listener
            // 
            this.autorun_listener.Enabled = true;
            this.autorun_listener.Interval = 1;
            this.autorun_listener.Tick += new System.EventHandler(this.autorun_listener_Tick);
            // 
            // nI1
            // 
            this.nI1.ContextMenuStrip = this.cms1;
            this.nI1.Icon = ((System.Drawing.Icon)(resources.GetObject("nI1.Icon")));
            this.nI1.Text = "USB Autorun Blocker";
            this.nI1.Visible = true;
            // 
            // cms1
            // 
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driveSafeStopToolStripMenuItem,
            this.whatMuchAutorunFileDeletedToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cms1.Name = "cms1";
            this.cms1.Size = new System.Drawing.Size(154, 70);
            // 
            // driveSafeStopToolStripMenuItem
            // 
            this.driveSafeStopToolStripMenuItem.Name = "driveSafeStopToolStripMenuItem";
            this.driveSafeStopToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.driveSafeStopToolStripMenuItem.Text = "Drive Safe Stop";
            this.driveSafeStopToolStripMenuItem.Click += new System.EventHandler(this.driveSafeStopToolStripMenuItem_Click);
            // 
            // whatMuchAutorunFileDeletedToolStripMenuItem
            // 
            this.whatMuchAutorunFileDeletedToolStripMenuItem.Name = "whatMuchAutorunFileDeletedToolStripMenuItem";
            this.whatMuchAutorunFileDeletedToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.whatMuchAutorunFileDeletedToolStripMenuItem.Text = "Main Panel";
            this.whatMuchAutorunFileDeletedToolStripMenuItem.Click += new System.EventHandler(this.whatMuchAutorunFileDeletedToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // status_listener
            // 
            this.status_listener.Enabled = true;
            this.status_listener.Interval = 1;
            this.status_listener.Tick += new System.EventHandler(this.status_listener_Tick);
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(166, 52);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(96, 73);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 4;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(166, 52);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(96, 73);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 5;
            this.pb2.TabStop = false;
            // 
            // hide_application
            // 
            this.hide_application.Enabled = true;
            this.hide_application.Interval = 1;
            this.hide_application.Tick += new System.EventHandler(this.hide_application_Tick);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Silver;
            this.pb3.Location = new System.Drawing.Point(0, 1);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(446, 29);
            this.pb3.TabIndex = 6;
            this.pb3.TabStop = false;
            this.pb3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb3_MouseDown);
            this.pb3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb3_MouseMove);
            this.pb3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb3_MouseUp);
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Silver;
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(412, 1);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(34, 29);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 7;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.Silver;
            this.pb5.Image = ((System.Drawing.Image)(resources.GetObject("pb5.Image")));
            this.pb5.Location = new System.Drawing.Point(380, 1);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(34, 29);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 8;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb5_Click);
            // 
            // lbl_window_text
            // 
            this.lbl_window_text.AutoSize = true;
            this.lbl_window_text.BackColor = System.Drawing.Color.Silver;
            this.lbl_window_text.ForeColor = System.Drawing.Color.Black;
            this.lbl_window_text.Location = new System.Drawing.Point(12, 9);
            this.lbl_window_text.Name = "lbl_window_text";
            this.lbl_window_text.Size = new System.Drawing.Size(108, 13);
            this.lbl_window_text.TabIndex = 9;
            this.lbl_window_text.Text = "USB Autorun Blocker";
            this.lbl_window_text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_window_text_MouseDown);
            this.lbl_window_text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_window_text_MouseMove);
            this.lbl_window_text.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_window_text_MouseUp);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(447, 287);
            this.Controls.Add(this.lbl_window_text);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB Autorun Blocker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.cms1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Timer autorun_listener;
        private System.Windows.Forms.NotifyIcon nI1;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.ToolStripMenuItem driveSafeStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatMuchAutorunFileDeletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer status_listener;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Timer hide_application;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.Label lbl_window_text;
    }
}


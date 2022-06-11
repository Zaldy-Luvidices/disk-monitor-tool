namespace F9VS
{
    partial class frmGrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrand));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHostname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.conLoggerFileEvents = new ConsoleLogger.SRCConsoleLogger();
            this.txtCommandReader = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.conLoggerEvents = new ConsoleLogger.SRCConsoleLogger();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblIPAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblHostname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picBanner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 72);
            this.panel1.TabIndex = 5;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.ForeColor = System.Drawing.Color.White;
            this.lblIPAddress.Location = new System.Drawing.Point(256, 22);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(14, 13);
            this.lblIPAddress.TabIndex = 7;
            this.lblIPAddress.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(156, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Logging:";
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostname.ForeColor = System.Drawing.Color.White;
            this.lblHostname.Location = new System.Drawing.Point(256, 9);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(14, 13);
            this.lblHostname.TabIndex = 5;
            this.lblHostname.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Logs:";
            // 
            // picBanner
            // 
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(150, 72);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 2;
            this.picBanner.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.conLoggerEvents);
            this.panel2.Controls.Add(this.txtCommandReader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(266, 436);
            this.panel2.TabIndex = 6;
            // 
            // conLoggerFileEvents
            // 
            this.conLoggerFileEvents.AddTimeStamp = true;
            this.conLoggerFileEvents.AutoScrollContent = true;
            this.conLoggerFileEvents.BackColor = System.Drawing.Color.Black;
            this.conLoggerFileEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conLoggerFileEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conLoggerFileEvents.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conLoggerFileEvents.ForeColor = System.Drawing.Color.White;
            this.conLoggerFileEvents.InsertLineFeed = true;
            this.conLoggerFileEvents.KeyValueSeparator = ": ";
            this.conLoggerFileEvents.Location = new System.Drawing.Point(0, 3);
            this.conLoggerFileEvents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.conLoggerFileEvents.Name = "conLoggerFileEvents";
            this.conLoggerFileEvents.NoteWriteOffset = false;
            this.conLoggerFileEvents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conLoggerFileEvents.Size = new System.Drawing.Size(260, 244);
            this.conLoggerFileEvents.TabIndex = 6;
            this.conLoggerFileEvents.TextPadding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conLoggerFileEvents.TimeStampBackColor = System.Drawing.Color.Black;
            this.conLoggerFileEvents.TimeStampFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conLoggerFileEvents.TimeStampForeColor = System.Drawing.Color.Gray;
            this.conLoggerFileEvents.WordWrap = false;
            // 
            // txtCommandReader
            // 
            this.txtCommandReader.BackColor = System.Drawing.Color.Black;
            this.txtCommandReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommandReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCommandReader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandReader.ForeColor = System.Drawing.Color.White;
            this.txtCommandReader.Location = new System.Drawing.Point(3, 3);
            this.txtCommandReader.Name = "txtCommandReader";
            this.txtCommandReader.Size = new System.Drawing.Size(260, 21);
            this.txtCommandReader.TabIndex = 1;
            this.txtCommandReader.WordWrap = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(266, 72);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 436);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // conLoggerEvents
            // 
            this.conLoggerEvents.AddTimeStamp = true;
            this.conLoggerEvents.AutoScrollContent = true;
            this.conLoggerEvents.BackColor = System.Drawing.Color.Black;
            this.conLoggerEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conLoggerEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.conLoggerEvents.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conLoggerEvents.ForeColor = System.Drawing.Color.White;
            this.conLoggerEvents.InsertLineFeed = true;
            this.conLoggerEvents.KeyValueSeparator = ": ";
            this.conLoggerEvents.Location = new System.Drawing.Point(3, 24);
            this.conLoggerEvents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.conLoggerEvents.Name = "conLoggerEvents";
            this.conLoggerEvents.NoteWriteOffset = false;
            this.conLoggerEvents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conLoggerEvents.Size = new System.Drawing.Size(260, 159);
            this.conLoggerEvents.TabIndex = 6;
            this.conLoggerEvents.TextPadding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conLoggerEvents.TimeStampBackColor = System.Drawing.Color.Black;
            this.conLoggerEvents.TimeStampFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conLoggerEvents.TimeStampForeColor = System.Drawing.Color.Gray;
            this.conLoggerEvents.WordWrap = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.conLoggerFileEvents);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 183);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel3.Size = new System.Drawing.Size(260, 250);
            this.panel3.TabIndex = 7;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmGrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 508);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmGrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F9VS [ZWGQ-8D73-YJCW]";
            this.Load += new System.EventHandler(this.frmGrand_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Panel panel2;
        public ConsoleLogger.SRCConsoleLogger conLoggerFileEvents;
        private System.Windows.Forms.TextBox txtCommandReader;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        public ConsoleLogger.SRCConsoleLogger conLoggerEvents;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}


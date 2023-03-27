namespace TicTacToe
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.controlBoxPnl = new System.Windows.Forms.Panel();
            this.stickerPb = new System.Windows.Forms.PictureBox();
            this.turnLbl = new System.Windows.Forms.Label();
            this.leavePb = new System.Windows.Forms.PictureBox();
            this.homePb = new System.Windows.Forms.PictureBox();
            this.linePnl = new System.Windows.Forms.Panel();
            this.controlBoxPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stickerPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leavePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePb)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBoxPnl
            // 
            this.controlBoxPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBoxPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(174)))), ((int)(((byte)(117)))));
            this.controlBoxPnl.Controls.Add(this.stickerPb);
            this.controlBoxPnl.Controls.Add(this.turnLbl);
            this.controlBoxPnl.Controls.Add(this.leavePb);
            this.controlBoxPnl.Controls.Add(this.homePb);
            this.controlBoxPnl.ForeColor = System.Drawing.Color.White;
            this.controlBoxPnl.Location = new System.Drawing.Point(0, 0);
            this.controlBoxPnl.Name = "controlBoxPnl";
            this.controlBoxPnl.Size = new System.Drawing.Size(597, 50);
            this.controlBoxPnl.TabIndex = 0;
            this.controlBoxPnl.Tag = "controlBoxContainer";
            this.controlBoxPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveFormEvent);
            // 
            // stickerPb
            // 
            this.stickerPb.Enabled = false;
            this.stickerPb.Image = ((System.Drawing.Image)(resources.GetObject("stickerPb.Image")));
            this.stickerPb.Location = new System.Drawing.Point(69, -23);
            this.stickerPb.Name = "stickerPb";
            this.stickerPb.Size = new System.Drawing.Size(139, 73);
            this.stickerPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stickerPb.TabIndex = 3;
            this.stickerPb.TabStop = false;
            // 
            // turnLbl
            // 
            this.turnLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.turnLbl.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLbl.Location = new System.Drawing.Point(221, 13);
            this.turnLbl.Name = "turnLbl";
            this.turnLbl.Size = new System.Drawing.Size(154, 25);
            this.turnLbl.TabIndex = 2;
            this.turnLbl.Text = "Your turn";
            this.turnLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leavePb
            // 
            this.leavePb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leavePb.Image = ((System.Drawing.Image)(resources.GetObject("leavePb.Image")));
            this.leavePb.Location = new System.Drawing.Point(550, 13);
            this.leavePb.Name = "leavePb";
            this.leavePb.Size = new System.Drawing.Size(25, 25);
            this.leavePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leavePb.TabIndex = 1;
            this.leavePb.TabStop = false;
            this.leavePb.Tag = "leaveButton";
            this.leavePb.Click += new System.EventHandler(this.LeaveClickEvent);
            this.leavePb.MouseLeave += new System.EventHandler(this.ControlBoxMouseHoverEvent);
            this.leavePb.MouseHover += new System.EventHandler(this.ControlBoxMouseHoverEvent);
            // 
            // homePb
            // 
            this.homePb.Image = ((System.Drawing.Image)(resources.GetObject("homePb.Image")));
            this.homePb.Location = new System.Drawing.Point(22, 13);
            this.homePb.Name = "homePb";
            this.homePb.Size = new System.Drawing.Size(25, 25);
            this.homePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homePb.TabIndex = 0;
            this.homePb.TabStop = false;
            this.homePb.Tag = "homeButton";
            this.homePb.Click += new System.EventHandler(this.HomeClickEvent);
            this.homePb.MouseLeave += new System.EventHandler(this.ControlBoxMouseHoverEvent);
            this.homePb.MouseHover += new System.EventHandler(this.ControlBoxMouseHoverEvent);
            // 
            // linePnl
            // 
            this.linePnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.linePnl.Location = new System.Drawing.Point(0, 50);
            this.linePnl.Name = "linePnl";
            this.linePnl.Size = new System.Drawing.Size(597, 2);
            this.linePnl.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 650);
            this.ControlBox = false;
            this.Controls.Add(this.linePnl);
            this.Controls.Add(this.controlBoxPnl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.LoadEvent);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintEvent);
            this.controlBoxPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stickerPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leavePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlBoxPnl;
        private System.Windows.Forms.PictureBox leavePb;
        private System.Windows.Forms.PictureBox homePb;
        private System.Windows.Forms.Panel linePnl;
        private System.Windows.Forms.Label turnLbl;
        private System.Windows.Forms.PictureBox stickerPb;
    }
}


﻿namespace CaRoC
{
    partial class frmCaro
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
            this.pnBanCo = new System.Windows.Forms.Panel();
            this.tmThongTin = new System.Windows.Forms.Timer(this.components);
            this.pnThongTin = new System.Windows.Forms.Panel();
            this.lblChuoiChu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHÔNGTINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hƯỚNGDẪNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcthoat = new System.Windows.Forms.PictureBox();
            this.ptchoigame = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnThongTin.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcthoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptchoigame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBanCo
            // 
            this.pnBanCo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnBanCo.Location = new System.Drawing.Point(262, 26);
            this.pnBanCo.Name = "pnBanCo";
            this.pnBanCo.Size = new System.Drawing.Size(501, 501);
            this.pnBanCo.TabIndex = 1;
            this.pnBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBanCo_Paint);
            this.pnBanCo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnBanCo_MouseClick);
            // 
            // tmThongTin
            // 
            this.tmThongTin.Interval = 25;
            this.tmThongTin.Tick += new System.EventHandler(this.tmThongTin_Tick);
            // 
            // pnThongTin
            // 
            this.pnThongTin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnThongTin.Controls.Add(this.lblChuoiChu);
            this.pnThongTin.Location = new System.Drawing.Point(12, 342);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(219, 187);
            this.pnThongTin.TabIndex = 7;
            this.pnThongTin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnThongTin_Paint);
            // 
            // lblChuoiChu
            // 
            this.lblChuoiChu.AutoSize = true;
            this.lblChuoiChu.Location = new System.Drawing.Point(4, 199);
            this.lblChuoiChu.Name = "lblChuoiChu";
            this.lblChuoiChu.Size = new System.Drawing.Size(0, 13);
            this.lblChuoiChu.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gAMEToolStripMenuItem,
            this.tHÔNGTINToolStripMenuItem,
            this.hƯỚNGDẪNToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gAMEToolStripMenuItem
            // 
            this.gAMEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.cToolStripMenuItem});
            this.gAMEToolStripMenuItem.Name = "gAMEToolStripMenuItem";
            this.gAMEToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.gAMEToolStripMenuItem.Text = "GAME";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "Thoát";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.cToolStripMenuItem.Text = "New Game";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // tHÔNGTINToolStripMenuItem
            // 
            this.tHÔNGTINToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.tHÔNGTINToolStripMenuItem.Name = "tHÔNGTINToolStripMenuItem";
            this.tHÔNGTINToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.tHÔNGTINToolStripMenuItem.Text = "THÔNG TIN";
            this.tHÔNGTINToolStripMenuItem.Click += new System.EventHandler(this.tHÔNGTINToolStripMenuItem_Click);
            // 
            // hƯỚNGDẪNToolStripMenuItem
            // 
            this.hƯỚNGDẪNToolStripMenuItem.Name = "hƯỚNGDẪNToolStripMenuItem";
            this.hƯỚNGDẪNToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.hƯỚNGDẪNToolStripMenuItem.Text = "HƯỚNG DẪN";
            this.hƯỚNGDẪNToolStripMenuItem.Click += new System.EventHandler(this.hƯỚNGDẪNToolStripMenuItem_Click);
            // 
            // pcthoat
            // 
            this.pcthoat.Image = global::CaRoC.Properties.Resources.thoat1;
            this.pcthoat.Location = new System.Drawing.Point(57, 286);
            this.pcthoat.Name = "pcthoat";
            this.pcthoat.Size = new System.Drawing.Size(131, 50);
            this.pcthoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcthoat.TabIndex = 0;
            this.pcthoat.TabStop = false;
            this.pcthoat.Click += new System.EventHandler(this.pcthoat_Click);
            // 
            // ptchoigame
            // 
            this.ptchoigame.Image = global::CaRoC.Properties.Resources.choigame1;
            this.ptchoigame.Location = new System.Drawing.Point(57, 229);
            this.ptchoigame.Name = "ptchoigame";
            this.ptchoigame.Size = new System.Drawing.Size(131, 50);
            this.ptchoigame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptchoigame.TabIndex = 0;
            this.ptchoigame.TabStop = false;
            this.ptchoigame.Click += new System.EventHandler(this.ptchoigame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaRoC.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 525);
            this.Controls.Add(this.pcthoat);
            this.Controls.Add(this.ptchoigame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnThongTin);
            this.Controls.Add(this.pnBanCo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmCaro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaRo_AI";
            this.Load += new System.EventHandler(this.frmCaro_Load);
            this.pnThongTin.ResumeLayout(false);
            this.pnThongTin.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcthoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptchoigame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnBanCo;
        private System.Windows.Forms.Timer tmThongTin;
        private System.Windows.Forms.Panel pnThongTin;
        private System.Windows.Forms.Label lblChuoiChu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHÔNGTINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hƯỚNGDẪNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox ptchoigame;
        private System.Windows.Forms.PictureBox pcthoat;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
    }
}


﻿namespace CyberNet.GUI
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbtnnaptenon = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gbtnmenu = new Guna.UI2.WinForms.Guna2Button();
            this.Label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbtnnaptenon);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.gbtnmenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 505);
            this.panel1.TabIndex = 0;
            // 
            // gbtnnaptenon
            // 
            this.gbtnnaptenon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnnaptenon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnnaptenon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnnaptenon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnnaptenon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnnaptenon.FillColor = System.Drawing.Color.Black;
            this.gbtnnaptenon.FocusedColor = System.Drawing.Color.White;
            this.gbtnnaptenon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnnaptenon.ForeColor = System.Drawing.Color.White;
            this.gbtnnaptenon.HoverState.BorderColor = System.Drawing.Color.Black;
            this.gbtnnaptenon.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.gbtnnaptenon.HoverState.FillColor = System.Drawing.Color.White;
            this.gbtnnaptenon.HoverState.ForeColor = System.Drawing.Color.Black;
            this.gbtnnaptenon.Location = new System.Drawing.Point(2, 176);
            this.gbtnnaptenon.Name = "gbtnnaptenon";
            this.gbtnnaptenon.Size = new System.Drawing.Size(114, 55);
            this.gbtnnaptenon.TabIndex = 33;
            this.gbtnnaptenon.Text = "Nạp Tiền online";
            this.gbtnnaptenon.Click += new System.EventHandler(this.gbtnnaptenon_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 109);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // gbtnmenu
            // 
            this.gbtnmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnmenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnmenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnmenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnmenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnmenu.FillColor = System.Drawing.Color.Black;
            this.gbtnmenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnmenu.ForeColor = System.Drawing.Color.White;
            this.gbtnmenu.HoverState.BorderColor = System.Drawing.Color.Black;
            this.gbtnmenu.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.gbtnmenu.HoverState.FillColor = System.Drawing.Color.White;
            this.gbtnmenu.HoverState.ForeColor = System.Drawing.Color.Black;
            this.gbtnmenu.Location = new System.Drawing.Point(3, 115);
            this.gbtnmenu.Name = "gbtnmenu";
            this.gbtnmenu.Size = new System.Drawing.Size(114, 55);
            this.gbtnmenu.TabIndex = 32;
            this.gbtnmenu.Text = "Menu";
            this.gbtnmenu.Click += new System.EventHandler(this.gbtnmenu_Click);
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(16, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 31);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "HOME";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(119, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 67);
            this.panel2.TabIndex = 31;
            // 
            // panel_body
            // 
            this.panel_body.BackgroundImage = global::CyberNet.Properties.Resources.CYBERnet_Logo;
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(119, 67);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(815, 438);
            this.panel_body.TabIndex = 32;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 505);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User";
            this.Text = "Cybernet";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_body;
        private Guna.UI2.WinForms.Guna2Button gbtnnaptenon;
        private Guna.UI2.WinForms.Guna2Button gbtnmenu;
    }
}
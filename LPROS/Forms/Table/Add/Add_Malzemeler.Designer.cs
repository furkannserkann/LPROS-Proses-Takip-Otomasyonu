﻿namespace LPROS.Forms.Table.Add
{
    partial class Add_Malzemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Malzemeler));
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_isim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.masktextbox_fiyat = new System.Windows.Forms.MaskedTextBox();
            this.panel_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel_head.Controls.Add(this.label_head);
            this.panel_head.Controls.Add(this.pictureBox_close);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(309, 30);
            this.panel_head.TabIndex = 56;
            // 
            // label_head
            // 
            this.label_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_head.ForeColor = System.Drawing.Color.White;
            this.label_head.Location = new System.Drawing.Point(12, 0);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(261, 30);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "Malzeme Ekle";
            this.label_head.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(279, 0);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 0;
            this.pictureBox_close.TabStop = false;
            // 
            // button_kaydet
            // 
            this.button_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_kaydet.FlatAppearance.BorderSize = 0;
            this.button_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_kaydet.ForeColor = System.Drawing.Color.White;
            this.button_kaydet.Location = new System.Drawing.Point(48, 223);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(211, 50);
            this.button_kaydet.TabIndex = 55;
            this.button_kaydet.Text = "Malzemeyi Kaydet";
            this.button_kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_kaydet.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label7.Location = new System.Drawing.Point(45, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Malzeme İsmi";
            // 
            // textbox_isim
            // 
            this.textbox_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textbox_isim.ForeColor = System.Drawing.Color.Black;
            this.textbox_isim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_isim.Location = new System.Drawing.Point(48, 101);
            this.textbox_isim.Name = "textbox_isim";
            this.textbox_isim.Size = new System.Drawing.Size(211, 24);
            this.textbox_isim.TabIndex = 47;
            this.textbox_isim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_kayit_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label4.Location = new System.Drawing.Point(45, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Fiyatı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.masktextbox_fiyat);
            this.panel1.Controls.Add(this.panel_head);
            this.panel1.Controls.Add(this.button_kaydet);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textbox_isim);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 306);
            this.panel1.TabIndex = 44;
            // 
            // masktextbox_fiyat
            // 
            this.masktextbox_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.masktextbox_fiyat.Location = new System.Drawing.Point(48, 155);
            this.masktextbox_fiyat.Mask = "00000.0";
            this.masktextbox_fiyat.Name = "masktextbox_fiyat";
            this.masktextbox_fiyat.Size = new System.Drawing.Size(211, 24);
            this.masktextbox_fiyat.TabIndex = 57;
            this.masktextbox_fiyat.Text = "000";
            this.masktextbox_fiyat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_kayit_KeyDown);
            // 
            // Add_Malzemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 306);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Malzemeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Malzemeler";
            this.Load += new System.EventHandler(this.Add_Malzemeler_Load);
            this.panel_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_isim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox masktextbox_fiyat;
    }
}
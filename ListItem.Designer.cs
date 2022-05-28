﻿
namespace ChatApplication
{
    partial class ListItem
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
            this.chatRoomName_label = new System.Windows.Forms.Label();
            this.message_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.circularPictureBox1 = new ChatApplication.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chatRoomName_label
            // 
            this.chatRoomName_label.BackColor = System.Drawing.Color.Transparent;
            this.chatRoomName_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chatRoomName_label.Location = new System.Drawing.Point(173, 58);
            this.chatRoomName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chatRoomName_label.Name = "chatRoomName_label";
            this.chatRoomName_label.Size = new System.Drawing.Size(308, 38);
            this.chatRoomName_label.TabIndex = 2;
            this.chatRoomName_label.Text = "label1";
            this.chatRoomName_label.Click += new System.EventHandler(this.contactName_Click);
            // 
            // message_label
            // 
            this.message_label.BackColor = System.Drawing.Color.Transparent;
            this.message_label.Location = new System.Drawing.Point(173, 120);
            this.message_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(308, 30);
            this.message_label.TabIndex = 3;
            this.message_label.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(490, 192);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.circularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularPictureBox1.BorderSize = 2;
            this.circularPictureBox1.GradientAngle = 50F;
            this.circularPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(163, 163);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 1;
            this.circularPictureBox1.TabStop = false;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.chatRoomName_label);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(496, 197);
            this.Load += new System.EventHandler(this.ListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Label chatRoomName_label;
        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.Button button1;
        private CircularPictureBox circularPictureBox1;
    }
}

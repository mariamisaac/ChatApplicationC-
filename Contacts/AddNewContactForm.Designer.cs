﻿
namespace ChatApplication.Contacts
{
    partial class AddNewContactForm
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
            this.AddContactbutton = new ChatApplication.RoundedButton();
            this.cancelButton = new ChatApplication.RoundedButton();
            this.phoneNumber_txt = new ChatApplication.TextBoxG();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddContactbutton
            // 
            this.AddContactbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddContactbutton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddContactbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddContactbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddContactbutton.BorderRadius = 20;
            this.AddContactbutton.BorderSize = 0;
            this.AddContactbutton.FlatAppearance.BorderSize = 0;
            this.AddContactbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactbutton.ForeColor = System.Drawing.Color.White;
            this.AddContactbutton.Location = new System.Drawing.Point(171, 173);
            this.AddContactbutton.Margin = new System.Windows.Forms.Padding(2);
            this.AddContactbutton.Name = "AddContactbutton";
            this.AddContactbutton.Size = new System.Drawing.Size(85, 42);
            this.AddContactbutton.TabIndex = 8;
            this.AddContactbutton.Text = "Add";
            this.AddContactbutton.TextColor = System.Drawing.Color.White;
            this.AddContactbutton.UseVisualStyleBackColor = false;
            this.AddContactbutton.Click += new System.EventHandler(this.AddContactbutton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelButton.BorderRadius = 20;
            this.cancelButton.BorderSize = 0;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(410, 173);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 42);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "cancel";
            this.cancelButton.TextColor = System.Drawing.Color.White;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // phoneNumber_txt
            // 
            this.phoneNumber_txt.BackColor = System.Drawing.SystemColors.Window;
            this.phoneNumber_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.phoneNumber_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.phoneNumber_txt.BorderRadius = 0;
            this.phoneNumber_txt.BorderSize = 2;
            this.phoneNumber_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneNumber_txt.Location = new System.Drawing.Point(199, 106);
            this.phoneNumber_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumber_txt.Multiline = false;
            this.phoneNumber_txt.Name = "phoneNumber_txt";
            this.phoneNumber_txt.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.phoneNumber_txt.PasswordChar = false;
            this.phoneNumber_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.phoneNumber_txt.PlaceholderText = "";
            this.phoneNumber_txt.Size = new System.Drawing.Size(262, 25);
            this.phoneNumber_txt.TabIndex = 10;
            this.phoneNumber_txt.Texts = "";
            this.phoneNumber_txt.UnderlinedStyle = false;
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Location = new System.Drawing.Point(83, 116);
            this.phoneNumber_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(88, 15);
            this.phoneNumber_label.TabIndex = 11;
            this.phoneNumber_label.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Phone number of person you want to add";
            // 
            // AddNewContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNumber_label);
            this.Controls.Add(this.phoneNumber_txt);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.AddContactbutton);
            this.Name = "AddNewContactForm";
            this.Text = "Add New Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton AddContactbutton;
        private RoundedButton cancelButton;
        private TextBoxG phoneNumber_txt;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Label label1;
    }
}
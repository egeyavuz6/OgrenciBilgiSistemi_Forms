﻿namespace OgrenciBilgiSistemi
{
    partial class NotEkleForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            txtNot = new Guna.UI2.WinForms.Guna2TextBox();
            btnNotEkle = new Guna.UI2.WinForms.Guna2Button();
            exitBtn = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            courseBindingSource = new BindingSource(components);
            studentNumberNameCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            ogrenciBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)courseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ogrenciBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(284, 152);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 2;
            label1.Text = "Student Number:";
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 15F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(284, 211);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 3;
            label2.Text = "Student's Grade";
            // 
            // txtNot
            // 
            txtNot.CustomizableEdges = customizableEdges1;
            txtNot.DefaultText = "";
            txtNot.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNot.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNot.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNot.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNot.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNot.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            txtNot.ForeColor = Color.FromArgb(35, 39, 42);
            txtNot.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNot.Location = new Point(446, 207);
            txtNot.Margin = new Padding(7, 9, 7, 9);
            txtNot.Name = "txtNot";
            txtNot.PlaceholderText = "";
            txtNot.SelectedText = "";
            txtNot.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtNot.Size = new Size(220, 36);
            txtNot.TabIndex = 6;
            // 
            // btnNotEkle
            // 
            btnNotEkle.CustomizableEdges = customizableEdges3;
            btnNotEkle.DisabledState.BorderColor = Color.DarkGray;
            btnNotEkle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNotEkle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNotEkle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNotEkle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNotEkle.ForeColor = SystemColors.Window;
            btnNotEkle.Location = new Point(370, 350);
            btnNotEkle.Name = "btnNotEkle";
            btnNotEkle.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnNotEkle.Size = new Size(160, 90);
            btnNotEkle.TabIndex = 7;
            btnNotEkle.Text = "Add Grade";
            btnNotEkle.Click += btnNotEkle_Click;
            // 
            // exitBtn
            // 
            exitBtn.CustomizableEdges = customizableEdges5;
            exitBtn.DisabledState.BorderColor = Color.DarkGray;
            exitBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            exitBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            exitBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            exitBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            exitBtn.ForeColor = SystemColors.Window;
            exitBtn.Location = new Point(691, 469);
            exitBtn.Name = "exitBtn";
            exitBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            exitBtn.Size = new Size(160, 90);
            exitBtn.TabIndex = 8;
            exitBtn.Text = "Exit to Main Menu";
            exitBtn.Click += exitBtn_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 15F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(284, 274);
            label3.Name = "label3";
            label3.Size = new Size(152, 23);
            label3.TabIndex = 11;
            label3.Text = "Course Name:";
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.CustomizableEdges = customizableEdges7;
            guna2ComboBox1.DataSource = courseBindingSource;
            guna2ComboBox1.DisplayMember = "Id";
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Calibri", 14F, FontStyle.Bold);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Location = new Point(446, 268);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2ComboBox1.Size = new Size(220, 36);
            guna2ComboBox1.TabIndex = 13;
            guna2ComboBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // courseBindingSource
            // 
            courseBindingSource.DataSource = typeof(Course);
            // 
            // studentNumberNameCombo
            // 
            studentNumberNameCombo.BackColor = Color.Transparent;
            studentNumberNameCombo.CustomizableEdges = customizableEdges9;
            studentNumberNameCombo.DataSource = ogrenciBindingSource;
            studentNumberNameCombo.DrawMode = DrawMode.OwnerDrawFixed;
            studentNumberNameCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            studentNumberNameCombo.FocusedColor = Color.FromArgb(94, 148, 255);
            studentNumberNameCombo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            studentNumberNameCombo.Font = new Font("Calibri", 14F, FontStyle.Bold);
            studentNumberNameCombo.ForeColor = Color.FromArgb(68, 88, 112);
            studentNumberNameCombo.ItemHeight = 30;
            studentNumberNameCombo.Location = new Point(446, 152);
            studentNumberNameCombo.Name = "studentNumberNameCombo";
            studentNumberNameCombo.ShadowDecoration.CustomizableEdges = customizableEdges10;
            studentNumberNameCombo.Size = new Size(220, 36);
            studentNumberNameCombo.TabIndex = 14;
            studentNumberNameCombo.TextAlign = HorizontalAlignment.Center;
            studentNumberNameCombo.SelectedIndexChanged += studentNumberNameCombo_SelectedIndexChanged;
            // 
            // ogrenciBindingSource
            // 
            ogrenciBindingSource.DataSource = typeof(Ogrenci);
            // 
            // NotEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            BackgroundImage = Properties.Resources.ChatGPT_Image_10_Tem_2025_14_42_46__1_;
            ClientSize = new Size(900, 600);
            Controls.Add(studentNumberNameCombo);
            Controls.Add(guna2ComboBox1);
            Controls.Add(label3);
            Controls.Add(exitBtn);
            Controls.Add(btnNotEkle);
            Controls.Add(txtNot);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotEkleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBS";
            Load += NotEkleForm_Load;
            ((System.ComponentModel.ISupportInitialize)courseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ogrenciBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNot;
        private Guna.UI2.WinForms.Guna2Button btnNotEkle;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private BindingSource courseBindingSource;
        private Guna.UI2.WinForms.Guna2ComboBox studentNumberNameCombo;
        private BindingSource ogrenciBindingSource;
    }
}
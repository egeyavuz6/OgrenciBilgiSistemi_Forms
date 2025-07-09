namespace OgrenciBilgiSistemi
{
    partial class StudentLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            loginButton = new Guna.UI2.WinForms.Guna2CircleButton();
            label2 = new Label();
            label1 = new Label();
            passwordBox = new Guna.UI2.WinForms.Guna2TextBox();
            studentIDbox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            hideSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Transparent;
            loginButton.DisabledState.BorderColor = Color.DarkGray;
            loginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            loginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loginButton.FillColor = Color.FromArgb(88, 101, 242);
            loginButton.Font = new Font("Calibri", 16F);
            loginButton.ForeColor = Color.White;
            loginButton.HoverState.BorderColor = Color.Black;
            loginButton.HoverState.CustomBorderColor = Color.Black;
            loginButton.HoverState.FillColor = Color.FromArgb(114, 137, 218);
            loginButton.Location = new Point(371, 292);
            loginButton.Name = "loginButton";
            loginButton.ShadowDecoration.CustomizableEdges = customizableEdges1;
            loginButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            loginButton.Size = new Size(148, 148);
            loginButton.TabIndex = 9;
            loginButton.Text = "LOGIN";
            loginButton.Click += loginButton_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 15F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(283, 168);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 8;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(283, 120);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 7;
            label1.Text = "Student ID:";
            // 
            // passwordBox
            // 
            passwordBox.CustomizableEdges = customizableEdges2;
            passwordBox.DefaultText = "";
            passwordBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passwordBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passwordBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passwordBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passwordBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordBox.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            passwordBox.ForeColor = Color.FromArgb(35, 39, 42);
            passwordBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordBox.Location = new Point(412, 168);
            passwordBox.Margin = new Padding(7, 9, 7, 9);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.PlaceholderText = "";
            passwordBox.SelectedText = "";
            passwordBox.ShadowDecoration.CustomizableEdges = customizableEdges3;
            passwordBox.Size = new Size(190, 32);
            passwordBox.TabIndex = 6;
            // 
            // studentIDbox
            // 
            studentIDbox.CustomizableEdges = customizableEdges4;
            studentIDbox.DefaultText = "";
            studentIDbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            studentIDbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            studentIDbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            studentIDbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            studentIDbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            studentIDbox.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            studentIDbox.ForeColor = Color.FromArgb(35, 39, 42);
            studentIDbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            studentIDbox.Location = new Point(412, 120);
            studentIDbox.Margin = new Padding(7, 9, 7, 9);
            studentIDbox.Name = "studentIDbox";
            studentIDbox.PlaceholderText = "";
            studentIDbox.SelectedText = "";
            studentIDbox.ShadowDecoration.CustomizableEdges = customizableEdges5;
            studentIDbox.Size = new Size(190, 32);
            studentIDbox.TabIndex = 5;
            studentIDbox.TextChanged += studentIDbox_TextChanged;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.BackColor = Color.Transparent;
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.FromArgb(88, 101, 242);
            guna2CircleButton1.Font = new Font("Calibri", 16F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.HoverState.BorderColor = Color.Black;
            guna2CircleButton1.HoverState.CustomBorderColor = Color.Black;
            guna2CircleButton1.HoverState.FillColor = Color.FromArgb(114, 137, 218);
            guna2CircleButton1.Location = new Point(724, 401);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(148, 148);
            guna2CircleButton1.TabIndex = 10;
            guna2CircleButton1.Text = "ADMIN LOGIN";
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(671, 178);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(93, 17);
            guna2HtmlLabel1.TabIndex = 13;
            guna2HtmlLabel1.Text = "(Show password)";
            // 
            // hideSwitch
            // 
            hideSwitch.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            hideSwitch.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            hideSwitch.CheckedState.InnerBorderColor = Color.White;
            hideSwitch.CheckedState.InnerColor = Color.White;
            hideSwitch.CustomizableEdges = customizableEdges7;
            hideSwitch.Location = new Point(622, 176);
            hideSwitch.Name = "hideSwitch";
            hideSwitch.ShadowDecoration.CustomizableEdges = customizableEdges8;
            hideSwitch.Size = new Size(35, 20);
            hideSwitch.TabIndex = 12;
            hideSwitch.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            hideSwitch.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            hideSwitch.UncheckedState.InnerBorderColor = Color.White;
            hideSwitch.UncheckedState.InnerColor = Color.White;
            hideSwitch.CheckedChanged += hideSwitch_CheckedChanged;
            // 
            // StudentLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(884, 561);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(hideSwitch);
            Controls.Add(guna2CircleButton1);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordBox);
            Controls.Add(studentIDbox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton loginButton;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox passwordBox;
        private Guna.UI2.WinForms.Guna2TextBox studentIDbox;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch hideSwitch;
    }
}
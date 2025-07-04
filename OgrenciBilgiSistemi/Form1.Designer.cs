namespace OgrenciBilgiSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            enter = new Button();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            username = new Label();
            password = new Label();
            SuspendLayout();
            // 
            // enter
            // 
            enter.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            enter.Location = new Point(292, 245);
            enter.Name = "enter";
            enter.Size = new Size(199, 118);
            enter.TabIndex = 1;
            enter.Text = "GİRİŞ YAP";
            enter.UseVisualStyleBackColor = true;
            enter.Click += button1_Click;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(327, 125);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(164, 23);
            usernameBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(327, 154);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(164, 23);
            passwordBox.TabIndex = 3;
            // 
            // username
            // 
            username.Font = new Font("Comic Sans MS", 15F);
            username.Location = new Point(167, 125);
            username.Name = "username";
            username.Size = new Size(154, 23);
            username.TabIndex = 4;
            username.Text = "Kullanıcı Adı:";
            // 
            // password
            // 
            password.Font = new Font("Comic Sans MS", 15F);
            password.Location = new Point(167, 154);
            password.Name = "password";
            password.Size = new Size(154, 23);
            password.TabIndex = 5;
            password.Text = "Şifre:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(enter);
            Name = "Form1";
            Text = "OBS";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button enter;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label username;
        private Label password;
    }
}

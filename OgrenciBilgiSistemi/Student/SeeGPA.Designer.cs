namespace OgrenciBilgiSistemi.Student
{
    partial class SeeGPA
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            gpaSonucBox = new Guna.UI2.WinForms.Guna2HtmlLabel();
            creditSonucBox = new Guna.UI2.WinForms.Guna2HtmlLabel();
            exitBtn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Calibri", 17F);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(353, 202);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(178, 56);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Current GPA:";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.AutoSize = false;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Calibri", 17F);
            guna2HtmlLabel2.ForeColor = Color.White;
            guna2HtmlLabel2.Location = new Point(353, 284);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(238, 56);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = "Credits You Have Taken:";
            // 
            // gpaSonucBox
            // 
            gpaSonucBox.AutoSize = false;
            gpaSonucBox.BackColor = Color.Transparent;
            gpaSonucBox.Font = new Font("Calibri", 17F);
            gpaSonucBox.ForeColor = Color.White;
            gpaSonucBox.Location = new Point(597, 202);
            gpaSonucBox.Name = "gpaSonucBox";
            gpaSonucBox.Size = new Size(253, 56);
            gpaSonucBox.TabIndex = 2;
            gpaSonucBox.Text = null;
            gpaSonucBox.Click += gpaSonucBox_Click;
            // 
            // creditSonucBox
            // 
            creditSonucBox.AutoSize = false;
            creditSonucBox.BackColor = Color.Transparent;
            creditSonucBox.Font = new Font("Calibri", 17F);
            creditSonucBox.ForeColor = Color.White;
            creditSonucBox.Location = new Point(597, 284);
            creditSonucBox.Name = "creditSonucBox";
            creditSonucBox.Size = new Size(253, 56);
            creditSonucBox.TabIndex = 3;
            creditSonucBox.Text = null;
            // 
            // exitBtn
            // 
            exitBtn.CustomizableEdges = customizableEdges3;
            exitBtn.DisabledState.BorderColor = Color.DarkGray;
            exitBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            exitBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            exitBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            exitBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            exitBtn.ForeColor = SystemColors.Window;
            exitBtn.Location = new Point(690, 460);
            exitBtn.Name = "exitBtn";
            exitBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            exitBtn.Size = new Size(160, 90);
            exitBtn.TabIndex = 12;
            exitBtn.Text = "Exit to Main Menu";
            exitBtn.Click += exitBtn_Click;
            // 
            // SeeGPA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            BackgroundImage = Properties.Resources.studentBackground;
            ClientSize = new Size(900, 600);
            Controls.Add(exitBtn);
            Controls.Add(creditSonucBox);
            Controls.Add(gpaSonucBox);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SeeGPA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SeeGPA";
            Load += SeeGPA_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel gpaSonucBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel creditSonucBox;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
    }
}
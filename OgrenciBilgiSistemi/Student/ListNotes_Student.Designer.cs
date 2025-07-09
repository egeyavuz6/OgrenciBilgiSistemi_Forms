namespace OgrenciBilgiSistemi.Student
{
    partial class ListNotes_Student
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
            button2 = new Guna.UI2.WinForms.Guna2Button();
            btnListele = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.CustomizableEdges = customizableEdges1;
            button2.DisabledState.BorderColor = Color.DarkGray;
            button2.DisabledState.CustomBorderColor = Color.DarkGray;
            button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(523, 460);
            button2.Name = "button2";
            button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            button2.Size = new Size(160, 90);
            button2.TabIndex = 13;
            button2.Text = "Exit to Main Menu";
            button2.Click += button2_Click;
            // 
            // btnListele
            // 
            btnListele.CustomizableEdges = customizableEdges3;
            btnListele.DisabledState.BorderColor = Color.DarkGray;
            btnListele.DisabledState.CustomBorderColor = Color.DarkGray;
            btnListele.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnListele.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnListele.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnListele.ForeColor = Color.White;
            btnListele.Location = new Point(210, 460);
            btnListele.Name = "btnListele";
            btnListele.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnListele.Size = new Size(160, 90);
            btnListele.TabIndex = 12;
            btnListele.Text = "List Grades";
            btnListele.Click += btnListele_Click;
            // 
            // ListNotes_Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(900, 600);
            Controls.Add(button2);
            Controls.Add(btnListele);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListNotes_Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListNotes_Student";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button button2;
        private Guna.UI2.WinForms.Guna2Button btnListele;
    }
}
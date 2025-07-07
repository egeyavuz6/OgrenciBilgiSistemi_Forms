namespace OgrenciBilgiSistemi
{
    partial class NotListeleForm
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
            label1 = new Label();
            txtNo = new Guna.UI2.WinForms.Guna2TextBox();
            btnListele = new Guna.UI2.WinForms.Guna2Button();
            button2 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(259, 247);
            label1.Name = "label1";
            label1.Size = new Size(169, 47);
            label1.TabIndex = 0;
            label1.Text = "Student Number:";
            // 
            // txtNo
            // 
            txtNo.CustomizableEdges = customizableEdges1;
            txtNo.DefaultText = "";
            txtNo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            txtNo.ForeColor = Color.FromArgb(35, 39, 42);
            txtNo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNo.Location = new Point(459, 247);
            txtNo.Margin = new Padding(7, 9, 7, 9);
            txtNo.Name = "txtNo";
            txtNo.PlaceholderText = "";
            txtNo.SelectedText = "";
            txtNo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtNo.Size = new Size(190, 32);
            txtNo.TabIndex = 3;
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
            btnListele.Location = new Point(370, 350);
            btnListele.Name = "btnListele";
            btnListele.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnListele.Size = new Size(160, 90);
            btnListele.TabIndex = 8;
            btnListele.Text = "List Grades";
            btnListele.Click += btnListele_Click;
            // 
            // button2
            // 
            button2.CustomizableEdges = customizableEdges5;
            button2.DisabledState.BorderColor = Color.DarkGray;
            button2.DisabledState.CustomBorderColor = Color.DarkGray;
            button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(690, 460);
            button2.Name = "button2";
            button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            button2.Size = new Size(160, 90);
            button2.TabIndex = 9;
            button2.Text = "Exit to Main Menu";
            button2.Click += button2_Click;
            // 
            // NotListeleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(900, 600);
            Controls.Add(button2);
            Controls.Add(btnListele);
            Controls.Add(txtNo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotListeleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBS";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNo;
        private Guna.UI2.WinForms.Guna2Button btnListele;
        private Guna.UI2.WinForms.Guna2Button button2;
    }
}
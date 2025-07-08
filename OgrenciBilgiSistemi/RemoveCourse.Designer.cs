namespace OgrenciBilgiSistemi
{
    partial class RemoveCourse
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
            exitBtn = new Guna.UI2.WinForms.Guna2Button();
            btnSil = new Guna.UI2.WinForms.Guna2Button();
            btnListele = new Guna.UI2.WinForms.Guna2Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.CustomizableEdges = customizableEdges1;
            exitBtn.DisabledState.BorderColor = Color.DarkGray;
            exitBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            exitBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            exitBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            exitBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            exitBtn.ForeColor = SystemColors.Window;
            exitBtn.Location = new Point(111, 336);
            exitBtn.Name = "exitBtn";
            exitBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            exitBtn.Size = new Size(160, 90);
            exitBtn.TabIndex = 17;
            exitBtn.Text = "Exit to Main Menu";
            exitBtn.Click += exitBtn_Click;
            // 
            // btnSil
            // 
            btnSil.CustomizableEdges = customizableEdges3;
            btnSil.DisabledState.BorderColor = Color.DarkGray;
            btnSil.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSil.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSil.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSil.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(195, 219);
            btnSil.Name = "btnSil";
            btnSil.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSil.Size = new Size(160, 90);
            btnSil.TabIndex = 16;
            btnSil.Text = "Delete Course";
            btnSil.Click += btnSil_Click;
            // 
            // btnListele
            // 
            btnListele.CustomizableEdges = customizableEdges5;
            btnListele.DisabledState.BorderColor = Color.DarkGray;
            btnListele.DisabledState.CustomBorderColor = Color.DarkGray;
            btnListele.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnListele.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnListele.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnListele.ForeColor = Color.White;
            btnListele.Location = new Point(23, 219);
            btnListele.Name = "btnListele";
            btnListele.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnListele.Size = new Size(160, 90);
            btnListele.TabIndex = 15;
            btnListele.Text = "List Courses";
            btnListele.Click += btnListele_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(44, 47, 51);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.WindowText;
            dataGridView1.Location = new Point(395, 100);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(480, 400);
            dataGridView1.TabIndex = 13;
            dataGridView1.Visible = false;
            // 
            // RemoveCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(900, 600);
            Controls.Add(exitBtn);
            Controls.Add(btnSil);
            Controls.Add(btnListele);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RemoveCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RemoveCourse";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2Button btnListele;
        private DataGridView dataGridView1;
    }
}
namespace OgrenciBilgiSistemi
{
    partial class OgrenciSilForm
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
            button1 = new Guna.UI2.WinForms.Guna2Button();
            button2 = new Guna.UI2.WinForms.Guna2Button();
            studentTableView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)studentTableView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.CustomizableEdges = customizableEdges1;
            button1.DisabledState.BorderColor = Color.DarkGray;
            button1.DisabledState.CustomBorderColor = Color.DarkGray;
            button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(210, 463);
            button1.Name = "button1";
            button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            button1.Size = new Size(160, 90);
            button1.TabIndex = 7;
            button1.Text = "Delete Student";
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.CustomizableEdges = customizableEdges3;
            button2.DisabledState.BorderColor = Color.DarkGray;
            button2.DisabledState.CustomBorderColor = Color.DarkGray;
            button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(530, 463);
            button2.Name = "button2";
            button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            button2.Size = new Size(160, 90);
            button2.TabIndex = 8;
            button2.Text = "Exit to Main Menu";
            button2.Click += button2_Click;
            // 
            // studentTableView
            // 
            studentTableView.BackgroundColor = Color.FromArgb(44, 47, 51);
            studentTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentTableView.GridColor = SystemColors.WindowText;
            studentTableView.Location = new Point(210, 40);
            studentTableView.MultiSelect = false;
            studentTableView.Name = "studentTableView";
            studentTableView.ReadOnly = true;
            studentTableView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentTableView.Size = new Size(480, 400);
            studentTableView.TabIndex = 9;
            studentTableView.Visible = false;
            studentTableView.CellContentClick += studentTableView_CellContentClick;
            // 
            // OgrenciSilForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(900, 600);
            Controls.Add(button2);
            Controls.Add(studentTableView);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OgrenciSilForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBS";
            Load += OgrenciSilForm_Load;
            ((System.ComponentModel.ISupportInitialize)studentTableView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2Button button2;
        private DataGridView studentTableView;
    }
}
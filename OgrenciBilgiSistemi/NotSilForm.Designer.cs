namespace OgrenciBilgiSistemi
{
    partial class NotSilForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridView1 = new DataGridView();
            btnSil = new Guna.UI2.WinForms.Guna2Button();
            exitBtn = new Guna.UI2.WinForms.Guna2Button();
            updateButton = new Guna.UI2.WinForms.Guna2Button();
            okButton = new Guna.UI2.WinForms.Guna2Button();
            numericBox = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBox).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(44, 47, 51);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.WindowText;
            dataGridView1.Location = new Point(112, 37);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(758, 400);
            dataGridView1.TabIndex = 3;
            dataGridView1.Visible = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSil
            // 
            btnSil.CustomizableEdges = customizableEdges11;
            btnSil.DisabledState.BorderColor = Color.DarkGray;
            btnSil.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSil.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSil.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSil.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(112, 480);
            btnSil.Name = "btnSil";
            btnSil.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnSil.Size = new Size(160, 90);
            btnSil.TabIndex = 10;
            btnSil.Text = "Delete Grade";
            btnSil.Click += btnSil_Click_2;
            // 
            // exitBtn
            // 
            exitBtn.CustomizableEdges = customizableEdges13;
            exitBtn.DisabledState.BorderColor = Color.DarkGray;
            exitBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            exitBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            exitBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            exitBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            exitBtn.ForeColor = SystemColors.Window;
            exitBtn.Location = new Point(710, 480);
            exitBtn.Name = "exitBtn";
            exitBtn.ShadowDecoration.CustomizableEdges = customizableEdges14;
            exitBtn.Size = new Size(160, 90);
            exitBtn.TabIndex = 11;
            exitBtn.Text = "Exit to Main Menu";
            exitBtn.Click += exitBtn_Click;
            // 
            // updateButton
            // 
            updateButton.CustomizableEdges = customizableEdges15;
            updateButton.DisabledState.BorderColor = Color.DarkGray;
            updateButton.DisabledState.CustomBorderColor = Color.DarkGray;
            updateButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            updateButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            updateButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(414, 480);
            updateButton.Name = "updateButton";
            updateButton.ShadowDecoration.CustomizableEdges = customizableEdges16;
            updateButton.Size = new Size(160, 90);
            updateButton.TabIndex = 12;
            updateButton.Text = "Update Grade";
            updateButton.Click += updateButton_Click;
            // 
            // okButton
            // 
            okButton.CustomizableEdges = customizableEdges17;
            okButton.DisabledState.BorderColor = Color.DarkGray;
            okButton.DisabledState.CustomBorderColor = Color.DarkGray;
            okButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            okButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            okButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            okButton.ForeColor = Color.White;
            okButton.Location = new Point(463, 353);
            okButton.Name = "okButton";
            okButton.ShadowDecoration.CustomizableEdges = customizableEdges18;
            okButton.Size = new Size(61, 48);
            okButton.TabIndex = 14;
            okButton.Text = "OK";
            okButton.Visible = false;
            okButton.Click += okButton_Click;
            // 
            // numericBox
            // 
            numericBox.BackColor = Color.Transparent;
            numericBox.CustomizableEdges = customizableEdges19;
            numericBox.Font = new Font("Segoe UI", 9F);
            numericBox.Location = new Point(414, 311);
            numericBox.Name = "numericBox";
            numericBox.ShadowDecoration.CustomizableEdges = customizableEdges20;
            numericBox.Size = new Size(160, 36);
            numericBox.TabIndex = 15;
            // 
            // NotSilForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            BackgroundImage = Properties.Resources.ChatGPT_Image_10_Tem_2025_14_42_46__1_;
            ClientSize = new Size(900, 600);
            Controls.Add(numericBox);
            Controls.Add(okButton);
            Controls.Add(updateButton);
            Controls.Add(exitBtn);
            Controls.Add(btnSil);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotSilForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotSilForm";
            Load += NotSilForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button okButton;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericBox;
    }
}
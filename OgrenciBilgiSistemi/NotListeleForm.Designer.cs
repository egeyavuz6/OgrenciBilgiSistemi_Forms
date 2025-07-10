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
            label1 = new Label();
            button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(198, 381);
            label1.Name = "label1";
            label1.Size = new Size(278, 47);
            label1.TabIndex = 0;
            label1.Text = "Student Number:";
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
            button2.Location = new Point(690, 460);
            button2.Name = "button2";
            button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            button2.Size = new Size(160, 90);
            button2.TabIndex = 9;
            button2.Text = "Exit to Main Menu";
            button2.Click += button2_Click;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.CustomizableEdges = customizableEdges3;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Calibri", 14F, FontStyle.Bold);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Location = new Point(387, 375);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ComboBox1.Size = new Size(299, 36);
            guna2ComboBox1.TabIndex = 10;
            guna2ComboBox1.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(44, 47, 51);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 270);
            dataGridView1.TabIndex = 12;
            // 
            // NotListeleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            BackgroundImage = Properties.Resources.ChatGPT_Image_10_Tem_2025_14_42_46__1_;
            ClientSize = new Size(900, 600);
            Controls.Add(guna2ComboBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotListeleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBS";
            Load += NotListeleForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button button2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private DataGridView dataGridView1;
    }
}
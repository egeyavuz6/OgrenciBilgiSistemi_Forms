namespace OgrenciBilgiSistemi
{
    partial class OrtalamaForm
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
            button2 = new Guna.UI2.WinForms.Guna2Button();
            comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            ogrenciBindingSource = new BindingSource(components);
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)ogrenciBindingSource).BeginInit();
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
            button2.Location = new Point(690, 460);
            button2.Name = "button2";
            button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            button2.Size = new Size(160, 90);
            button2.TabIndex = 8;
            button2.Text = "Exit to Main Menu";
            button2.Click += button2_Click;
            // 
            // comboBox
            // 
            comboBox.BackColor = Color.Transparent;
            comboBox.CustomizableEdges = customizableEdges3;
            comboBox.DataSource = ogrenciBindingSource;
            comboBox.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            comboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboBox.Font = new Font("Calibri", 14F, FontStyle.Bold);
            comboBox.ForeColor = Color.FromArgb(68, 88, 112);
            comboBox.ItemHeight = 30;
            comboBox.Location = new Point(379, 315);
            comboBox.Name = "comboBox";
            comboBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            comboBox.Size = new Size(268, 36);
            comboBox.TabIndex = 10;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // ogrenciBindingSource
            // 
            ogrenciBindingSource.DataSource = typeof(Ogrenci);
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Calibri", 14F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(227, 180);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(109, 25);
            guna2HtmlLabel1.TabIndex = 11;
            guna2HtmlLabel1.Text = "Student GPA:";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Calibri", 14F, FontStyle.Bold);
            guna2HtmlLabel2.ForeColor = Color.White;
            guna2HtmlLabel2.Location = new Point(107, 233);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(229, 25);
            guna2HtmlLabel2.TabIndex = 12;
            guna2HtmlLabel2.Text = "Student Name and Surname: ";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Calibri", 14F, FontStyle.Bold);
            guna2HtmlLabel3.ForeColor = Color.White;
            guna2HtmlLabel3.Location = new Point(379, 180);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(9, 25);
            guna2HtmlLabel3.TabIndex = 14;
            guna2HtmlLabel3.Text = "-";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Calibri", 14F, FontStyle.Bold);
            guna2HtmlLabel4.ForeColor = Color.White;
            guna2HtmlLabel4.Location = new Point(379, 233);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(9, 25);
            guna2HtmlLabel4.TabIndex = 13;
            guna2HtmlLabel4.Text = "-";
            guna2HtmlLabel4.Click += guna2HtmlLabel4_Click;
            // 
            // OrtalamaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            BackgroundImage = Properties.Resources.ChatGPT_Image_10_Tem_2025_14_42_46__1_;
            ClientSize = new Size(900, 600);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(comboBox);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrtalamaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBS";
            Load += OrtalamaForm_Load;
            ((System.ComponentModel.ISupportInitialize)ogrenciBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button button2;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox;
        private BindingSource ogrenciBindingSource;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}
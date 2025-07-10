namespace OgrenciBilgiSistemi.Student
{
    partial class ListCourses_Student
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
            button2 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.CustomizableEdges = customizableEdges1;
            button2.DisabledState.BorderColor = Color.DarkGray;
            button2.DisabledState.CustomBorderColor = Color.DarkGray;
            button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button2.FillColor = Color.CadetBlue;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(728, 472);
            button2.Name = "button2";
            button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            button2.Size = new Size(160, 90);
            button2.TabIndex = 14;
            button2.Text = "Exit to Main Menu";
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = false;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(181, 32);
            label1.Name = "label1";
            label1.Size = new Size(549, 58);
            label1.TabIndex = 13;
            label1.Text = "LIST OF COURSES";
            label1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(44, 47, 51);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(181, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(549, 342);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ListCourses_Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            BackgroundImage = Properties.Resources.ChatGPT_Image_10_Tem_2025_14_42_46__1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(900, 600);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListCourses_Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListCourses_Student";
            Load += ListCourses_Student_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button button2;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private DataGridView dataGridView1;
    }
}
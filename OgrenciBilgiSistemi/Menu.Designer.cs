namespace OgrenciBilgiSistemi
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            ogrenciIslemleriToolStripMenuItem = new ToolStripMenuItem();
            ogrenciEkleToolStripMenuItem = new ToolStripMenuItem();
            ogrenciSilToolStripMenuItem = new ToolStripMenuItem();
            ogrencileriListeleToolStripMenuItem = new ToolStripMenuItem();
            notIslemleriToolStripMenuItem = new ToolStripMenuItem();
            notEkleToolStripMenuItem = new ToolStripMenuItem();
            notlarıListeleToolStripMenuItem = new ToolStripMenuItem();
            notSilToolStripMenuItem = new ToolStripMenuItem();
            notSilToolStripMenuItem1 = new ToolStripMenuItem();
            yönetimToolStripMenuItem = new ToolStripMenuItem();
            adminEkleToolStripMenuItem = new ToolStripMenuItem();
            cikisToolStripMenuItem = new ToolStripMenuItem();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ogrenciIslemleriToolStripMenuItem, notIslemleriToolStripMenuItem, yönetimToolStripMenuItem, cikisToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ogrenciIslemleriToolStripMenuItem
            // 
            ogrenciIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ogrenciEkleToolStripMenuItem, ogrenciSilToolStripMenuItem, ogrencileriListeleToolStripMenuItem });
            ogrenciIslemleriToolStripMenuItem.Name = "ogrenciIslemleriToolStripMenuItem";
            ogrenciIslemleriToolStripMenuItem.Size = new Size(76, 36);
            ogrenciIslemleriToolStripMenuItem.Text = "Student";
            // 
            // ogrenciEkleToolStripMenuItem
            // 
            ogrenciEkleToolStripMenuItem.Name = "ogrenciEkleToolStripMenuItem";
            ogrenciEkleToolStripMenuItem.Size = new Size(181, 24);
            ogrenciEkleToolStripMenuItem.Text = "Add Student";
            ogrenciEkleToolStripMenuItem.Click += ogrenciEkleToolStripMenuItem_Click;
            // 
            // ogrenciSilToolStripMenuItem
            // 
            ogrenciSilToolStripMenuItem.Name = "ogrenciSilToolStripMenuItem";
            ogrenciSilToolStripMenuItem.Size = new Size(181, 24);
            ogrenciSilToolStripMenuItem.Text = "Delete Student";
            ogrenciSilToolStripMenuItem.Click += ogrenciSilToolStripMenuItem_Click;
            // 
            // ogrencileriListeleToolStripMenuItem
            // 
            ogrencileriListeleToolStripMenuItem.Name = "ogrencileriListeleToolStripMenuItem";
            ogrencileriListeleToolStripMenuItem.Size = new Size(181, 24);
            ogrencileriListeleToolStripMenuItem.Text = "List Students";
            ogrencileriListeleToolStripMenuItem.Click += ogrencileriListeleToolStripMenuItem_Click;
            // 
            // notIslemleriToolStripMenuItem
            // 
            notIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { notEkleToolStripMenuItem, notlarıListeleToolStripMenuItem, notSilToolStripMenuItem, notSilToolStripMenuItem1 });
            notIslemleriToolStripMenuItem.Name = "notIslemleriToolStripMenuItem";
            notIslemleriToolStripMenuItem.Size = new Size(62, 36);
            notIslemleriToolStripMenuItem.Text = "Grade";
            // 
            // notEkleToolStripMenuItem
            // 
            notEkleToolStripMenuItem.Name = "notEkleToolStripMenuItem";
            notEkleToolStripMenuItem.Size = new Size(203, 24);
            notEkleToolStripMenuItem.Text = "Add Grade";
            notEkleToolStripMenuItem.Click += notEkleToolStripMenuItem_Click;
            // 
            // notlarıListeleToolStripMenuItem
            // 
            notlarıListeleToolStripMenuItem.Name = "notlarıListeleToolStripMenuItem";
            notlarıListeleToolStripMenuItem.Size = new Size(203, 24);
            notlarıListeleToolStripMenuItem.Text = "List Grades";
            notlarıListeleToolStripMenuItem.Click += notlarıListeleToolStripMenuItem_Click;
            // 
            // notSilToolStripMenuItem
            // 
            notSilToolStripMenuItem.Name = "notSilToolStripMenuItem";
            notSilToolStripMenuItem.Size = new Size(203, 24);
            notSilToolStripMenuItem.Text = "Average of Grades";
            notSilToolStripMenuItem.Click += notSilToolStripMenuItem_Click;
            // 
            // notSilToolStripMenuItem1
            // 
            notSilToolStripMenuItem1.Name = "notSilToolStripMenuItem1";
            notSilToolStripMenuItem1.Size = new Size(203, 24);
            notSilToolStripMenuItem1.Text = "Delete Grade";
            notSilToolStripMenuItem1.Click += notSilToolStripMenuItem1_Click;
            // 
            // yönetimToolStripMenuItem
            // 
            yönetimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminEkleToolStripMenuItem });
            yönetimToolStripMenuItem.Name = "yönetimToolStripMenuItem";
            yönetimToolStripMenuItem.Size = new Size(123, 36);
            yönetimToolStripMenuItem.Text = "Administration";
            // 
            // adminEkleToolStripMenuItem
            // 
            adminEkleToolStripMenuItem.Name = "adminEkleToolStripMenuItem";
            adminEkleToolStripMenuItem.Size = new Size(155, 24);
            adminEkleToolStripMenuItem.Text = "Add Admin";
            adminEkleToolStripMenuItem.Click += adminEkleToolStripMenuItem_Click;
            // 
            // cikisToolStripMenuItem
            // 
            cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            cikisToolStripMenuItem.Size = new Size(46, 36);
            cikisToolStripMenuItem.Text = "Exit";
            cikisToolStripMenuItem.Click += cikisToolStripMenuItem_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(0, 285);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(900, 97);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "WELCOME TO THE STUDENT MANAGEMENT SYSTEM PLEASE SELECT THE OPERATION YOU WANT TO DO FROM THE MENU ON TOP";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.TopCenter;
            // 
            // guna2AnimateWindow1
            // 
            guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            guna2AnimateWindow1.TargetForm = this;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(900, 600);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBS";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ogrenciIslemleriToolStripMenuItem;
        private ToolStripMenuItem ogrenciEkleToolStripMenuItem;
        private ToolStripMenuItem ogrenciSilToolStripMenuItem;
        private ToolStripMenuItem ogrencileriListeleToolStripMenuItem;
        private ToolStripMenuItem notIslemleriToolStripMenuItem;
        private ToolStripMenuItem notEkleToolStripMenuItem;
        private ToolStripMenuItem notSilToolStripMenuItem;
        private ToolStripMenuItem notlarıListeleToolStripMenuItem;
        private ToolStripMenuItem cikisToolStripMenuItem;
        private ToolStripMenuItem yönetimToolStripMenuItem;
        private ToolStripMenuItem adminEkleToolStripMenuItem;
        private ToolStripMenuItem notSilToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}
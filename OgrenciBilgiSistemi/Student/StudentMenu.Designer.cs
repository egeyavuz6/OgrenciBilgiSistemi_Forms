namespace OgrenciBilgiSistemi.Student
{
    partial class StudentMenu
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
            menuStrip1 = new MenuStrip();
            gradesToolStripMenuItem = new ToolStripMenuItem();
            seeYourGradesToolStripMenuItem = new ToolStripMenuItem();
            seeYourGPAToolStripMenuItem = new ToolStripMenuItem();
            lecturesToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gradesToolStripMenuItem, lecturesToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 49);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // gradesToolStripMenuItem
            // 
            gradesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { seeYourGradesToolStripMenuItem, seeYourGPAToolStripMenuItem });
            gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            gradesToolStripMenuItem.Size = new Size(68, 45);
            gradesToolStripMenuItem.Text = "Grades";
            // 
            // seeYourGradesToolStripMenuItem
            // 
            seeYourGradesToolStripMenuItem.Name = "seeYourGradesToolStripMenuItem";
            seeYourGradesToolStripMenuItem.Size = new Size(188, 24);
            seeYourGradesToolStripMenuItem.Text = "See Your Grades";
            seeYourGradesToolStripMenuItem.Click += seeYourGradesToolStripMenuItem_Click;
            // 
            // seeYourGPAToolStripMenuItem
            // 
            seeYourGPAToolStripMenuItem.Name = "seeYourGPAToolStripMenuItem";
            seeYourGPAToolStripMenuItem.Size = new Size(188, 24);
            seeYourGPAToolStripMenuItem.Text = "See Your GPA";
            seeYourGPAToolStripMenuItem.Click += seeYourGPAToolStripMenuItem_Click;
            // 
            // lecturesToolStripMenuItem
            // 
            lecturesToolStripMenuItem.Name = "lecturesToolStripMenuItem";
            lecturesToolStripMenuItem.Size = new Size(78, 45);
            lecturesToolStripMenuItem.Text = "Lectures";
            lecturesToolStripMenuItem.Click += lecturesToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(46, 45);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Calibri", 16F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(30, 67);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(257, 54);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = null;
            // 
            // StudentMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            BackgroundImage = Properties.Resources.studentMenu;
            ClientSize = new Size(900, 600);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "StudentMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentMenu";
            Load += StudentMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gradesToolStripMenuItem;
        private ToolStripMenuItem lecturesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem seeYourGradesToolStripMenuItem;
        private ToolStripMenuItem seeYourGPAToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
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
            menuStrip1 = new MenuStrip();
            ogrenciIslemleriToolStripMenuItem = new ToolStripMenuItem();
            ogrenciEkleToolStripMenuItem = new ToolStripMenuItem();
            ogrenciSilToolStripMenuItem = new ToolStripMenuItem();
            ogrencileriListeleToolStripMenuItem = new ToolStripMenuItem();
            notIslemleriToolStripMenuItem = new ToolStripMenuItem();
            notEkleToolStripMenuItem = new ToolStripMenuItem();
            notlarıListeleToolStripMenuItem = new ToolStripMenuItem();
            notSilToolStripMenuItem = new ToolStripMenuItem();
            cikisToolStripMenuItem = new ToolStripMenuItem();
            yönetimToolStripMenuItem = new ToolStripMenuItem();
            adminEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ogrenciIslemleriToolStripMenuItem, notIslemleriToolStripMenuItem, cikisToolStripMenuItem, yönetimToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(799, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ogrenciIslemleriToolStripMenuItem
            // 
            ogrenciIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ogrenciEkleToolStripMenuItem, ogrenciSilToolStripMenuItem, ogrencileriListeleToolStripMenuItem });
            ogrenciIslemleriToolStripMenuItem.Name = "ogrenciIslemleriToolStripMenuItem";
            ogrenciIslemleriToolStripMenuItem.Size = new Size(135, 23);
            ogrenciIslemleriToolStripMenuItem.Text = "Ogrenci Islemleri";
            // 
            // ogrenciEkleToolStripMenuItem
            // 
            ogrenciEkleToolStripMenuItem.Name = "ogrenciEkleToolStripMenuItem";
            ogrenciEkleToolStripMenuItem.Size = new Size(200, 24);
            ogrenciEkleToolStripMenuItem.Text = "Ogrenci Ekle";
            ogrenciEkleToolStripMenuItem.Click += ogrenciEkleToolStripMenuItem_Click;
            // 
            // ogrenciSilToolStripMenuItem
            // 
            ogrenciSilToolStripMenuItem.Name = "ogrenciSilToolStripMenuItem";
            ogrenciSilToolStripMenuItem.Size = new Size(200, 24);
            ogrenciSilToolStripMenuItem.Text = "Ogrenci Sil";
            ogrenciSilToolStripMenuItem.Click += ogrenciSilToolStripMenuItem_Click;
            // 
            // ogrencileriListeleToolStripMenuItem
            // 
            ogrencileriListeleToolStripMenuItem.Name = "ogrencileriListeleToolStripMenuItem";
            ogrencileriListeleToolStripMenuItem.Size = new Size(200, 24);
            ogrencileriListeleToolStripMenuItem.Text = "Ogrencileri Listele";
            ogrencileriListeleToolStripMenuItem.Click += ogrencileriListeleToolStripMenuItem_Click;
            // 
            // notIslemleriToolStripMenuItem
            // 
            notIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { notEkleToolStripMenuItem, notlarıListeleToolStripMenuItem, notSilToolStripMenuItem });
            notIslemleriToolStripMenuItem.Name = "notIslemleriToolStripMenuItem";
            notIslemleriToolStripMenuItem.Size = new Size(108, 23);
            notIslemleriToolStripMenuItem.Text = "Not Islemleri";
            // 
            // notEkleToolStripMenuItem
            // 
            notEkleToolStripMenuItem.Name = "notEkleToolStripMenuItem";
            notEkleToolStripMenuItem.Size = new Size(213, 24);
            notEkleToolStripMenuItem.Text = "Not Ekle";
            notEkleToolStripMenuItem.Click += notEkleToolStripMenuItem_Click;
            // 
            // notlarıListeleToolStripMenuItem
            // 
            notlarıListeleToolStripMenuItem.Name = "notlarıListeleToolStripMenuItem";
            notlarıListeleToolStripMenuItem.Size = new Size(213, 24);
            notlarıListeleToolStripMenuItem.Text = "Notları Listele";
            notlarıListeleToolStripMenuItem.Click += notlarıListeleToolStripMenuItem_Click;
            // 
            // notSilToolStripMenuItem
            // 
            notSilToolStripMenuItem.Name = "notSilToolStripMenuItem";
            notSilToolStripMenuItem.Size = new Size(213, 24);
            notSilToolStripMenuItem.Text = "Notların Ortalaması";
            notSilToolStripMenuItem.Click += notSilToolStripMenuItem_Click;
            // 
            // cikisToolStripMenuItem
            // 
            cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            cikisToolStripMenuItem.Size = new Size(51, 23);
            cikisToolStripMenuItem.Text = "Cikis";
            cikisToolStripMenuItem.Click += cikisToolStripMenuItem_Click;
            // 
            // yönetimToolStripMenuItem
            // 
            yönetimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminEkleToolStripMenuItem });
            yönetimToolStripMenuItem.Name = "yönetimToolStripMenuItem";
            yönetimToolStripMenuItem.Size = new Size(76, 23);
            yönetimToolStripMenuItem.Text = "Yönetim";
            // 
            // adminEkleToolStripMenuItem
            // 
            adminEkleToolStripMenuItem.Name = "adminEkleToolStripMenuItem";
            adminEkleToolStripMenuItem.Size = new Size(180, 24);
            adminEkleToolStripMenuItem.Text = "Admin Ekle";
            adminEkleToolStripMenuItem.Click += adminEkleToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(799, 421);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "OBS";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
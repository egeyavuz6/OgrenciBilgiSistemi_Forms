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
            adBox1 = new TextBox();
            soyadBox1 = new TextBox();
            noBox = new TextBox();
            adLabel1 = new Label();
            soyadLabel = new Label();
            noLabel = new Label();
            Button = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ogrenciIslemleriToolStripMenuItem, notIslemleriToolStripMenuItem, cikisToolStripMenuItem });
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
            // adBox1
            // 
            adBox1.Location = new Point(236, 114);
            adBox1.Name = "adBox1";
            adBox1.Size = new Size(200, 23);
            adBox1.TabIndex = 1;
            adBox1.Visible = false;
            adBox1.TextChanged += adBox1_TextChanged;
            // 
            // soyadBox1
            // 
            soyadBox1.Location = new Point(236, 162);
            soyadBox1.Name = "soyadBox1";
            soyadBox1.Size = new Size(200, 23);
            soyadBox1.TabIndex = 2;
            soyadBox1.Visible = false;
            // 
            // noBox
            // 
            noBox.Location = new Point(236, 215);
            noBox.Name = "noBox";
            noBox.Size = new Size(200, 23);
            noBox.TabIndex = 3;
            noBox.Visible = false;
            // 
            // adLabel1
            // 
            adLabel1.Font = new Font("Segoe UI", 15F);
            adLabel1.Location = new Point(70, 106);
            adLabel1.Name = "adLabel1";
            adLabel1.Size = new Size(160, 49);
            adLabel1.TabIndex = 4;
            adLabel1.Text = "Öğrenci Adı:";
            adLabel1.Visible = false;
            adLabel1.Click += adLabel1_Click;
            // 
            // soyadLabel
            // 
            soyadLabel.Font = new Font("Segoe UI", 15F);
            soyadLabel.Location = new Point(70, 162);
            soyadLabel.Name = "soyadLabel";
            soyadLabel.Size = new Size(160, 49);
            soyadLabel.TabIndex = 5;
            soyadLabel.Text = "Öğrenci Soyadı:";
            soyadLabel.Visible = false;
            // 
            // noLabel
            // 
            noLabel.Font = new Font("Segoe UI", 15F);
            noLabel.Location = new Point(70, 215);
            noLabel.Name = "noLabel";
            noLabel.Size = new Size(160, 49);
            noLabel.TabIndex = 6;
            noLabel.Text = "Öğrenci No:";
            noLabel.Visible = false;
            // 
            // Button
            // 
            Button.Font = new Font("Calibri", 13F, FontStyle.Bold);
            Button.Location = new Point(236, 277);
            Button.Name = "Button";
            Button.Size = new Size(200, 66);
            Button.TabIndex = 7;
            Button.UseVisualStyleBackColor = true;
            Button.Visible = false;
            Button.Click += ekleButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(799, 421);
            Controls.Add(Button);
            Controls.Add(noLabel);
            Controls.Add(soyadLabel);
            Controls.Add(adLabel1);
            Controls.Add(noBox);
            Controls.Add(soyadBox1);
            Controls.Add(adBox1);
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
        private TextBox adBox1;
        private TextBox soyadBox1;
        private TextBox noBox;
        private Label adLabel1;
        private Label soyadLabel;
        private Label noLabel;
        private Button Button;
    }
}
namespace OgrenciBilgiSistemi
{
    partial class OgrenciEkleForm
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNo = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button1.Location = new Point(324, 269);
            button1.Name = "button1";
            button1.Size = new Size(152, 95);
            button1.TabIndex = 0;
            button1.Text = "ÖĞRENCİ EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15F, FontStyle.Bold);
            label1.Location = new Point(248, 108);
            label1.Name = "label1";
            label1.Size = new Size(113, 24);
            label1.TabIndex = 1;
            label1.Text = "Öğrenci Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15F, FontStyle.Bold);
            label2.Location = new Point(248, 158);
            label2.Name = "label2";
            label2.Size = new Size(140, 24);
            label2.TabIndex = 2;
            label2.Text = "Öğrenci Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 15F, FontStyle.Bold);
            label3.Location = new Point(248, 205);
            label3.Name = "label3";
            label3.Size = new Size(109, 24);
            label3.TabIndex = 3;
            label3.Text = "Öğrenci No:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(439, 108);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(126, 23);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(439, 158);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(126, 23);
            txtSoyad.TabIndex = 5;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(439, 209);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(126, 23);
            txtNo.TabIndex = 6;
            txtNo.TextChanged += textBox3_TextChanged;
            // 
            // OgrenciEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(txtNo);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "OgrenciEkleForm";
            Text = "OBS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtNo;
    }
}
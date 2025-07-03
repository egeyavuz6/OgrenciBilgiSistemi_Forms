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
            label1 = new Label();
            txtNo = new TextBox();
            btnListele = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(224, 136);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci No:";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(354, 132);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(124, 23);
            txtNo.TabIndex = 1;
            txtNo.TextChanged += txtNo_TextChanged;
            // 
            // btnListele
            // 
            btnListele.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnListele.Location = new Point(311, 262);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(167, 71);
            btnListele.TabIndex = 2;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click_1;
            // 
            // NotListeleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(btnListele);
            Controls.Add(txtNo);
            Controls.Add(label1);
            Name = "NotListeleForm";
            Text = "OBS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNo;
        private Button btnListele;
    }
}
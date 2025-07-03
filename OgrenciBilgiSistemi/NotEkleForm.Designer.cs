namespace OgrenciBilgiSistemi
{
    partial class NotEkleForm
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
            txtNo = new TextBox();
            txtNot = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnNotEkle = new Button();
            SuspendLayout();
            // 
            // txtNo
            // 
            txtNo.Location = new Point(368, 112);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(100, 23);
            txtNo.TabIndex = 0;
            // 
            // txtNot
            // 
            txtNot.Location = new Point(368, 165);
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(100, 23);
            txtNot.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(206, 115);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            label1.Text = "Öğrenci No:";
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.Location = new Point(206, 165);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "Öğrenci Not:";
            // 
            // btnNotEkle
            // 
            btnNotEkle.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnNotEkle.Location = new Point(368, 231);
            btnNotEkle.Name = "btnNotEkle";
            btnNotEkle.Size = new Size(100, 70);
            btnNotEkle.TabIndex = 4;
            btnNotEkle.Text = "NOT EKLE";
            btnNotEkle.UseVisualStyleBackColor = true;
            btnNotEkle.Click += btnNotEkle_Click_1;
            // 
            // NotEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(btnNotEkle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNot);
            Controls.Add(txtNo);
            Name = "NotEkleForm";
            Text = "OBS";
            Load += NotEkleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNo;
        private TextBox txtNot;
        private Label label1;
        private Label label2;
        private Button btnNotEkle;
    }
}
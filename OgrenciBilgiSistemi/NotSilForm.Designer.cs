namespace OgrenciBilgiSistemi
{
    partial class NotSilForm
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
            textBox1 = new TextBox();
            btnListele = new Button();
            dataGridView1 = new DataGridView();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 15F, FontStyle.Bold);
            label1.Location = new Point(20, 155);
            label1.Name = "label1";
            label1.Size = new Size(150, 60);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci No: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 23);
            textBox1.TabIndex = 1;
            // 
            // btnListele
            // 
            btnListele.Font = new Font("Calibri", 15F, FontStyle.Bold);
            btnListele.Location = new Point(83, 218);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(145, 79);
            btnListele.TabIndex = 2;
            btnListele.Text = "Notları Gör";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnSil_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(309, 32);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(479, 406);
            dataGridView1.TabIndex = 3;
            dataGridView1.Visible = false;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Calibri", 15F, FontStyle.Bold);
            btnSil.Location = new Point(83, 334);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(145, 79);
            btnSil.TabIndex = 4;
            btnSil.Text = "Seçili Notu Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // NotSilForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSil);
            Controls.Add(dataGridView1);
            Controls.Add(btnListele);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "NotSilForm";
            Text = "NotSilForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnListele;
        private DataGridView dataGridView1;
        private Button btnSil;
    }
}
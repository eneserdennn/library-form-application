namespace LibraryWinForm.Kaynak
{
    partial class KaynakGuncelleForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.kaynakBasimTarihiText = new System.Windows.Forms.DateTimePicker();
            this.kaynakSayfaSayisiText = new System.Windows.Forms.NumericUpDown();
            this.kaynakYayinEviText = new System.Windows.Forms.TextBox();
            this.kaynakYazarText = new System.Windows.Forms.TextBox();
            this.kaynakAdText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakSayfaSayisiText)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 768);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(124, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 52);
            this.button1.TabIndex = 51;
            this.button1.Text = "Guncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kaynakBasimTarihiText
            // 
            this.kaynakBasimTarihiText.Location = new System.Drawing.Point(124, 246);
            this.kaynakBasimTarihiText.Name = "kaynakBasimTarihiText";
            this.kaynakBasimTarihiText.Size = new System.Drawing.Size(193, 22);
            this.kaynakBasimTarihiText.TabIndex = 50;
            // 
            // kaynakSayfaSayisiText
            // 
            this.kaynakSayfaSayisiText.Location = new System.Drawing.Point(124, 199);
            this.kaynakSayfaSayisiText.Name = "kaynakSayfaSayisiText";
            this.kaynakSayfaSayisiText.Size = new System.Drawing.Size(193, 22);
            this.kaynakSayfaSayisiText.TabIndex = 49;
            // 
            // kaynakYayinEviText
            // 
            this.kaynakYayinEviText.Location = new System.Drawing.Point(124, 155);
            this.kaynakYayinEviText.Name = "kaynakYayinEviText";
            this.kaynakYayinEviText.Size = new System.Drawing.Size(193, 22);
            this.kaynakYayinEviText.TabIndex = 48;
            // 
            // kaynakYazarText
            // 
            this.kaynakYazarText.Location = new System.Drawing.Point(124, 110);
            this.kaynakYazarText.Name = "kaynakYazarText";
            this.kaynakYazarText.Size = new System.Drawing.Size(193, 22);
            this.kaynakYazarText.TabIndex = 47;
            // 
            // kaynakAdText
            // 
            this.kaynakAdText.Location = new System.Drawing.Point(124, 64);
            this.kaynakAdText.Name = "kaynakAdText";
            this.kaynakAdText.Size = new System.Drawing.Size(193, 22);
            this.kaynakAdText.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Basim Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Sayfa Sayisi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Yayin Evi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Yazar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ad:";
            // 
            // KaynakGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 792);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kaynakBasimTarihiText);
            this.Controls.Add(this.kaynakSayfaSayisiText);
            this.Controls.Add(this.kaynakYayinEviText);
            this.Controls.Add(this.kaynakYazarText);
            this.Controls.Add(this.kaynakAdText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KaynakGuncelleForm";
            this.Text = "KaynakGuncelleForm";
            this.Load += new System.EventHandler(this.KaynakGuncelleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakSayfaSayisiText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker kaynakBasimTarihiText;
        private System.Windows.Forms.NumericUpDown kaynakSayfaSayisiText;
        private System.Windows.Forms.TextBox kaynakYayinEviText;
        private System.Windows.Forms.TextBox kaynakYazarText;
        private System.Windows.Forms.TextBox kaynakAdText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
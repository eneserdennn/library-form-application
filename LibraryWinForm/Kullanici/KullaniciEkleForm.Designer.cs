namespace LibraryWinForm.Kullanici
{
    partial class KullaniciEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kullaniciAdText = new System.Windows.Forms.TextBox();
            this.kullaniciSoyadText = new System.Windows.Forms.TextBox();
            this.kullaniciMailText = new System.Windows.Forms.TextBox();
            this.kullaniciCezaText = new System.Windows.Forms.TextBox();
            this.kullaniciTelText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kullaniciTcText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ceza:";
            // 
            // kullaniciAdText
            // 
            this.kullaniciAdText.Location = new System.Drawing.Point(153, 107);
            this.kullaniciAdText.Name = "kullaniciAdText";
            this.kullaniciAdText.Size = new System.Drawing.Size(100, 22);
            this.kullaniciAdText.TabIndex = 4;
            // 
            // kullaniciSoyadText
            // 
            this.kullaniciSoyadText.Location = new System.Drawing.Point(153, 138);
            this.kullaniciSoyadText.Name = "kullaniciSoyadText";
            this.kullaniciSoyadText.Size = new System.Drawing.Size(100, 22);
            this.kullaniciSoyadText.TabIndex = 5;
            // 
            // kullaniciMailText
            // 
            this.kullaniciMailText.Location = new System.Drawing.Point(153, 174);
            this.kullaniciMailText.Name = "kullaniciMailText";
            this.kullaniciMailText.Size = new System.Drawing.Size(100, 22);
            this.kullaniciMailText.TabIndex = 6;
            // 
            // kullaniciCezaText
            // 
            this.kullaniciCezaText.Location = new System.Drawing.Point(153, 291);
            this.kullaniciCezaText.Name = "kullaniciCezaText";
            this.kullaniciCezaText.Size = new System.Drawing.Size(100, 22);
            this.kullaniciCezaText.TabIndex = 7;
            // 
            // kullaniciTelText
            // 
            this.kullaniciTelText.Location = new System.Drawing.Point(153, 211);
            this.kullaniciTelText.Name = "kullaniciTelText";
            this.kullaniciTelText.Size = new System.Drawing.Size(100, 22);
            this.kullaniciTelText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tel:";
            // 
            // kullaniciTcText
            // 
            this.kullaniciTcText.Location = new System.Drawing.Point(153, 253);
            this.kullaniciTcText.Name = "kullaniciTcText";
            this.kullaniciTcText.Size = new System.Drawing.Size(100, 22);
            this.kullaniciTcText.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "TC:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(88, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(787, 652);
            this.dataGridView1.TabIndex = 13;
            // 
            // KullaniciEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 757);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kullaniciTcText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kullaniciTelText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kullaniciCezaText);
            this.Controls.Add(this.kullaniciMailText);
            this.Controls.Add(this.kullaniciSoyadText);
            this.Controls.Add(this.kullaniciAdText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciEkleForm";
            this.Text = "KullaniciEkleForm";
            this.Load += new System.EventHandler(this.KullaniciEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kullaniciAdText;
        private System.Windows.Forms.TextBox kullaniciSoyadText;
        private System.Windows.Forms.TextBox kullaniciMailText;
        private System.Windows.Forms.TextBox kullaniciCezaText;
        private System.Windows.Forms.TextBox kullaniciTelText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kullaniciTcText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
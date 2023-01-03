namespace LibraryWinForm.Kullanici
{
    partial class KullaniciGuncelleForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.kullaniciTcText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kullaniciTelText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kullaniciCezaText = new System.Windows.Forms.TextBox();
            this.kullaniciMailText = new System.Windows.Forms.TextBox();
            this.kullaniciSoyadText = new System.Windows.Forms.TextBox();
            this.kullaniciAdText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(87, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullaniciTcText
            // 
            this.kullaniciTcText.Location = new System.Drawing.Point(152, 238);
            this.kullaniciTcText.Name = "kullaniciTcText";
            this.kullaniciTcText.Size = new System.Drawing.Size(100, 22);
            this.kullaniciTcText.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "TC:";
            // 
            // kullaniciTelText
            // 
            this.kullaniciTelText.Location = new System.Drawing.Point(152, 196);
            this.kullaniciTelText.Name = "kullaniciTelText";
            this.kullaniciTelText.Size = new System.Drawing.Size(100, 22);
            this.kullaniciTelText.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tel:";
            // 
            // kullaniciCezaText
            // 
            this.kullaniciCezaText.Location = new System.Drawing.Point(152, 276);
            this.kullaniciCezaText.Name = "kullaniciCezaText";
            this.kullaniciCezaText.Size = new System.Drawing.Size(100, 22);
            this.kullaniciCezaText.TabIndex = 20;
            // 
            // kullaniciMailText
            // 
            this.kullaniciMailText.Location = new System.Drawing.Point(152, 159);
            this.kullaniciMailText.Name = "kullaniciMailText";
            this.kullaniciMailText.Size = new System.Drawing.Size(100, 22);
            this.kullaniciMailText.TabIndex = 19;
            // 
            // kullaniciSoyadText
            // 
            this.kullaniciSoyadText.Location = new System.Drawing.Point(152, 123);
            this.kullaniciSoyadText.Name = "kullaniciSoyadText";
            this.kullaniciSoyadText.Size = new System.Drawing.Size(100, 22);
            this.kullaniciSoyadText.TabIndex = 18;
            // 
            // kullaniciAdText
            // 
            this.kullaniciAdText.Location = new System.Drawing.Point(152, 92);
            this.kullaniciAdText.Name = "kullaniciAdText";
            this.kullaniciAdText.Size = new System.Drawing.Size(100, 22);
            this.kullaniciAdText.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ceza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 802);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // KullaniciGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 892);
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
            this.Name = "KullaniciGuncelleForm";
            this.Text = "KullaniciGuncelleForm";
            this.Load += new System.EventHandler(this.KullaniciGuncelleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kullaniciTcText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kullaniciTelText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kullaniciCezaText;
        private System.Windows.Forms.TextBox kullaniciMailText;
        private System.Windows.Forms.TextBox kullaniciSoyadText;
        private System.Windows.Forms.TextBox kullaniciAdText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
namespace AlgoProje
{
    partial class Arama
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
            this.txt_ran_Num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sayi_miktari = new System.Windows.Forms.TextBox();
            this.sayi_olustur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_aranan = new System.Windows.Forms.TextBox();
            this.Binary = new System.Windows.Forms.Button();
            this.Linear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.TextBox();
            this.txt_sonuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Exp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ran_Num
            // 
            this.txt_ran_Num.Location = new System.Drawing.Point(260, 26);
            this.txt_ran_Num.Multiline = true;
            this.txt_ran_Num.Name = "txt_ran_Num";
            this.txt_ran_Num.ReadOnly = true;
            this.txt_ran_Num.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ran_Num.Size = new System.Drawing.Size(507, 148);
            this.txt_ran_Num.TabIndex = 0;
            this.txt_ran_Num.TextChanged += new System.EventHandler(this.txt_ran_Num_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kaç sayı oluşturulacağını giriniz.";
            this.label1.UseWaitCursor = true;
            // 
            // sayi_miktari
            // 
            this.sayi_miktari.Location = new System.Drawing.Point(15, 70);
            this.sayi_miktari.Name = "sayi_miktari";
            this.sayi_miktari.Size = new System.Drawing.Size(96, 20);
            this.sayi_miktari.TabIndex = 5;
            this.sayi_miktari.UseWaitCursor = true;
            this.sayi_miktari.TextChanged += new System.EventHandler(this.sayi_miktari_TextChanged);
            // 
            // sayi_olustur
            // 
            this.sayi_olustur.Location = new System.Drawing.Point(122, 146);
            this.sayi_olustur.Name = "sayi_olustur";
            this.sayi_olustur.Size = new System.Drawing.Size(98, 28);
            this.sayi_olustur.TabIndex = 6;
            this.sayi_olustur.Text = "Sayıları Oluştur";
            this.sayi_olustur.UseVisualStyleBackColor = true;
            this.sayi_olustur.UseWaitCursor = true;
            this.sayi_olustur.Click += new System.EventHandler(this.sayi_olustur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Aradığınız sayıyı giriniz ve algoritma seçiniz -";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(133, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Aranan Sayı :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_aranan
            // 
            this.txt_aranan.Location = new System.Drawing.Point(236, 248);
            this.txt_aranan.Name = "txt_aranan";
            this.txt_aranan.Size = new System.Drawing.Size(100, 20);
            this.txt_aranan.TabIndex = 15;
            this.txt_aranan.TextChanged += new System.EventHandler(this.txt_aranan_TextChanged);
            // 
            // Binary
            // 
            this.Binary.Location = new System.Drawing.Point(423, 211);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(103, 23);
            this.Binary.TabIndex = 16;
            this.Binary.Text = "Binary";
            this.Binary.UseVisualStyleBackColor = true;
            this.Binary.Click += new System.EventHandler(this.Binary_Click);
            // 
            // Linear
            // 
            this.Linear.Location = new System.Drawing.Point(596, 211);
            this.Linear.Name = "Linear";
            this.Linear.Size = new System.Drawing.Size(103, 23);
            this.Linear.TabIndex = 17;
            this.Linear.Text = "Linear";
            this.Linear.UseVisualStyleBackColor = true;
            this.Linear.Click += new System.EventHandler(this.Linear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(22, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Geçen Süre :";
            this.label6.UseWaitCursor = true;
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Time.Location = new System.Drawing.Point(206, 311);
            this.Time.Multiline = true;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Time.Size = new System.Drawing.Size(561, 127);
            this.Time.TabIndex = 20;
            this.Time.UseWaitCursor = true;
            this.Time.TextChanged += new System.EventHandler(this.Time_TextChanged);
            // 
            // txt_sonuc
            // 
            this.txt_sonuc.Location = new System.Drawing.Point(334, 285);
            this.txt_sonuc.Name = "txt_sonuc";
            this.txt_sonuc.ReadOnly = true;
            this.txt_sonuc.Size = new System.Drawing.Size(433, 20);
            this.txt_sonuc.TabIndex = 21;
            this.txt_sonuc.TextChanged += new System.EventHandler(this.txt_sonuc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(257, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sonuç -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(256, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 23;
            // 
            // lbl_Exp
            // 
            this.lbl_Exp.AutoSize = true;
            this.lbl_Exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Exp.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Exp.Location = new System.Drawing.Point(257, 181);
            this.lbl_Exp.Name = "lbl_Exp";
            this.lbl_Exp.Size = new System.Drawing.Size(0, 16);
            this.lbl_Exp.TabIndex = 24;
            // 
            // Arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Exp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_sonuc);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Linear);
            this.Controls.Add(this.Binary);
            this.Controls.Add(this.txt_aranan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sayi_olustur);
            this.Controls.Add(this.sayi_miktari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ran_Num);
            this.Name = "Arama";
            this.Text = "Arama";
            this.Load += new System.EventHandler(this.Arama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ran_Num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sayi_miktari;
        private System.Windows.Forms.Button sayi_olustur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_aranan;
        private System.Windows.Forms.Button Binary;
        private System.Windows.Forms.Button Linear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox txt_sonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Exp;
    }
}
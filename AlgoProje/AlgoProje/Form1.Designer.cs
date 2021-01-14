namespace AlgoProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.sayi_olustur = new System.Windows.Forms.Button();
            this.BucketSort = new System.Windows.Forms.Button();
            this.ran_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sayi_miktari = new System.Windows.Forms.TextBox();
            this.RadixSort = new System.Windows.Forms.Button();
            this.HeapSort = new System.Windows.Forms.Button();
            this.MergeSort = new System.Windows.Forms.Button();
            this.QuickSort = new System.Windows.Forms.Button();
            this.CountingSort = new System.Windows.Forms.Button();
            this.insertionSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sorted_num = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sıralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Exp = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sayi_olustur
            // 
            this.sayi_olustur.Location = new System.Drawing.Point(114, 155);
            this.sayi_olustur.Name = "sayi_olustur";
            this.sayi_olustur.Size = new System.Drawing.Size(98, 28);
            this.sayi_olustur.TabIndex = 0;
            this.sayi_olustur.Text = "Sayıları Oluştur";
            this.sayi_olustur.UseVisualStyleBackColor = true;
            this.sayi_olustur.UseWaitCursor = true;
            this.sayi_olustur.Click += new System.EventHandler(this.sayi_olustur_Click);
            // 
            // BucketSort
            // 
            this.BucketSort.Location = new System.Drawing.Point(242, 216);
            this.BucketSort.Name = "BucketSort";
            this.BucketSort.Size = new System.Drawing.Size(75, 23);
            this.BucketSort.TabIndex = 1;
            this.BucketSort.Text = "Bucket";
            this.BucketSort.UseVisualStyleBackColor = true;
            this.BucketSort.UseWaitCursor = true;
            this.BucketSort.Click += new System.EventHandler(this.BucketSort_Click);
            // 
            // ran_num
            // 
            this.ran_num.Location = new System.Drawing.Point(242, 48);
            this.ran_num.Multiline = true;
            this.ran_num.Name = "ran_num";
            this.ran_num.ReadOnly = true;
            this.ran_num.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ran_num.Size = new System.Drawing.Size(561, 146);
            this.ran_num.TabIndex = 2;
            this.ran_num.UseWaitCursor = true;
            this.ran_num.TextChanged += new System.EventHandler(this.ran_num_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kaç sayı oluşturulacağını giriniz.";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sayi_miktari
            // 
            this.sayi_miktari.Location = new System.Drawing.Point(15, 77);
            this.sayi_miktari.Name = "sayi_miktari";
            this.sayi_miktari.Size = new System.Drawing.Size(96, 20);
            this.sayi_miktari.TabIndex = 4;
            this.sayi_miktari.UseWaitCursor = true;
            this.sayi_miktari.TextChanged += new System.EventHandler(this.sayi_miktari_TextChanged);
            // 
            // RadixSort
            // 
            this.RadixSort.Location = new System.Drawing.Point(323, 216);
            this.RadixSort.Name = "RadixSort";
            this.RadixSort.Size = new System.Drawing.Size(75, 23);
            this.RadixSort.TabIndex = 5;
            this.RadixSort.Text = "Radix";
            this.RadixSort.UseVisualStyleBackColor = true;
            this.RadixSort.UseWaitCursor = true;
            this.RadixSort.Click += new System.EventHandler(this.RadixSort_Click);
            // 
            // HeapSort
            // 
            this.HeapSort.Location = new System.Drawing.Point(566, 216);
            this.HeapSort.Name = "HeapSort";
            this.HeapSort.Size = new System.Drawing.Size(75, 23);
            this.HeapSort.TabIndex = 6;
            this.HeapSort.Text = "Heap";
            this.HeapSort.UseVisualStyleBackColor = true;
            this.HeapSort.UseWaitCursor = true;
            this.HeapSort.Click += new System.EventHandler(this.HeapSort_Click);
            // 
            // MergeSort
            // 
            this.MergeSort.Location = new System.Drawing.Point(485, 216);
            this.MergeSort.Name = "MergeSort";
            this.MergeSort.Size = new System.Drawing.Size(75, 23);
            this.MergeSort.TabIndex = 7;
            this.MergeSort.Text = "Merge";
            this.MergeSort.UseVisualStyleBackColor = true;
            this.MergeSort.UseWaitCursor = true;
            this.MergeSort.Click += new System.EventHandler(this.MergeSort_Click);
            // 
            // QuickSort
            // 
            this.QuickSort.Location = new System.Drawing.Point(647, 216);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(75, 23);
            this.QuickSort.TabIndex = 8;
            this.QuickSort.Text = "Quick";
            this.QuickSort.UseVisualStyleBackColor = true;
            this.QuickSort.UseWaitCursor = true;
            this.QuickSort.Click += new System.EventHandler(this.QuickSort_Click);
            // 
            // CountingSort
            // 
            this.CountingSort.Location = new System.Drawing.Point(728, 216);
            this.CountingSort.Name = "CountingSort";
            this.CountingSort.Size = new System.Drawing.Size(75, 23);
            this.CountingSort.TabIndex = 9;
            this.CountingSort.Text = "Counting";
            this.CountingSort.UseVisualStyleBackColor = true;
            this.CountingSort.UseWaitCursor = true;
            this.CountingSort.Click += new System.EventHandler(this.CountingSort_Click);
            // 
            // insertionSort
            // 
            this.insertionSort.Location = new System.Drawing.Point(404, 216);
            this.insertionSort.Name = "insertionSort";
            this.insertionSort.Size = new System.Drawing.Size(75, 23);
            this.insertionSort.TabIndex = 11;
            this.insertionSort.Text = "İnsertion";
            this.insertionSort.UseVisualStyleBackColor = true;
            this.insertionSort.UseWaitCursor = true;
            this.insertionSort.Click += new System.EventHandler(this.insertionSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sıralama algoritması seçiniz -";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sorted_num
            // 
            this.sorted_num.Location = new System.Drawing.Point(242, 279);
            this.sorted_num.Multiline = true;
            this.sorted_num.Name = "sorted_num";
            this.sorted_num.ReadOnly = true;
            this.sorted_num.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sorted_num.Size = new System.Drawing.Size(561, 131);
            this.sorted_num.TabIndex = 13;
            this.sorted_num.UseWaitCursor = true;
            this.sorted_num.TextChanged += new System.EventHandler(this.sorted_num_TextChanged);
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Time.Location = new System.Drawing.Point(242, 418);
            this.Time.Multiline = true;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Time.Size = new System.Drawing.Size(561, 127);
            this.Time.TabIndex = 14;
            this.Time.UseWaitCursor = true;
            this.Time.TextChanged += new System.EventHandler(this.Time_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(10, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sıralanmış Dizi :";
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(10, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Geçen Süre :";
            this.label6.UseWaitCursor = true;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sıralamaToolStripMenuItem
            // 
            this.sıralamaToolStripMenuItem.Name = "sıralamaToolStripMenuItem";
            this.sıralamaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // aramaToolStripMenuItem
            // 
            this.aramaToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.aramaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.aramaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aramaToolStripMenuItem.Name = "aramaToolStripMenuItem";
            this.aramaToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.aramaToolStripMenuItem.Text = "               Arama                   ";
            this.aramaToolStripMenuItem.Click += new System.EventHandler(this.aramaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aramaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(196, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "<== Arama algoritmaları için tıklayınız !!";
            this.label4.UseWaitCursor = true;
            // 
            // lbl_Exp
            // 
            this.lbl_Exp.AutoSize = true;
            this.lbl_Exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Exp.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Exp.Location = new System.Drawing.Point(245, 200);
            this.lbl_Exp.Name = "lbl_Exp";
            this.lbl_Exp.Size = new System.Drawing.Size(0, 16);
            this.lbl_Exp.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 557);
            this.Controls.Add(this.lbl_Exp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.sorted_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.insertionSort);
            this.Controls.Add(this.CountingSort);
            this.Controls.Add(this.QuickSort);
            this.Controls.Add(this.MergeSort);
            this.Controls.Add(this.HeapSort);
            this.Controls.Add(this.RadixSort);
            this.Controls.Add(this.sayi_miktari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ran_num);
            this.Controls.Add(this.BucketSort);
            this.Controls.Add(this.sayi_olustur);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Algoritma Proje";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sayi_olustur;
        private System.Windows.Forms.Button BucketSort;
        private System.Windows.Forms.TextBox ran_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sayi_miktari;
        private System.Windows.Forms.Button RadixSort;
        private System.Windows.Forms.Button HeapSort;
        private System.Windows.Forms.Button MergeSort;
        private System.Windows.Forms.Button QuickSort;
        private System.Windows.Forms.Button CountingSort;
        private System.Windows.Forms.Button insertionSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sorted_num;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem sıralamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aramaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Exp;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoProje
{
    public partial class Arama : Form
    {
        int[] arr = new int[] { };
        public Arama()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sayi_olustur_Click(object sender, EventArgs e)
        {
            txt_ran_Num.Text = "";
            Time.Text = "";
            if (!validateProgram()) return;

            var count = int.Parse(sayi_miktari.Text);
            var rnd = new Random();
            arr = new int[count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 1000);
            }
            Array.Sort(arr);
            txt_ran_Num.Text = string.Join(",", arr.Select(c => c.ToString()).ToArray());
        }

        private void txt_ran_Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void Arama_Load(object sender, EventArgs e)
        {

        }

        private void sayi_miktari_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Binary_Click(object sender, EventArgs e)
        {
            if (!validateProgram()) return;
            Stopwatch stopWatch = new Stopwatch();
            int x = int.Parse(txt_aranan.Text);
            stopWatch.Start();
            int sonuc = Search(arr, x);
            stopWatch.Stop();
            static int Search(int[] arr, int x)
            {
                int min = 0;
                int max = arr.Length - 1;

                while (min <= max)
                {
                    int mid = (min + max) / 2;
                    int z = arr[mid];
                    if (x == z)
                    {
                        return mid;
                    }
                    else if (x < z)
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
                return -1;
            }

            if (sonuc == -1)
                txt_sonuc.Text = "Aradığınız sayı dizide bulunmamaktadır!";
            else
                txt_sonuc.Text = "Aradığınız " + x + " sayısı " + sonuc + ". indexte.";

            Time.Text = arr.Length + " elemanlı dizi için geçen süre : \r\n" + "Geçen MiliSaniye: " + stopWatch.Elapsed.Milliseconds +
                "\r\nGeçen Saniye: " + stopWatch.Elapsed.Seconds + "\r\nGeçen Tick: " + stopWatch.Elapsed.Ticks + "\r\nGeçen Dakika: "
                + stopWatch.Elapsed.Minutes + "\n";

        }

        private void txt_aranan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sonuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Time_TextChanged(object sender, EventArgs e)
        {

        }

        private void Linear_Click(object sender, EventArgs e)
        {
            if (!validateProgram()) return;
            Stopwatch stopWatch = new Stopwatch();
            int x = int.Parse(txt_aranan.Text);
            stopWatch.Start();
            int sonuc = search(arr, x);
            stopWatch.Stop();
            static int search(int[] arr, int x)
            {
                int n = arr.Length;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] == x)
                        return i;
                }
                return -1;
            }

            if (sonuc == -1)
                txt_sonuc.Text = "Aradığınız sayı dizide bulunmamaktadır!";
            else
                txt_sonuc.Text = "Aradığınız " + x + " sayısı " + sonuc + ". indexte.";

            Time.Text = arr.Length + " elemanlı dizi için geçen süre : \r\n" + "Geçen MiliSaniye: " + stopWatch.Elapsed.Milliseconds +
                "\r\nGeçen Saniye: " + stopWatch.Elapsed.Seconds + "\r\nGeçen Tick: " + stopWatch.Elapsed.Ticks + "\r\nGeçen Dakika: "
                + stopWatch.Elapsed.Minutes + "\n";

        }

        private bool validateProgram()
        {
            lbl_Exp.Text = "";
            if (string.IsNullOrEmpty(sayi_miktari.Text))
                lbl_Exp.Text = "Eleman sayısı giriniz!!";
            else if (int.Parse(sayi_miktari.Text) <= 0)
                lbl_Exp.Text = "Öncelikle geçerli bir dizi eleman sayısını giriniz.";
            else if (string.IsNullOrEmpty(txt_aranan.Text))
                lbl_Exp.Text = "Aradığınız sayıyı giriniz!!";

            if (string.IsNullOrEmpty(lbl_Exp.Text))
                return true;
            else
                return false;
        }
    }
}

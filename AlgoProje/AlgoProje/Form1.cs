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
    public partial class Form1 : Form
    {
        int[] arr = new int[] {};

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ran_num_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RadixSort_Click(object sender, EventArgs e)
        {
            if (!validateProgram()) return;
            Stopwatch stopWatch = new Stopwatch();
            sorted_num.Text = "";
            stopWatch.Start();
            radixsort(arr, arr.Length);
            stopWatch.Stop();
            static int getMaxNm(int[] arr, int n)
            {
                int maxNm = arr[0];
                for (int i = 1; i < n; i++)
                    if (arr[i] > maxNm)
                        maxNm = arr[i];
                return maxNm;
            }

            static void countSort(int[] arr, int n, int exp)
            {
                int[] output = new int[n];
                int i;
                int[] count = new int[10];

                for (i = 0; i < 10; i++)
                    count[i] = 0;

                for (i = 0; i < n; i++)
                    count[(arr[i] / exp) % 10]++;

                for (i = 1; i < 10; i++)
                    count[i] += count[i - 1];

                for (i = n - 1; i >= 0; i--)
                {
                    output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                    count[(arr[i] / exp) % 10]--;
                }

                for (i = 0; i < n; i++)
                    arr[i] = output[i];
            }

            static void radixsort(int[] arr, int n)
            {

                int m = getMaxNm(arr, n);

                for (int exp = 1; m / exp > 0; exp *= 10)
                    countSort(arr, n, exp);
            }
            
            sorted_num.Text = string.Join(",", arr.Select(c => c.ToString()).ToArray());

            Time.Text =  arr.Length + " elemanlı dizi için geçen süre : \r\n" + 
                "Geçen MiliSaniye: " + stopWatch.Elapsed.Milliseconds + "\r\nGeçen Saniye: " + stopWatch.Elapsed.Seconds +
                 "\r\nGeçen Tick: " + stopWatch.Elapsed.Ticks + "\r\nGeçen Dakika: " + stopWatch.Elapsed.Minutes + "\n";



        }

        private void sayi_miktari_TextChanged(object sender, EventArgs e)
        {

        }

        private void sayi_olustur_Click(object sender, EventArgs e)
        {
            ran_num.Text = "";
            sorted_num.Text = "";
            Time.Text = "";
            if (!validateProgram()) return;

            var count = int.Parse(sayi_miktari.Text);
            var rnd = new Random();
            arr = new int[count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 1000);
            }
            ran_num.Text = string.Join(",",arr.Select(c => c.ToString()).ToArray());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BucketSort_Click(object sender, EventArgs e)
        {
            if (!validateProgram()) return;
            Stopwatch stopWatch = new Stopwatch();
            sorted_num.Text = "";
            int maxValue = arr[0];
            int minValue = arr[0];

            stopWatch.Start();
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                    maxValue = arr[i];

                if (arr[i] < minValue)
                    minValue = arr[i];
            }


            List<int>[] bucket = new List<int>[maxValue - minValue + 1];


            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }


            for (int i = 0; i < arr.Length; i++)
            {
                bucket[arr[i] - minValue].Add(arr[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        arr[k] = bucket[i][j];
                        k++;
                    }
                }
            }
            stopWatch.Stop();
            sorted_num.Text = string.Join(",", arr.Select(c => c.ToString()).ToArray());
            Time.Text = arr.Length + " elemanlı dizi için geçen süre : \r\n" + "Geçen MiliSaniye: " + stopWatch.Elapsed.Milliseconds + 
                "\r\nGeçen Saniye: " + stopWatch.Elapsed.Seconds + "\r\nGeçen Tick: " + stopWatch.Elapsed.Ticks + "\r\nGeçen Dakika: " 
                + stopWatch.Elapsed.Minutes + "\n";
        }

        private void insertionSort_Click(object sender, EventArgs e)
        {
            if (!validateProgram()) return;
            Stopwatch stopWatch = new Stopwatch();
            sorted_num.Text = "";
            stopWatch.Start();
            for (int i = 1; i < arr.Length; i++)
            {
                int x = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > x)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = x;
            }
            stopWatch.Stop();
            sorted_num.Text = string.Join(",", arr.Select(c => c.ToString()).ToArray());
            Time.Text = arr.Length + " elemanlı dizi için geçen süre : \r\n" + "Geçen MiliSaniye: " + stopWatch.Elapsed.Milliseconds +
                "\r\nGeçen Saniye: " + stopWatch.Elapsed.Seconds + "\r\nGeçen Tick: " + stopWatch.Elapsed.Ticks + "\r\nGeçen Dakika: "
                + stopWatch.Elapsed.Minutes + "\n";

        }

        private void HeapSort_Click(object sender, EventArgs e)
        {
            if (!validateProgram()) return;
            Stopwatch stopWatch = new Stopwatch();
            sorted_num.Text = "";
            stopWatch.Start();
            heapSort(arr);
            stopWatch.Stop();
            static void heapSort<T>(T[] arr) where T : IComparable<T>
            {
                int heapSize = arr.Length;

                buildMaxHeap(arr);

                for (int i = heapSize - 1; i >= 1; i--)
                {
                    swap(arr, i, 0);
                    heapSize--;
                    sink(arr, heapSize, 0);
                }
            }

            static void buildMaxHeap<T>(T[] arr) where T : IComparable<T>
            {
                int heapSize = arr.Length;

                for (int i = (heapSize / 2) - 1; i >= 0; i--)
                {
                    sink(arr, heapSize, i);
                }
            }

            static void sink<T>(T[] arr, int heapSize, int toSinkPos) where T : IComparable<T>
            {
                if (getLeftKidPos(toSinkPos) >= heapSize)
                {
                    return;
                }


                int largestKidPos;
                bool leftIsLargest;

                if (getRightKidPos(toSinkPos) >= heapSize || arr[getRightKidPos(toSinkPos)].CompareTo(arr[getLeftKidPos(toSinkPos)]) < 0)
                {
                    largestKidPos = getLeftKidPos(toSinkPos);
                    leftIsLargest = true;
                }
                else
                {
                    largestKidPos = getRightKidPos(toSinkPos);
                    leftIsLargest = false;
                }



                if (arr[largestKidPos].CompareTo(arr[toSinkPos]) > 0)
                {
                    swap(arr, toSinkPos, largestKidPos);

                    if (leftIsLargest)
                    {
                        sink(arr, heapSize, getLeftKidPos(toSinkPos));

                    }
                    else
                    {
                        sink(arr, heapSize, getRightKidPos(toSinkPos));
                    }
                }

            }

            static void swap<T>(T[] arr, int pos0, int pos1)
            {
                T tmpVal = arr[pos0];
                arr[pos0] = arr[pos1];
                arr[pos1] = tmpVal;
            }

            static int getLeftKidPos(int parentPos)
            {
                return (2 * (parentPos + 1)) - 1;
            }

            static int getRightKidPos(int parentPos)
            {
                return 2 * (parentPos + 1);
            }
            
            sorted_num.Text = string.Join(",", arr.Select(c => c.ToString()).ToArray());
            Time.Text = arr.Length + " elemanlı dizi için geçen süre : \r\n" + "Geçen MiliSaniye: " + stopWatch.Elapsed.Milliseconds +
                "\r\nGeçen Saniye: " + stopWatch.Elapsed.Seconds + "\r\nGeçen Tick: " + stopWatch.Elapsed.Ticks + "\r\nGeçen Dakika: "
                + stopWatch.Elapsed.Minutes + "\n";
        }

        private void MergeSort_Click(object sender, EventArgs e)
        {
            if (!validateProgram()) return;
            Stopwatch stopWatch = new Stopwatch();
            sorted_num.Text = "";
            stopWatch.Start();
            sort(arr, 0, arr.Length - 1);
            stopWatch.Stop();
            void sort(int[] arr, int Left, int Right)
            {
                if (Left < Right)
                {

                    int Med = (Left + Right) / 2;

                    sort(arr, Left, Med);
                    sort(arr, Med + 1, Right);

                    mergeSort(arr, Left, Med, Right);
                }
            }
            void mergeSort(int[] arr, int Left, int Med, int Right)
            {
                int n1 = Med - Left + 1;
                int n2 = Right - Med;

                int[] leftArr = new int[n1];
                int[] rightArr = new int[n2];
                int i, j;

                for (i = 0; i < n1; ++i)
                    leftArr[i] = arr[Left + i];
                for (j = 0; j < n2; ++j)
                    rightArr[j] = arr[Med + 1 + j];

                i = 0;
                j = 0;

                int k = Left;
                while (i < n1 && j < n2)
                {
                    if (leftArr[i] <= rightArr[j])
                    {
                        arr[k] = leftArr[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = rightArr[j];
                        j++;
                    }
                    k++;
                }

                while (i < n1)
                {
                    arr[k] = leftArr[i];
                    i++;
                    k++;
                }

                while (j < n2)
                {
                    arr[k] = rightArr[j];
                    j++;
                    k++;
                }
            }
            
            sorted_num.Text = string.Join(",", arr.Select(c => c.ToString()).ToArray());
            Time.Text = arr.Length + " elemanlı dizi için geçen süre : \r\n" + "Geçen MiliSaniye: " + stopWatch.Elapsed.Milliseconds +
                "\r\nGeçen Saniye: " + stopWatch.Elapsed.Seconds + "\r\nGeçen Tick: " + stopWatch.Elapsed.Ticks + "\r\nGeçen Dakika: "
                + stopWatch.Elapsed.Minutes + "\n";

        }

        private void CountingSort_Click(object sender, EventArgs e)
        {
            if (!validateProgram()) return;
            Stopwatch stopWatch = new Stopwatch();
            sorted_num.Text = "";
            stopWatch.Start();
            countingsort(arr);
            static void countingsort(int[] arr)
            {
                int n = arr.Length;

                int[] output = new int[n];

                int minVal = arr[0];
                int maxVal = arr[0];

                for (int i = 1; i < n; i++)
                {
                    if (arr[i] < minVal) minVal = arr[i];
                    else if (arr[i] > maxVal) maxVal = arr[i];
                }
                int[] counts = new int[maxVal - minVal + 1];

                for (int i = 0; i < n; i++)
                {
                    counts[arr[i] - minVal]++;
                }

                counts[0]--;
                for (int i = 1; i < counts.Length; i++)
                {
                    counts[i] = counts[i] + counts[i - 1];
                }

                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    output[counts[arr[i] - minVal]--] = arr[i];
                }
                Array.Copy(output, arr,n);
            }

            stopWatch.Stop();
            sorted_num.Text = string.Join(",", arr.Select(c => c.ToString()).ToArray());
            Time.Text = arr.Length + " elemanlı dizi için geçen süre : \r\n" + "Geçen MiliSaniye: " + stopWatch.Elapsed.Milliseconds +
                "\r\nGeçen Saniye: " + stopWatch.Elapsed.Seconds + "\r\nGeçen Tick: " + stopWatch.Elapsed.Ticks + "\r\nGeçen Dakika: "
                + stopWatch.Elapsed.Minutes + "\n";
        }

        private void QuickSort_Click(object sender, EventArgs e)
        {
            if (!validateProgram()) return;
            Stopwatch stopWatch = new Stopwatch();
            sorted_num.Text = "";
            stopWatch.Start();
            Quick_Sort(arr, 0, arr.Length - 1);
            stopWatch.Stop();
            static void Quick_Sort(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    int pivot = Partition(arr, left, right);

                    if (pivot > 1)
                    {
                        Quick_Sort(arr, left, pivot - 1);
                    }
                    if (pivot + 1 < right)
                    {
                        Quick_Sort(arr, pivot + 1, right);
                    }
                }

            }

            static int Partition(int[] arr, int left, int right)
            {
                int pivot = arr[left];
                while (true)
                {

                    while (arr[left] < pivot)
                    {
                        left++;
                    }

                    while (arr[right] > pivot)
                    {
                        right--;
                    }

                    if (left < right)
                    {
                        if (arr[left] == arr[right]) return right;

                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;


                    }
                    else
                    {
                        return right;
                    }
                }
            }
            
            sorted_num.Text = string.Join(",", arr.Select(c => c.ToString()).ToArray());
            Time.Text = arr.Length + " elemanlı dizi için geçen süre : \r\n" + "Geçen MiliSaniye: " + stopWatch.Elapsed.Milliseconds +
                "\r\nGeçen Saniye: " + stopWatch.Elapsed.Seconds + "\r\nGeçen Tick: " + stopWatch.Elapsed.Ticks + "\r\nGeçen Dakika: "
                + stopWatch.Elapsed.Minutes + "\n";
        }

        private void sorted_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void Time_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void aramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arama arama = new Arama();
            arama.Show();
        }
        private bool validateProgram()
        {
            lbl_Exp.Text = "";
            if (string.IsNullOrEmpty(sayi_miktari.Text)) lbl_Exp.Text = "Eleman sayısı giriniz!!";

            else if(int.Parse(sayi_miktari.Text) <= 0) 
                lbl_Exp.Text = "Öncelikle geçerli bir dizi eleman sayısını giriniz.";

            if (string.IsNullOrEmpty(lbl_Exp.Text))
                return true;
            else
                return false;
        }
    }
}

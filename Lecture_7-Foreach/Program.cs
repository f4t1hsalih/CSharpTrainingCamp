using System;
using System.Collections.Generic;

namespace Lecture_7_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach

            //Foreach (1;2;3;4)

            //1: Değişken türü
            //2: Değişken adı
            //3: İn
            //4: Dizi, Liste, Koleksiyon

            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Adana" };
            //foreach (var item in cities)
            //{
            //    Console.WriteLine(item);
            //}
            //--

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //--

            //int[] numbers = { 1, 232, 4453, 6754, 4645, 6758, 7743, 8235, 739, 1470 };
            //foreach (var item in numbers)
            //{
            //    if (item % 2 == 0)
            //    {
            //        Console.WriteLine(numbers);
            //    }
            //}
            //--

            //int[] numbers = { 351, 232, 4453, 6754, 4645, 6758, 7743, 8235, 739, 1470 };
            //int total = 0;
            //foreach (var item in numbers)
            //{
            //    total += item;
            //}
            //Console.WriteLine(total);
            //--

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////Burada console.writeline içerisinde numbers yazdığımızda, numbers listesinin adresini gösterir.
            //Console.WriteLine(numbers);
            ////Burada ise numbers listesinin içerisindeki elemanları yazdırır.
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //--

            //string word = "Merhaba";
            //foreach (var item in word)
            //{
            //    Console.WriteLine(item);
            //}
            //--

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfta Kaç Öğrenci Var: ");
            //int studentCount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////Öğrenci isimlerini ve notlarını tutacak dizileri oluşturma
            //string[] students = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write("Öğrenci Adı: ");
            //    students[i] = Console.ReadLine();
                
            //    double totalExamResult = 0;

            //    //Öğrencinin 3 sınav notunu alma
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.Write($"{students[i]} adlı öğrencinin {j}. sınav notunu giriniz: ");
            //        double examResult = Convert.ToDouble(Console.ReadLine());
            //        totalExamResult += examResult;
            //    }

            //    studentExamAvg[i] = totalExamResult / 3;

            //    Console.WriteLine();
            //}

            ////Öğrenci isimleri ve sınav ortalamalarını ekrana yazdırma
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("*****************************************");

            //    Console.WriteLine($"{students[i]} adlı öğrencinin sınav ortalaması: {studentExamAvg[i]}");

            //    //Öğrencinin sınav ortalamasına göre durumunu kontrol etme
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{students[i]} isimli öğrenci dersi Geçti");
            //    }
            //    else if (studentExamAvg[i]<50)
            //    {
            //        Console.WriteLine($"{students[i]} isimli öğrenci dersten Kaldı");
            //    }

            //    Console.WriteLine("*****************************************");

            //}


            #endregion

        }
    }
}

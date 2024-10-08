using System;
using System.Collections.Generic;

namespace Lecture_4_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //For(x;y;z)
            //x = başlangıç değeri
            //y = bitiş değeri
            //z = artış-azalış değeri

            //int i;
            //for (i = 1; i <= 5; ++i)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}
            //--

            //for (int i = 1; i <= 20 ; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //--

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}
            //--

            //Console.Write("Lütfen Ekrana Yazılmasını İstediğiniz Adeti Giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("{0}. Selam Sana ...", i);
            //}
            //--

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //--

            ////1'den 10'a kadar olan sayıların toplamını verir
            //int totalValue = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);
            //--

            ////1'den 20'ye kadar olan sayılar arasında 2'ye tam bölünenleri verir
            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-----------");
            //Console.WriteLine(totalValue);
            //--

            //1'den 60'a kadar olan sayılar arasında 7'ye bölünebilen kaç sayı var
            //int count = 0;
            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            //--

            //Her saat 2'ye katlanan bakteri 24 saatte kaç tane olur
            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat sonunda: " + bacterium + " bakteri bulunur.");
            //}
            //--

            #endregion

            #region While Döngüsü

            //Şart sağlandığı sürece işlemler yapılır
            //while (şart)
            //{
            //    işlemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //--

            //int i = 1;
            //int sum = 0;
            //while (i<=10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            //--

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 baasamaklı sayının basamakları toplamını hesaplayan kodu yazınız
            int flag = 0;
            while (flag == 0)
            {
                Console.Write("Sayıyı Giriniz: ");
                int number = int.Parse(Console.ReadLine());
                if (number >= 100 & number <= 999)
                {
                    int ones, tens, hundreds, sum;

                    ones = number % 10;
                    tens = (number % 100) / 10;
                    hundreds = number / 100;

                    sum = ones + tens + hundreds;

                    Console.WriteLine("------------------");
                    Console.WriteLine("Birler Basamağı: " + ones);
                    Console.WriteLine("Onlar Basamağı: " + tens);
                    Console.WriteLine("Yüzler Basamağı: " + hundreds);
                    Console.WriteLine("------------------");
                    Console.WriteLine("Basamaklar Toplamı: " + sum);
                    flag = 1;
                }
                else
                {
                    Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz!!!");
                    Console.WriteLine("***************************");
                    Console.WriteLine();
                }
            }
            #endregion

            Console.ReadKey();

        }
    }
}

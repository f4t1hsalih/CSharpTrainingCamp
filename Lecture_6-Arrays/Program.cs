using System;

namespace Lecture_6_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //2-4-6-8
            //sarı-mavi-kırmızı-yeşil
            //adana-ankara-istanbul-bursa
            //değişkenTürü [] diziAdı = new değişkenTürü[elemanSayısı];

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);
            //--

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Roma";
            //cities[3] = "Napoli";
            //cities[4] = "Torino";
            //Console.WriteLine(cities[2]); //Dizinin içinde olan fakat değer atanmayan string dizi öğesine otomatik null atanır.

            //int [] numbers = new int[10];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;
            //numbers[7] = 50;
            //Console.WriteLine(numbers[5]); //Dizinin içinde olan fakat değer atanmayan integer dizi öğesine otomatik 0 atanır.
            //--

            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Adana", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Mavi", "Kırmızı", "Yeşil", "Beyaz", "Turuncu", "Siyah" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine("Dizideki "+numbers[i]+" sayısı 3'e tam bölünür.");
            //    }
            //}

            //char[] symbols = {'a','b', 'c', '*', '/', '-'};
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100};
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region Dizi Metodları

            //Dizi Uzunluğunu Verir
            //string[] persons = { "Ali", "Veli", "Ayşe", "Fatma", "Mehmet", "Zeynep", "Kemal", "Hüseyin" };
            //Console.WriteLine("Dizideki kişi sayısı: " + persons.Length);

            //Küçükten Büyüğe Sıralar
            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Tersten Sıralar
            //int[] numbers2 = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //Array.Reverse(numbers2);
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}

            //Dizinin Belirli Bir Kısmını Kopyalar
            //int[] numbers3 = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //int[] numbers4 = new int[5];
            //Array.Copy(numbers3, numbers4, 5);
            //for (int i = 0; i < numbers4.Length; i++)
            //{
            //    Console.WriteLine(numbers4[i]);
            //}

            //Dizinin Belirli Bir Kısmını Siler
            //int[] numbers5 = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //Array.Clear(numbers5, 3, 5);
            //for (int i = 0; i < numbers5.Length; i++)
            //{
            //    Console.WriteLine(numbers5[i]);
            //}

            //Dizi içinde aranan değerin Index numarasını verir
            //string[] customers = { "Ali", "Veli", "Ayşe", "Fatma", "Mehmet", "Zeynep", "Kemal", "Hüseyin" };
            //int index = Array.IndexOf(customers, "Zeynep");
            //Console.WriteLine("Zeynep isimli kişi dizinin " + index + ". index numarasında yer almaktadır.");

            //Dizi İçindeki En Büyük ve En Küçük Değerleri Verir
            //int[] numbers6 = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //Console.WriteLine("Dizinin En Büyük Değeri: " + numbers6.Max() + "\nDizinin En Küçük Değeri: " + numbers6.Min());

            //Dizi İçindeki Elemanların Toplamını Verir
            //int[] numbers7 = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //Console.WriteLine("Dizinin Toplamı: " + numbers7.Sum());

            #endregion

            #region

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 0 };
            //Console.WriteLine("Çift Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------");
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

        }
    }
}

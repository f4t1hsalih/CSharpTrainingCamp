using System;

namespace Lecture_02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ₺ işaretinin consolda gözükmesi için consolun kodlamasını utf8 olarak ayarladım
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            #region Double

            ////Double noktalı sayı tutmak için kullanılır
            ////Kullanımı: double değişken_adı = tam_sayı.ondalık_kısım ;
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            ////--

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine("---- Elma Fiyatı: " + applePrice + " ₺");
            //Console.WriteLine("---- Portakal Fiyatı: " + orangePrice + " ₺");
            //Console.WriteLine("---- Çilek Fiyatı: " + strawberryPrice + " ₺");
            //Console.WriteLine("---- Patates Fiyatı: " + patatoPrice + " ₺");
            //Console.WriteLine("---- Domates Fiyatı: " + tomatoPrice + " ₺");
            //Console.WriteLine("*************************");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawGram, patatoGram, tomatoGram, totalPrice;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //patatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawTotalPrice = strawberryPrice * strawGram;
            //double patatoTotalPrice = patatoPrice * patatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;
            //totalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + patatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("----- Kasa Tutarı -----");
            //Console.WriteLine("Elmanın Toplam Fiyatı: " + appleTotalPrice + " ₺");
            //Console.WriteLine("Portakalın Toplam Fiyatı: " + orangeTotalPrice + " ₺");
            //Console.WriteLine("Çileğin Toplam Fiyatı: " + strawTotalPrice + " ₺");
            //Console.WriteLine("Patatesin Toplam Fiyatı: " + patatoTotalPrice + " ₺");
            //Console.WriteLine("Domatesin Toplam Fiyatı: " + tomatoTotalPrice + " ₺");
            //Console.WriteLine("Toplam Tutar: " + totalPrice + " ₺");
            //Console.WriteLine("------------------------");
            //Console.WriteLine();


            #endregion

            #region Char

            ////char değişken tek karekter tutar
            ////char tanımlanırken tek tırnak ile tanılanır ('') şeklinde
            //char symb = 'A';
            //Console.WriteLine(symb);

            #endregion

            #region Klavyeden Veri Girişleri (string değişkenlerle)

            //Console.WriteLine("***** CSharp Havayolları *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerId, passengerAge, passengerDistrict, passengerCity;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("İl Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("TC Kimlik Numarası: ");
            //passengerId = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----- Yolcu Bilgileri -----");
            //Console.WriteLine("Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + "\nAdres: " + passengerDistrict + " / " + passengerCity + "\nTC Kimlik Numarası: " + passengerId + "\nYaş: " + passengerAge);


            #endregion

            #region Klavyeden Veri Girişleri(tam sayı girişi ve dönüşümler)

            ////Klavyeden sayı girdiğimizde sistem bunu karekter olarak algılar bu sebeptendir ki eğer kullanıcıdan sayı alacaksak bu aldığımız değeri sayıya çevirmemiz gerekir.
            //int shoePrice, compPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //compPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, compCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //compCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Aldığınız Ürünlerin Toplam Tutarı: " + (shoeCount * shoePrice + compCount * compPrice + chairCount * chairPrice + tvCount * tvPrice) + " ₺");

            #endregion

            #region Klavyeden Veri Girişleri(ondalıklı sayı girişi ve dönüşümler)

            //double exam1, exam2, exam3, avarage;

            //Console.Write("Sınav1: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = double.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Not Ortalamanız: " + avarage);

            #endregion

            #region Klavyeden Veri Girişleri(char karakter girişi ve dönüşümler)

            //char gender;

            //Console.Write("Cinsiyet Seçiniz(E/K): ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine();
            //if (gender == 'E' || gender == 'e') Console.WriteLine("Seçtiğiniz Cinsiyet: Erkek");
            //else if (gender == 'K' || gender == 'k') Console.WriteLine("Seçtiğiniz Cinsiyet: Kadın");
                
            #endregion

        }
    }
}

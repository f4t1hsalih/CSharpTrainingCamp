using System;

namespace Lecture_8_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metodlar, kodun tekrar tekrar kullanılmasını sağlar.
            //Metodlar, kodun daha okunabilir ve daha düzenli olmasını sağlar.
            //erişim_belirleyici geri_dönüş_tipi metod_adı(parametre_listesi)
            //Geri dönüş tipi void olan metodlar geriye değer döndürmez.
            //Metodlar, kodun tekrar tekrar kullanılmasını sağlar.

            #region Void Metodlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Mehmet Yıldız");
            //    Console.WriteLine("Fatma Yıldız");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int number1 = 10;
            //    int number2 = 20;
            //    int result = number1 + number2;
            //    Console.WriteLine("Toplam: " + result);
            //}
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metodlar

            //void CustomerName(string name)
            //{
            //    Console.WriteLine("Müşteri Adı: " + name);
            //}
            //CustomerName("Ali Yıldız");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri Adı: " + name + " " + surname);
            //}
            //CustomerCard("Ali", "Yıldız");
            //CustomerCard("Ayşe", "Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metodlar

            //void Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    Console.WriteLine("Toplam: " + result);
            //}
            //Sum(10, 20);

            #endregion

            #region Geriye Değer Döndüren Metodlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //Console.WriteLine(CustomerName());

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metodlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke Adı: " + countryName + " Başkent: " + capital + " Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //Console.Write("Ülke Adını Giriniz: ");
            //string countryNamee = Console.ReadLine();
            //Console.Write("Başkentini Giriniz: ");
            //string capitall = Console.ReadLine();
            //Console.Write("Bayrak Rengini Giriniz: ");
            //string flagColorr = Console.ReadLine();

            //Console.WriteLine(CountryCard(countryNamee, capitall, flagColorr));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metodlar

            //int sum(int number1, int number2)
            //{
            //    return number1 + number2;
            //}
            //Console.WriteLine(sum(10, 20));
            //Console.WriteLine(sum(36, 25));

            #endregion

            #region Örnek Uygulama

            //string examResult(string student, double exam1, double exam2, double exam3)
            //{
            //    double avarage = (exam1 + exam2 + exam3) / 3;
            //    if (avarage >= 50)
            //    {
            //        return student + "İsimli Öğrenci Sınavı Geçti :D - Ortalama: " + avarage;
            //    }
            //    else
            //    {
            //        return student + "İsimli Öğrenci Sınavı Geçemedi :C - Ortalama: " + avarage;
            //    }
            //}

            //Console.WriteLine(examResult("Ali", 25, 41, 65));
            //Console.WriteLine(examResult("Ayşe", 75, 85, 95));

            #endregion

        }
    }
}

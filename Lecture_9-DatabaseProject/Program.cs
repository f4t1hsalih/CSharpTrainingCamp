using System;
using System.Data;
using System.Data.SqlClient;

namespace Lecture_09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ado.Net

            //Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("---------------------------------------------------------");
            //Console.WriteLine("1-Kategoriler");
            //Console.WriteLine("2-Ürünler");
            //Console.WriteLine("3-Siparişler");
            //Console.WriteLine("4-Çıkış");
            //Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            //string tableNumber = Console.ReadLine();
            //Console.WriteLine("---------------------------------------------------------");

            //// SQL bağlantısı
            //SqlConnection connection = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = C#CampByMuratYucedag; Integrated Security = True");

            //try
            //{
            //    connection.Open();

            //    // Komut ve sorguyu hazırlıyoruz
            //    SqlCommand command = null;

            //    // Kullanıcının girdiği tablo numarasına göre sorgular
            //    if (tableNumber == "1")
            //    {
            //        command = new SqlCommand("Select * from Categories", connection);
            //        Console.WriteLine("Kategoriler Tablosu:");
            //    }
            //    else if (tableNumber == "2")
            //    {
            //        command = new SqlCommand("Select * from Products", connection);
            //        Console.WriteLine("Ürünler Tablosu:");
            //    }
            //    else if (tableNumber == "3")
            //    {
            //        command = new SqlCommand("Select * from Orders", connection);
            //        Console.WriteLine("Siparişler Tablosu:");
            //    }
            //    else if (tableNumber == "4")
            //    {
            //        Console.WriteLine("Programdan çıkılıyor...");
            //        return;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Geçersiz bir seçim yaptınız.");
            //        return;
            //    }

            //    // Veri çekme ve tabloyu doldurma
            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //    DataTable dataTable = new DataTable();
            //    dataAdapter.Fill(dataTable);

            //    // Verileri ekrana yazdırma
            //    foreach (DataRow dataRow in dataTable.Rows)
            //    {
            //        foreach (var item in dataRow.ItemArray)
            //        {
            //            Console.Write(item + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Bir hata oluştu: " + ex.Message);
            //}
            //finally
            //{
            //    // Bağlantıyı kapatıyoruz
            //    connection.Close();
            //}

            //Console.WriteLine("---------------------------------------------------------");

            #endregion

        }
    }
}

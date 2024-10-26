using System;
using System.Data;
using System.Data.SqlClient;

namespace Lecture_10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CRUD

            //CRUD -->Create, Read, Update, Delete

            //Console.WriteLine("***** Menü Sipariş İşlemi Paneli *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori: ");

            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = C#CampByMuratYucedag; Integrated Security = True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Insert into Categories(Name) values(@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //Console.WriteLine("Kategori Başarıyla Eklendi");

            //connection.Close();
            #endregion

            #region Ürün Ekleme İşlemi

            //Console.Write("Eklemek İstediğiniz Ürün Adı: ");
            //string name = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //decimal price = Convert.ToDecimal(Console.ReadLine());

            //SqlConnection sqlConnection = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = C#CampByMuratYucedag; Integrated Security = True;");
            //sqlConnection.Open();

            //SqlCommand command = new SqlCommand("Insert into Products values (@productName, @productPrice, @productStatus)", sqlConnection);
            //command.Parameters.AddWithValue("@productName", name);
            //command.Parameters.AddWithValue("@productPrice", price);
            //command.Parameters.AddWithValue("@productStatus", 1);
            //command.ExecuteNonQuery();

            //Console.WriteLine("Ürün Başarıyla Eklendi");

            //sqlConnection.Close();

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = C#CampByMuratYucedag; Integrated Security = True;");
            //connection.Open();

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Products", connection);
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    Console.WriteLine($"{row["Id"]} {row["Name"]}, Fiyat: {row["Price"]}, Durum: {row["Status"]}");
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = C#CampByMuratYucedag; Integrated Security = True;");
            //connection.Open();

            //Console.Write("Hangi Ürünü Silmek İstersin(ID No): ");
            //int id = Convert.ToInt32(Console.ReadLine());

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Delete from Products where Id = @id", connection);
            //sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@id", id);
            //sqlDataAdapter.SelectCommand.ExecuteNonQuery();

            //Console.WriteLine("Ürün Başarıyla Silindi");

            //connection.Close();

            #endregion

            #region Ürün Güncelleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = C#CampByMuratYucedag; Integrated Security = True;");
            //connection.Open();

            //Console.Write("Hangi Ürünü Güncellemek İstersin(ID No): ");
            //int id = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Yeni Ürün Adı: ");
            //string name = Console.ReadLine();

            //Console.Write("Yeni Ürün Fiyatı: ");
            //decimal price = Convert.ToDecimal(Console.ReadLine());

            //SqlCommand command = new SqlCommand("Update Products set Name = @name, Price = @price where Id = @id", connection);
            //command.Parameters.AddWithValue("@name", name);
            //command.Parameters.AddWithValue("@price", price);
            //command.Parameters.AddWithValue("@id", id);
            //command.ExecuteNonQuery();

            //Console.WriteLine("Ürün Başarıyla Güncellendi");

            //connection.Close();

            #endregion

            #endregion

        }
    }
}

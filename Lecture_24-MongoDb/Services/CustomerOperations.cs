using Lecture_24_MongoDb.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Lecture_24_MongoDb.Services
{
    public class CustomerOperations
    {
        public void InsertCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomerCollection();

            var document = new BsonDocument
            {
                { "Name", customer.Name },
                { "Surname", customer.Surname },
                { "City", customer.City },
                { "Balance", customer.Balance },
                { "ShoppingCount", customer.ShoppingCount }
            };
            customerCollection.InsertOne(document);
        }

        public List<Customer> GetCustomerList()
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomerCollection();
            var costumerList = customerCollection.Find(new BsonDocument()).ToList();
            var customerList = new List<Customer>();
            foreach (var item in costumerList)
            {
                var customer = new Customer
                {
                    CustomerId = item["_id"].ToString(),
                    Name = item["Name"].ToString(),
                    Surname = item["Surname"].ToString(),
                    City = item["City"].ToString(),
                    Balance = decimal.Parse(item["Balance"].ToString()),
                    ShoppingCount = int.Parse(item["ShoppingCount"].ToString())
                };
                customerList.Add(customer);
            }
            return customerList;
            //return customerCollection.Find(new BsonDocument()).ToList().ConvertAll(x => new Customer
            //{
            //    CustomerId = x.GetValue("CustomerId").AsString,
            //    Name = x.GetValue("Name").AsString,
            //    Surname = x.GetValue("Surname").AsString,
            //    City = x.GetValue("City").AsString,
            //    Balance = x.GetValue("Balance").AsDecimal,
            //    ShoppingCount = x.GetValue("ShoppingCount").AsInt32
            //});
        }

        public void DeleteCustomer(string id)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomerCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            customerCollection.DeleteOne(filter);
        }

        public void UpdateCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomerCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));
            var update = Builders<BsonDocument>.Update
                .Set("Name", customer.Name)
                .Set("Surname", customer.Surname)
                .Set("City", customer.City)
                .Set("Balance", customer.Balance)
                .Set("ShoppingCount", customer.ShoppingCount);
            customerCollection.UpdateOne(filter, update);

        }

        public Customer GetCustomerById(string id)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomerCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var customer = customerCollection.Find(filter).FirstOrDefault();
            return new Customer
            {
                CustomerId = customer["_id"].ToString(),
                Name = customer["Name"].ToString(),
                Surname = customer["Surname"].ToString(),
                City = customer["City"].ToString(),
                Balance = decimal.Parse(customer["Balance"].ToString()),
                ShoppingCount = int.Parse(customer["ShoppingCount"].ToString())
            };
        }
    }
}

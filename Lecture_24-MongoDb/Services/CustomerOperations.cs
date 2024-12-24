using Lecture_24_MongoDb.Entities;
using MongoDB.Bson;

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
    }
}

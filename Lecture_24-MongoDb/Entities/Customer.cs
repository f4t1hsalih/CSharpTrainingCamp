using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Lecture_24_MongoDb.Entities
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public decimal Balance { get; set; }
        public int ShoppingCount { get; set; }

    }
}

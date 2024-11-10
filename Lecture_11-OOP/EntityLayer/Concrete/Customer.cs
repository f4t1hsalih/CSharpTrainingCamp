using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public bool Status { get; set; }
        public List<Order> Order { get; set; }
    }
}

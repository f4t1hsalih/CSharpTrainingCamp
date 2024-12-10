using EntityLayer.Concrete;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public List<Order> Order { get; set; }

    }
}

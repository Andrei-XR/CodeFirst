using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstPostgreSql.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

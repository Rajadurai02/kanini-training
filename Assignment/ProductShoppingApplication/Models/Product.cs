using System;


namespace ProductShoppingApplication.Models
{
    public class Product
    {
        //primary key for products table 
        public int ProductId { get; set; }
        //other entities
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}

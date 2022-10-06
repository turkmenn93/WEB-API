using System;

namespace Udemy.ConsumeAPIApp.RepsonseModels
{
    public class ProductResponseModel
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public string ImagePath { get; set; }
        public int? categoryId { get; set; }
    }
}

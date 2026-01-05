namespace SignalR.EntityLayer.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool ProductStatus { get; set; }

        //one to many relation with category table
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        //one to many relation with orderdetail table
        public List<OrderDetail> OrderDetails { get; set; }

        //one to many relation with basket table
        public List<Basket> Baskets { get; set; }
    }
}

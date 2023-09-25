namespace TestProject1.TestSale
{
    public class SaleServiceClas
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int PurchaserId { get; set; } 
        public int StoreId { get; set; }
        //public Store Store { get; set; }
        //Relationship
        //public IList<Product> Products { get; set; } = new List<Product>();
    }
}
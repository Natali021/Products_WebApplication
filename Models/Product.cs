namespace Products_WebApplication.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }        
        public string Producer { get; set; }
        public DateTime DateProducer { get; set; }
        public string Сategory { get; set; }
        public Product(int productId, string name, int price,  string producer, DateTime dateProducer, string category)
        {
            this.ProductId = productId;
            this.Name = name;
            this.Price = price;            
            this.Producer = producer;
            this.DateProducer = dateProducer;
            this.Сategory = category;
        }

    }
}

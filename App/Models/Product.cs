namespace WebApplicationRazor.Models
{
    public class Product
    {
        int id { get; set; }
        string name { get; set; }
        string description { get; set; }
        int price { get; set; }

        public Product(string name, int price, string description)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}

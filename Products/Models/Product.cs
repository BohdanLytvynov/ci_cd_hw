namespace Products.Models
{
    public class Product_Compare_By_Price : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            return y.Price.Value.CompareTo(x.Price.Value); 
        }
    }

    public class Product_Compare_By_Name : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public class Product : IEquatable<Product>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }

        public Product()
        {

        }

        public Product(int id, string? name, decimal? price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public bool Equals(Product? other)
        {
            return Id == other.Id && Name == other.Name && Price == other.Price;
        }
    }
}

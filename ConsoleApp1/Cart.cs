namespace ConsoleApp1
{
    internal class Cart
    {
        private List<Product> products;

        public Cart()
        {
            products = new List<Product>();
        }

        public void AddToCart(Product product)
        {
            products.Add(product);
        }
    }
}

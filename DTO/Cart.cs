namespace ConsoleApp1
{
    /// <summary>
    /// The cart.
    /// </summary>
    public class Cart
    {
        private List<Product> products;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cart"/> class.
        /// </summary>
        public Cart()
        {
            products = new List<Product>();
        }

        public List<Product> Products { get { return products; } }

        /// <summary>
        /// Adds a to cart.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        public void AddToCart(Product product)
        {
            products.Add(product);
        }
    }
}

namespace ConsoleApp1
{
    /// <summary>
    /// The price.
    /// </summary>
    internal class Price
    {
        /// <summary>
        /// Calculate.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns>A double.</returns>
        public double calculate(Cart cart)
        {
            FactoryPricingStrategy factory = new FactoryPricingStrategy();

            double totalPrice = 0;

            foreach (var product in cart.Products)
            {
                // Checks the Weight and Age of the product and returns the Appropriate class type
                IPricingStrategy pricingStrategy = (product.Weight >= 10) ?
                    (product.Age > 5 ? factory.GetHeavyWeightStrategy() : factory.GetHeavyWeightStrategyDiscount()) :
                    (product.Age > 5 ? factory.GetLightWeightStrategy() : factory.GetLightWeightStrategyDiscount());

                product.Price = pricingStrategy.CalculateCost(product);
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}

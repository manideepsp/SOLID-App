namespace ConsoleApp1
{
    internal class Price
    {
        public double calculate(Product product)
        {
            IPricingStrategy pricingStrategy;
            pricingStrategy = (product.Weight >= 10) ?
                (product.Age > 5 ? new HeavyWeightStrategy() : new HeavyWeightStrategyDiscount()) :
                (product.Age > 5 ? new LightWeightStrategy() : new LightWeightStrategyDiscount());
            product.Price = pricingStrategy.CalculateCost(product);

            return product.Price;
        }
    }
}

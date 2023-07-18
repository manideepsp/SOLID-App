namespace ConsoleApp1
{
    public class LightWeightStrategyDiscount : IPricingStrategy, IDiscountStrategy
    {
        public double CalculateCost(Product product)
        {
            product.Price = (10 - ApplyDiscount());
            return product.Price;
        }
        public int ApplyDiscount()
        {
            return 5;
        }
    }
}

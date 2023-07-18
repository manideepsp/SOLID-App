namespace ConsoleApp1
{
    public class HeavyWeightStrategyDiscount : IPricingStrategy, IDiscountStrategy
    { 
        public double CalculateCost(Product product)
        {
           product.Price = (15 - ApplyDiscount());
            return product.Price;
        }
        public int ApplyDiscount()
        {
            return 10;
        }
    }
}

namespace ConsoleApp1
{
    public class HeavyWeightStrategy : IPricingStrategy
    {
        public double CalculateCost(Product product)
        {
            Console.WriteLine("Heavy Weight Cost");
            return product.Price = 15;
        }
    }
}

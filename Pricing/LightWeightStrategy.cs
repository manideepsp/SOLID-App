namespace ConsoleApp1
{
    public class LightWeightStrategy : IPricingStrategy
    {
        public double CalculateCost(Product product)
        {
            Console.WriteLine("Light Weight Cost");
            return product.Price = 10;
        }
    }
}

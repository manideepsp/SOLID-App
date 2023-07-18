namespace ConsoleApp1
{
    public class FactoryPricingStrategy
    {
        public IPricingStrategy GetHeavyWeightStrategy()
        {
            return new HeavyWeightStrategy();
        }
        public IPricingStrategy GetHeavyWeightStrategyDiscount()
        {
            return new HeavyWeightStrategyDiscount();
        }
        public IPricingStrategy GetLightWeightStrategy()
        {
            return new LightWeightStrategy();
        }
        public IPricingStrategy GetLightWeightStrategyDiscount()
        {
            return new LightWeightStrategyDiscount();
        }
    }
}

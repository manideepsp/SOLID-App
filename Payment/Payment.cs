namespace ConsoleApp1
{
    public class Payment
    {
        public void ProcessPayment(IProcessPayment p, Product product)
        {
            p.ProcessPayment(product);
        }
    }
}

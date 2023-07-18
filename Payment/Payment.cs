namespace ConsoleApp1
{
    public class Payment
    {
        public void ProcessPayment(IProcessPayment p, double totalPrice)
        {
            p.ProcessPayment(totalPrice);
        }
    }
}

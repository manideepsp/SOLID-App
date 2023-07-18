namespace ConsoleApp1
{
    public abstract class CardPayment : IProcessPayment
    {
        public abstract void ProcessPayment(double totalPrice);
    }
}
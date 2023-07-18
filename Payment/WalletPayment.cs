namespace ConsoleApp1
{
    public class WalletPayment : IProcessPayment
    {
        public void ProcessPayment(double totalPrice)
        {
            Console.WriteLine($"""
                Wallet Payment of {totalPrice} has been successful
                """);
        }
    }
}
namespace ConsoleApp1
{
    public class WalletPayment : IProcessPayment
    {
        public void ProcessPayment(Product product)
        {
            Console.WriteLine($"""
                Wallet Payment of {product.Price} has been successful
                """);
        }
    }
}
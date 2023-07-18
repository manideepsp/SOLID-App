namespace ConsoleApp1
{
    public class UpiPayment : IProcessPayment
    {
        public void ProcessPayment(Product product)
        {
            Console.WriteLine($"""
                Upi Payment of {product.Price} has been successful.
                """);
        }
    }
}
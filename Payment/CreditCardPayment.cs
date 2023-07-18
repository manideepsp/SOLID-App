namespace ConsoleApp1
{
    public class CreditCardPayment : CardPayment
    {
        public override void ProcessPayment(Product product)
        {
            Console.WriteLine($"""
                Creditcard Payment of {product.Price} has been successful.
                """);
        }
    }
}
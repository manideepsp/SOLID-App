namespace ConsoleApp1
{
    public class DebitCardPayment : CardPayment
    {
        public override void ProcessPayment(Product product)
        {
            Console.WriteLine($"""
                Debitcard Payment of {product.Price} has been successful.
                """);
        }
    }
}
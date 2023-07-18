namespace ConsoleApp1
{
    public class CreditCardPayment : CardPayment
    {
        public override void ProcessPayment(double totalPrice)
        {
            Console.WriteLine($"""
                Creditcard Payment of {totalPrice} has been successful.
                """);
        }
    }
}
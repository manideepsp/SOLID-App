namespace ConsoleApp1
{
    public class DebitCardPayment : CardPayment
    {
        public override void ProcessPayment(double totalPrice)
        {
            Console.WriteLine($"""
                Debitcard Payment of {totalPrice} has been successful.
                """);
        }
    }
}
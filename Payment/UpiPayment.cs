namespace ConsoleApp1
{
    public class UpiPayment : IProcessPayment
    {
        public void ProcessPayment(double totalPrice)
        {
            Console.WriteLine($"""
                Upi Payment of {totalPrice} has been successful.
                """);
        }
    }
}
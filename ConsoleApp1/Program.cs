namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Product product = new Product();

            // Take Input
            Input input = new Input();
            input.TakeInput(product);

            // Calculate Price
            Price price = new Price();
            price.calculate(product);
            Console.WriteLine("Price: "+product.Price);

            // Process Payment
            DoPayment doPayment = new DoPayment();
            doPayment.ProcessPayment(product);
        }
    }
}
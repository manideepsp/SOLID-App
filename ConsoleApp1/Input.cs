namespace ConsoleApp1
{
    internal class Input
    {
        public void TakeInput(Product product)
        {
            // Product Namne Input
            Console.Write("""
                Enter the product Name: 
                """);
            product.Name = Console.ReadLine();

            // Product weight input
            Console.Write("""
                Enter the Weight: 
                """);
            product.Weight = Convert.ToDouble(Console.ReadLine());

            // Product Age Input
            Console.Write("""
                Enter the age of product: 
                """);
            product.Age = Convert.ToInt32(Console.ReadLine());
        }
    }
}

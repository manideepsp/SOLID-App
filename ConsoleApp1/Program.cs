namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Product product = new Product();
            Cart cart = new Cart();

            while (true)
            {
                Console.WriteLine("Add new product ?" +
                    "y/Y yes" +
                    "n/N no");
                string inp = Console.ReadLine();
                if (inp == "y" || inp == "Y" )
                {
                    product = new Product();
                    // Take Input
                    Input input = new Input();
                    input.TakeInput(product);

                    // Print Product Properties
                    Console.WriteLine($"""
                        The product properties are
                        name: {product.Name}
                        age: {product.Age}
                        weight: {product.Weight}
                        """);

                    // Add to cart
                    cart.AddToCart(product);
                }
                else if (inp == "n" || inp == "N")
                {
                    break;
                }
            }


            // Calculate Price
            Price price = new Price();
            double totalPrice = price.calculate(cart);
            Console.WriteLine("Price: " + totalPrice);

            foreach(var item in cart.Products)
            {
                Console.WriteLine(item.Age+" "+item.Name+" "+item.Price+" "+item.Weight);
            }

            // Process Payment
            DoPayment doPayment = new DoPayment();
            doPayment.ProcessPayment(totalPrice);
        }
    }
}
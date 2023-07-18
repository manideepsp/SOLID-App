namespace ConsoleApp1
{
    internal class DoPayment
    {
        public void ProcessPayment(Product product)
        {
            IProcessPayment processPayment;
            Payment payment = new Payment();

            Console.WriteLine($"""
                Choose Payment option:
                1. Upi
                2. Wallet
                3. Debit Card
                4. CreditCard
                """);
            int inp = Convert.ToInt32(Console.ReadLine());
            Func<int, IProcessPayment> paymentOption = (int inp) =>
            {
                switch (inp)
                {
                    case 1:
                        return new UpiPayment();
                    case 2:
                        return new WalletPayment();
                    case 3:
                        return new DebitCardPayment();
                    case 4:
                        return new CreditCardPayment();
                    default:
                        throw new ArgumentException("Invalid input for payment option.");
                }
            };
            processPayment = paymentOption(inp);
            payment.ProcessPayment(processPayment, product);

            processPayment = new CreditCardPayment();
            payment.ProcessPayment(processPayment, product);
        }
    }
}
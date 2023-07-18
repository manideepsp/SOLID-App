namespace ConsoleApp1
{
    /// <summary>
    /// The do payment.
    /// </summary>
    internal class DoPayment
    {
        /// <summary>
        /// Process payment.
        /// </summary>
        /// <param name="totalPrice">Double.</param>
        /// <returns></returns>
        public void ProcessPayment(double totalPrice)
        {
            FactoryPaymentProcessor factory = new FactoryPaymentProcessor();
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
                        return factory.GetUpiPayment();
                    case 2:
                        return factory.GetWalletPayment();
                    case 3:
                        return factory.GetDebitCardPayment();
                    case 4:
                        return factory.GetCreditCardPayment();
                    default:
                        throw new ArgumentException("Invalid input for payment option.");
                }
            };
            payment.ProcessPayment(paymentOption(inp), totalPrice);

            payment.ProcessPayment(factory.GetCreditCardPayment(), totalPrice);
        }
    }
}
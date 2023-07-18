namespace ConsoleApp1
{
    public class FactoryPaymentProcessor
    {
        public IProcessPayment GetUpiPayment()
        {
            return new UpiPayment();
        }
        public IProcessPayment GetWalletPayment()
        {
            return new WalletPayment();
        }
        public IProcessPayment GetDebitCardPayment() {
            return new DebitCardPayment();
        }
        public IProcessPayment GetCreditCardPayment()
        {
            return new CreditCardPayment();
        }
    }
}

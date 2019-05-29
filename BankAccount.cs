namespace MontlyChargeDemo
{
    public delegate void WithdrawEventHandler(decimal balance, decimal amount, bool success);
    public class BankAccount
    {
        public event WithdrawEventHandler OnBankAccountChanged;

        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if(this.Balance - amount >= 0)
            {
                this.Balance -= amount;

                this.OnBankAccountChanged(this.Balance, amount, true);
            }
            else
            {
                this.OnBankAccountChanged(this.Balance, amount, false);
            }
        }

    }
}

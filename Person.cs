namespace MontlyChargeDemo
{
    public class Person
    {
        public string FullName { get; set; }

        public BankAccount Account { get; set; }

        public GSM Phone { get; set; }

        public Person(string FullnName, BankAccount bankAccount, GSM phone)
        {
            this.FullName = FullName;

            this.Account = bankAccount;

            this.Phone = phone;

            //Subscribing all people by default
            this.Account.OnBankAccountChanged += Account_OnBankAccountChanged; 
        }

        private void Account_OnBankAccountChanged(decimal balance, decimal amount, bool success)
        {
            string message = "Curent balance: " + balance + ",\ntaken amount: " + amount + ",\nsuccess: " + success;

            Phone.SendMessage(message);
        }
    }
}

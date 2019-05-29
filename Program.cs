namespace MontlyChargeDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GSM gsmGosho = new GSM("0898204521");

            BankAccount bankAccountGosho = new BankAccount();

            GSM gsmIvan = new GSM("0898704382");

            BankAccount bankAccountIvan = new BankAccount();

            Person gosho = new Person("Georgi Ivanov", bankAccountGosho, gsmGosho);

            Person ivan = new Person("Ivan Georgiev", bankAccountIvan, gsmIvan);

            //Starting money
            gosho.Account.Balance = 200.00m;
            ivan.Account.Balance = 9.00m;

            //Creating array of Person and give clients to the company
            Person[] clients = new Person[2];

            clients[0] = gosho;
            clients[1] = ivan;

            MobileCompany mobileCompany = new MobileCompany(clients);

            mobileCompany.MontlyCharge(9.99m);
        }
    }
}

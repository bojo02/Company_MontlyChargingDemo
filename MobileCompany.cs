namespace MontlyChargeDemo
{
    public class MobileCompany
    {
        private Person[] _clients;

        public MobileCompany(Person[] clients)
        {
            this._clients = clients;
        }

        public void MontlyCharge(decimal money)
        {
            for(int i = 0; i < _clients.Length; i++)
            {
                _clients[i].Account.Withdraw(money);
            }
        }
    }
}

using System;

namespace MontlyChargeDemo
{
    public class GSM
    {
        public string Number { get; set; }

        public GSM(string number)
        {
            this.Number = number;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Message: " + message);
            Console.WriteLine("-----------------------------");
        }
    }
}

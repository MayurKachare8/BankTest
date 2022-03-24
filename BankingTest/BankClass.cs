using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingTest
{
    public  class BankClass
    {

        private readonly string customer_name;
        private double balance;

        private BankClass() { }

        public BankClass(string cname, double cbalance)
        { 
            customer_name = cname;
            balance = cbalance;
        }
        public string CustomerName
        {
            get { return customer_name; }
        }
        public double Balance
        { 
            get { return balance; }
        }

        public void debit(double amount)
        {
            if (balance < amount)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            else if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            balance -= amount;   

        }
        public void credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");

            }
            balance += amount;
        
        }
        static void Main(string[] args)
        {
            BankClass bank = new BankClass("Mayur Kachare",100);
            bank.debit(10);
            bank.credit(40);
            Console.WriteLine(" Current Balance is : " + bank.balance);
            
        }
    }
}

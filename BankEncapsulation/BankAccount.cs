using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {

        private double _balance = 0;
        private double _withdraw = 0;

        public void Deposit(double money) 
        {
            _balance += money;
        }
        public double GetBalance() 
        {
            Console.WriteLine($"{_balance}");
            return _balance;
        }
        public void Withdraw(double amount) 
        {
            _balance -= amount;
        }
        public void Withdraw() 
        {
            Console.WriteLine($"{_withdraw}");
        }
        
    }


}
        
 


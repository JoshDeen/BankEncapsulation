using System.IO.Pipes;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            account1.Deposit(5000);
            account1.GetBalance();
            account1.Withdraw(3000);
            account1.GetBalance();
            Console.WriteLine("Please choose an option: Deposit, Withdraw, Balance");
            string answer = Console.ReadLine();

            if (answer == "deposit") 
            {
                Console.WriteLine("How much would you like to deposit?");
                double depositAmount = double.Parse(Console.ReadLine());
                account1.Deposit(depositAmount);
                Console.WriteLine("Here is your balance:");
                account1.GetBalance();
            }
            else if(answer == "withdraw")
            {
                Console.WriteLine("How much would you like to withdraw?");
                double withdrawAmount = double.Parse(Console.ReadLine());
                account1.Withdraw(withdrawAmount);
                Console.WriteLine("Here is your balance:");
                account1.GetBalance();
            }
            else if(answer == "balance") 
            {
                               
                var amount = account1.GetBalance();
                Console.WriteLine($"Here is your balance: {amount}");
                
            }
        }
    }
}

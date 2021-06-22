using System;

namespace ConsoleApp1
{

    // bank accounts class
    class BankAccount
    {

        public override string ToString()
        {
            return string.Format("Account information : Id:{0} ,Name : {1}, Balance:{2}", _accId, _accName, _accBalance);
        }

        // class constructor for the Bank bank accounts class
        public BankAccount(string accId, string accName)
        {
            _accId = accId;
            _accName = accName;
        }

        //public string AccId { get; set; } // property
        //public string AccName { get; set; }  // property
        //public double AccBalance { get; set; } // property     

        private string _accId; // filed
        private string _accName;  // filed
        private double _accBalance; // filed     

        
        public void Deposit (Double amount)
        {
            _accBalance += amount;

    
        }

        public void Withdraw(Double amount)
        {
            if (_accBalance >= amount) 
            {
                _accBalance -= amount;
            }
            else 
            {
                Console.Write("Account balance is not enough");
            }
        }

        public string GetName()
        {
            return _accName;

        }

        public double GetBalance()
        {
            return _accBalance;
        }


        public void SetBalalnce(double amount)
        {
            _accBalance = amount;
        }

    }
    class Program {

        static void Main(string[] args)
        {


            BankAccount savingAccount = new BankAccount("0002", "savingAccount");
            savingAccount.Deposit(5000);

            BankAccount currentAccount = new BankAccount("0001","currentAccount");
            currentAccount.Deposit(1000);
            Console.WriteLine(currentAccount.GetBalance().ToString("N"));

            savingAccount.Withdraw(200); // 500 - 200
            currentAccount.Deposit(200); // 1000 + 200
            Console.WriteLine(savingAccount.ToString());
            Console.WriteLine(currentAccount.ToString());
           // Console.ReadLine();
        }
    }
}


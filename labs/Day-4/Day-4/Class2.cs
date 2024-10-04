using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    public class BankAccount
    {
        private int _accountNumber,_balance;
        private string _accountHolderName;
        public BankAccount(int AccountNumber,string AccountHolderName)
        {
            _accountNumber=AccountNumber;
            _accountHolderName=AccountHolderName;
            _balance=0;
        }
        public void Deposit(int amount)
        {
            _balance += amount;
        }
        public void Withdraw(int amount)
        {
            if((_balance-amount)>=500)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("Account minimum balance should be 500");
            }
        }
        ~BankAccount()
        {

        }
        public void Print()
        {
            Console.WriteLine($"Account No : {_accountNumber} Account HolderName : {_accountHolderName} balance:{_balance}");
        }
    }
    internal class Class2
    {
        public static void Main2()
        {
            //array of object
            BankAccount[] arrayOfBankaccount = new BankAccount[5];


            BankAccount objBankAccount = new BankAccount(101,"Vikash Verma");
            objBankAccount.Deposit(1500);
            objBankAccount.Print();
            objBankAccount.Withdraw(500);
            objBankAccount.Print();
            objBankAccount.Withdraw(800);
            objBankAccount.Print();
        }
    }
}

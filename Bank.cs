using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Bank
    {
        frontend f;
        database db;
        Bank()
        {
            db=new DatabaseFactory().MakeDb();
            f = new FrontEndFactory().Make();
        }
        void createAccount()
        {
            f.TakeCustomerDetails(out string details);
            int accno=db.StoreDetails(details);
            string msg = "Successfully created account and your account number is: "+accno;
            f.display(msg);
        }
        decimal getBalance(int accountNo)
        {
            decimal bal = 0;
            db.RetrieveDetails(accountNo);
            return bal;
        }
        void Deposit(int accountNo, decimal amount) { }
        void Withdraw(int accountNo, decimal amount) { }
    }
}

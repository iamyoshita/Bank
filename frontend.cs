using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    interface frontend
    {
        void TakeCustomerDetails(out string details);
        void display(string msg);
    }

    class ConsoleUI : frontend
    {
        public void display(string msg)
        {
            Console.WriteLine(msg);
        }

        public void TakeCustomerDetails(out string details)
        {
            Console.WriteLine("enter customer name");
            details=Console.ReadLine();
        }
    }
}

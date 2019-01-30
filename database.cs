using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    interface database
    {
         int StoreDetails(string details); //returns account number assigned
        decimal RetrieveDetails(int accno); //returns balance
    }
    class FileDb : database
    {
        static int accno=1;
        public  int StoreDetails(string details)
        {

            return accno++;
        }

        public decimal RetrieveDetails(int accno)
        {
            throw new NotImplementedException();
        }

    }
}

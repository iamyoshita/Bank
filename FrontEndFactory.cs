using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class FrontEndFactory
    {
        public frontend Make() {
            return new ConsoleUI();
        }
    }
}

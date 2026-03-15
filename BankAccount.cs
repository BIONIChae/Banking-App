using System;
using System.Collections.Generic;
using System.Text;

namespace TheBankingApp
{
    internal class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; set; }
    }
}
 
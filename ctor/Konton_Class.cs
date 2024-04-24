using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    internal class Account
    {
        public string ID { get; set; }
        public int Saldo { get; set; }

        public Account(string id, int saldo)
        {
            ID = id;
            Saldo = saldo;
        }

    }
}

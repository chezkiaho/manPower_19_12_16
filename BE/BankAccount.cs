using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    struct BankAccount
    {
        private int bankNumeber;

        public int BankNumeber
        {
            get { return bankNumeber; }
            set { bankNumeber = value; }
        }

        private string bankname;

        public string BankName
        {
            get { return bankname; }
            set { bankname = value; }
        }

        private int branchNumeber;

        public int BranchNumber
        {
            get { return branchNumeber; }
            set { branchNumeber = value; }
        }

        private Address address;

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        private string branchCiti; //  not need becouse is in address struct

        public string BranchCiti
        {
            get { return branchCiti; }
            set { branchCiti = value; }
        }

        private int accountNumber;

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

    }
}

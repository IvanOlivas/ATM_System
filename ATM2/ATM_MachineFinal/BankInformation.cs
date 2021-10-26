using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MachineFinal
{
    class BankInformation
    {
        //calss attribute
        private string address;
        private int bankID;

        //cnstructor 

        public BankInformation(string address, int bankID)
        {
            this.address = address;
            this.bankID = bankID;
        }

        //setters and getters
        public void setAddress(string address)
        {
            this.address = address;
        }
        public string getAddress()
        {
            return this.address;
        }

        public void setBankID(int bankID)
        {
            this.bankID = bankID;
        }
        public int getBankID()
        {
            return this.bankID;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MachineFinal
{
    class AtmInformation
    {
        //class attributes 
        private int atmNum;
        private int bankID;
        private int moneyStoreInMachine = 10000;//is there a default amount to be store? if so substract the default minus every amount a users withdraws
        private string location;

        //constructors
        public AtmInformation()
        {

        }
        public AtmInformation(int atmNum, int bankID, int moneyStoreInMachine, string location)
        {
            this.atmNum = atmNum;
            this.bankID = bankID;
            this.moneyStoreInMachine = moneyStoreInMachine;
            this.location = location;
        }

        //setters and getters
        public void setAtmNum(int atmNum)
        {
            this.atmNum = atmNum;
        }
        public int getAtmNum()
        {
            return this.atmNum;
        }

        public void setBankID(int bankID)
        {
            this.bankID = bankID;
        }
        public int getBankID()
        {
            return this.bankID;
        }

        public void setMoneyStoreInMachine(int moneyStoreInMachine)
        {
            this.moneyStoreInMachine = moneyStoreInMachine;
        }
        public int getMoneyStoreInMachine()
        {
            return this.moneyStoreInMachine;
        }

        public void setLocation(string location)
        {
            this.location = location;
        }
        public string getLocation()
        {
            return this.location;
        }
        //-----------------------END OF GET AND SET METHODS---------------------

        public Boolean checkMachineCash(double amount)
        {
            if (amount <= moneyStoreInMachine)
                return true;

            return false;
        }
    }
}

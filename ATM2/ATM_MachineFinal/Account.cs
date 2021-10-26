using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MachineFinal
{
    class Account
    {
        //calss attributes 
        private int customerID;
        private string accountType;
        private int accountNum;
        private int dailyTransactionLimit;//database contains default value.
        private double balance;         //update database from here pa bajo
        private double dailyTransactionTotal;
        private string dailyTransactionDate;
        private double pendingBalance;

        AtmInformation thisATM;//deugging when i use thisATM in form1


        public Account()
        {

        }
        //constructor
        public Account(int customerID, string accountType, int accountNum, double balance, int dailyTransactionLimit, double dailyTransactionTotal, string dailyTransactionDate, double pendingBalance)
        {
            this.customerID = customerID;
            this.accountType = accountType;
            this.accountNum = accountNum;
            this.balance = balance;
            this.dailyTransactionLimit = dailyTransactionLimit;
            this.dailyTransactionTotal = dailyTransactionTotal;
            this.dailyTransactionDate = dailyTransactionDate;
            this.pendingBalance = pendingBalance;
        }
        //setters and getters 
        public void setCustomerID(int customerID)
        {
            this.customerID = customerID;

        }

        public int getCustomerID()
        {
            return this.customerID;
        }

        public void setAccountType(string accountType)
        {
            this.accountType = accountType;
        }

        public string getAccountType()
        {
            return this.accountType;
        }

        public void setAccountNum(int accountNum)
        {
            this.accountNum = accountNum;
        }

        public int getAccountNum()
        {
            return this.accountNum;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public double getBalance()
        {
            return this.balance;
        }

        public void setDailyTransactionLimit(int dailyTransactionLimit)
        {
            this.dailyTransactionLimit = dailyTransactionLimit;
        }

        public int getDailyTransactionLimit()
        {
            return this.dailyTransactionLimit;
        }

        public void setDailyTransactionTotal(double dailyTransactionTotal)
        {
            this.dailyTransactionTotal = dailyTransactionTotal;
        }

        public double getDailyTransacctionTotal()
        {
            return this.dailyTransactionTotal;
        }

        public void setDailyTransactionDate(string dailyTransacctionDate)
        {
            this.dailyTransactionDate = dailyTransacctionDate;
        }

        public string getDailyTransactioDate()
        {
            return this.dailyTransactionDate;
        }

        public void setPendingBalance(double pendingBalance)
        {
            this.pendingBalance = pendingBalance;
        }

        public double getPendingBalance()
        {
            return this.pendingBalance;
        }

        //retrieve Accounts
        public static ArrayList RetrieveAccounts(int usingCustomerID)
        {
            ArrayList customerAccounts = new ArrayList();
            DataTable myTable = new DataTable(); //will read all rows from the returning values
            string connectionToDatabse = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            MySqlConnection conn = new MySqlConnection(connectionToDatabse);

            try
            {
                Console.WriteLine("Connecting to MySql...");
                conn.Open();
                string selectAccountsSql = "SELECT * FROM olivasAccount WHERE customerID = @customerID ORDER BY accountNumber ASC;";
                MySqlCommand cmd = new MySqlCommand(selectAccountsSql, conn);
                cmd.Parameters.AddWithValue("@customerID", usingCustomerID);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);
                Console.WriteLine("Table is ready");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Close();
            //convert the retrieved Dada to AccountNumbers and save them to the list
            foreach (DataRow row in myTable.Rows)
            {
                //create default Account Class without inizialization.
                Account newAccount = new Account(); 

                newAccount.accountNum = Int32.Parse(row["accountNumber"].ToString());
                newAccount.customerID = Int32.Parse(row["customerID"].ToString());
                newAccount.accountType = row["accountType"].ToString();
                newAccount.balance = Double.Parse(row["balance"].ToString());
                newAccount.dailyTransactionTotal = Double.Parse(row["dailyTransactionTotal"].ToString());
                newAccount.dailyTransactionLimit = Int32.Parse(row["dailyTransactionLimit"].ToString());
                newAccount.dailyTransactionDate = row["dailyTransactionDate"].ToString();
                newAccount.pendingBalance = Double.Parse(row["pendingBalance"].ToString());

                customerAccounts.Add(newAccount);
            }
            return customerAccounts;
        }
       
        public void updateDailyTransactionDate()
        {
            //get the right format date -> MM/dd/yyyy
            dailyTransactionDate = correctFormatDate(dailyTransactionDate);
            dailyTransactionDate = dailyTransactionDate.Substring(0, 10);//get rid of the time since we dont need it!
            string todaysDate = DateTime.Now.ToString("MM/dd/yyyy");
           
            Console.WriteLine("old date " + dailyTransactionDate);
            Console.WriteLine("new date " + todaysDate);
            
            if(!dailyTransactionDate.Equals(todaysDate))
            {
                //reset dailyTransaction Items
                dailyTransactionDate = todaysDate;
                dailyTransactionTotal = 0.0;
            }
            
        }
        //in order to have the same format date perform the function
        public string correctFormatDate(string date)
        {
            switch (date.Substring(0, 1))
            {
                case "0":
                    return date;
                default:
                    return "0" + date;
            }
        }

        public Boolean hasDailyTransactionTotalReachLimit()
        {
            if(dailyTransactionTotal == 3000)
            {
                return true;
            }
            return false;
        }

        //use the nexttwo function once the user enters an amount. 
        public Boolean veifyDailyTransactionTotalAndAmount(double amount)
        {
            if(dailyTransactionTotal + amount <= 3000)
            {
                return false;
            }
            return true; 
        }

        public bool verifyAccountBalanceWithGiven(double amount)
        {
            if(amount <= balance)
            {
                return true;
            }
            return false;
        }

        //withdraw function... if theres is enough money in the atm machine
        public void withdrawMoney(double amount, AtmInformation thisATM)
        {
            //update account information based on withdraw amount 
            balance = balance - amount;
            dailyTransactionTotal += amount;
            thisATM.setMoneyStoreInMachine(thisATM.getMoneyStoreInMachine()- Int32.Parse(amount.ToString()));
        }

        public string changeDateFormat(string withGivenDate)
        {
            string formatedDate = "";
            string year = "";
            string day = "";
            string month = "";

            month = withGivenDate.Substring(0, 2);
            day = withGivenDate.Substring(3, 2);
            year = withGivenDate.Substring(6, 4);

            return year + "/" + month + "/" + day;
        }

        public void updateAccountData()
        {
            //change the dailyTransaction format before its send to the databe.
            dailyTransactionDate = changeDateFormat(dailyTransactionDate);
            Console.Write(dailyTransactionDate);
            string connStr = "server = 157.89.28.130; user = ChangK; database = csc340; port = 3306; password = Wallace#409;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                //string sql = "INSERT INTO olivasaccount
                string sql = "UPDATE olivasaccount SET dailyTransactionDate=@date, dailyTransactionTotal=@total, balance=@newBalance, pendingBalance=@newPendingBalance WHERE accountNumber=@accountNum;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", dailyTransactionDate);
                cmd.Parameters.AddWithValue("@total", dailyTransactionTotal);
                cmd.Parameters.AddWithValue("@newBalance", balance);
                cmd.Parameters.AddWithValue("@newPendingBalance",pendingBalance);
                cmd.Parameters.AddWithValue("@accountNum", accountNum);
                cmd.ExecuteNonQuery();
                Console.WriteLine("successful update perro!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        //Function to perform deposit -> pending balance
        public void Depsit(Account currentAccount, double amount)
        {
            string connStr = "server = 157.89.28.130; user = ChangK; database = csc340; port = 3306; password = Wallace#409;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                //string sql = "INSERT INTO olivasaccount
                string sql = "UPDATE olivasaccount SET pendingBalance= pendingBalance + @newPendingBalance WHERE accountNumber=@accountNum;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@newPendingBalance", amount);
                cmd.Parameters.AddWithValue("@accountNum", currentAccount.getAccountNum());
                cmd.ExecuteNonQuery();
                Console.WriteLine("successful update perro!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
    }
    
}
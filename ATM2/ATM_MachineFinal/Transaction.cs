using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MachineFinal
{
    class Transaction
    {
        //class attributes 
        private int transactionNum;
        private string transactionType;
        private int accountNum;
        private double amount;
        private int sendingAccount;
        private int receivingAccount;
        private DateTime dateOfTransaction;

        //constructor
        public Transaction(string transactionType, int accountNum, double amount, int sendingAccount, int receivingAccount, DateTime dateOfTransaction)
        {
            //this.transactionNum = transactionNum;
            this.transactionType = transactionType;
            this.accountNum = accountNum;
            this.amount = amount;
            this.sendingAccount = sendingAccount;
            this.receivingAccount = receivingAccount;
            this.dateOfTransaction = dateOfTransaction;
        }

        //setters and getters

        public void setTransactionNum(int transactionNum)
        {
            this.transactionNum = transactionNum;
        }
        public int getTransactionNum()
        {
            return this.transactionNum;
        }

        public void setTransactionType(string transactionType)
        {
            this.transactionType = transactionType;
        }
        public string getTransactionType()
        {
            return this.transactionType;
        }

        public void setAccountNum(int accountNum)
        {
            this.accountNum = accountNum;
        }
        public int getAccountNum()
        {
            return this.accountNum;
        }

        public void setAmount(double amount)
        {
            this.amount = amount;
        }
        public double getAmount()
        {
            return this.amount;
        }

        public void setSendingAccount(int sendingAccount)
        {
            this.sendingAccount = sendingAccount;
        }
        public int getSendingAccount()
        {
            return this.sendingAccount;
        }

        public void setReceivingAccount(int receivingAccount)
        {
            this.receivingAccount = receivingAccount;
        }
        public int getReceivingAccount()
        {
            return this.receivingAccount;
        }

        public void setDateOfTransaction(DateTime dateOftransaction)
        {
            this.dateOfTransaction = dateOftransaction;
        }
        public DateTime getDateOfTransaction()
        {
            return this.dateOfTransaction;
        }

        //save transaction to the database
        public void saveTransaction()
        {
       
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "INSERT INTO olivastransaction(amount, transactionType, sendingAccount, recievingAccount, dateOfTransaction, accountNumber) VALUES (@amount, @transactionType, @sendingAccount, @receivingAccount, @dateOfTransaction, @accountNumber)"; 
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@transactionType", transactionType);
                cmd.Parameters.AddWithValue("@sendingAccount", sendingAccount);
                cmd.Parameters.AddWithValue("@receivingAccount", receivingAccount);
                cmd.Parameters.AddWithValue("@dateOfTransaction", dateOfTransaction);
                cmd.Parameters.AddWithValue("@accountnumber", accountNum);
                cmd.ExecuteNonQuery();
                Console.WriteLine("we did it boiiiiz");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace ATM_MachineFinal
{
    class CustomerInfo
    {
        //Class atributes 
        private int customerID;
        private string userName;
        private string customerName;
        private string customerAddress;
        private string dateOfBirth;
        private string passcode;

        //constructor to logIn 
        public CustomerInfo(int customerID, string passcode)
        {
            this.customerID = customerID;
            this.passcode = passcode;
        }

        public CustomerInfo(int customerID, string userName, string customerName, string customerAddress, string dateOfBirth, string passcode)
        {
            this.customerID = customerID;
            this.userName = userName;
            this.customerName = customerName;
            this.customerAddress = customerAddress;
            this.dateOfBirth = dateOfBirth;
            this.passcode = passcode;
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

        public void setCustomerName(String customerName)
        {
            this.customerName = customerName;
        }

        public String getCustomerName()
        {
            return customerName;
        }

        public void setCustomerAddress(String customerAddress)
        {
            this.customerAddress = customerAddress;
        }

        public String getCustomerAddress()
        {
            return customerAddress;
        }

        public void setCustomerBirthDate(String customerBirthdate)
        {
            dateOfBirth = customerBirthdate;
        }

        public String getCustomerBirthdate()
        {
            return dateOfBirth;
        }

        public void setUserName(String userName)
        {
            this.userName = userName;
        }

        public String getUserName()
        {
            return userName;
        }

        public void setPasscode(String PIN)
        {
            passcode = PIN;
        }

        public String getPasscode()
        {
            return passcode;
        }
        //---------------END OF GET AND SET METHODS-----------------------

        public static bool VerifyUserNameAndPassword(int cid, string PIN)
        {
            //first acces the database and pull the custID based on the input
            bool result = true;
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Console.WriteLine("WE made it here");
                string sql = "SELECT * FROM olivascustomerinfo WHERE customerID=@cid AND passCode=@PIN;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cid", cid);
                cmd.Parameters.AddWithValue("@PIN", PIN);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    //Console.WriteLine("we here");
                    //Console.WriteLine("maybe");
                    //textBox1.Text = myReader["FirstName"].ToString();
                    //textBox2.Text = myReader["LastName"].ToString();
                    //textBox3.Text = myReader["ID"].ToString();
                     
                    result = true;
                }
                else
                {
                    result = false;
                }
                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return result;
        }

        
    }


}

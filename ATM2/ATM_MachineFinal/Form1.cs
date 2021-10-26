using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATM_MachineFinal
{
    public partial class ATM_Machine : Form
    {
        //global variables Objects
        CustomerInfo thisCustomerInfo;
        Account selectedAccount;
        Transaction thisTransaction;
        DateTime date;

        AtmInformation thisATM = new AtmInformation();
        Boolean transactionComplete = false;//withdrawSuccessfullyProcessed!
        Boolean needToSelectAnotherAccount = false;

        //booleans to determine wich operation will be performed
        Boolean isWithdrawInProgress = false;
        Boolean isCheckBalanceInProgress = false;

        //Empty list to store accounts in it.
        ArrayList listOfCustomersAccounts = new ArrayList();
        Boolean customerIDTextBoxIsSelected = false;
        Boolean passcodeTexboxIsSelected = false;
        Boolean customerAmountTextBoxIsSelected = true;

        //curentButtonSelected to allow deposit
        string currentButtonSelected = "";
        public ATM_Machine()
        {
            InitializeComponent();
            MainMenuPanel.Visible = false;
            //LogInPanel.Visible = true;
        }

        private void LogInPanel_Paint(object sender, PaintEventArgs e) { }

        //Sign In Function
        private void SignInButton_Click(object sender, EventArgs e)
        {
            int userName = Int32.Parse(CustomerIDTextBox.Text);
            string PIN = PasscodeTextBox.Text;
            bool isValidUser = CustomerInfo.VerifyUserNameAndPassword(userName, PIN);

            //log in and display customer menu
            if (isValidUser == true)
            {
                thisCustomerInfo = new CustomerInfo(userName, PIN);
                Console.WriteLine("Success!!");
                ErrorLabel.Text = "You Have succesfully Logged In!";
                //LogInPanel.Visible = false;
                MainMenuPanel.Visible = true;
                //make main menu visible
                AccountTableLayOut.Visible = false;//listOfAccounts not visible 
                InteractionPanel.Visible = false;//interactionPanel visible when signin in
                AlertPanel.Visible = false;//alerPanel not visible when signin in
            }
            else
            {
                ErrorLabel.Text = "No CustomerID or Passcode Found, please try again! ";
            }
        }

        //Event handler when NumberPad (Buttons) are clicked - > Log In Panel
        private void numberPadIsPressed(object sender, EventArgs e)
        {
            //Create new ButtonObject to identify wich button has been selected based on sender. 
            Button numberPadButton = (Button)sender;
            if (customerIDTextBoxIsSelected)
            {
                CustomerIDTextBox.Text = CustomerIDTextBox.Text + numberPadButton.Text;
                
            }
            else if (passcodeTexboxIsSelected)
            {
                PasscodeTextBox.Text = PasscodeTextBox.Text + numberPadButton.Text;
            }
        }
        
        //Withdraw functionality
        public void customerNumberPadIsPressed(object currentButtonSelected, EventArgs e)
        {
            Button customerNumberPad = (Button)currentButtonSelected;
            if (customerAmountTextBoxIsSelected)
            {
                CustomerAmountTextBox.Text = CustomerAmountTextBox.Text + customerNumberPad.Text;
            }
        }

        //Clear or Back soace button
        public void customerClearAndBackSpaceButtonClicked(object currentButtonSelected, EventArgs e)
        {
            //determine which fuction to perform based on the selected button
            Button clearOrBackspace = (Button)currentButtonSelected;
            switch (clearOrBackspace.Text)
            {
                case "CR":
                    CustomerAmountTextBox.Clear();
                    break;
                case "Bksp":
                    if(CustomerAmountTextBox.Text.Length != 0)
                    {
                        CustomerAmountTextBox.Text = CustomerAmountTextBox.Text.Substring(0, CustomerAmountTextBox.Text.Length - 1);
                    }
                    break;
            }
        }

        //clearButton Log In Function
        private void clearButtonClicked(object sender, EventArgs e)
        {
            //perform operation based on the current textbox selected
            if (customerIDTextBoxIsSelected)
            {
                CustomerIDTextBox.Clear();//clear the textBox

            }
            else if (passcodeTexboxIsSelected)
            {
                PasscodeTextBox.Clear();
            }
        }

        //find which textBox is selected...
        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            //Create new TextBoxobject to identify wich TextBox has been selected based on sender. 
            TextBox customerIdOrPasscode = (TextBox)sender;

            if(customerIdOrPasscode.Name.Equals("CustomerIDTextBox"))
            {
                passcodeTexboxIsSelected = false;
                customerIDTextBoxIsSelected = true;
            }
            else if(PasscodeTextBox.Name.Equals("PasscodeTextBox"))
            {
                customerIDTextBoxIsSelected = false;
                passcodeTexboxIsSelected = true;
            }
        }

        private void backSpaceClicked(object sender, EventArgs e)
        {
            //perform operation based on the current textbox selected
            if (customerIDTextBoxIsSelected)
            {
                if (CustomerIDTextBox.Text.Length != 0) //clear last character
                {
                    CustomerIDTextBox.Text = CustomerIDTextBox.Text.Substring(0, CustomerIDTextBox.Text.Length - 1);
                }
                
            }
            else if (passcodeTexboxIsSelected)
            {
                if (PasscodeTextBox.Text.Length != 0) //clear last character
                {
                    PasscodeTextBox.Text = PasscodeTextBox.Text.Substring(0, PasscodeTextBox.Text.Length - 1);
                }
            }

        }

        private void SignOutClicked(object exitButton, EventArgs e)
        {
            MainMenuPanel.Visible = false;
            LogInPanel.Visible = true;

            CustomerIDTextBox.Clear();
            PasscodeTextBox.Clear();
            ErrorLabel.Text = "";
        }

        //Function to allow a deposit  transaction
        private void DepositButtonClicked(object sender, EventArgs e)
        {
            
            //update currentButtonSelected
            currentButtonSelected = "Deposit";
            AccountListBox.Items.Clear();
            AccountListBox.Enabled = true;
            AccountTableLayOut.Visible = true;

            //Disable other button.
            CheckBalanceButton.Enabled = false;
            TransferButton.Enabled = false;
            WithdrawButton.Enabled = false;

            //retrieve data from the database
            listOfCustomersAccounts = Account.RetrieveAccounts(thisCustomerInfo.getCustomerID());
            displayAccountsUsing(listOfCustomersAccounts);

            //enable andmake visible interaction pannel to allow user input.
            InteractionPanel.Visible = true;
            InteractionPanel.Enabled = false;

        }

        //display list of accounts to thisCustomer when withdrawButton is Cliecked
        private void WithdrawButtonClicked(object sender, EventArgs e)
        {
            isWithdrawInProgress = true; //added this line to make sure after reading an amount only withdraw will perform
            AccountListBox.Items.Clear();
            AccountTableLayOut.Enabled = true;
            AccountTableLayOut.Visible = true;//display list of accounts tabelLayout
            //disable other buttons 
            DepositButton.Enabled = false;
            CheckBalanceButton.Enabled = false;
            TransferButton.Enabled = false;
            WithdrawButton.Enabled = false;

            listOfCustomersAccounts = Account.RetrieveAccounts(thisCustomerInfo.getCustomerID());
            displayAccountsUsing(listOfCustomersAccounts);
        }
        //displayAccount function 
        public void displayAccountsUsing(ArrayList listOfCustomersAccounts)
        {
            foreach (Account item in listOfCustomersAccounts)
            {
                //format and display lists of accounts in the table layout
                Console.WriteLine(item.getAccountNum());
                AccountListBox.Items.Add(item.getAccountNum());
            }
        }
        //CheckBalanceIsClicked
        public void CheckBalanceIsClicked(object sender, EventArgs e)
        {
            AccountListBox.Items.Clear();
            isCheckBalanceInProgress = true;
            AccountTableLayOut.Enabled = true;
            AccountTableLayOut.Visible = true;//display list of accounts tabelLayout
            //disable all the buttons
            DepositButton.Enabled = false;
            CheckBalanceButton.Enabled = false;
            TransferButton.Enabled = false;
            WithdrawButton.Enabled = false;
            listOfCustomersAccounts = Account.RetrieveAccounts(thisCustomerInfo.getCustomerID());//retrieve sccounts
            displayAccountsUsing(listOfCustomersAccounts);//display the lists of accounts
        }

        //identify which account the user selected from the given list 
        private void SelectedAccountFromAccountListBox(object sender, EventArgs e)
        {
            CustomerAmountTextBox.Text = "";
            selectedAccount = (Account)listOfCustomersAccounts[AccountListBox.SelectedIndex];
            //check wich current transaction is in process
            if (isWithdrawInProgress)
            {
                //perform this function whenever withdraw is in process(pressed)
                validateWithdrawWith(selectedAccount);
            }
            else if(isCheckBalanceInProgress)
            {
                //call function to display current and pending balance
                displayBalanceToCustomer(selectedAccount); 
                
            }
            else if (currentButtonSelected.Equals("Deposit"))
            {
                //enable interaction pannel if user clicks depositButton.
                InteractionPanel.Enabled = true;            
            }
        }
        //newFunction to dipslay balance once the user selects an account.
        private void displayBalanceToCustomer(Account currentAccount)
        {
            Console.WriteLine("Pending balance = " + currentAccount.getPendingBalance());
            AlertPanel.Visible = true;
            if(currentAccount.getPendingBalance() != 0.0)
            {
                AlertLabel.Text = "Your cuurent balance is " + currentAccount.getBalance() + " \n Your pending balance is "+ currentAccount.getPendingBalance();
                //isCheckBalanceInProgress = false;               //Disable isCheckBalanceInProgress to allow new interaction.
            }
            else
            {
                AlertLabel.Text = "Your cuurent balance is " + currentAccount.getBalance();
                //isCheckBalanceInProgress = false;
            }
            
        }
        private void validateWithdrawWith(Account currentAccount)
        {
            currentAccount.updateDailyTransactionDate();
            Console.WriteLine("Current amount in ATM " + thisATM.getMoneyStoreInMachine());//debugging atm money
            if (!currentAccount.hasDailyTransactionTotalReachLimit())
            {
                Console.WriteLine("current balance " + currentAccount.getBalance());//debugging
                Console.WriteLine(currentAccount.getDailyTransacctionTotal());
                //ask user to enter the amount to withdraw.
                Console.WriteLine("Please Enter an amount to withdraw");
                //display customerPadNumberpanel to read amount
                InteractionPanel.Visible = true;
                AlertPanel.Visible = false;

            }
            else
            {
                AlertLabel.Text = "Account has reached the daily transaction limit\nPlease select another account";
                needToSelectAnotherAccount = true;
                InteractionPanel.Visible = false;
                AlertPanel.Visible = true;
            }
        }

        //hide OKAlertButton And AlertPanel when OkButton is clicked
        private void oKButtonClicked(object oKButton, EventArgs e)
        {
            if (currentButtonSelected.Equals("Deposit"))            //when OK clicked perform all this only for deposit.
            {
                currentButtonSelected = "";
                AlertLabel.Text = "";
                InteractionPanel.Visible = false;
                AlertPanel.Visible = false;
                AccountListBox.Items.Clear();
                AccountTableLayOut.Visible = false;
                //Enable other buttons 
                WithdrawButton.Enabled = true;
                CheckBalanceButton.Enabled = true;
                TransferButton.Enabled = true;
                return;
            }
            if (transactionComplete)
            {
                //when the trasaction is complete enable all buttons 
                DepositButton.Enabled = true;
                CheckBalanceButton.Enabled = true;
                TransferButton.Enabled = true;
                WithdrawButton.Enabled = true;
                //hide interaction panel
                InteractionPanel.Visible = false; //maybe enable them but hidethem.
                //hide Account tableLayOutPanel.
                AccountTableLayOut.Visible = false;
                AlertPanel.Visible = false;
                transactionComplete = false;
            }
            //check if need to SelectAnotherAccount to enabel the AccountTableLayOut, hide the alert and make the interacion panel visible
            else if (needToSelectAnotherAccount)
            {
                AlertPanel.Visible = false;
                AccountTableLayOut.Enabled = true;
                
            }
            else if (isCheckBalanceInProgress)//after we click OK we need to display the main menu.
            {
                DepositButton.Enabled = true;
                CheckBalanceButton.Enabled = true;
                TransferButton.Enabled = true;
                WithdrawButton.Enabled = true;
                AccountTableLayOut.Visible = false;
                //set isCheckBalanceInProgress to false after user clicked ok 
                AlertPanel.Visible = false;
                isCheckBalanceInProgress = false;
            }
            else
            {
                //return to the interaction panel to select another account
                AlertPanel.Visible = false;
                InteractionPanel.Visible = true;
                AccountTableLayOut.Enabled = true;
            }
            
        }
        //Read amount for withdraw and check balance
        private void ReadAmountFromCustomerTextBox(object sender, EventArgs e)
        {
            double amount = Double.Parse(CustomerAmountTextBox.Text);//read amount
            //Perform this function only when Deposit is clicked.
            if (currentButtonSelected.Equals("Deposit"))    
            {
                Console.WriteLine("The amount: "+amount + " will be depsoit");
                //Call Event to update the pending balace of the selected account
                selectedAccount.Depsit(selectedAccount,amount);
                //save the transaction 
                date = DateTime.Now;
                thisTransaction = new Transaction("Deposit", selectedAccount.getAccountNum(), amount, -1, -1, date);
                thisTransaction.saveTransaction();
                CustomerAmountTextBox.Text = "";
                AlertLabel.Text = "Your transaction was done successfully";
                AlertPanel.Visible = true;
                return;
            }
            //clear customerAmountTextbox
            CustomerAmountTextBox.Clear();
            if (selectedAccount.veifyDailyTransactionTotalAndAmount(amount) == false)
            {
                //proceed with transaction -> Balance must be greater than amount. 
                if (selectedAccount.verifyAccountBalanceWithGiven(amount))
                {
                    //if (selectedAccount.checkTotalMoneyInATMmachine(amount) == true)
                    if(thisATM.checkMachineCash(amount) == true)
                    {
                        //transaction can be complete there is enough money in the atm 
                        Console.WriteLine("there is enough money");
                        //perform withdraw. -> call withdrawMoney from account, sending the amount the user entered.  
                        selectedAccount.withdrawMoney(amount,thisATM);
                        selectedAccount.updateAccountData();
                        date = DateTime.Now;
                        Console.WriteLine(date + " is the right format?"); //debiggon 
                        thisTransaction = new Transaction("Withdraw",selectedAccount.getAccountNum(), amount, -1, -1, date);
                        thisTransaction.saveTransaction();
                        isWithdrawInProgress = false; //set it to false once the transaction is complete to allow another withdraw
                        InteractionPanel.Visible = false;
                        AlertPanel.Visible = true;
                        AlertOkButton.Visible = true;//just aded to see why it dissapeared
                        AlertLabel.Text = "Your transaction was processed susccessfully!";
                        transactionComplete = true;
                        
                    }
                    else
                    {
                        AlertLabel.Text = "There is not enough money in the ATM";
                        needToSelectAnotherAccount = true;
                        InteractionPanel.Visible = false;
                        AlertPanel.Visible = true;
                        //when OK button clicked display interaction panel to enter a different amount
                        AlertOkButton.Visible = true;
                        transactionComplete = true;     //After every transaction we should display main menue.

                    }
                }
                else
                {
                    Console.WriteLine("The transaction cannot be perform because the amount \n is greater than the current balance");
                    AlertLabel.Text = "The transaction cannot be perform because the amount \n is greater than the current balance\nPlease enter an amount less "+selectedAccount.getBalance();
                    InteractionPanel.Visible = false;
                    AlertPanel.Visible = true;
                    AlertOkButton.Visible = true;
                    //ok button should go here 

                    transactionComplete = true;     //After every transaction we should display main menue.
                }
            }
            else
            {
                Console.WriteLine("Your daily transction plus the amount you entered will reached the daily transaction limit.");
                AlertLabel.Text = "Your daily transction plus the amount you entered \n will reached the daily transaction limit\nPlease select another account.";
                needToSelectAnotherAccount = true;//debugging not really need here unless we want to usea= the OK button
                InteractionPanel.Visible = false;
                AlertPanel.Visible = true;
                AccountTableLayOut.Enabled = true;
                AlertOkButton.Visible = false;
                //After every transaction we should display main menu.
                transactionComplete = true;     
            }
        }
    }
}

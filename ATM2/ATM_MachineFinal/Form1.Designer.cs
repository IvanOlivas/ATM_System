namespace ATM_MachineFinal
{
    partial class ATM_Machine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogInPanel = new System.Windows.Forms.Panel();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.AccountTableLayOut = new System.Windows.Forms.TableLayoutPanel();
            this.AccountListBox = new System.Windows.Forms.ListBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TransferButton = new System.Windows.Forms.Button();
            this.CheckBalanceButton = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.BankNameLabel = new System.Windows.Forms.Label();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.BackSpaceButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.PasscodeLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.PasscodeTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.InteractionPanel = new System.Windows.Forms.Panel();
            this.CustomerAmountTextBox = new System.Windows.Forms.TextBox();
            this.CButton1 = new System.Windows.Forms.Button();
            this.CButton2 = new System.Windows.Forms.Button();
            this.CButton3 = new System.Windows.Forms.Button();
            this.CButton6 = new System.Windows.Forms.Button();
            this.CButton5 = new System.Windows.Forms.Button();
            this.CButton4 = new System.Windows.Forms.Button();
            this.CButton9 = new System.Windows.Forms.Button();
            this.CButton8 = new System.Windows.Forms.Button();
            this.CButton7 = new System.Windows.Forms.Button();
            this.CBackspaceButton = new System.Windows.Forms.Button();
            this.CButtonZero = new System.Windows.Forms.Button();
            this.CRButton = new System.Windows.Forms.Button();
            this.CButtonEnter = new System.Windows.Forms.Button();
            this.AlertPanel = new System.Windows.Forms.Panel();
            this.AlertLabel = new System.Windows.Forms.Label();
            this.EnterAmountLabel = new System.Windows.Forms.Label();
            this.AlertOkButton = new System.Windows.Forms.Button();
            this.LogInPanel.SuspendLayout();
            this.MainMenuPanel.SuspendLayout();
            this.AccountTableLayOut.SuspendLayout();
            this.InteractionPanel.SuspendLayout();
            this.AlertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogInPanel
            // 
            this.LogInPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LogInPanel.Controls.Add(this.MainMenuPanel);
            this.LogInPanel.Controls.Add(this.BackSpaceButton);
            this.LogInPanel.Controls.Add(this.ZeroButton);
            this.LogInPanel.Controls.Add(this.ClearButton);
            this.LogInPanel.Controls.Add(this.Button9);
            this.LogInPanel.Controls.Add(this.Button8);
            this.LogInPanel.Controls.Add(this.Button7);
            this.LogInPanel.Controls.Add(this.Button6);
            this.LogInPanel.Controls.Add(this.Button5);
            this.LogInPanel.Controls.Add(this.Button4);
            this.LogInPanel.Controls.Add(this.Button3);
            this.LogInPanel.Controls.Add(this.Button2);
            this.LogInPanel.Controls.Add(this.Button1);
            this.LogInPanel.Controls.Add(this.ErrorLabel);
            this.LogInPanel.Controls.Add(this.SignInButton);
            this.LogInPanel.Controls.Add(this.PasscodeLabel);
            this.LogInPanel.Controls.Add(this.CustomerIDLabel);
            this.LogInPanel.Controls.Add(this.PasscodeTextBox);
            this.LogInPanel.Controls.Add(this.CustomerIDTextBox);
            this.LogInPanel.Controls.Add(this.LogInLabel);
            this.LogInPanel.Location = new System.Drawing.Point(0, 0);
            this.LogInPanel.Name = "LogInPanel";
            this.LogInPanel.Size = new System.Drawing.Size(980, 594);
            this.LogInPanel.TabIndex = 0;
            this.LogInPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LogInPanel_Paint);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.AlertPanel);
            this.MainMenuPanel.Controls.Add(this.InteractionPanel);
            this.MainMenuPanel.Controls.Add(this.AccountTableLayOut);
            this.MainMenuPanel.Controls.Add(this.ExitButton);
            this.MainMenuPanel.Controls.Add(this.TransferButton);
            this.MainMenuPanel.Controls.Add(this.CheckBalanceButton);
            this.MainMenuPanel.Controls.Add(this.DepositButton);
            this.MainMenuPanel.Controls.Add(this.BankNameLabel);
            this.MainMenuPanel.Controls.Add(this.WithdrawButton);
            this.MainMenuPanel.Location = new System.Drawing.Point(3, 3);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(974, 588);
            this.MainMenuPanel.TabIndex = 19;
            // 
            // AccountTableLayOut
            // 
            this.AccountTableLayOut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AccountTableLayOut.ColumnCount = 1;
            this.AccountTableLayOut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AccountTableLayOut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AccountTableLayOut.Controls.Add(this.AccountListBox, 0, 0);
            this.AccountTableLayOut.Location = new System.Drawing.Point(46, 125);
            this.AccountTableLayOut.Name = "AccountTableLayOut";
            this.AccountTableLayOut.RowCount = 1;
            this.AccountTableLayOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AccountTableLayOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AccountTableLayOut.Size = new System.Drawing.Size(415, 411);
            this.AccountTableLayOut.TabIndex = 10;
            // 
            // AccountListBox
            // 
            this.AccountListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AccountListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountListBox.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountListBox.FormattingEnabled = true;
            this.AccountListBox.ItemHeight = 40;
            this.AccountListBox.Location = new System.Drawing.Point(3, 3);
            this.AccountListBox.Name = "AccountListBox";
            this.AccountListBox.Size = new System.Drawing.Size(409, 405);
            this.AccountListBox.TabIndex = 0;
            this.AccountListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedAccountFromAccountListBox);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(9, 545);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(104, 32);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.SignOutClicked);
            // 
            // TransferButton
            // 
            this.TransferButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferButton.Location = new System.Drawing.Point(793, 32);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(161, 63);
            this.TransferButton.TabIndex = 8;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            // 
            // CheckBalanceButton
            // 
            this.CheckBalanceButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBalanceButton.Location = new System.Drawing.Point(606, 32);
            this.CheckBalanceButton.Name = "CheckBalanceButton";
            this.CheckBalanceButton.Size = new System.Drawing.Size(161, 63);
            this.CheckBalanceButton.TabIndex = 7;
            this.CheckBalanceButton.Text = "Check Balance";
            this.CheckBalanceButton.UseVisualStyleBackColor = true;
            this.CheckBalanceButton.Click += new System.EventHandler(this.CheckBalanceIsClicked);
            // 
            // DepositButton
            // 
            this.DepositButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositButton.Location = new System.Drawing.Point(196, 32);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(161, 63);
            this.DepositButton.TabIndex = 6;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButtonClicked);
            // 
            // BankNameLabel
            // 
            this.BankNameLabel.AutoSize = true;
            this.BankNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BankNameLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankNameLabel.Location = new System.Drawing.Point(386, 32);
            this.BankNameLabel.Name = "BankNameLabel";
            this.BankNameLabel.Size = new System.Drawing.Size(188, 58);
            this.BankNameLabel.TabIndex = 5;
            this.BankNameLabel.Text = "ZZZ Bank";
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawButton.Location = new System.Drawing.Point(9, 32);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(161, 63);
            this.WithdrawButton.TabIndex = 0;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButtonClicked);
            // 
            // BackSpaceButton
            // 
            this.BackSpaceButton.Location = new System.Drawing.Point(766, 392);
            this.BackSpaceButton.Name = "BackSpaceButton";
            this.BackSpaceButton.Size = new System.Drawing.Size(103, 91);
            this.BackSpaceButton.TabIndex = 18;
            this.BackSpaceButton.Text = "Backspace";
            this.BackSpaceButton.UseVisualStyleBackColor = true;
            this.BackSpaceButton.Click += new System.EventHandler(this.backSpaceClicked);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Location = new System.Drawing.Point(657, 392);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(103, 91);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.numberPadIsPressed);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(548, 392);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(103, 91);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.clearButtonClicked);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(766, 295);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(103, 91);
            this.Button9.TabIndex = 15;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.numberPadIsPressed);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(657, 295);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(103, 91);
            this.Button8.TabIndex = 14;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.numberPadIsPressed);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(548, 295);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(103, 91);
            this.Button7.TabIndex = 13;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.numberPadIsPressed);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(766, 198);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(103, 91);
            this.Button6.TabIndex = 12;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.numberPadIsPressed);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(657, 198);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(103, 91);
            this.Button5.TabIndex = 11;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.numberPadIsPressed);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(548, 198);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(103, 91);
            this.Button4.TabIndex = 10;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.numberPadIsPressed);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(766, 101);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(103, 91);
            this.Button3.TabIndex = 9;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.numberPadIsPressed);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(657, 101);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(103, 91);
            this.Button2.TabIndex = 8;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.numberPadIsPressed);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(548, 101);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(103, 91);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.numberPadIsPressed);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(116, 360);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 6;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(116, 392);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(194, 54);
            this.SignInButton.TabIndex = 5;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // PasscodeLabel
            // 
            this.PasscodeLabel.AutoSize = true;
            this.PasscodeLabel.Location = new System.Drawing.Point(116, 299);
            this.PasscodeLabel.Name = "PasscodeLabel";
            this.PasscodeLabel.Size = new System.Drawing.Size(57, 13);
            this.PasscodeLabel.TabIndex = 4;
            this.PasscodeLabel.Text = "Passcode:";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(116, 216);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomerIDLabel.TabIndex = 3;
            this.CustomerIDLabel.Text = "CustomerID:";
            // 
            // PasscodeTextBox
            // 
            this.PasscodeTextBox.Location = new System.Drawing.Point(116, 318);
            this.PasscodeTextBox.Name = "PasscodeTextBox";
            this.PasscodeTextBox.Size = new System.Drawing.Size(194, 20);
            this.PasscodeTextBox.TabIndex = 2;
            this.PasscodeTextBox.Click += new System.EventHandler(this.CustomerIDTextBox_TextChanged);
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(116, 235);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(194, 20);
            this.CustomerIDTextBox.TabIndex = 1;
            this.CustomerIDTextBox.Click += new System.EventHandler(this.CustomerIDTextBox_TextChanged);
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Segoe UI Black", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLabel.Location = new System.Drawing.Point(114, 101);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(196, 72);
            this.LogInLabel.TabIndex = 0;
            this.LogInLabel.Text = "Log In";
            this.LogInLabel.UseMnemonic = false;
            // 
            // InteractionPanel
            // 
            this.InteractionPanel.Controls.Add(this.EnterAmountLabel);
            this.InteractionPanel.Controls.Add(this.CButtonEnter);
            this.InteractionPanel.Controls.Add(this.CBackspaceButton);
            this.InteractionPanel.Controls.Add(this.CButtonZero);
            this.InteractionPanel.Controls.Add(this.CRButton);
            this.InteractionPanel.Controls.Add(this.CButton9);
            this.InteractionPanel.Controls.Add(this.CButton8);
            this.InteractionPanel.Controls.Add(this.CButton7);
            this.InteractionPanel.Controls.Add(this.CButton6);
            this.InteractionPanel.Controls.Add(this.CButton5);
            this.InteractionPanel.Controls.Add(this.CButton4);
            this.InteractionPanel.Controls.Add(this.CButton3);
            this.InteractionPanel.Controls.Add(this.CButton2);
            this.InteractionPanel.Controls.Add(this.CButton1);
            this.InteractionPanel.Controls.Add(this.CustomerAmountTextBox);
            this.InteractionPanel.Location = new System.Drawing.Point(518, 125);
            this.InteractionPanel.Name = "InteractionPanel";
            this.InteractionPanel.Size = new System.Drawing.Size(409, 420);
            this.InteractionPanel.TabIndex = 11;
            // 
            // CustomerAmountTextBox
            // 
            this.CustomerAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerAmountTextBox.Location = new System.Drawing.Point(80, 38);
            this.CustomerAmountTextBox.Name = "CustomerAmountTextBox";
            this.CustomerAmountTextBox.Size = new System.Drawing.Size(243, 20);
            this.CustomerAmountTextBox.TabIndex = 0;
            // 
            // CButton1
            // 
            this.CButton1.Location = new System.Drawing.Point(81, 64);
            this.CButton1.Name = "CButton1";
            this.CButton1.Size = new System.Drawing.Size(77, 71);
            this.CButton1.TabIndex = 1;
            this.CButton1.Text = "1";
            this.CButton1.UseVisualStyleBackColor = true;
            this.CButton1.Click += new System.EventHandler(this.customerNumberPadIsPressed);
            // 
            // CButton2
            // 
            this.CButton2.Location = new System.Drawing.Point(164, 64);
            this.CButton2.Name = "CButton2";
            this.CButton2.Size = new System.Drawing.Size(77, 71);
            this.CButton2.TabIndex = 2;
            this.CButton2.Text = "2";
            this.CButton2.UseVisualStyleBackColor = true;
            this.CButton2.Click += new System.EventHandler(this.customerNumberPadIsPressed);
            // 
            // CButton3
            // 
            this.CButton3.Location = new System.Drawing.Point(247, 64);
            this.CButton3.Name = "CButton3";
            this.CButton3.Size = new System.Drawing.Size(77, 71);
            this.CButton3.TabIndex = 3;
            this.CButton3.Text = "3";
            this.CButton3.UseVisualStyleBackColor = true;
            this.CButton3.Click += new System.EventHandler(this.customerNumberPadIsPressed);
            // 
            // CButton6
            // 
            this.CButton6.Location = new System.Drawing.Point(247, 141);
            this.CButton6.Name = "CButton6";
            this.CButton6.Size = new System.Drawing.Size(77, 71);
            this.CButton6.TabIndex = 6;
            this.CButton6.Text = "6";
            this.CButton6.UseVisualStyleBackColor = true;
            this.CButton6.Click += new System.EventHandler(this.customerNumberPadIsPressed);
            // 
            // CButton5
            // 
            this.CButton5.Location = new System.Drawing.Point(164, 141);
            this.CButton5.Name = "CButton5";
            this.CButton5.Size = new System.Drawing.Size(77, 71);
            this.CButton5.TabIndex = 5;
            this.CButton5.Text = "5";
            this.CButton5.UseVisualStyleBackColor = true;
            this.CButton5.Click += new System.EventHandler(this.customerNumberPadIsPressed);
            // 
            // CButton4
            // 
            this.CButton4.Location = new System.Drawing.Point(81, 141);
            this.CButton4.Name = "CButton4";
            this.CButton4.Size = new System.Drawing.Size(77, 71);
            this.CButton4.TabIndex = 4;
            this.CButton4.Text = "4";
            this.CButton4.UseVisualStyleBackColor = true;
            this.CButton4.Click += new System.EventHandler(this.customerNumberPadIsPressed);
            // 
            // CButton9
            // 
            this.CButton9.Location = new System.Drawing.Point(247, 218);
            this.CButton9.Name = "CButton9";
            this.CButton9.Size = new System.Drawing.Size(77, 71);
            this.CButton9.TabIndex = 9;
            this.CButton9.Text = "9";
            this.CButton9.UseVisualStyleBackColor = true;
            this.CButton9.Click += new System.EventHandler(this.customerNumberPadIsPressed);
            // 
            // CButton8
            // 
            this.CButton8.Location = new System.Drawing.Point(164, 218);
            this.CButton8.Name = "CButton8";
            this.CButton8.Size = new System.Drawing.Size(77, 71);
            this.CButton8.TabIndex = 8;
            this.CButton8.Text = "8";
            this.CButton8.UseVisualStyleBackColor = true;
            this.CButton8.Click += new System.EventHandler(this.customerNumberPadIsPressed);
            // 
            // CButton7
            // 
            this.CButton7.Location = new System.Drawing.Point(81, 218);
            this.CButton7.Name = "CButton7";
            this.CButton7.Size = new System.Drawing.Size(77, 71);
            this.CButton7.TabIndex = 7;
            this.CButton7.Text = "7";
            this.CButton7.UseVisualStyleBackColor = true;
            this.CButton7.Click += new System.EventHandler(this.customerNumberPadIsPressed);
            // 
            // CBackspaceButton
            // 
            this.CBackspaceButton.Location = new System.Drawing.Point(247, 295);
            this.CBackspaceButton.Name = "CBackspaceButton";
            this.CBackspaceButton.Size = new System.Drawing.Size(77, 71);
            this.CBackspaceButton.TabIndex = 12;
            this.CBackspaceButton.Text = "Bksp";
            this.CBackspaceButton.UseVisualStyleBackColor = true;
            this.CBackspaceButton.Click += new System.EventHandler(this.customerClearAndBackSpaceButtonClicked);
            // 
            // CButtonZero
            // 
            this.CButtonZero.Location = new System.Drawing.Point(164, 295);
            this.CButtonZero.Name = "CButtonZero";
            this.CButtonZero.Size = new System.Drawing.Size(77, 71);
            this.CButtonZero.TabIndex = 11;
            this.CButtonZero.Text = "0";
            this.CButtonZero.UseVisualStyleBackColor = true;
            this.CButtonZero.Click += new System.EventHandler(this.customerNumberPadIsPressed);
            // 
            // CRButton
            // 
            this.CRButton.Location = new System.Drawing.Point(81, 295);
            this.CRButton.Name = "CRButton";
            this.CRButton.Size = new System.Drawing.Size(77, 71);
            this.CRButton.TabIndex = 10;
            this.CRButton.Text = "CR";
            this.CRButton.UseVisualStyleBackColor = true;
            this.CRButton.Click += new System.EventHandler(this.customerClearAndBackSpaceButtonClicked);
            // 
            // CButtonEnter
            // 
            this.CButtonEnter.Location = new System.Drawing.Point(81, 372);
            this.CButtonEnter.Name = "CButtonEnter";
            this.CButtonEnter.Size = new System.Drawing.Size(242, 36);
            this.CButtonEnter.TabIndex = 13;
            this.CButtonEnter.Text = "Enter";
            this.CButtonEnter.UseVisualStyleBackColor = true;
            this.CButtonEnter.Click += new System.EventHandler(this.ReadAmountFromCustomerTextBox);
            // 
            // AlertPanel
            // 
            this.AlertPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AlertPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AlertPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlertPanel.Controls.Add(this.AlertOkButton);
            this.AlertPanel.Controls.Add(this.AlertLabel);
            this.AlertPanel.Location = new System.Drawing.Point(500, 245);
            this.AlertPanel.Name = "AlertPanel";
            this.AlertPanel.Size = new System.Drawing.Size(445, 187);
            this.AlertPanel.TabIndex = 12;
            // 
            // AlertLabel
            // 
            this.AlertLabel.AutoSize = true;
            this.AlertLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertLabel.Location = new System.Drawing.Point(37, 50);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(386, 44);
            this.AlertLabel.TabIndex = 0;
            this.AlertLabel.Text = "The transaction cannot be perform because the amount \r\nis greater than the curren" +
    "t balance";
            // 
            // EnterAmountLabel
            // 
            this.EnterAmountLabel.AutoSize = true;
            this.EnterAmountLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterAmountLabel.Location = new System.Drawing.Point(136, 9);
            this.EnterAmountLabel.Name = "EnterAmountLabel";
            this.EnterAmountLabel.Size = new System.Drawing.Size(131, 26);
            this.EnterAmountLabel.TabIndex = 14;
            this.EnterAmountLabel.Text = "Enter amount:";
            // 
            // AlertOkButton
            // 
            this.AlertOkButton.Location = new System.Drawing.Point(153, 115);
            this.AlertOkButton.Name = "AlertOkButton";
            this.AlertOkButton.Size = new System.Drawing.Size(147, 35);
            this.AlertOkButton.TabIndex = 1;
            this.AlertOkButton.Text = "OK";
            this.AlertOkButton.UseVisualStyleBackColor = true;
            this.AlertOkButton.Click += new System.EventHandler(this.oKButtonClicked);
            // 
            // ATM_Machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 592);
            this.Controls.Add(this.LogInPanel);
            this.Name = "ATM_Machine";
            this.Text = "Form1";
            this.LogInPanel.ResumeLayout(false);
            this.LogInPanel.PerformLayout();
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.AccountTableLayOut.ResumeLayout(false);
            this.InteractionPanel.ResumeLayout(false);
            this.InteractionPanel.PerformLayout();
            this.AlertPanel.ResumeLayout(false);
            this.AlertPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogInPanel;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label PasscodeLabel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.TextBox PasscodeTextBox;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button BackSpaceButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Button CheckBalanceButton;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Label BankNameLabel;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.TableLayoutPanel AccountTableLayOut;
        private System.Windows.Forms.ListBox AccountListBox;
        private System.Windows.Forms.Panel InteractionPanel;
        private System.Windows.Forms.Button CBackspaceButton;
        private System.Windows.Forms.Button CButtonZero;
        private System.Windows.Forms.Button CRButton;
        private System.Windows.Forms.Button CButton9;
        private System.Windows.Forms.Button CButton8;
        private System.Windows.Forms.Button CButton7;
        private System.Windows.Forms.Button CButton6;
        private System.Windows.Forms.Button CButton5;
        private System.Windows.Forms.Button CButton4;
        private System.Windows.Forms.Button CButton3;
        private System.Windows.Forms.Button CButton2;
        private System.Windows.Forms.Button CButton1;
        private System.Windows.Forms.TextBox CustomerAmountTextBox;
        private System.Windows.Forms.Button CButtonEnter;
        private System.Windows.Forms.Panel AlertPanel;
        private System.Windows.Forms.Label AlertLabel;
        private System.Windows.Forms.Label EnterAmountLabel;
        private System.Windows.Forms.Button AlertOkButton;
    }
}


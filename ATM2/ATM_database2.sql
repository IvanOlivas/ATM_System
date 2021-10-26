# Ivan Olivas
# CSC 340 Individual Project
# Database for ATM System

USE csc340;

# statements for dropping tables, in order based on constraintscsc340
DROP TABLE olivasTransaction;
DROP TABLE OlivasAccount;
DROP TABLE OlivasCustomerInfo;
DROP TABLE OlivasATMInformation;
DROP TABLE OlivasBank;

#  Customer Data
CREATE TABLE OlivasCustomerInfo(
	customerID		INT(9) PRIMARY KEY,
	NAME				VARCHAR(20),
	userName			VARCHAR(30),
	passCode			VARCHAR(4),
	address			VARCHAR(50),
	dateOfBirth		VARCHAR(30)
); 

# Account Data
CREATE TABLE OlivasAccount(
	accountNumber				INT(9) PRIMARY KEY,
	customerID					INT(9),
	accountType					VARCHAR(30),
	balance						DOUBLE,
	dailyTransactionTotal	DOUBLE,
	dailyTransactionLimit 	DOUBLE,
	dailyTransactionDate		DATE,
	pendingBalance				DOUBLE,
	CONSTRAINT CustomerID_FKey FOREIGN KEY (customerID) REFERENCES OlivasCustomerInfo(customerID) 
); 

# Bank Data
CREATE TABLE OlivasBank(
	bankID	INT(9) PRIMARY KEY,
	address	VARCHAR(60)
);

# ATMInformation Data
CREATE TABLE OlivasATMInformation(
	ATMnum					INT(9) PRIMARY KEY,
	bankID					INT(9),
	moneyStoredInMachine INT(9),
	location 				VARCHAR(35),
	CONSTRAINT BankID_FKey FOREIGN KEY (bankID) REFERENCES OlivasBank(bankID)
); 

# Transaction Data
CREATE TABLE OlivasTransaction(
	transactionNumber	INT(9) AUTO_INCREMENT PRIMARY KEY,
	amount				DOUBLE,
	transactionType	VARCHAR(25),
	sendingAccount		INT(9),
	recievingAccount 	INT(9),
	dateOfTransaction	DATETIME,
	accountNumber		INT(9),
	CONSTRAINT AccountNumber_FKey FOREIGN KEY (accountNumber) REFERENCES OlivasAccount(accountNumber)
);

# Querycollinscustomer
INSERT INTO olivascustomerinfo VALUES(111111111, 'Ivan Olivas', 'ivan_olivas', '1234', '1000 Heathcliff', '05/22/97');


#Insert data to olivasAccount
INSERT INTO olivasaccount VALUES(01,111111111,'Checking',2500.00,0.0,3000.0,'2021-04-15',100.0);
INSERT INTO olivasaccount VALUES(02,111111111,'Saving',10000.00,0.0,3000.0,'2021-04-15',1500.0);
INSERT INTO olivasaccount VALUES(03,111111111,'Saving',10000.00,2500.0,3000.0,'2021-04-20',1500.0);
INSERT INTO olivasaccount VALUES(04,111111111,'Saving',100.00,2900.0,3000.0,'2021-04-20',1500.0);
INSERT INTO olivasaccount VALUES(08,111111111,'Saving',120.00,3000.0,3000.0,'2021-04-21',1500.0);
SELECT * FROM olivasaccount WHERE customerID = 111111111;

UPDATE olivasaccount
SET dailyTransactionDate = '2021/04/15' WHERE customerID = 111111111 AND accountNumber = 7;

SELECT MAX(transactionNumber) FROM olivastransaction;
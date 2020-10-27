using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1WeekendHomeWork
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.Title = "The Bank of BOB";
            Console.WriteLine("Welcom to the bank of BOB");
            Console.WriteLine("Press the Y key to begin a transaction");
            string userStart = Console.ReadLine().ToUpper();
            Console.Clear();
            if (userStart == "Y")//if else branching
            {
                string accountNbr = "123456";//hard coded account number
                bool validAccount = true;
                Console.Write("Please enter your six digit account  number: ");
                string userAcctInput = Console.ReadLine();
                Console.Clear();

                if (userAcctInput == accountNbr)//while loop 
                {
                    validAccount = false;
                }//end if (account number)

                bool lockOut = true;
                int maxAttempts = 1;
                while (validAccount == true && lockOut == true) 
                {
                    Console.Write("Invalid account number, Please enter your account six digit number:  ");
                    string userAcctInput2 = Console.ReadLine();
                    Console.Clear();
                    if (userAcctInput2 == accountNbr)
                    {
                        validAccount = false;
                    }//end if (invalid account number)
                    else if (maxAttempts == 2)
                    {
                        Console.WriteLine("You have reached the maximum number of attemps.");
                        Console.Clear();
                        lockOut = false;
                    }//end else if (invalid account number the system will lock account)
                    else
                    {
                        maxAttempts = maxAttempts + 1;
                    }//end else (attempt counter)
                }//end while (account number)
                    string accountPin = "1234";//hard code PIN
                    bool validPIN = true;
                if (lockOut == true)
                {
                    Console.Write("Please enter your four digit PIN number: ");
                    string userPinInput = Console.ReadLine();
                    Console.Clear();

                    if (userPinInput == accountPin)//while loop 
                    {
                        validPIN = false;
                    }//end if (account pin)

                    int maxAttemptsPin = 1;
                    while (validPIN == true && lockOut == true)
                    {
                        Console.Write("Invalid PIN number, Please enter your four digit PIN number: ");
                        string userPinInput2 = Console.ReadLine();
                        Console.Clear();
                        if (userPinInput2 == accountPin)
                        {
                            validPIN = false;
                        }//end if (invalid pin)
                        else if (maxAttemptsPin == 2)
                        {
                            Console.WriteLine("You have reached the maximum number of attemps.");
                            Console.Clear();
                            lockOut = false;
                        }//end else if (lock out for 3 attempts at the PIN)
                        else
                        {
                            maxAttemptsPin = maxAttemptsPin + 1;
                        }//end else (PIN attempts counter)
                    }//end wihle (account pin)
                }//end if (lock out)
                if (lockOut == false)
                {
                    Console.WriteLine("Ending program");
                }//lock out for PIN / account
                
                if (validAccount == false && validPIN == false)
                {
                    decimal accTotal = 0;//account balance
                    bool anoutherTransaction = true;

                    do//do while loop 
                    {
                        Console.Title = string.Format($"Account Number {accountNbr}");//title change 

                        Console.WriteLine("Would you like to:\n" +
                            "Press 1 to make a Deposit\n" +
                            "Press 2 to make a Withdrawal\n" +
                            "Press 3 for Account Balance\n" +
                            "Press 4 to Exit");
                        ConsoleKey userTransInput = Console.ReadKey().Key;
                        Console.Clear();

                        switch (userTransInput)//branching with switches 
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Write("Enter the amount you will be Depositing: $ ");
                                decimal userDeposit = Convert.ToDecimal(Console.ReadLine());
                                accTotal += userDeposit;
                                Console.WriteLine("Thank you for your deposit of {0:c}, your acouunt balance is {1:c}", userDeposit, accTotal);
                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Write("Enter the amount you would like to Withdrawal: $ ");
                                decimal userWithdrawal = Convert.ToDecimal(Console.ReadLine());
                                accTotal -= userWithdrawal;
                                Console.WriteLine("You have withdrawn {0:c}, your account balance is {1:c}", userWithdrawal, accTotal);
                                break;

                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.WriteLine($"Account number {accountNbr} balance is {accTotal:c}");
                                break;

                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                anoutherTransaction = false;
                                break;

                            default:
                                Console.WriteLine(userTransInput + " is not valid choice. " +
                                    "Please choose again.");
                                break;

                        }//end switch (account Desosit,Withdrawal)

                    } while (anoutherTransaction);

                    Console.Clear();
                    Console.WriteLine($"Thank you for your business, account number {accountNbr} has a balance of {accTotal:c}");

                }//end if (for good username and password)

            }//end if (begin transaction)5
            else
            {
                Console.WriteLine("Thank you for visiting");
            }//end else (begin transaction)
        







        }//end Main()
    }//end class
}//end namespace

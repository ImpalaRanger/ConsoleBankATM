
using System;

namespace Main {
    class MainATM {

        public static void Main(string[] args) {
            Account acc = new Account(1, 100);
            int userInput = -1;

            // main program loop, terminates on user entry "5"
            do {

            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Account Information");
            Console.WriteLine("5. Exit");
            Console.Write("Enter an option as an integer: ");
            

            string input = Console.ReadLine();
            if (int.TryParse(input, out int inputVal)) {
                userInput = inputVal;
                // check account balance
                if (inputVal == 1) {
                    Console.WriteLine("Your current account balance is " + acc.getBalance());
                }
                // withdraws from account
                if (inputVal == 2) {
                    Console.Write("How much would you like to withdraw?: ");
                    string withdrawAmt = Console.ReadLine();
                    if (!string.IsNullOrEmpty(withdrawAmt)) {
                        if (int.TryParse(withdrawAmt, out int withdrawInt)) {
                            acc.setBalance(acc.getBalance() - withdrawInt);
                            Console.WriteLine(withdrawInt + " withdrawn.");
                            Console.WriteLine("Your new account balance is " + acc.getBalance());
                        }
                    }
                    else {
                        Console.WriteLine("You must enter a value.");
                    }
                }
                // deposits to account
                if (inputVal == 3) {
                    Console.Write("Enter the amount you would like to deposit: ");
                    string depositAmt = Console.ReadLine();
                    if (!string.IsNullOrEmpty(depositAmt)) {
                        if (int.TryParse(depositAmt, out int depositInt)) {
                            acc.setBalance(acc.getBalance() + depositInt);
                            Console.WriteLine(depositInt + " deposited.");
                            Console.WriteLine("Your new account balance is " + acc.getBalance());
                        }
                    }
                    else {
                        Console.WriteLine("You must enter a value.");
                    }
                }
                // returns date of account creation
                if (inputVal == 4) {
                    Console.WriteLine("Account was created " + acc.getDateCreated());
                }
            }
            else {
                Console.WriteLine("Not valid entry. Enter choice as an integer (1-5)");
                continue;
            }
            }
            while(userInput != 5);
            Console.WriteLine("System shutting down...");
        }
    }
}

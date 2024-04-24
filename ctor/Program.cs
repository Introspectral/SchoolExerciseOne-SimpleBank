using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;


namespace Banksystem
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int total_saldo = 0;
            Account[] accounts = new Account[11];
            Account a00 = new Account("",0);
            Account a01 = new Account("Account 1:       ", 0);
            Account a02 = new Account("Account 2:       ", 0);
            Account a03 = new Account("Account 3:       ", 0);
            Account a04 = new Account("Account 4:       ", 0);
            Account a05 = new Account("Account 5:       ", 0);
            Account a06 = new Account("Account 6:       ", 0);
            Account a07 = new Account("Account 7:       ", 0);
            Account a08 = new Account("Account 8:       ", 0);
            Account a09 = new Account("Account 9:       ", 0);
            Account a10 = new Account("Account 10:      ", 0);

            accounts[0] = a00;
            accounts[1] = a01;
            accounts[2] = a02;
            accounts[3] = a03;
            accounts[4] = a04;
            accounts[5] = a05;
            accounts[6] = a06;
            accounts[7] = a07;
            accounts[8] = a08;
            accounts[9] = a09;
            accounts[10] = a10;

            string[] menu = { "1: Deposit", "2: Withdraw", "3: List accounts","", "4: Quit"};

            do
            {
                Console.Clear();
                Console.WriteLine("Gringotts Wizarding Bank");
                Console.WriteLine("=---------=");

                for (int i = 0; i < menu.Length; i++)
                    {
                        Console.WriteLine(menu[i]);
                    }
                Console.Write("\n" + "> ");

                string menu_selection = Console.ReadLine();

                try
                {
                    switch (menu_selection)
                    {
                        case "1":// Deposit

                            var chosen_account_d = Methods.AccountSwitch(accounts);

                            Console.Clear();
                            Console.WriteLine($"Current Balance on {chosen_account_d.ID}    \n{chosen_account_d.Saldo}:-");
                            Console.WriteLine("=---------=");
                            Console.WriteLine($"Deposit ammount:");
                            Console.Write("> ");
                            string d_amt = Console.ReadLine();

                            chosen_account_d.Saldo += int.Parse(d_amt);
                            Console.Clear();
                            Console.WriteLine($"You deposited: \n{d_amt}:-\n=---------=" +
                                    $"\nCurrent Balance on {chosen_account_d.ID}    \n{chosen_account_d.Saldo}:-");
                            Console.ReadLine();
                            break;
                        case "2":// Withdraw

                            var chosen_account_w = Methods.AccountSwitch(accounts);

                            Console.Clear();
                            Console.WriteLine($"Current Balance on {chosen_account_w.ID}    \n{chosen_account_w.Saldo}:-");
                            Console.WriteLine("=---------=");
                            Console.WriteLine($"Withdraw ammount:");
                            Console.Write("> ");
                            string w_amt = Console.ReadLine();
                            if (int.Parse(w_amt) > chosen_account_w.Saldo)
                            {
                                Console.WriteLine("You can't withdraw more than your saldo.");
                                Console.ReadLine();
                                break;
                            }
                            else

                            {
                                chosen_account_w.Saldo -= int.Parse(w_amt);
                                Console.Clear();

                                Console.WriteLine($"You withdrew: \n{w_amt}:-\n=---------=\nCurrent Balance on {chosen_account_w.ID}    \n{chosen_account_w.Saldo}:-");
                                Console.ReadLine();
                                break;
                            }
                        case "3": // List Accounts
                            Console.Clear();
                            Console.WriteLine($"-= Account overview =-\n");
                            for (int i = 1; i < accounts.Length; i++)
                            {
                                Console.WriteLine(accounts[i].ID + accounts[i].Saldo);
                                total_saldo += accounts[i].Saldo;
                            }
                            Console.WriteLine($"=---------=\nTotal balance:   {total_saldo}:-");
                            Console.ReadLine();
                            break;

                        case "4": // Exit
                            Console.Clear();
                            Console.WriteLine("Quit");
                            return;
                    }
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Oväntat...");
                    Console.ReadLine();
                }
            } while (true);
        }
    }
}

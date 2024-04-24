namespace Banksystem
{
    internal class Methods
    {
        public static Account AccountSwitch(Account[] accounts)
        {
            Console.Clear();
            Console.WriteLine($"-= Account overview =-\n");
            for (int i = 1; i < accounts.Length; i++)
            {
                Console.WriteLine(accounts[i].ID + accounts[i].Saldo);
            }

            Console.WriteLine("=---------=");
            Console.WriteLine("Choose an account: ");
            Console.Write("> ");
            string acc_choice = Console.ReadLine();

            var account_selected = accounts[int.Parse(acc_choice)];
            return account_selected;

        }
    }
}
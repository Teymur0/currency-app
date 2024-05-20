internal class Program
{
    private static void Main(string[] args)
    {
        string[] availableCurrencies = ["USD", "TRY", "RUB"];
        decimal[] rates = [1.7m, 0.053m, 0.019m,];
        int index = 0;
        string[] availableCommands = ["show", "find", "calculate", "exit"];

        string userCommand;
        string findByCode;
        decimal amount;
        decimal convertedAmount;
        string selectedCurrency;
        bool terminateApp = false;

        while (!terminateApp)
        {
            Console.WriteLine("Select availabele commands");
            Console.WriteLine("--------------------------------");
            index = 0;
            while (index < availableCommands.Length)
            {
                //Console.WriteLine("*" + availableCommands[index]);
                if (index == 0)
                {
                    Console.WriteLine("Show currency rates:");
                    Console.WriteLine("*" + availableCommands[index]);
                    Console.WriteLine("=============================================");

                }
                else if (index == 1)
                {
                    Console.WriteLine("Find currency by rate:");
                    Console.WriteLine("*" + availableCommands[index]);
                    Console.WriteLine("=============================================");
                }
                else if (index == 2)
                {
                    Console.WriteLine("Calculate:");
                    Console.WriteLine("*" + availableCommands[index]);
                    Console.WriteLine("=============================================");
                }
                else if (index == 3)
                {
                    Console.WriteLine("Exit:");
                    Console.WriteLine("*" + availableCommands[index]);
                    Console.WriteLine("=============================================");
                }
                index++;
            }

            index = 0;


            Console.Write("Enter Command: ");
            userCommand = Console.ReadLine();
            if (userCommand == "show")
            {
                while (index < availableCurrencies.Length)
                {
                    Console.WriteLine(availableCurrencies[index] + " - " + rates[index]);
                    index++;

                }

            }
            else if (userCommand == "find")
            {

                Console.Write("Select currency code: ");
                findByCode = Console.ReadLine();
                bool found = false;

                while (index < availableCurrencies.Length)
                {

                    if (findByCode == availableCurrencies[index])
                    {
                        Console.WriteLine(availableCurrencies[index] + " - " + rates[index]);
                        found = true;
                        break;
                    }
                    index += 1;
                }

                if (!found)
                {
                    Console.WriteLine("Enter correct currency code: ");
                }

            }
            else if (userCommand == "exit")
            {
                Console.WriteLine("App was terminated");
                terminateApp = true;

            }
            else if (userCommand == "calculate")
            {
                Console.Write("Select Currency: ");
                selectedCurrency = Console.ReadLine();


                if (selectedCurrency == "USD")
                {
                    Console.Write("Enter amount: ");
                    amount = int.Parse(Console.ReadLine());
                    if (amount <= 0)
                    {
                        Console.WriteLine("Write right amount");

                    }
                    else
                    {
                        convertedAmount = amount / 1.7m;
                        Console.WriteLine(convertedAmount + " - " + selectedCurrency);
                    }
                }
                else if (selectedCurrency == "TRY")
                {
                    Console.Write("Enter amount: ");
                    amount = int.Parse(Console.ReadLine());
                    if (amount <= 0)
                    {
                        Console.WriteLine("Write right amount");

                    }
                    else
                    {
                        convertedAmount = amount / 0.053m;
                        Console.WriteLine(convertedAmount + " - " + selectedCurrency);
                    }
                }
                else if (selectedCurrency == "RUB")
                {
                    Console.Write("Enter amount: ");
                    amount = int.Parse(Console.ReadLine());
                    if (amount <= 0)
                    {
                        Console.WriteLine("Write right amount");

                    }
                    else
                    {
                        convertedAmount = amount / 0.019m;
                        Console.WriteLine(convertedAmount + " - " + selectedCurrency);
                    }
                }
                else
                {
                    Console.WriteLine("Select available currency");
                }



            }
            else
            {
                Console.WriteLine("Plese write the correct command");
            }


        }








    }
}
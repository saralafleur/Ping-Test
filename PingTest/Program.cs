using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingTest
{
    class Program
    {
        static public int DisplayMenu()
        {
            Console.WriteLine("Ping Test");
            Console.WriteLine(string.Format("Status: {0}", InternalPing.Status));
            Console.WriteLine();
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Stop");
            Console.WriteLine("3. Status");
            Console.WriteLine("4. Exit");
            Console.WriteLine("");
            Console.WriteLine("Select a Command and hit Enter...");
            var result = Console.ReadLine();
            bool isNumeric = int.TryParse(result, out int number);
            if (isNumeric)
                return number;
            return Convert.ToInt32(result);
        }


        static void Main(string[] args)
        {
            InternalPing.Status = "Idle";

            

            int userInput;
            do
            {

                userInput = DisplayMenu();

                switch (userInput)
                {
                    case 1:
                        InternalPing.Start();
                        break;
                    case 2:
                        InternalPing.Stop();
                        break;
                    case 3:
                        InternalPing.DisplayStatus();
                        break;
                }

            } while (userInput != 4);

        }
    }
}

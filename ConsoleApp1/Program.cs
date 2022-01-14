using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            int num1 = 0; int num2 = 0;
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            // Ask the user to type the first number.
            Console.WriteLine("Type a number (int), and then press Enter");
            //num1 = Convert.ToInt32(Console.ReadLine());
            num1 = ConvertNumberSafe(Console.ReadLine());
            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = ConvertNumberSafe(Console.ReadLine());

            //Ask the user to choose an option.
           Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }

        private static int ConvertNumberSafe(string entreeUtilisateur)
        {
            try
            {
                
                int pos = entreeUtilisateur.IndexOf(",");
                if (pos==-1)
                {
                    return Convert.ToInt32(entreeUtilisateur);
                }
                //string newNumber = entreeUtilisateur.Remove(pos);
                int longueur = entreeUtilisateur.Length;
                //12,3 --length = 4 ; pos = 2
                //3 car--"," position 1--
                string newString = entreeUtilisateur.Substring(0, pos);
                return Convert.ToInt32(newString);

            }
            catch (Exception ex)
            {
                //insert into Log + manage errors you know will occur often
                throw;
            }

        }
    }
}

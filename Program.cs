/*
 Övning 1: Skapa ett program som frågar användaren vilket land som vann fotbolls-VM för damer
år 2015. Om användaren svarar USA ska programmet skriva ut att svaret var rätt, annars ska
programmet skriva ut att svaret var fel. Det ska inte spela någon roll om användaren skriver
svaret med stora eller små bokstäver.
 */

namespace ifStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
                Console.Clear();
                Console.WriteLine("Can you answer this question?");
                Console.WriteLine("Who won soccer World Championship for women year 2015:");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "USA")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("***************************************************");
                    Console.WriteLine("***************************************************");
                    Console.WriteLine("********Congratulations! You are correct.**********");
                    Console.WriteLine("***************************************************");
                    Console.WriteLine("***************************************************");
                    Console.ForegroundColor= ConsoleColor.White;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry! Wrong answer...");
                    Console.ForegroundColor= ConsoleColor.White;
                    Thread.Sleep(2000);
                    continue;
                }
            }
        }
    }
}

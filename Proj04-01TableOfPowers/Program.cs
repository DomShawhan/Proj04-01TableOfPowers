namespace Proj04_01TableOfPowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter an Integer: ");
                int input = 0;

                if(!int.TryParse(Console.ReadLine(), out input)) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number.");
                    Console.ResetColor();
                    continue;
                }

                Console.WriteLine($"{"Number", -8} {"Squared", -8} {"Cubed", -8}");
                Console.WriteLine("======== ======== ========");

                for (int i = 1; i <= input; i++) 
                {
                    int squared = i * i;
                    int cubed = i * i * i;

                    Console.WriteLine($"{i, -8} {squared, -8} {cubed, -8}");
                }

                Console.Write("Continue? (y/n)");
                if(Console.ReadLine().ToLower() != "y") { break; }
            }



            Console.WriteLine("Bye!");
        }
    }
}

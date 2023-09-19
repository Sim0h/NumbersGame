namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allowedguess = 5;
            int numguess = 0;
            Random random = new Random();
            int Correctnum = random.Next(1, 20);
            Console.WriteLine("Gissa nummret!");

        Start:
            while (true)
            {
                try
                {


                    int guess = Convert.ToInt32(Console.ReadLine());
                    numguess++;
                    if (guess == Correctnum)
                    {
                        Console.WriteLine("Woho! Du gjorde det!");
                        break;

                    }
                    if (guess > Correctnum)
                    {
                        Console.WriteLine("Tyvärr, du gissade för högt! ");

                    }
                    if (guess < Correctnum)
                    {
                        Console.WriteLine("Tyvärr, du gissade för lågt! ");

                    }
                    if (numguess == allowedguess)
                    {
                        Console.Clear();
                        Console.WriteLine("Tyvärr lyckades du inte gissa talet på fem försök!");
                        Console.ReadKey();
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Vänligen skriv en siffra mellan 1 och 20.");
                    goto Start;
                }
            }
        }
    }
}
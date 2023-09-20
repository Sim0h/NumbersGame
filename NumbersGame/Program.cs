namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Gissa nummret!");
            RunGame();
        }

        public static void RunGame()
        {
        Start:
            int allowedguess = 5;
            int numguess = 0;
            Random random = new Random();
            int Correctnum = random.Next(1, 20);
            Console.WriteLine("jag tänker på ett nummer mellan 1 och 20. Du får 5 försök att gissa rätt!");
            bool spela = true;

            while (spela == true)
            {
            Game:
                try
                {

                    int guess = Convert.ToInt32(Console.ReadLine());
                    numguess++;
                    if (guess == Correctnum)
                    {
                        Console.WriteLine("Woho! Du gjorde det!");
                        Console.ReadKey();
                        spela = false;
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
                        spela = false;
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Vänligen skriv en siffra mellan 1 och 20.");
                    goto Game;
                }

            }
            while (spela == false)
            {

                Console.WriteLine("Vill  du spela igen? Skriv Ja eller Nej");
                string replay = Console.ReadLine().ToLower();


                switch (replay)
                {
                    case "ja":
                        Console.Clear();
                        goto Start;


                    case "nej":

                        Console.WriteLine("Ha en trevlig dag!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Vänligen skriv Ja eller Nej");
                        break;

                }

            }
        }

    }
}

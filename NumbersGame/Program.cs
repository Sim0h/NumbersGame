namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start:
            int allowedguess = 5;
            int numguess = 0;
            Random random = new Random();
            int Correctnum = random.Next(1, 20);
            Console.WriteLine("Gissa nummret!");
            bool spela = true;
        
            while (spela == true)
            {
                Start1:
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
                    goto Start1;
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
                       
                        
                    default:

                        Console.WriteLine("Ha en trevlig dag!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
                
                    
                
                
            }
        }

    }
}
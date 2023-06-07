class Projekt
{
    public static void Main()
    {
        try
        {
            int mojeSkore = 0, skoreNepritele = 0;
            string volba = "";
            Random random = new Random();
            while (true)
            {
                if (mojeSkore == 5 || skoreNepritele == 5) break;
                Console.Clear(); ;
                Console.WriteLine("Zadej volbu: Kámen, Nůžky nebo Papír.");
                volba = Console.ReadLine();
                switch (volba)
                {
                    case "Kámen" or "Nůžky" or "Papír": break;
                    default:
                        {
                            Console.WriteLine("Špatná volba, zmáčkni jakoukoli klávesu pro pokračování.");
                            Console.ReadKey();
                            continue;
                        }
                }
                int volbaProtivnika = random.Next(0, 3);
                if (volbaProtivnika == 0)
                {
                    Console.WriteLine("Protivník zvolil kámen.");
                    switch (volba)
                    {
                        case "Kámen":
                            Console.WriteLine("Remíza, nikdo nezískal bod.");
                            break;
                        case "Nůžky":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Prohrál si, protivník dostává bod.");
                            skoreNepritele++;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case "Papír":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vyhrál jsi, dostáváš bod.");
                            mojeSkore++;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }
                else if (volbaProtivnika == 1)
                {
                    Console.WriteLine("Protivník zvolil nůžky.");
                    switch (volba)
                    {
                        case "Kámen":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vyhrál jsi, dostáváš bod.");
                            mojeSkore++;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case "Nůžky":
                            Console.WriteLine("Remíza, nikdo nezískal bod.");
                            break;
                        case "Papír":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Prohrál si, protivník dostává bod.");
                            Console.ForegroundColor = ConsoleColor.White;
                            skoreNepritele++;
                            break;
                    }
                }
                else if (volbaProtivnika == 2)
                {
                    Console.WriteLine("Protivník zvolil papír");
                    switch (volba)
                    {
                        case "Kámen":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Prohrál si, protivník dostává bod.");
                            Console.ForegroundColor = ConsoleColor.White;
                            skoreNepritele++;
                            break;
                        case "Nůžky":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vyhrál jsi, dostáváš bod.");
                            Console.ForegroundColor = ConsoleColor.White;
                            mojeSkore++;
                            break;
                        case "Papír":
                            Console.WriteLine("Remíza, nikdo nezískal bod.");
                            break;
                    }
                }
                Console.ReadKey();
            }
            if (skoreNepritele++ == 5)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Prohrál jsi");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vyhrál jsi");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Špatně zadaná hodnota - zadej vstup znovu");
            Console.ForegroundColor = ConsoleColor.White;
        }



    }
}
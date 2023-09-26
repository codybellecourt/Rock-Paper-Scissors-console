using static System.Formats.Asn1.AsnWriter;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int computerChoice = 0;
            Random rng = new Random();
            string userInput = "0";
            string continuePlaying = "1";

            int userScore = 0;
            int cpuScore = 0;
            int tieScore = 0;

            do
            {
                Console.WriteLine("ROCK PAPER SCISSORS - By Cody Bellecourt\n\nScore" + "\nYou: " + userScore + "\nTie: " + tieScore + "\nComputer: " + cpuScore);
                Console.WriteLine("\n1 - Rock\n2 - Paper\n3 - Scissors\n");
                userInput = Console.ReadLine().ToUpper();
                computerChoice = rng.Next(1, 4);
                Console.Clear();

                if (userInput == "1" || userInput == "2" || userInput == "3")
                {
                    Console.WriteLine("ROCK PAPER SCISSORS - By Cody Bellecourt\n\nScore" + "\nYou: " + userScore + "\nTie: " + tieScore + "\nComputer: " + cpuScore);
                    if (userInput == "1")
                    {
                        Console.Write("\nYou chose: Rock");
                    }

                    if (userInput == "2")
                    {
                        Console.Write("\nYou chose: Paper");
                    }

                    if (userInput == "3")
                    {
                        Console.Write("\nYou chose: Scissors");
                    }

                    Thread.Sleep(250);
                    Console.Write("\nThe computer chose");
                    Thread.Sleep(250);
                    Console.Write(".");
                    Thread.Sleep(250);
                    Console.Write(".");
                    Thread.Sleep(250);
                    Console.Write(".");
                    Thread.Sleep(250);
                    Console.Clear();

                    Console.WriteLine("ROCK PAPER SCISSORS - By Cody Bellecourt\n\nScore" + "\nYou: " + userScore + "\nTie: " + tieScore + "\nComputer: " + cpuScore);
                    if (userInput == "1" && computerChoice == 1)
                    {
                        Console.WriteLine("\nYou chose: Rock\nThe computer chose: Rock");
                        Console.WriteLine("Tie!");
                        tieScore++;
                    }

                    if (userInput == "2" && computerChoice == 1)
                    {
                        Console.WriteLine("\nYou chose: Paper\nThe computer chose: Rock");
                        Console.WriteLine("You Win!");
                        userScore++;
                    }

                    if (userInput == "3" && computerChoice == 1)
                    {
                        Console.WriteLine("\nYou chose: Scissors\nThe computer chose: Rock");
                        Console.WriteLine("You Lose");
                        cpuScore++;
                    }

                    if (userInput == "1" && computerChoice == 2)
                    {
                        Console.WriteLine("\nYou chose: Rock\nThe computer chose: Paper");
                        Console.WriteLine("You lose");
                        cpuScore++;
                    }

                    if (userInput == "2" && computerChoice == 2)
                    {
                        Console.WriteLine("\nYou chose: Paper\nThe computer chose: Paper");
                        Console.WriteLine("Tie!");
                        tieScore++;
                    }

                    if (userInput == "3" && computerChoice == 2)
                    {
                        Console.WriteLine("\nYou chose: Scissors\nThe computer chose: Paper");
                        Console.WriteLine("You Win!");
                        userScore++;
                    }

                    if (userInput == "1" && computerChoice == 3)
                    {
                        Console.WriteLine("\nYou chose: Rock\nThe computer chose: Scissors");
                        Console.WriteLine("You Win!");
                        userScore++;
                    }

                    if (userInput == "2" && computerChoice == 3)
                    {
                        Console.WriteLine("\nYou chose: Paper\nThe computer chose: Scissors");
                        Console.WriteLine("You Lose");
                        cpuScore++;
                    }

                    if (userInput == "3" && computerChoice == 3)
                    {
                        Console.WriteLine("\nYou chose: Scissors\nThe computer chose: Scissors");
                        Console.WriteLine("Tie!");
                        tieScore++;
                    }


                    Thread.Sleep(1000);
                    Console.Write("\nPlay again?\n\n1 - Play Again\n2 - Quit\n\n");
                    continuePlaying = Console.ReadLine();

                    Console.Clear();

                    if (continuePlaying == "2")
                    {
                        Console.Write("Thank you for playing!\n\nFINAL SCORE\n" + userScore + " - " + tieScore + " - " + cpuScore);

                        if (userScore > cpuScore)
                        {
                            Console.Write("\n\nYOU WIN!");
                        }
                        if (userScore == cpuScore)
                        {
                            Console.Write("\n\nTie!");
                        }
                        if (userScore > cpuScore)
                        {
                            Console.Write("\n\nYou lose");
                        }

                        Console.Write("\n\n\nThis window will close automatically in 10 seconds");
                        Thread.Sleep(10000);
                    }
                }

            }
            while (continuePlaying == "1");


        }
    }
}
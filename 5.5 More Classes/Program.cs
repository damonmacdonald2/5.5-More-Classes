using System.Collections;
using System.Threading.Channels;

namespace _5._5_More_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer, keepPlaying;
            double balance = 100, bet;
            bool on;
            Die dieOne;
            Die dieTwo;
            dieOne = new Die();
            dieTwo = new Die();

            Console.WriteLine("Welcome to Ethan's Casino! What game would you like to play? Sike doesn't matter he makes you bet on the outcome of two die... So what would you like to bet on?");
            on = true;
            while (on=true) 
            { 
            Console.WriteLine("A)Double \nB)Not Double \nC)Odd \nD)Even \nPlease type the letter of the bet you want! ");
            answer = Console.ReadLine().ToLower();
            Console.WriteLine("How much would you like to bet?");
            bet = Convert.ToInt32(Console.ReadLine());
            if (bet > balance)
            {
                Console.WriteLine("You don't have that much to bet please try again!");
                bet = Convert.ToInt32(Console.ReadLine());

            }
            if (answer == "a")
            {
                Console.WriteLine("You're betting $" + bet + " on doubles! Let's see if your lucky or not.");
                dieOne.RollDie();
                Console.WriteLine(dieOne);
                dieOne.DrawRoll();
                dieTwo.RollDie();
                Console.WriteLine(dieTwo);
                dieTwo.DrawRoll();
                if (dieOne.Roll != dieTwo.Roll)
                {
                    balance = balance - bet;
                    Console.WriteLine("You Lost your bet... You now have $" + balance);
                }
                else if (dieTwo.Roll == dieOne.Roll)
                {
                    balance = balance + (2 * bet);
                    Console.WriteLine("You won!! You now have $" + balance);
                }

            }
            if (answer == "b")
            {
                Console.WriteLine("You're betting $" + bet + " on not doubles! Let's see if your lucky or not.");
                dieOne.RollDie();
                Console.WriteLine(dieOne);
                dieOne.DrawRoll();
                dieTwo.RollDie();
                Console.WriteLine(dieTwo);
                dieTwo.DrawRoll();
                if (dieOne.Roll == dieTwo.Roll)
                {
                    balance = balance - bet;
                    Console.WriteLine("You Lost your bet... You now have $" + balance);
                }
                else if (dieTwo.Roll != dieOne.Roll)
                {
                    balance = balance + (.5 * bet);
                    Console.WriteLine("You won!! You now have $" + balance);
                }

            }
            if (answer == "c")
            {
                Console.WriteLine("You're betting $" + bet + " on Odds! Let's see if your lucky or not.");
                dieOne.RollDie();
                Console.WriteLine(dieOne);
                dieOne.DrawRoll();
                dieTwo.RollDie();
                Console.WriteLine(dieTwo);
                dieTwo.DrawRoll();
                if (dieOne.Roll + dieTwo.Roll == 2 || dieOne.Roll + dieTwo.Roll == 4 || dieOne.Roll + dieTwo.Roll == 6 || dieOne.Roll + dieTwo.Roll == 8 || dieOne.Roll + dieTwo.Roll == 10 || dieOne.Roll + dieTwo.Roll == 12)
                {
                    Console.WriteLine("The outcome was " + (dieOne.Roll + dieTwo.Roll) + " which is an even number sorry!");
                    balance = balance - bet;
                    Console.WriteLine("You Lost your bet... You now have $" + balance);
                }
                else if (dieOne.Roll + dieTwo.Roll == 3 || dieOne.Roll + dieTwo.Roll == 5 || dieOne.Roll + dieTwo.Roll == 7 || dieOne.Roll + dieTwo.Roll == 9 || dieOne.Roll + dieTwo.Roll == 11)
                {
                    Console.WriteLine("The outcome was " + (dieOne.Roll + dieTwo.Roll) + " which is an odd number congrats!");
                    balance = balance + bet;
                    Console.WriteLine("You won!! You now have $" + balance);
                }

            }
            if (answer == "d")
            {
                Console.WriteLine("You're betting $" + bet + " on Evens! Let's see if your lucky or not.");
                dieOne.RollDie();
                Console.WriteLine(dieOne);
                dieOne.DrawRoll();
                dieTwo.RollDie();
                Console.WriteLine(dieTwo);
                dieTwo.DrawRoll();
                if (dieOne.Roll + dieTwo.Roll == 2 || dieOne.Roll + dieTwo.Roll == 4 || dieOne.Roll + dieTwo.Roll == 6 || dieOne.Roll + dieTwo.Roll == 8 || dieOne.Roll + dieTwo.Roll == 10 || dieOne.Roll + dieTwo.Roll == 12)
                {
                    Console.WriteLine("The outcome was " + (dieOne.Roll + dieTwo.Roll) + " which is an even number congrats!");
                    balance = balance + bet;
                    Console.WriteLine("You won!! You now have $" + balance);
                }
                else if (dieOne.Roll + dieTwo.Roll == 3 || dieOne.Roll + dieTwo.Roll == 5 || dieOne.Roll + dieTwo.Roll == 7 || dieOne.Roll + dieTwo.Roll == 9 || dieOne.Roll + dieTwo.Roll == 11)
                {
                    Console.WriteLine("The outcome was " + (dieOne.Roll + dieTwo.Roll) + " which is an odd number sorry!");
                    balance = balance - bet;
                    Console.WriteLine("You Lost your bet... You now have $" + balance);
                }

            }
            Console.WriteLine("Would you like to play again?");
            keepPlaying = Console.ReadLine().ToLower();
            if (keepPlaying == "yes" )
                {
                    on = true;
                }
            else if (keepPlaying == "no" )
                {
                    return;
                }
        }
        }
    }
}
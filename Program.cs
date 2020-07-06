using System;
using System.Collections.Generic;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Greetings Traveller");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            bool playing = true;
            Console.WriteLine($"{name} , would you like to play a game?(y/n)");
            while(playing)
            {
            char choice = Console.ReadKey().KeyChar;
            // playing = false;

            string[] choices = { "rock", "paper", "scissors"};
             
            Random rand = new Random();
            var wins = 0;
            var losses = 0;

            if (choice == 'y')
            {
            
            Console.WriteLine("\nYou have chosen to play me in 'rock paper scissors'. Foolish move.");
            Console.WriteLine($"Wins: {wins}   Losses: {losses}");
            Console.WriteLine("Make your Choice");
            Console.WriteLine(@"
            _______
        ---'   ____)
              (_____)
              (_____)                   ROCK
              (____)
        ---.__(___)     

             _______
        ---'    ____)____
                   ______)
                  _______)              PAPER
                 _______)
        ---.__________)

            _______
        ---'   ____)____
                  ______)
               __________)             SCISSORS
              (____)
        ---.__(___)
            ");
            string playerChoice = Console.ReadLine()
            ;
            int index = rand.Next(choices.Length);

                if(playerChoice == "rock" && index == 1)
                {
                    losses += 1;
                    Console.WriteLine("You thought a rock could defeat me?");
                    Console.WriteLine($"I chose {choices[index]}");
                    Console.WriteLine("Go home kid.  This is a Warrior's game."
                    );
                    Console.WriteLine($"Wins: {wins}   Losses: {losses}");
                    Console.WriteLine("Do you want to play again? (y/n)");
                    
                    
                }
                else if(playerChoice == "rock" && index == 2)
                {
                    Console.Clear();
                    wins += 1;
                    Console.WriteLine($"I chose {choices[index]}");
                    Console.WriteLine("I can't believe I have been beaten by you! I have to move far away because of my shame.");
                    Console.WriteLine($"Wins: {wins}   Losses: {losses}");
                    Console.WriteLine("Do you want to play again? (y/n)");
                }

                else if(playerChoice == "paper" && index == 0)
                {
                   Console.Clear();
                   wins += 1;
                   Console.WriteLine($"I chose {choices[index]}");
                   Console.WriteLine("You filthy swine! You won this one!"); 
                   Console.WriteLine("Do you want to play again? (y/n)");
                }

                else if (playerChoice == "paper" && index == 2)
                {
                    losses += 1;
                    Console.WriteLine($"I chose {choices[index]}");
                    Console.WriteLine("You just weren't meant to play this game.");
                    Console.WriteLine("Do you want to play again? (y/n)");
                }

                else if (playerChoice == "scissors" && index == 0)
                {
                    losses += 1;
                    Console.WriteLine($"I chose {choices[index]}");
                    Console.WriteLine("My rock has smashed your scissors. You Lose.");
                    Console.WriteLine("Do you want to play again? (y/n)");
                }

                 else if (playerChoice == "scissors" && index == 1)
                {
                    wins += 1;
                    Console.WriteLine($"I chose {choices[index]}");
                    Console.WriteLine("I have never lost to such a weakling.  Its about time I retire.");
                    Console.WriteLine("Do you want to play again? (y/n)");
                }
                
                else
                {
                    Console.WriteLine("We tied! It seems we are evenly Matched! Lets go again!");
                    Console.WriteLine("Do you want to play again? (y/n)");                
                };
            }

            else if(choice == 'n')
            {
            Console.WriteLine("\nYou coward.");
            playing = false;
            }

            else 
            {
            Console.WriteLine("\nChoose yes or no");
            }
            }
        }
    }
}

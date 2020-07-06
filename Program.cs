using System;
using System.Collections.Generic;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rock-Paper-Total-Destruction";
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("As you walk through the woods, you come upon a clearing.");
            Console.WriteLine("In the clearing is a mysterious cottage.");
            Console.WriteLine("An old mysterious comes out to greet you...");
            Console.Write(@"
            
    ) )        /\                                           
   =====      /  \
  _|___|_____/ __ \____________
 |::::::::::/ |  | \:::::::::::|
 |:::::::::/  ====  \::::::::::|
 |::::::::/__________\:::::::::|
 |_________|  ____  |__________|
  | ______ | / || \ | _______ |
  ||  |   || ====== ||   |   ||
  ||--+---|| |    | ||---+---||
  ||__|___|| |   o| ||___|___||
  |========| |____| |=========|
 (^^-^^^^^-|________|-^^^--^^^)
 (,, , ,, ,/________\,,,, ,, ,)
','',,,,' /__________\,,,',',;;
            ");
            Console.WriteLine("Greetings Traveller");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("What is your name?");
            Console.WriteLine("----------------------------------------");
            string name = Console.ReadLine();
            bool playing = false;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"{name} , would you like to play a game?(y/n)");
            var wins = 0;
            var losses = 0;
            while(!playing)
            {
            char choice = Console.ReadKey().KeyChar;
            // playing = true;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;

            string[] choices = { "rock", "paper", "scissors"};
             
            Random rand = new Random();

            if (choice == 'y')
            {
            Console.Clear();
            Console.WriteLine("\nYou have chosen to play me in 'rock paper scissors'. Foolish move.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Wins: {wins}   Losses: {losses}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Make your Choice");
            Console.WriteLine("----------------------------------------");
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
                    Console.Clear();
                    losses += 1;
                    Console.WriteLine(@"

            .`=-._.-=-.-=..-'\
             |                |
    .-._     |-.            ./
   /''  `.   |  `-._.--._.-' |  .-.
   |:.    `-./               |.`  .)
   \ `-._    `---..__..----._/   .'
    '-.._'-`-.-._    _..----.__.'
         `-.-..-.`--`   .-.  \
           'o/o`\  /     >)) /
           `-..-.( \    `-' |
   .----._.-`     .'     _).-.
  (           ) .`      _)/   `.
   `-._--._ -'.`    .-._).      \
        (_.-._)    / |  |        \
       (_          /_|   \        |
      (_           / |    `._/     \
     (_           _/ \      |      |
    (_           _)   |     /      |
    (_           _)    \    |      \
   (_            _)     `._ \      |
  (_           _)        |@ /_..--'
 (_           _)         |@  |   |
(_            _)         \   / ..\_
 (_           _)           .'_ '`. `-.
  (_        _)            (_/ ) \\\ \ \
    (_    _)                 (_/ /| /\_)
     (_.-_)                   (_/(_/                   


                    ");
                    Console.WriteLine("");
                    Console.WriteLine("You thought a rock could defeat me?");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"I chose {choices[index]}");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Go home kid.  This is a Warrior's game.");
                    Console.WriteLine("----------------------------------------");
                    
                    Console.WriteLine($"Wins: {wins}   Losses: {losses}");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Do you want to play again? (y/n)");
                    Console.WriteLine("----------------------------------------");
                    
                    
                }
                else if(playerChoice == "rock" && index == 2)
                {
                    Console.Clear();
                    wins += 1;
                                    Console.WriteLine(@"
              .`=-._.-=-.-=..-'\
             |                |
    .-._     |-.            ./
   /''  `.   |  `-._.--._.-' |  .-.
   |:.    `-./               |.`  .)
   \ `-._    `---..__..----._/   .'
    '-.._'-`-.-._    _..----.__.'
         `-.-..-.`--`   .-.  \
           'o/o`\  /     >)) /
           `-..-.( \    `-' |
   .----._.-`     .'     _).-.
  (           ) .`      _)/   `.
   `-._--._ -'.`    .-._).      \
        (_.-._)    / |  |        \
       (_          /_|   \        |
      (_           / |    `._/     \
     (_           _/ \      |      |
    (_           _)   |     /      |
    (_           _)    \    |      \
   (_            _)     `._ \      |
  (_           _)        |@ /_..--'
 (_           _)         |@  |   |
(_            _)         \   / ..\_
 (_           _)           .'_ '`. `-.
  (_        _)            (_/ ) \\\ \ \
    (_    _)                 (_/ /| /\_)
     (_.-_)                   (_/(_/                   


                    ");
                    Console.WriteLine("");
                    Console.WriteLine($"I chose {choices[index]}");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("I can't believe I have been beaten by you! I have to move far away because of my shame.");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Wins: {wins}   Losses: {losses}");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Do you want to play again? (y/n)");
                    Console.WriteLine("----------------------------------------");
                }

                else if(playerChoice == "paper" && index == 0)
                {
                   Console.Clear();
                   wins += 1;
                   Console.WriteLine("");
                   Console.WriteLine($"I chose {choices[index]}");
                   Console.WriteLine("----------------------------------------");
                   Console.WriteLine("You filthy swine! You won this one!"); 
                   Console.WriteLine("----------------------------------------");
                   Console.WriteLine("Do you want to play again? (y/n)");
                   Console.WriteLine("----------------------------------------");
                }

                else if (playerChoice == "paper" && index == 2)
                {
                    Console.Clear();
                    losses += 1;
                                    Console.WriteLine(@"
              .`=-._.-=-.-=..-'\
             |                |
    .-._     |-.            ./
   /''  `.   |  `-._.--._.-' |  .-.
   |:.    `-./               |.`  .)
   \ `-._    `---..__..----._/   .'
    '-.._'-`-.-._    _..----.__.'
         `-.-..-.`--`   .-.  \
           'o/o`\  /     >)) /
           `-..-.( \    `-' |
   .----._.-`     .'     _).-.
  (           ) .`      _)/   `.
   `-._--._ -'.`    .-._).      \
        (_.-._)    / |  |        \
       (_          /_|   \        |
      (_           / |    `._/     \
     (_           _/ \      |      |
    (_           _)   |     /      |
    (_           _)    \    |      \
   (_            _)     `._ \      |
  (_           _)        |@ /_..--'
 (_           _)         |@  |   |
(_            _)         \   / ..\_
 (_           _)           .'_ '`. `-.
  (_        _)            (_/ ) \\\ \ \
    (_    _)                 (_/ /| /\_)
     (_.-_)                   (_/(_/                   


                    ");
                    Console.WriteLine("");
                    Console.WriteLine($"I chose {choices[index]}");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("You just weren't meant to play this game.");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Do you want to play again? (y/n)");
                    Console.WriteLine("----------------------------------------");
                }

                else if (playerChoice == "scissors" && index == 0)
                {
                    Console.Clear();
                    losses += 1;
                                    Console.WriteLine(@"
              .`=-._.-=-.-=..-'\
             |                |
    .-._     |-.            ./
   /''  `.   |  `-._.--._.-' |  .-.
   |:.    `-./               |.`  .)
   \ `-._    `---..__..----._/   .'
    '-.._'-`-.-._    _..----.__.'
         `-.-..-.`--`   .-.  \
           'o/o`\  /     >)) /
           `-..-.( \    `-' |
   .----._.-`     .'     _).-.
  (           ) .`      _)/   `.
   `-._--._ -'.`    .-._).      \
        (_.-._)    / |  |        \
       (_          /_|   \        |
      (_           / |    `._/     \
     (_           _/ \      |      |
    (_           _)   |     /      |
    (_           _)    \    |      \
   (_            _)     `._ \      |
  (_           _)        |@ /_..--'
 (_           _)         |@  |   |
(_            _)         \   / ..\_
 (_           _)           .'_ '`. `-.
  (_        _)            (_/ ) \\\ \ \
    (_    _)                 (_/ /| /\_)
     (_.-_)                   (_/(_/                   


                    ");
                    Console.WriteLine("");
                    Console.WriteLine($"I chose {choices[index]}");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("My rock has smashed your scissors. You Lose.");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Do you want to play again? (y/n)");
                    Console.WriteLine("----------------------------------------");
                }

                 else if (playerChoice == "scissors" && index == 1)
                {
                    Console.Clear();
                    wins += 1;
                    Console.WriteLine("");
                    Console.WriteLine($"I chose {choices[index]}");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("I have never lost to such a weakling.  Its about time I retire.");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Do you want to play again? (y/n)");
                    Console.WriteLine("----------------------------------------");
                }
                
                else if (playerChoice == "rock" && index == 0)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("We tied! It seems we are evenly Matched! Lets go again!");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Do you want to play again? (y/n)");     
                    Console.WriteLine("----------------------------------------");
                }
                
                else if (playerChoice == "paper" && index == 1)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("We tied! It seems we are evenly Matched! Lets go again!");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Do you want to play again? (y/n)");     
                    Console.WriteLine("----------------------------------------");
                }

                else if (playerChoice == "scissors" && index == 2)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("We tied! It seems we are evenly Matched! Lets go again!");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Do you want to play again? (y/n)");     
                    Console.WriteLine("----------------------------------------");
                }
               
                else
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("That is not a move.");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Do you want to play or not? (y/n)");       
                    Console.WriteLine("----------------------------------------");         
                };
            }

            else if(choice == 'n')
            {
            playing = true;
            Console.WriteLine("\nYou coward.");
            Console.WriteLine("----------------------------------------");
            }

            else 
            {
            Console.WriteLine("\nChoose yes or no");
            Console.WriteLine("----------------------------------------");
            }
            }
        }
    }
}

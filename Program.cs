using System;

namespace Hello_World
{
    class Program
    {
        // Player stats
        static string name = "None";
        static string role = "None";
        static float health = -1;
        static float stamina = -1;
        static float strength = -1;
        static int level = -1;

        /// <summary>
        /// Prints the player stats to the console
        /// </summary>
        static void PrintPlayerStats()
        {
            Console.WriteLine();
            Console.WriteLine("Name:     " + name);
            Console.WriteLine("Role:     " + role);
            Console.WriteLine("Health:   " + health);
            Console.WriteLine("Stamina:  " + stamina);
            Console.WriteLine("Strength: " + strength);
            Console.WriteLine("Level:    " + level);
        }

        /// <summary>
        /// Prompts the player for input
        /// </summary>
        /// <param name="text">Text to display for the prompt</param>
        /// <returns>Player input</returns>
        static string Prompt(string text)
        {
            Console.WriteLine(text);
            Console.Write("> ");

            // Return the player's input in the console out of this function
            return Console.ReadLine();
        }

        /// <summary>
        /// Ask the player to choose between two options. Loops until input is valid
        /// </summary>
        /// <param name="description">Text to display for the prompt</param>
        /// <param name="option1">First choice</param>
        /// <param name="option2">Second choice</param>
        /// <returns>Player's choice</returns>
        static string PlayerChoice(string description, string option1, string option2)
        {
            // Create variable to store choice and initialize it to empty string
            string choice = "";

            // While choice is not equal to either option1 or option2
            while (choice != option1 && choice != option2)
            {
                // Prompt for input
                choice = Prompt(description);

                // If choice is not valid, list the choices
                if (choice != option1 && choice != option2)
                {
                    Console.Write("Invalid Input! Choices are: ");
                    Console.WriteLine(option1 + " or " + option2);
                }
            }

            // Return the player's choice out of the function
            return choice;
        }

        static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }

        static void GoblinFight()
        {
            // Goblin
            float goblinHealth = 10;
            float goblinStamina = 5;

            // Goblin fight
            while (health > 0 && goblinHealth > 0)
            {
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine("A wild Goblin appears!");

                // Add a line to separate rounds of combat
                Console.WriteLine("-----------------------------------");

                // Print player stats
                PrintPlayerStats();

                // Print goblin stats
                Console.WriteLine();
                Console.WriteLine("Goblin Health:   " + goblinHealth);
                Console.WriteLine("Goblin Stamina:  " + goblinStamina);

                string input = "";
                // Ask the player to Attack or Run
                input = PlayerChoice("Would you like to Attack or Run?", "Attack", "Run");

                // Check if the player said Attack or Run
                if (input == "Attack")
                {
                    // Damage the goblin
                    goblinHealth = goblinHealth - 5;

                    // Lower player stamina
                    stamina = stamina - 5;

                    Console.WriteLine("You did 5 damage to the Goblin!");
                }
                else if (input == "Run")
                {
                    Console.WriteLine("You ran away!");
                    PressAnyKeyToContinue();
                }


                if (input == "Run")
                {
                    break;
                }

                // Goblin attack

                // Damage the player
                health = health - 5;
                Console.WriteLine("The Goblin did 5 damage");

                if (goblinHealth <= 0)
                {
                    Console.WriteLine("You win!");
                }
                if (health <= 0)
                {
                    Console.WriteLine("You died!");
                }

                PressAnyKeyToContinue();
            }
        }


        static void Main(string[] args)
        {
            // Get the player name
            name = Prompt("What is your name?");

            
            // Get the player role
            role = PlayerChoice("What is your role?", "Knight", "Wizard");

            // If role is Knight, set our stats and skip the rest
            if (role == "Knight")
            {
                health = 100;
                stamina = 20;
                strength = 10;
                level = 1;
            }
            // If role is Wizard, set our stats and skip the rest
            else if (role == "Wizard")
            {
                health = 50;
                stamina = 10;
                strength = 5;
                level = 1;
            }

            // Print stats
            PrintPlayerStats();

            // Do goblin fight
            for (int i = 0; i < 3; i++)
            {
                GoblinFight();
            }
            

            // Second fight
        }
    }
}

using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            // Player stats
            string name = "None";
            string role = "None";
            float health = -1;
            float stamina = -1;
            float strength = -1;
            int level = -1;

            // Get the player name
            Console.WriteLine("What is your name?");
            Console.Write("> ");
            name = Console.ReadLine();

            // Loop while role is not Knight or Wizard
            while (role != "Knight" && role != "Wizard")
            {
                // Get the player role
                Console.WriteLine("What is your role?");
                Console.Write("> ");
                role = Console.ReadLine();

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
                // If our role is none of the above, say invalid input and loop again
                else
                {
                    Console.WriteLine("Invalid input. Choices are Knight or Wizard");
                }
            }

            // Print stats
            Console.WriteLine();
            Console.WriteLine("Name:     " + name);
            Console.WriteLine("Role:     " + role);
            Console.WriteLine("Health:   " + health);
            Console.WriteLine("Stamina:  " + stamina);
            Console.WriteLine("Strength: " + strength);
            Console.WriteLine("Level:    " + level);

            // Goblin
            Console.WriteLine();
            Console.WriteLine("A wild Goblin appears!");
            float goblinHealth = 10;
            float goblinStamina = 5;

            // Goblin fight
            while (health > 0 && goblinHealth > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Goblin Health:   " + goblinHealth);
                Console.WriteLine("Goblin Stamina:  " + goblinStamina);

                string input = "";
                while (input != "Attack" && input != "Run")
                {
                    // Ask the player to Attack or Run
                    Console.WriteLine("Would you like to Attack or Run?");
                    Console.Write("> ");
                    input = Console.ReadLine();

                    // Check if the player said Attack or Run
                    if (input == "Attack")
                    {
                        goblinHealth = goblinHealth - 5;
                        stamina = stamina - 5;

                        Console.WriteLine("You did 5 damage to the Goblin!");
                    }
                    else if (input == "Run")
                    {
                        Console.WriteLine("You ran away!");
                    }
                }

                if (input == "Run")
                {
                    break;
                }

                // Goblin attack
                health = health - 5;
                Console.WriteLine("The Goblin did 5 damage");
                Console.WriteLine("Health: " + health);

                if (goblinHealth <= 0)
                {
                    Console.WriteLine("You win!");
                }
                if (health <= 0)
                {
                    Console.WriteLine("You died!");
                }
            }


            // Second fight
        }
    }
}

using System;

namespace RPGInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== RPG TEXT GAME ===");

            Character player;

            Console.WriteLine("Wybierz klasę:");
            Console.WriteLine("[1] Warrior");
            Console.WriteLine("[2] Mage");
            Console.WriteLine("[3] Archer");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    player = new Warrior("Warrior");
                    break;

                case "2":
                    player = new Mage("Mage");
                    break;

                case "3":
                    player = new Archer("Archer");
                    break;

                default:
                    player = new Warrior("Warrior");
                    break;
            }

            Enemy enemy = new Enemy("Goblin");

            Console.WriteLine("\nRozpoczyna się walka!");

            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("\n====================");
                Console.WriteLine($"{player.Name} HP: {player.Health}");
                Console.WriteLine($"{enemy.Name} HP: {enemy.Health}");

                Console.WriteLine("\n[1] Atak");
                Console.Write("Wybierz akcję: ");

                string action = Console.ReadLine();

                if (action == "1")
                {
                    player.Attack(enemy);

                    if (enemy.Health > 0)
                    {
                        enemy.Attack(player);
                    }
                }
                else
                {
                    Console.WriteLine("Niepoprawna akcja.");
                }
            }

            Console.WriteLine("\n====================");

            if (player.Health > 0)
            {
                Console.WriteLine("Wygrałeś!");
            }
            else
            {
                Console.WriteLine("Przegrałeś!");
            }
        }
    }
}
using System;
using Pewaris;
using Pewarisan;

namespace Pewarisan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO INHERITANCE ===\n");

            Console.WriteLine("1. Membuat objek Warrior (dengan konstruktor berparameter)");
            Warrior warrior = new Warrior(50, "W-001", "Arthas", 100, "Stormwind");
            warrior.DisplayBaseData();

            Console.WriteLine("\n2. Membuat objek Mage (dengan konstruktor berparameter)");
            Mage mage = new Mage(80, "M-001", "Jaina", 90, "Dalaran");
            mage.DisplayData();

            Console.WriteLine("\n3. Membuat objek ArchMage (dengan konstruktor berparameter)");
            Archmage archMage = new Archmage(120, 80, "AM-001", "Khadgar", 110, "Karazhan");
            archMage.DisplayData();

            Console.WriteLine("\n4 Membuat objek Warrior dengan konstruktor default");
            Warrior defaultWarrior = new Warrior();
            defaultWarrior.DisplayBaseData();
            
            Console.ReadKey();
        }
    }
}
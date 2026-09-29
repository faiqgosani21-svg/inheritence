using System;
using System.Reflection.PortableExecutable;
using program;

namespace Pewaris
{
    public class Mage : Character
    {
        public int spellpower;
        public Mage()
        {
            Console.WriteLine("---> Konstruktor berparameter mage <---");
        }
        public Mage(int spellpower, string id, string name, int basePower, string address)
        : base(id, name, basePower, address)
        {
            Console.WriteLine("---> Konstreuktor berparameter mage <---");
            this.spellpower = spellpower;
        }
        public void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("SPELL POWER      =" + spellpower);
            Console.WriteLine("TOTAL POWER      = + spellpower");
            Console.WriteLine("=======================");
        }
    }
}
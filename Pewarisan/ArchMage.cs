using System;
using Pewaris;

namespace Pewarisan
{
    public class Archmage : Mage
    {
        public int ancientKnowledge;

        public Archmage()
        {
            Console.WriteLine("---> Konstrutor default ArchMage <---");
        }
        public Archmage(int ancientKnowledge, int spellPower, string id, string name, int basePower, string address)
        : base(spellPower, id, name, basePower, address)
        {
            Console.WriteLine("---> Konstruktor berparameter ArchMage");
            this.ancientKnowledge = ancientKnowledge;
        }
        public new void DisplayData()
        {
            base.DisplayData();
            Console.WriteLine("ANCIENT KNOWLEDGE =" + ancientKnowledge);
            Console.WriteLine("GRAND TOTAL POWER =" + (GetBasePower() + spellpower + ancientKnowledge));
            Console.WriteLine("=======================");
        }
    }
}
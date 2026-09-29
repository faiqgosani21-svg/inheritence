using System;
namespace program

{
    public class Character
    {
        private string? characterID;
        private string? name;
        private int basepower;
        private string?  address;

        public Character()
        {
            Console.WriteLine("---> Konstruktor default character <---");
        }
        public Character(string id, string name, int basePower, string address)
        {
            Console.WriteLine("---> Kontruktor berparameter Chacter <---");
            this.characterID = id;
            this.name = name;
            this.basepower = basePower;
            this.address = address;
        }
        public void DisplayBaseData()
        {
            Console.WriteLine("CHARACTERID =" + characterID);
            Console.WriteLine("NAME        =" + name);
            Console.WriteLine("BASE POWER  =" + basepower);
            Console.WriteLine("ADDRESS     =" + address);
        }
        public int GetBasePower()
        {
            return basepower;
        }
    }    
}

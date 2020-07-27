using System;
using System.Collections.Generic;

namespace Lab_5._1_RPG
{
    class GameCharacter
    {
        public string Name { get; set; }

        public int Strength { get; set; }

        public int Intelligence { get; set; }
        
        public GameCharacter(string thename, int thestrength, int theintelligence)
        {
            Name = thename;
            Strength = thestrength;
            Intelligence = theintelligence;
        }
        public virtual void Play()
        {
            Console.Write($"{Name} (strength {Strength}, int {Intelligence}) ");
        }
    }
    class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }
        public Warrior(string thename, int thestrength, int theintelligence, string theweapontype) : base(thename, thestrength, theintelligence)
        {
            WeaponType = theweapontype;
        }
        public override void Play()
        {
            base.Play();
            Console.Write(WeaponType);
            Console.WriteLine();
        }
    }
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }
        public MagicUsingCharacter(string thename, int thestrength, int theintelligence, int themagicalenergy) : base(thename, thestrength, theintelligence)
        {
            MagicalEnergy = themagicalenergy;
        }
        public override void Play()
        {
            base.Play();
        }


    }
    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }
        public Wizard(string thename, int thestrength, int theintelligence, int themagicalenergy, int thespellnumber) : base(thename, thestrength, theintelligence, themagicalenergy)
        {
            SpellNumber = thespellnumber;
        }
        public override void Play()
        {
            //base.Play();
            Console.Write($"{Name} (strength {Strength}, int {Intelligence}, magic {MagicalEnergy}) {SpellNumber} spells");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Welcome to World of Dev.Buildcraft!\n");

            List<GameCharacter> gameCharacters = new List<GameCharacter>();

            Warrior warrior1 = new Warrior("Tnarg the Barbarian", 16, 9, "Shortsword");
            warrior1.Play();

            Warrior warrior2 = new Warrior("Kincaid the Fighter", 15, 16, "Longsword");
            warrior2.Play();

            Warrior warrior3 = new Warrior("Grant the Viking", 15, 16, "Axe");
            warrior3.Play();

            Wizard wizard1 = new Wizard("Lady Witherell the Wizard", 11, 18, 10, 5);
            wizard1.Play();

            Wizard wizard2 = new Wizard("Pearl the Magician", 12, 17, 9, 4);
            wizard2.Play();
            
        }
    }
}

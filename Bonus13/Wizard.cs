using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    public class SubclassWizard : SubclassMagicUsingCharacter
    {
       
        public SubclassWizard(string Name, int strength, int intelligence, int MagicalEnergy, int spell) : base(Name, strength, intelligence, MagicalEnergy)
        {
            SpellNumber = spell;
        }

        public int  SpellNumber { get; }

        public override void Play()
        {
            Console.WriteLine("This characters spell strength is " + SpellNumber + " This character name is  " + CharacterName + " and the strength level is " + Strength + " the intelligence level is " + Intelligence);
          
        }

    }
}

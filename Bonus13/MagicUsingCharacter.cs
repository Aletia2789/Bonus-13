using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    public class SubclassMagicUsingCharacter : GameCharacter
    {
      
        public SubclassMagicUsingCharacter(string Name, int strength, int intelligence, int MagicalEnergy) : base( Name, strength, intelligence)
        {
            Magic = MagicalEnergy;

        }
       
        public int Magic { get; }

        public override void Play() 
        {
            Console.WriteLine("This character name is  " + CharacterName + " and the strength level is " + Strength + " the intelligence level is " + Intelligence +
            " The Magical Energy Level is " + Magic);
        }


    }
}

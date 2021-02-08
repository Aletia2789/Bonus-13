using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    public class SubclassWarrior : GameCharacter
    {
      
        public SubclassWarrior(string Name, int strength, int intelligence, string weapon) : base (Name, strength, intelligence)
        {
            WeaponType = weapon;
        }

        public string WeaponType { get;}

        public override void Play() 
        {
            Console.WriteLine("This character name is  " + CharacterName + " and the strength level is " + Strength + " the intelligence level is " + Intelligence +
            " The weapong type is " + WeaponType);

        }


    }
}

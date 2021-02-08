using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    public class GameCharacter
    {
        

        public GameCharacter(string Name, int strength, int intelligence)
        {
            CharacterName = Name;
            Strength = strength;
            Intelligence = intelligence;

        }

        public int Strength { get;}
        public string CharacterName { get;}
        public int Intelligence { get;}

        public virtual void Play()
            {

            Console.WriteLine("This character name is  " + CharacterName +" and the strength level is " + Strength + " the intelligence level is " + Intelligence);
          
            }
    
    }

  
        
    
}

using System;

namespace Bonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter gameCharacter = new GameCharacter("John", 98, 75);
            gameCharacter.Play();


            GameCharacter[] gameCharacters;
            gameCharacters = new GameCharacter[5];
            gameCharacters[0] = new SubclassWarrior("Dave", 100, 60, "sword");
            gameCharacters[1] = new SubclassWarrior("Paul", 100, 60, "broad sword");
            gameCharacters[2] = new SubclassWizard("Steven", 60, 100, 80, 75);
            gameCharacters[3] = new SubclassWizard("Chris", 60, 100, 80, 75);
            gameCharacters[4] = new SubclassWizard("Ollie", 60, 100, 80, 75);

            for (int i = 0; i < gameCharacters.Length; i++)
            {
                gameCharacters[i].Play();
            }


        }
    }
}
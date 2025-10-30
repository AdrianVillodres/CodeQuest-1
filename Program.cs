using System;

class Program
{
    static void Main()
    {
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";
        const string IntroductionMessageC1 = "Hey you! You're finally awake. Rise and shine! Its your first day in the academy. You will learn about the arcane arts and alchemy. But first things first, what's your name?";
        const string TrainingMessageC1 = "Alright! Let's go. Before you can go outside the academy, you must train your mind and spells. So you will need to meditate for 5 days. I recommend you do it from 1 to 10 hours, the choice is yours. See you in five days. Good luck!";
        const string TrainingCompleteMessageC1 = "Hello! I came back to see how you are doing and evaluate your power. Let me see through your soul...";
        const string TrainingResultMessageC1_1 = "Wow, I'm surpirsed, I've seen scarecrows with more power than you. You need to leave the academy because your range is...";
        const string TrainingResultMessageC1_2 = "Now, that's progress, it's small though. By now you only can summon little familiars or throw a couple of embers. Your range shall be...";
        const string TrainingResultMessageC1_3 = "I'm quite impressed, you done it pretty well. You can summon dragons or throw a fire blasts. You are a...";
        const string TrainingResultMessageC1_4 = "Tha-That's impossible. You are even stronger than the Great Mage! You are a natural! You can do Anything, summon deities, manipulate the minds of your enemies, create real ilusions or create hellfire or permafrost! There's anything I can teach you. You will be...";
        const string MageLevel1 = "The weakest weapon of humanity";
        const string MageLevel2 = "Necromancer";
        const string MageLevel3 = "Elarion of flames";
        const string MageLevel4 = "Demise of Inferno";

        int op = 0;
        int power = 0;
        int randNum;
        bool validInput;
        var rand = new Random();

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            validInput = true;

            try
            {
                op = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }

            if (validInput)
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine(IntroductionMessageC1);
                        string playerName = Console.ReadLine();
                        Console.WriteLine($"Welcome to the academy, {playerName}!");
                        Thread.Sleep(1000);
                        Console.WriteLine(TrainingMessageC1);
                        Thread.Sleep(3000);
                        for (int ctr = 0; ctr <= 4; ctr++)
                        {
                            randNum = rand.Next(1, 11);
                            power += randNum;
                            Console.WriteLine($"Today I meditated for {randNum} hours! My power might increase to {power}!");
                            Thread.Sleep(1000);
                        }
                        Console.WriteLine(TrainingCompleteMessageC1);
                        Thread.Sleep(2000);
                        if (power < 20)
                        {
                            Console.WriteLine(TrainingResultMessageC1_1);
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine(MageLevel1);
                            Thread.Sleep(1000);
                            Console.WriteLine();
                        }
                        else if (power >= 20 && power < 35)
                        {
                            Console.WriteLine(TrainingResultMessageC1_2);
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine(MageLevel2);
                            Thread.Sleep(1000);
                            Console.WriteLine();
                        }
                        else if (power >= 35 && power < 47)
                        {
                            Console.WriteLine(TrainingResultMessageC1_3);
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine(MageLevel3);
                            Thread.Sleep(1000);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine(TrainingResultMessageC1_4);
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine(MageLevel4);
                            Thread.Sleep(1000);
                            Console.WriteLine();
                        }
                        break;


                }
            }


        } while (op != 0);
    }
}
using System;

namespace htc_final_project_masaryk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the Mad Lib generator!");

            Console.WriteLine("Do You want to play (y or n)? ");

            string Answer = Console.ReadLine();

            while (Answer == "y")
            {
   
             PickingForMadLib();
            }
        }

        public static void PickingForMadLib()
        {
            Console.WriteLine("Give me a noun-");

            string Noun1 = Console.ReadLine();

            Console.WriteLine("Give me an adjective-");

            string Adjective1 = Console.ReadLine();

            Console.WriteLine("Give me a noun-");

            string Noun2 = Console.ReadLine();

            Console.WriteLine("Give me an animal-");

            string Animal1 = Console.ReadLine();

            Console.WriteLine("Give me a Mode of Transportaion-");

            string ModeOfTransportaion1 = Console.ReadLine();

            Console.WriteLine("Give me a adjective-");

            string Adjective2 = Console.ReadLine();

            Console.WriteLine("Give me a noun-");

            string Noun3 = Console.ReadLine();

            Console.WriteLine("Give me a number-");

            string Number1 = Console.ReadLine();

            Console.WriteLine("Give me a Verb ending in ING-");

            string VerbING1 = Console.ReadLine();

            Console.WriteLine("Give me a body part-");

            string BodyPart1 = Console.ReadLine();

            Console.WriteLine("Give me an adjective-");

            string Adjective3 = Console.ReadLine();

            Console.WriteLine("Give me a food-");

            string Food1 = Console.ReadLine();

            Console.WriteLine("Give me an adjective-");

            string Adjective4 = Console.ReadLine();

            Console.WriteLine("Give me an adjective-");

            string Adjective5 = Console.ReadLine();

            Console.WriteLine("Give me an animal-");

            string Animal2 = Console.ReadLine();

            Console.WriteLine("Give me a verb-");

            string Verb1 = Console.ReadLine();

            MadLib(Noun1, Adjective1, Noun2, Animal1, ModeOfTransportaion1, Adjective2, Noun3, Number1, VerbING1, BodyPart1, Adjective3, Food1, Adjective4, Adjective5, Animal2, Verb1);


               
        }

        public static void MadLib(string Nou1, string Adj1, string Nou2, string Anim1, string MOD1, string Adj2, string Nou3, string Num1, string VING1, string BP1, string Adj3, string F1, string Adj4, string Adj5, string Anim2, string V1)
        {
            Console.WriteLine("You deciding to go camping in", Nou1, "forest. You are very", Adj1,  "because it is your first time");
            Console.WriteLine("going camping alone. You decide to start packing. The nesesities for this camping trip are food,",Nou2);
            Console.WriteLine("water, and",Anim1,"spray. You are now ready for this trip. You get in you",MOD1,"and head");
            Console.WriteLine("off. You make it to the forest and you step onto the",Adj2,"gound. You decide to set up camp near");
            Console.WriteLine("the",Nou3,"It takes you",Num1,"minutes to set up camp. You decide to go",VING1,"in the lake. When you");
            Console.WriteLine("get to the lake you test the water with your",BP1, ". You conclude that the water is too",Adj3, "to go");
            Console.WriteLine("swimming so you head back to camp. When you get back, you decide to make a fire and roast",F1,". The");
            Console.WriteLine("food is",Adj4,". When you are eating you hear a",Adj5,"sound. You turn to see a giant",Anim2,"You");
            Console.WriteLine("scream and",V1,"away. You jump in your",MOD1,"and drive off and decide to NEVER GO CAMPING AGAIN!!!");
        }
    }
}

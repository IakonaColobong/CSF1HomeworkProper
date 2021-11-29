using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            string[] answers = new string[20];
            Console.WriteLine("for the upcoming Mad Lib, answer the following twenty questions as they appear:\n\n");
            Console.WriteLine("An ADJECTIVE is a word or phrase naming an attribute, added to or\n" +
                "grammatically related to a noun to modify or describe it.\n" +
                 "i.e. windy, silly, etc. \n" +
                 "A NOUN is a person place or thing\n" +
                 "A VERB describes an action." +
                 "\n\n");

            Console.Write("Enter an adjective.  ");
            answers[0] = Console.ReadLine();
            Console.Write("Enter a second adjective.  ");
            answers[4] = Console.ReadLine();
            Console.Write("Enter a third adjective.  ");
            answers[5] = Console.ReadLine();
            Console.Write("Enter an fourth adjective.  ");
            answers[6] = Console.ReadLine();
            Console.Write("Enter a fifth  adjective.  ");
            answers[9] = Console.ReadLine();
            Console.Write("Enter a sixth and final adjective.  ");
            answers[19] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Now for the nouns.\n Please enter a noun.");
            answers[1] = Console.ReadLine();
            Console.WriteLine("Enter another noun.");
            answers[11] = Console.ReadLine();
            Console.WriteLine("Enter a third noun.");
            answers[12] = Console.ReadLine();
            Console.WriteLine("Enter a fourth noun.");
            answers[15] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Name a place.");
            answers[2] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Name an article of clothing you like.");
            answers[3] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is the title of your favorite song?");
            answers[7] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Name a food item.");
            answers[8] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Now for three past tense verbs, what is your first one?");
            answers[10] = Console.ReadLine();
            Console.WriteLine("And what is the second past tense verb?");
            answers[13] = Console.ReadLine();
            Console.WriteLine("What is your third past tense verb?");
            answers[14] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("And finally, three verbs. What is your first verb?");
            answers[16] = Console.ReadLine();
            Console.WriteLine("The second verb?");
            answers[17] = Console.ReadLine();
            Console.WriteLine("And the final verb?");
            answers[18] = Console.ReadLine();
            Console.WriteLine();

           
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Now for the story of the Mad Lib Camping Trip:\n\n"));
            Console.WriteLine($"It was a {answers[0]} fall evening. {answers[1]} and I were excited to go camping at {answers[2]}.");
            Console.WriteLine($"This would be my first time going there. I packed my favorite {answers[3]}.");
            Console.WriteLine($"It is {answers[4]} and {answers[5]}, PERFECT for camping");
            Console.WriteLine($"We drove our {answers[6]} van to the campsite while listening to {answers[7]} the whole way");
            Console.WriteLine($"It was a long drive with a lot of repeat songs, but worth it!");
            Console.WriteLine($"Once there and unpacked, I could smell the {answers[8]} cooking... it smelled {answers[9]}." );
            Console.WriteLine($"I {answers[10]} to the rooom I was sharing with {answers[11]}.");
            Console.WriteLine($"The next thing I knew, {answers[12]} burst into the room {answers[13]} 'GET OFF THE BED!!'");
            Console.WriteLine($"I {answers[14]} outside. I saw {answers[15]} it was {answers[16]}. ");
            Console.WriteLine($"Over the next few days I got to {answers[17]} and {answers[18]}.");
            Console.WriteLine($"All in all, the camping trip was {answers[19]}.\n\n\n");










        }//end MAIN()
    }//end CLASS
}//end NAMESPACE

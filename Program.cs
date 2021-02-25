using System;

namespace Lesson_2_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Mad Libs!\n"); // title

            Console.WriteLine("What's your name?\n"); // collecting variables
            var name = Console.ReadLine();
            name = name.Trim();

            Console.WriteLine($"\nNice to meet you, {name}! Now I'm going to ask you for a series of words; they'll help me tell a story. Be creative!\n");
            Console.WriteLine("To start with, I need an adverb, a word that describes how something is done.\n");
            var adverb = Console.ReadLine();
            adverb = adverb.Trim();
            adverb = adverb.ToLower();

            Console.WriteLine($"\nNicely done, {name}! Now give me an adjective, a describing word.\n");
            var adjective1 = Console.ReadLine();
            adjective1 = adjective1.Trim();
            adjective1 = adjective1.ToLower();

            Console.WriteLine($"\nThanks, {name}! Alright, now I need the name of an object.\n");
            var weapon = Console.ReadLine();
            weapon = weapon.Trim();
            weapon = weapon.ToLower();

            Console.WriteLine($"\n{weapon}, huh? Give me another adjective.\n");
            var adjective2 = Console.ReadLine();
            adjective2 = adjective2.Trim();
            adjective2 = adjective2.ToLower();

            Console.WriteLine($"\n{adjective2}, great! One last adjective, please!\n");
            var adjective3 = Console.ReadLine();
            adjective3 = adjective3.Trim();
            adjective3 = adjective3.ToLower();

            // using variables in an interpolated string
            Console.WriteLine("\nAnd that's all I need! Let's have a look at your finished game!\n");
            Console.WriteLine($"{name} crept {adverb} through the {adjective1} passage, {weapon} at the ready. \n{name}'s senses were on high alert; {adjective2} voices drifted through the {adjective3} air towards them.\n");
            Console.WriteLine($"That was fun! Thanks for playing, {name}! See you next time!");
        }
    }
}

﻿using System;

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
            adverb = adverb.Trim().ToLower();

            Console.WriteLine($"\nNicely done, {name}! Now give me an adjective, a describing word.\n");
            var adjective1 = Console.ReadLine();
            adjective1 = adjective1.Trim().ToLower();

            Console.WriteLine($"\nThanks, {name}! Alright, now I need the name of an object.\n");
            var weapon = Console.ReadLine();
            weapon = weapon.Trim();
            var weapon1st = weapon.Substring(0,1).ToUpper();
            var weapon2nd = weapon.Substring(1).ToLower();
            var weaponInstruct = weapon1st + weapon2nd;
            weapon = weapon.ToLower();


            Console.WriteLine($"\n{weaponInstruct}, huh? Give me another adjective.\n");
            var adjective2 = Console.ReadLine();
            adjective2 = adjective2.Trim();
            var adjective21st = adjective2.Substring(0,1).ToUpper();
            var adjective22nd = adjective2.Substring(1).ToLower();
            var adjective2Instruct = adjective21st + adjective22nd;
            adjective2 = adjective2.ToLower();

            Console.WriteLine($"\n{adjective2Instruct}, great! One last adjective, please!\n");
            var adjective3 = Console.ReadLine();
            adjective3 = adjective3.Trim().ToLower();

            // using variables in an interpolated string
            Console.WriteLine("\nAnd that's all I need! Let's have a look at your finished game!\n");
            Console.WriteLine($"{name} crept {adverb} through the {adjective1} passage, {weapon} at the ready. \n{name}'s senses were on high alert; {adjective2} voices drifted through the {adjective3} air towards them.\n");
            Console.WriteLine($"That was fun! Thanks for playing, {name}! See you next time!");
        }
    }
}

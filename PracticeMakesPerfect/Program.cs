﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMakesPerfect
{
    class Program
    {
        Logic logic = new Logic();
        GuessingGame game = new GuessingGame();
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        void Run()
        {
            //game.NewGame();
            //logic.Swapper(-3, 4);
            //logic.CheckStringForEnglishLetters("ab%cDEF{}Ghijk");
            Console.ReadKey();
        }
    }
}

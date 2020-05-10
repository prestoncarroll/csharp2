using System;

namespace csharp2 {

    class Program {
        static void Main (string[] args) {

            //------------------------------------------------------------
            // var season = Season.Autumn;
            // switch (season) {
            //     case Season.Autumn:
            //         System.Console.WriteLine ("beautiful");
            //         break;
            //     case Season.Summer:
            //         System.Console.WriteLine ("its hot");
            //         break;
            //     default:
            //         System.Console.WriteLine ("idk what season it is");
            //         break;

            // }
            //-------------------------------------------------
            //     bool isGoldCustomer = true;
            //     double price = (isGoldCustomer) ? 20.99 : 25.99;

            //     System.Console.WriteLine (price);

            //     //---------------------------------------------
            //     int hour = 18;

            //     if (hour > 0 && hour < 12) {
            //         System.Console.WriteLine ("goodmorning");
            //     } else if (hour >= 12 && hour < 18) {
            //         System.Console.WriteLine ("its afternoon");
            //     } else {

            //         Console.WriteLine ("its evening");
            //     }
            // }

            System.Console.WriteLine ("enter a number 1 through 10");

            var userNum = Convert.ToInt32(Console.ReadLine ());

            // Convert.ToInt32 (userNum);

            if (userNum >= 1 && userNum <= 10) {
                System.Console.WriteLine ("valid");
            } else {
                System.Console.WriteLine ("not a valid number");
            }

        }
    }
}
using System;
using System.Collections.Generic;

namespace csharp2
{

    class Program
    {
        static void Main(string[] args)
        {

            var dateTime = new DateTime(2020, 5, 3);
            var now = DateTime.Now;
            var today = DateTime.Today;
            System.Console.WriteLine(now.Hour);
            System.Console.WriteLine(dateTime);
            System.Console.WriteLine(now.Minute);


            var tomorrow = now.AddDays(1); //tomorrow
            var yesterday = now.AddDays(-1); //yesterday


            System.Console.WriteLine(now.ToLongDateString());
            System.Console.WriteLine(now.ToString("yyyy-MM-dd"));

            //----------------------------------------------------------
            // var numbers = new List<int>(){1, 2, 3, 4};

            // numbers.Add(1);
            // numbers.AddRange(new int[3]{5, 6, 7});


            // foreach (var t in numbers)
            // System.Console.WriteLine(t);


            //-----------------------------------------------------------
            // var numbers = new[] { 3, 5, 6, 9, 1, 3 };
            // //Length
            // System.Console.WriteLine(numbers.Length);

            // //--------------------------------------IndexOf()
            // var index = Array.IndexOf(numbers, 9);
            // System.Console.WriteLine(index);

            // //-------------------------------------- Clear()
            // Array.Clear(numbers, 0, 2);

            // System.Console.WriteLine("Effect of Clear()");
            // foreach (var n in numbers)
            //     System.Console.WriteLine(n);


            // //--------------------------------------COPY()
            // int[] another = new int[3];
            // Array.Copy(numbers, another, 3);

            // System.Console.WriteLine("effect of copy()");
            // foreach (var n in another)
            // System.Console.WriteLine(n);


            // //--------------------------------------Sort()

            // Array.Sort(numbers);

            // System.Console.WriteLine("effect of Sort()");
            // foreach (var n in numbers)
            // System.Console.WriteLine(n);


            // //--------------------------------Reverse()

            // Array.Reverse(numbers);

            // System.Console.WriteLine("effect of reverse()");
            // foreach (var n in numbers)
            // System.Console.WriteLine(n);





            //----------------------------RANDOM NUMBERS THROUGH LOOP

            // var random = new Random();
            // for (int i = 0; i < 10; i++)
            // {
            //     System.Console.WriteLine(random.Next(97, 122));
            //     // 10 random numbers 1 through 10
            // }


            // var random = new Random();
            // for (int i = 0; i < 5; i++)
            // {
            //     System.Console.WriteLine((char)random.Next(97, 122));
            //     // prints letters
            // }

            //----------------------------------


            // var random = new Random();


            // const int passwordLength = 6;

            // var buffer = new char[passwordLength];
            // for (var i = 0; i < passwordLength; i++)
            // {
            //     buffer[i] = ((char)('a' + random.Next(0, 26)));

            //     var password = new string(buffer);


            //     System.Console.WriteLine(password);
            // }






            //-------------------------------------------WHILE LOOPS

            // while (true)
            // {
            //     System.Console.Write("type your name:");
            //     var input = Console.ReadLine();

            //     if (String.IsNullOrWhiteSpace(input))
            //         break;

            //     System.Console.WriteLine("@Echo: " + input);
            // }


            // while (true)
            // {
            //     System.Console.Write("type your name:");
            //     var input = Console.ReadLine();

            //     if (!String.IsNullOrWhiteSpace(input))
            //     {
            //         System.Console.WriteLine("@Echo: " + input);
            //         continue;
            //     }
            //     break;


            // }


            // var i = 0;
            // while (i <= 10)
            // {
            //     if (i % 2 == 0)
            //         System.Console.WriteLine(i);

            //     i++;
            // }



            //-------------------------------------------FOR EACH ARRAY
            // var numbers = new int[] { 1, 2, 3, 4 };


            // foreach (var number in numbers)
            // {
            //     System.Console.WriteLine(number);
            // }



            //--------------------------------FOR, FOR EACH
            // var name = "john smith";

            // for (int i = 0; i < name.Length; i++)
            // {
            //     System.Console.WriteLine(name[i]);
            // }

            // foreach (var character in name)
            // {
            //     System.Console.WriteLine(character);
            // }




            // -------------------------------itteration
            // for (int i = 0; i <= 10; i++)
            // {
            //     if (i % 2 == 0)
            //     {
            //         System.Console.WriteLine(i);
            //     }
            // }

            // for (int i = 10; i >= 1; i--)
            // {
            //     if (i % 2 == 0){
            //         System.Console.WriteLine(i);
            //     }
            // }



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

            // ----------------------------------EXERCISE

            // System.Console.WriteLine ("enter a number 1 through 10");

            // var userNum = Convert.ToInt32(Console.ReadLine ());



            // if (userNum >= 1 && userNum <= 10) {
            //     System.Console.WriteLine ("valid");
            // } else {
            //     System.Console.WriteLine ("not a valid number");
            // }
            //---------------------------------------EXERCISE

            // System.Console.WriteLine ("enter a number 1 through 10");
            // var num1 = Convert.ToInt32(Console.ReadLine ());
            // System.Console.WriteLine ("enter a number 1 through 10");
            // var num2 = Convert.ToInt32(Console.ReadLine ());

            // if (num1 > num2) {
            //     System.Console.WriteLine(" the first number is greater");
            // } else if (num2 > num1){
            //     System.Console.WriteLine("second number is greater");
            // } else if(num1 == num2) {
            //     System.Console.WriteLine("it was a tie");
            // };


            //---------------------------EXERCISE
        }
    }
}
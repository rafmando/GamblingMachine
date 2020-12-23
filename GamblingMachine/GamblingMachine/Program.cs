using System;

namespace GamblingMachine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Gambler();
            RepeatOrNot();
            

            void Gambler()
            {

                Random rgen = new Random();

                int rNum = rgen.Next(1, 4);
                Console.WriteLine("PRESS ENTER TO ROLL DICE :");
                Console.WriteLine("GOOD LUCK !!");
                Console.ReadLine();
                Console.WriteLine("");
                string[] luckList = new string[5];
                Console.WriteLine("YOU HAVE WON...");
                luckList[1] = "£2000";
                luckList[2] = "£30";
                luckList[3] = "£90";
                luckList[4] = "10";
                string result = luckList[rNum];
                Console.WriteLine(result);
                Console.WriteLine("IF YOU WOULD LIKE TO ROLL AGAIN , ENTER 'yes' ");
                Console.WriteLine("IF YOU WOULD LIKE TO LEAVE , ENTER 'no' ");
                Console.WriteLine("Would you like to roll again?");




            }

            void RepeatOrNot()
            {

                string choice = Console.ReadLine();

                if (choice == "no")
                {
                    Console.WriteLine("");
                    Console.WriteLine("THANK YOU FOR USING THE GAMBLINGMACHINE !!");
                }
                else if (choice =="yes")
                {
                    Gambler();
                    RepeatOrNot();
                }
            }














        }
    }
}

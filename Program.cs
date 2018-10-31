using System;
using System.Threading;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My super program!!!!!");

            Console.WriteLine("What's your name?");

            string pictureName = Questions();
            DrawPicture(pictureName);

            //Readline and exit
            Console.ReadLine();

        }

        private static string Questions()
        {
            // C# Ex for text/string variable:
            string firstName;
            //firstName = "Adrian";
            firstName = Console.ReadLine();

            //bool condition = Cesar;

            if (firstName.ToUpper() == "ADRIAN")
            {
                Console.WriteLine("You are super cool!!");
            }
            else
            {
                Console.WriteLine("You are just learning.");
            }

            string message = "Hi buddy, your name is " + firstName;

            Console.WriteLine(message);

            Console.WriteLine("How old are you?");
            string yourAgeAsText = Console.ReadLine();

            // C# Ex for number variable:
            //int myAge;
            // myAge = 0;
            //Cast or Convert from text to number
            //myAge = Convert.ToInt32(numberAsText);

            Console.WriteLine("Ok," + firstName + " Your age is... " + yourAgeAsText);

            Console.WriteLine("What do you want me to draw?");
            string pictureName = Console.ReadLine();
            return pictureName;
        }

        static void DrawPicture(string picturetype)
        {
            if(picturetype.ToUpper()=="SIMPSON")
            {
                Console.WriteLine("Drawing Simpson");



                Console.WriteLine("   ___  _____                                 "); Thread.Sleep(500);
                Console.WriteLine(" .'/,-Y'     '~-.                             "); Thread.Sleep(500);
                Console.WriteLine(" l.Y             ^.                           "); Thread.Sleep(500);
                Console.WriteLine(" /\\               _\\_                         "); Thread.Sleep(500);
                Console.WriteLine("i            ___/'   '\\                       "); Thread.Sleep(500);
                Console.WriteLine("|          /'   '\\   o !                      "); Thread.Sleep(500);
                Console.WriteLine("l         ]     o !__./                       "); Thread.Sleep(500);
                Console.WriteLine(" \\ _  _    \\.___./    '~\\                     "); Thread.Sleep(500);
                Console.WriteLine("  X \\/ \\            ___./                     "); Thread.Sleep(500);
                Console.WriteLine(" ( \\ ___.   _..--~~'   ~`-.                   "); Thread.Sleep(500);
                Console.WriteLine("  ` Z,--   /               \\                  "); Thread.Sleep(500);
                Console.WriteLine("    \\__.  (   /       ______)                 "); Thread.Sleep(500);
                Console.WriteLine("      \\   l  /-----~~' /                      "); Thread.Sleep(500);
                Console.WriteLine("       Y   \\          /                       "); Thread.Sleep(500);
                Console.WriteLine("       |    'x______.^                        "); Thread.Sleep(500);
                Console.WriteLine("       |           \\                          "); Thread.Sleep(500);
                Console.WriteLine("       |            \\                         "); Thread.Sleep(500);





            }
            else
            {
                Console.WriteLine("Drawing something else");

            }
        }



    }
}

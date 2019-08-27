using System;

namespace Players_Guide_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Part 3 of my coding learning from the C# Player's guide. I'll be working alond with the book and taking notes in this program");
            Console.WriteLine("Please Choose a chapter. Chapter 17-17 are available.");
            int chapterselect = Convert.ToInt32(Console.ReadLine());
            switch (chapterselect)
            {
                case 17:
                    //In a nutshell: 
                    //Object oriented program is a programming style where you create chunks of code that are modeled after real world objects. 



                //All code from Chapter 17 should be before this break.
                break;




                //This breaks the Switch Statement.  All code should be before this.
                default:
                    {
                        Console.WriteLine("No chapter work exists for that value: " + chapterselect);
                        break;
                    }
            }





        }
    }
}

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
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Chapter 17: Object Oriented Basics");
                    System.Threading.Thread.Sleep(2000);
                    //Object Classes or Object Instances:
                    //Classes: ex, a house or a car
                    //Instance: this thouse, that house, the White House. 

                    Random random = new Random();
                    //Using Randome() is calling a special type of method called a constructor.  A cosntrutor is placed in a class and describes how to create or build a new instance of that type.
                    int aRandomNumber = random.Next();
                    int dieRoll = random.Next(6) + 1; //add one, because Next(6) gives us 0 to 5.



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

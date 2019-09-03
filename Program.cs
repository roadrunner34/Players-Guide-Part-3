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
                    // int dieRoll = random.Next(6) + 1; //add one, because Next(6) gives us 0 to 5.

                    //Try it Out - Die Rolling 
                    //1. Ask the player for how many die rolls they want to do.
                    //2. Create a new random object and use the Random.Next method to simulate that many dice rolls.
                    //3. Add the total up and print the result to the user.
                    //Bonuse: Keep loping and handle new numbers until they enter 'quit' or 'exit'


                    string diceRolling = "";
                    
                    
                    do
                    {
                        Console.WriteLine("We're testing dice rolls.  Can you please enter how many dice you want to roll. \n If you want to stop, enter Quit or Exit.");
                        diceRolling = Console.ReadLine();

                        if (int.TryParse(diceRolling, out int diceToRoll))
                        {
                            //int diceToRoll = Convert.ToInt32(diceRolling);
                            int diceTotal = 0;
                            for (int i = 0; i < diceToRoll; i++)
                            {
                                int dieRoll = random.Next(6) + 1;
                                diceTotal += dieRoll;

                                if (i != diceToRoll - 1)
                                {
                                    Console.Write(dieRoll + " + ");
                                }
                                else
                                {
                                    Console.Write(dieRoll);
                                }

                            }
                            Console.WriteLine(" = " + diceTotal);
                        }


                        Console.WriteLine("Thank you for Playing");
                        
                    }
                    while (diceRolling != "quit" && diceRolling != "exit");

                                   
                    //All code from Chapter 17 should be before this break.
                    break;


                case 18:
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Chapter 18: Making Your Own Classes");
                    System.Threading.Thread.Sleep(2000);
                    //In a Nutshell
                    //Classes go in their own file
                    //Anything that is a part of a class (or other type) is a member.  This inclused instance variables, methods, and constructors.
                    //Variables can be added to a class - they are called instance variables.
                    //You can add as many constructors to a class as you want.
                    //You can add methods to a class which operate on the instance variables that the class has.
                    //A private method or instance variable is only visible from inside the class.
                    // A public method or instance variable can be seen from anywhere, inside or outside the class.



                    //All code from chapter 18 should be before this break.
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

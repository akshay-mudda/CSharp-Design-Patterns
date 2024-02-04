using CSharp_Design_Patterns._1._Singleton;
using CSharp_Design_Patterns._2._Decorator;
using CSharp_Design_Patterns._3._Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the introduction to C# design patterns
            DisplayIntroduction();

            // Variables to track which patterns have been shown
            bool[] patternShown = new bool[4]; // Index 0 is not used
            bool stopProcess = false;

            for (int i = 1; i <= 3; i++) // Loop 3 times to cover all design patterns
            {
                // Prompt the user to choose a design pattern to learn about
                DisplayOptions(i);

                // Get user input
                string userInput = Console.ReadLine();

                // Based on the user input, display the chosen design pattern explanation
                switch (userInput)
                {
                    case "1":
                        if (patternShown[1])
                        {
                            Console.WriteLine("Singleton Pattern has already been explained. Please choose another pattern.");
                            i--; // Decrement i to ask the same question again
                            continue; // Continue to prompt the user for input
                        }
                        patternShown[1] = true;
                        ExplainSingletonPattern();
                        break;
                    case "2":
                        if (patternShown[2])
                        {
                            Console.WriteLine("Decorator Pattern has already been explained. Please choose another pattern.");
                            i--; // Decrement i to ask the same question again
                            continue; // Continue to prompt the user for input
                        }
                        patternShown[2] = true;
                        ExplainDecoratorPattern();
                        break;
                    case "3":
                        if (patternShown[3])
                        {
                            Console.WriteLine("Observer Pattern has already been explained. Please choose another pattern.");
                            i--; // Decrement i to ask the same question again
                            continue; // Continue to prompt the user for input
                        }
                        patternShown[3] = true;
                        ExplainObserverPattern();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option (1, 2, or 3).");
                        i--; // Decrement i to ask the same question again
                        continue; // Continue to prompt the user for input
                }

                if (i < 3)
                {
                    // Ask user if they want to see another design pattern explanation or quit
                    Console.WriteLine("\nDo you want to learn about another design pattern? (Y/N)");
                    string choice = Console.ReadLine().ToLower();
                    while (choice != "y" && choice != "n")
                    {
                        Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
                        choice = Console.ReadLine().ToLower();
                    }
                    if (choice == "n")
                    {
                        stopProcess = true;
                        break;
                    }
                }
            }

            // End of program if user wants to stop or if all pattern explanations are over
            if (!stopProcess)
            {
                // No need to display anything here, the program will automatically exit
            }
            Console.WriteLine();
            Console.WriteLine("Thank You !");
            Console.WriteLine("-Developed by Akshay Mudda");
        }

        static void DisplayIntroduction()
        {
            Console.WriteLine("Welcome to the C# Design Patterns Example Program!");
            Console.WriteLine("In this program, you will learn about various design patterns in C#.");
            Console.WriteLine("You will be shown explanations of the following design patterns:");
            Console.WriteLine("1. Singleton Pattern");
            Console.WriteLine("2. Decorator Pattern");
            Console.WriteLine("3. Observer Pattern");
            Console.WriteLine("Let's get started!");
        }

        static void DisplayOptions(int patternNumber)
        {
            Console.WriteLine($"\nPlease choose a design pattern to learn about ({patternNumber}/3):");
            Console.WriteLine("1. Singleton Pattern");
            Console.WriteLine("2. Decorator Pattern");
            Console.WriteLine("3. Observer Pattern");
            Console.Write("Enter the number corresponding to the design pattern: ");
        }

        static void ExplainSingletonPattern()
        {
            Console.WriteLine("\nSingleton Pattern:");
            Console.WriteLine("- Ensures a class has only one instance and provides a global access point to it.");

            Console.WriteLine("\nExplanation of the Provided Code:");
            Console.WriteLine("- Declares a private static variable 'instance' to hold the single instance of the class.");
            Console.WriteLine("- Defines a private constructor to prevent external instantiation.");
            Console.WriteLine("- Provides a public static method 'GetInstance()' to retrieve the single instance.");
            Console.WriteLine("  - If 'instance' is null, a new instance is created and assigned to 'instance'.");
            Console.WriteLine("  - Subsequent calls to 'GetInstance()' return the same instance.");
        }



        static void ExplainDecoratorPattern()
        {
            Console.WriteLine("\nDecorator Pattern:");
            Console.WriteLine("- Allows behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class.");

            Console.WriteLine("\nExplanation of the Provided Code:");
            Console.WriteLine("- Defines a 'Component' interface with an 'Operation' method.");
            Console.WriteLine("- Implements the 'Component' interface with 'ConcreteComponent', which provides the basic functionality.");
            Console.WriteLine("- Defines a 'Decorator' abstract class that implements the 'Component' interface and holds a reference to another 'Component'.");
            Console.WriteLine("  - Provides a default implementation of the 'Operation' method that delegates to the wrapped 'Component'.");
            Console.WriteLine("- Extends the 'Decorator' class with 'ConcreteDecorator', which adds additional behavior before or after calling the wrapped 'Component'.");
            Console.WriteLine("  - Overrides the 'Operation' method to invoke the base operation and then add its own behavior.");
            Console.WriteLine("  - Contains the 'AddedBehavior' method, which represents the added functionality.");
        }


        static void ExplainObserverPattern()
        {
            Console.WriteLine("\nObserver Pattern:");
            Console.WriteLine("- Defines a one-to-many dependency between objects, where one object (the subject) notifies its observers of any state changes.");

            Console.WriteLine("\nExplanation of the Provided Code:");
            Console.WriteLine("- Defines a 'Subject' interface with methods to attach, detach, and notify observers.");
            Console.WriteLine("- Implements the 'Subject' interface with 'ConcreteSubject', which maintains a list of observers and notifies them of state changes.");
            Console.WriteLine("- Provides a 'State' property in 'ConcreteSubject' to hold the current state, and notifies observers when the state changes.");
            Console.WriteLine("- Defines an 'Observer' interface with an 'Update' method to notify observers of state changes.");
            Console.WriteLine("- Implements the 'Observer' interface with 'ConcreteObserver', which updates its state based on changes in the subject.");
            Console.WriteLine("  - Contains a reference to the subject and updates its state when notified.");
        }

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignmentsProgect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I've made some fun things ahead, please play along, press enter once each one is done. \nProject 1");
            //Part 1 - one dimensional string

            List<string> responses = new List<string>();
            //ask user for input
            Console.WriteLine("Pick a color from the rainbow:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("What name brings you great memories?");
            responses.Add(Console.ReadLine());

            string[] myfunnyString = {
                "\n\nThe perfect color for a new line in the rainbow: ",
                "We should call the rainbow: " };
            string[] stringFinish =
            {
                " sparkle.",
                " the great!"
            };
            //Loop that adds users text to the string
            for (int i = 0; i < myfunnyString.Length; i++)
            {
                myfunnyString[i] += responses[i];

            }
            Console.ReadLine();
            Console.WriteLine("What my thoughts are plus yours:");
            //loop that prints each string on new line
            for (int i = 0; i < myfunnyString.Length; i++)
            {
                //part 2 infinate loop
                Console.WriteLine(myfunnyString[i] + stringFinish[i]);
                //in order to fix the infiniate loop(uncoment i-- for infinate loop)
                //i--;
            }
            Console.ReadLine();

            //part 3
            Console.WriteLine("\nProject 2 - Can you hear a snowman?");
            Console.WriteLine("Do you hear a snowman?");
            StringBuilder swishSwish = new StringBuilder();
            swishSwish.Append("Sw");
            //create loop for iteration
            while (swishSwish.Length < 10)
            {
                swishSwish.Append("ish");
            }
            swishSwish.Append("!");
            Console.ReadLine();
            Console.WriteLine(swishSwish);
            Console.ReadLine();
            StringBuilder flutter = new StringBuilder();
            flutter.Append("Flutter");
            //add loop used to compare for iteration
            while (flutter.Length <= 10)
            {
                flutter.Append("flutter");
            }
            flutter.Append("!");
            Console.WriteLine(flutter);
            Console.ReadLine();



            //Part 4 
            //create list for unique items
            Console.WriteLine("\nProject 3 - Can you guess my unicorn name?!");
            List<string> unicornNames = new List<string>()
            {
                "Pixie", "Love", "Sunshine", "Fancypants", "Sparkle", "StarShine", "Pony"
            };
            Console.WriteLine("\nWhat do you think I named my unicorn?  ");
            int standing = 0;
            bool isValid = false;
            int index = 0;
            //create loop that iterates and displays
            while (!isValid)
            {
                int i2 = 0;
                string nameIt = Console.ReadLine();
                foreach (string unicornName in unicornNames)
                {
                    if (nameIt == unicornName)
                    {
                        standing = i2 + 1;
                        index = i2;
                    }
                    i2++;
                }
                //add loop that says not the right info
                if (standing == 0)
                {
                    Console.WriteLine("whoops, try agian!");
                }
                else
                {
                    isValid = true;
                }
            }
            Console.WriteLine("Hey! That's pretty good, you got it! And my favorite number is: " + standing);
            Console.ReadLine();

            //part 5
            Console.WriteLine("\nProject 4!");
            //create a list of strings with 2 identical strings in the list.
            List<string> fishTypes = new List<string>()
            { "Brown", "Steelhead", "Rainbow", "Steelhead", "Steelhead", "Brown", "Rainbow" };
            Console.WriteLine("\nI hope you like fishing as much as I do!!! \nThe most common fish to start with is Trout!  " +
                "But there are dozens of varieties! " +
                "\nCan you think of kinds?" +
                "\n\"Rainbow\" trout from a lake?.\nOr if you like going to the river better, you could say \"Steelhead\" trout. " +
                "\nThere is also one that goes in both! Crazy right?? \"Brown\" trout!.\nThese types, Brown trout, can travel in both salt and fresh water."
                + "\nMy favorite to try for is \"Rainbow\".");
            //ask the user to select text to search the list
            Console.WriteLine("Have you fished for one of these?  If so which one? Enter here: ");
            string selection = Console.ReadLine();
            while (!(selection == "Rainbow" || selection == "Steelhead" || selection == "Brown"))
            {
                //displays to user try again not in the list
                Console.WriteLine("Please enter one of the 3 choices: Steelhead, Rainbow or Brown.");
                selection = Console.ReadLine();
            }
            Console.WriteLine("For that type of fish you can be found in these numbered regions of BC: ");
            //loop that loops through input and array to match
            for (int i3 = 1; i3 < fishTypes.Count; i3++)
            {
                if (selection == fishTypes[i3])
                {
                    Console.WriteLine(i3);
                }

            }
            Console.ReadLine();

            //part 6
            Console.WriteLine("\nProject 5, final one!");
            //list of strings that has a matching string
            List<string> names = new List<string>()
            {
                "Salmon", "Halibut", "Cod", "Trout", "Sculpin", "Salmon", "Sole"
            };
            List<string> repeatCheck = new List<string>();
            Console.WriteLine("Fish Species!!");
            // forloop to check items in list for matching strings and displays the match
            foreach (string name in names)
            {
                Console.WriteLine(name);
                if (repeatCheck.Contains(name))
                {
                    Console.WriteLine("This fish was already entered. \nPlease enter a different kind of species or varient.");
                }
                else
                {
                    Console.WriteLine("That's a good one!");
                }
                repeatCheck.Add(name);
            }
            Console.WriteLine("Thank you for playing along! Goodbye :) ");
            Console.ReadLine();

        }


    }
       
  
}

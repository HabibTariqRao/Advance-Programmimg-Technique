using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dictionary to store first 30 elements
        Dictionary<int, (string Name, string Type)> elements = new Dictionary<int, (string, string)>()
        {
            {1, ("Hydrogen", "Nonmetal")},
            {2, ("Helium", "Noble Gas")},
            {3, ("Lithium", "Alkali Metal")},
            {4, ("Beryllium", "Alkaline Earth Metal")},
            {5, ("Boron", "Metalloid")},
            {6, ("Carbon", "Nonmetal")},
            {7, ("Nitrogen", "Nonmetal")},
            {8, ("Oxygen", "Nonmetal")},
            {9, ("Fluorine", "Halogen")},
            {10, ("Neon", "Noble Gas")},
            {11, ("Sodium", "Alkali Metal")},
            {12, ("Magnesium", "Alkaline Earth Metal")},
            {13, ("Aluminium", "Post-transition Metal")},
            {14, ("Silicon", "Metalloid")},
            {15, ("Phosphorus", "Nonmetal")},
            {16, ("Sulfur", "Nonmetal")},
            {17, ("Chlorine", "Halogen")},
            {18, ("Argon", "Noble Gas")},
            {19, ("Potassium", "Alkali Metal")},
            {20, ("Calcium", "Alkaline Earth Metal")},
            {21, ("Scandium", "Transition Metal")},
            {22, ("Titanium", "Transition Metal")},
            {23, ("Vanadium", "Transition Metal")},
            {24, ("Chromium", "Transition Metal")},
            {25, ("Manganese", "Transition Metal")},
            {26, ("Iron", "Transition Metal")},
            {27, ("Cobalt", "Transition Metal")},
            {28, ("Nickel", "Transition Metal")},
            {29, ("Copper", "Transition Metal")},
            {30, ("Zinc", "Transition Metal")}
        };

        Console.WriteLine("Hi there! Happy to help!");

        char choice;

        do
        {
            Console.Write("\nProvide atomic number of the element: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (elements.ContainsKey(number))
            {
                var element = elements[number];

                Console.WriteLine($"Atomic Number: {number}");
                Console.WriteLine($"Name: {element.Name}");
                Console.WriteLine($"Class: {element.Type}");
            }
            else
            {
                Console.WriteLine("Invalid atomic number! Please enter between 1 and 30.");
            }

            Console.Write("\nDo you want to know more elements [y/n]? ");
            choice = Convert.ToChar(Console.ReadLine().ToLower());

        } while (choice == 'y');

        Console.WriteLine("Thanks!");
    }
}
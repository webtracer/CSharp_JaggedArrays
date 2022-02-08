using System;

namespace Jagged_Arrays_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a jagged array, which contains 3 "friends arrays", in which two family members should be stored
            // Introduce family members from different families to each other via console (3 introductions)

            string[][] familyArray = new string[][]
            {
                new string[] {"Niel", "Terry"},
                new string[] {"Art","Joanne"},
                new string[] {"Vickie", "Monica"}
            };

            Console.WriteLine($"Introducing the families to each other");

            // My solution - I made it WAY too difficult, thought of his solution but figured it was too easy
            for(int i = 0; i < familyArray.Length;i++)
            {
                for(int j = 0; j < familyArray[i].Length;j++)
                {
                    //Console.WriteLine($"{familyArray[i][j]} I would like you to meet {familyArray[j][i]}");
                    for (int k = 0; k < familyArray[i].Rank;k++)
                    {
                        Console.WriteLine($"{familyArray[j][k]} I would like you to meet {familyArray[i][j]}");
                    }
                }
            }
            Console.WriteLine();
            /*for(int i=0,j=1,k=0; i<familyArray.Length;i++,j--,k++)
            {
                Console.WriteLine($"{familyArray[i][k]} I would like you to meet {familyArray[i][j]}");
            }*/

            // Actual Solution - I made it WAY to difficult
            string[][] friendsAndFamliy = new string[][]
            {
                new string[] {"Niel", "Terry"},
                new string[] {"Art","Joanne"},
                new string[] {"Vickie", "Monica"}
            };

            Console.WriteLine($"Hi {friendsAndFamliy[0][0]}, I would like to introduce {friendsAndFamliy[1][0]} to you.");
            Console.WriteLine($"Hi {friendsAndFamliy[0][1]}, I would like to introduce {friendsAndFamliy[1][1]} to you.");
            Console.WriteLine($"Hi {friendsAndFamliy[2][0]}, I would like to introduce {friendsAndFamliy[2][1]} to you.");
            Console.WriteLine();
            // Can also create jagged arrays this way
            string[] laurasParents = new string[] { "Niel", "Terry" };
            string[] randysParents = new string[] { "Art", "Joanne" };
            string[] ourAunts = new string[] { "Vickie", "Monica" };

            string[][] familyNames = new string[][]
            {
                laurasParents,
                randysParents,
                ourAunts
            };

            Console.WriteLine($"Hi {familyNames[0][0]}, I would like to introduce {familyNames[1][0]} to you.");
            Console.WriteLine($"Hi {familyNames[0][1]}, I would like to introduce {familyNames[1][1]} to you.");
            Console.WriteLine($"Hi {familyNames[2][0]}, I would like to introduce {familyNames[2][1]} to you.");

        }
    }
}

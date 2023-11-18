//Grading ID: R2201
//Lab:        7
//Due Date:   04/10/22
//CIS 199-02

//This program displays a square based on user input declaring the number of stars per side.
using static System. Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input; //will store the user input
            bool parse = false; //initializes the variable used to store TryParse value
            do
            {
                WriteLine("Enter the number of stars per side: "); //prompts the user
                parse = int.TryParse(ReadLine(), out input);
            }
            while (!parse || input <= 0); //post test loop
            ShowSquareOfStars(input); //will execute after ensuring there is good input
        }

        private static void ShowSquareOfStars(int numStars)
        {
            for (int i = 0; i < numStars; i++) //controls the amount of lines
            {
                for (int x = 0; x < numStars; x++) //controls the stars per line
                    Write("*");
                WriteLine();
            }
            
          
        }
    }
}

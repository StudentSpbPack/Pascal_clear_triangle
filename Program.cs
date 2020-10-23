using System;
using static System.Console;  // Method that make job easier by removing the need write Console. in code, because C# language for real lazy people (:

namespace Pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method that create window size of Console and take its center
            SetWindowSize(200, 30); // Create window size of Console for x16 Pascal Triangle
            int width = WindowWidth / 2; // Create variable that contain center of console
            int height = 1; // Create variables that transfer columns of triangle on new line

            // Method that return amount columns of triangle and check its maximum
            WriteLine("Enter amount columns of triangle. Can be maximum 16"); 
            byte ColumnsOfTriangle; // create varible that contain columns of triangle
            while(true) // Endless cycle that check max of columns for triangle
            {
                ColumnsOfTriangle = Convert.ToByte(ReadLine()); // Enter number of columns for triangle

                if (ColumnsOfTriangle > 16) // Operator that create requirement for number
                {
                    WriteLine("Columns of triangle can be 16 Maximum"); // Console message that user write too big number
                }
                else // Exit from cycle
                    break; // if number meets the requirements
            }

            // Create jagged array that contain numb of array which contain numbers pascal triangle on current column
            int[][] PascalTriangle = new int[ColumnsOfTriangle][];

            //Method that clear console and write text how much columns have triangle
            Console.Clear(); // Clear console with past texts
            SetCursorPosition(width - 11, 0); // Set center position of text
            Console.WriteLine($"Triangle with {ColumnsOfTriangle} colums:"); // Write text how much columns have triangle

            // Method that actually create pascal triangle
            for (int i = 0; i < ColumnsOfTriangle; i++) // Cycle that goes over numbers of array
            {
                PascalTriangle[i] = new int[i + 2]; // Create array in array with quantity in current column of triangle
                SetCursorPosition(width, height); //Set current position of column, firstly that center
                for (int j = 0; j < PascalTriangle[i].Length - 1; j++) // Cycle that goes over arrays in array[i]
                { 
                    if(i>0 && j>0) // Bypass error through operator that check i and j
                    {
                        if (PascalTriangle[i - 1][j - 1] > 0 && PascalTriangle[i - 1][j] > 0) // Check numbers of upper columns for create exactly Pascal triangle
                            PascalTriangle[i][j] = PascalTriangle[i - 1][j - 1] + PascalTriangle[i - 1][j]; // Addition upper columns
                        else
                            PascalTriangle[i][j] = 1; // Else just give number 1 for array
                    }
                    else // Else just give number 1 for array
                        PascalTriangle[i][j] = 1;
                    Write($"{PascalTriangle[i][j]}        "); //Write count of number in current array
                }
                width -= 5;//Subsctraction from width for correct position for next numbers of columns for Pascal triangle
                height++; // Addition height for correct position for next numbers of columns for Pascal triangle
            }

            // CODE END!
            WriteLine();
            ReadKey();
        }
    }
}

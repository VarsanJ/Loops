//Name: Varsan jeyakkumar
//Date: 2024-03-21 ->
//Title: Loop Assignment
//Purpose: Offer users multiple programs using an application of loops, and other prgramming concepts.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4VarsanJeyakkumar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Purpose: Serve as a home page for the program

            //Variable Declaration
            string strUser = "", strChoice = "";

            //Input and Process
            Console.WriteLine("Welcome to the loop program stimulation system.");
            while (true)
            {
                menu();
                strUser = Console.ReadLine();
                strChoice = strUser;
                if (strChoice == "1")
                {
                    Console.Clear(); //clear
                    fivecounter();
                }
                else if (strChoice == "2")
                {
                    Console.Clear(); //clear
                    decrementation();
                }
                else if (strChoice == "3")
                {
                    Console.Clear(); //clear
                    subtractor();
                }
                else if (strChoice == "4")
                {
                    Console.Clear(); //clear
                    multplicationtable();
                }
                else if (strChoice == "5")
                {
                    Console.Clear(); //clear
                    primesum();
                }
                else if (strChoice == "6")
                {
                    Console.Clear(); //clear
                    exponents();
                }
                else if (strChoice == "7")
                {
                    Console.Clear(); //clear
                    picalculator();
                }
                else if ((strChoice == "EXIT") || (strChoice == "0") || (strChoice == ""))
                {
                    Console.Clear(); //clear
                    break;
                }

            }

            //Program Termination
            Console.WriteLine("Press any key to terminate the program");
            Console.ReadKey(); //waits for user to terminate the program
        }

        public static void menu()
        {
            //Purpose: Display the menu for the program.

            //Output
            Console.WriteLine("\nPlease select an option below by inputting the number.\n(1) Five Counter\n(2) Custom Decrementor Sequence\n(3) Continuous Subtractor\n(4) Multiplication Table Generator\n(5) Prime Number Sum \n(6) Exponent Table\n(7) Pi Special Accuracy Calculator\n______________________\n(0) To exit, enter EXIT");
        }
        public static void fivecounter()
        {
            //Purpose: Count by 5 between two numbers

            //Variable Declaration
            int intEnd = 1000;

            //Process and Output
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nHere is how to count by 5 from -32000 to 1000\n\n\n");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = -32000; i <= intEnd; i += 5) //for loop for range of numbers
            {
                if (i == intEnd) //if comma warranted
                {
                    Console.Write(i);
                }
                else //last number of sequence
                {
                    Console.Write(i + ",");
                }

            }

            //Method Termination
            Console.WriteLine("\nPress any key to return to MAIN MENU"); //display
            Console.ReadKey(); //exit
            Console.Clear(); //clear
        }

        public static void decrementation()
        {
            //Purpose: Decrement downwards between two numbers using a given decrementor

            //Variable Declaration
            string strUser = "";
            int intFirstInput = 0, intSecondInput = 0, intUpperNumber = 0, intLowerNumber = 0, intDecrementor = 0; //numerical variables

            //Input
            Console.WriteLine("\nThis program will decrement from an upper to lower number using a specified input"); //info

            Console.WriteLine("\nPlease enter your first number");
            strUser = Console.ReadLine();
            intFirstInput = Int32.Parse(strUser);

            Console.WriteLine("\nPlease enter your second number");
            strUser = Console.ReadLine();
            intSecondInput = Int32.Parse(strUser);

            Console.WriteLine("\nPlease enter your decrement value");
            strUser = Console.ReadLine();
            intDecrementor = Int32.Parse(strUser);

            //Process and Output 
            //Process A: Comparing values to assign values to upper num and lower num
            if (intFirstInput >= intSecondInput)
            {
                intUpperNumber = intFirstInput;
                intLowerNumber = intSecondInput;
            }
            else if (intFirstInput < intSecondInput)
            {
                intLowerNumber = intFirstInput;
                intUpperNumber = intSecondInput;
            }

            //Process B and Output: Establishes a for loop to display all values
            if (intLowerNumber == intUpperNumber)
            {
                Console.WriteLine(intUpperNumber);
                Console.WriteLine("Both upper and lower values are same!\n");
            }
            else
            {
                for (int i = intUpperNumber; i >= intLowerNumber; i -= intDecrementor)
                {
                    if ((i - intDecrementor) >= intLowerNumber)
                        Console.Write(i + ",");
                    else
                        Console.Write(i);
                }
            }

            //Method Termination
            Console.WriteLine("\nPress any key to return to MAIN MENU"); //display
            Console.ReadKey(); //exit
            Console.Clear(); //clear
        }
        public static void subtractor()
        {
            //Purpose: Continuously subtract values from a number until specified to stop by the user

            //Variable Declaration
            int intOriginalNumber = 0, intSubtracting = 0, intTotal = 0;
            string strUser, strOutput;

            //Input and Process
            Console.WriteLine("What is your original number?");
            strUser = Console.ReadLine();
            intOriginalNumber = Int32.Parse(strUser);
            intTotal = intOriginalNumber;

            while (true) //continuous subtractor
            {
                Console.WriteLine("Please enter what number to subtract. To exit, enter \"exit\" or no input");
                strUser = Console.ReadLine();
                strOutput = strUser;

                if ((strOutput == "exit") || (strOutput == ""))
                {
                    break; //exit
                }
                else
                {
                    intSubtracting = Int32.Parse(strOutput); //get subtracting value
                    intTotal -= intSubtracting;
                }
            }

            //Output
            Console.WriteLine("Your Total Difference is: " + intTotal);

            //Method Termination
            Console.WriteLine("\nPress any key to return to MAIN MENU"); //display
            Console.ReadKey(); //exit
            Console.Clear(); //clear
        }

        public static void multplicationtable()
        {
            //Variable Declaration
            int intColumns, intRows;
            string strUser;

            //Input
            Console.WriteLine("How many columns are in your multiplication table?");
            strUser = Console.ReadLine();
            intColumns = Int32.Parse(strUser);

            Console.WriteLine("How many rows are in your multiplication table?");
            strUser = Console.ReadLine();
            intRows = Int32.Parse(strUser);

            //Process

            //top row
            Console.ForegroundColor = ConsoleColor.Red; //color
            Console.Write("X\t");
            for (int j = 1; j <= intColumns; j++)
            {
                Console.Write(j + "\t");
            }
            Console.ForegroundColor = ConsoleColor.White; //color
            Console.WriteLine("");
            for (int i = 1; i <= intRows; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red; //color
                Console.Write(i + "\t");
                Console.ForegroundColor = ConsoleColor.White; //color
                for (int k = 1; k <= intColumns; k++)
                {

                    Console.Write((k * i) + "\t");
                }

                Console.WriteLine("");
            }

            //Method Termination
            Console.WriteLine("\nPress any key to return to MAIN MENU"); //display
            Console.ReadKey(); //exit
            Console.Clear(); //clear
        }

        public static void primesum()
        {
            //Purpose: Determine the sum of all prime numbers between 11 and 11403
            Console.WriteLine("The purpose of the program is to determine the sum of all prime numbers between 11 and 11403 inclusive.");

            //Variable Declaration
            int intSum = 0, intFactors, intTotalFactors = 0; //sum

            //Process
            for (int i = 11; i <= 11403; i++) //11403
            {
                intFactors = 1;
                intTotalFactors = 0;
                while (intFactors <= i)
                {
                    if (i % intFactors == 0)
                    {
                        intTotalFactors += 1;
                    }
                    intFactors++;
                }

                if (intTotalFactors > 2)
                {
                    //nothing            
                }
                else
                {
                    intSum += i;
                }
            }

            //Output
            Console.WriteLine(intSum);

            //Method Termination
            Console.WriteLine("\nPress any key to return to MAIN MENU"); //display
            Console.ReadKey(); //exit
            Console.Clear(); //clear
        }
        public static void exponents()
        {
            //Purpose: To create an exponential table to display powers of a number

            //Variable Declaration
            int intBase, intPOW, intExponent;
            string strUser;

            //Input
            Console.WriteLine("How many columns (bases) are in your multiplication table?");
            strUser = Console.ReadLine();
            intBase = Int32.Parse(strUser);

            Console.WriteLine("How many rows (exponents) are in your multiplication table?");
            strUser = Console.ReadLine();
            intExponent = Int32.Parse(strUser);

            //Process
            Console.ForegroundColor = ConsoleColor.Red;
            for (int j = 1; j <= intBase; j++) //top row
            {
                Console.Write("x^" + j + "\t\t");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            for (int i = 1; i <= intExponent; i++)
            {
                Console.ForegroundColor = ConsoleColor.White; //color
                for (int k = 1; k <= intBase; k++)
                {
                    intPOW = (Int32)Math.Pow(i, k);
                    Console.Write(intPOW + "\t\t");
                }

                Console.WriteLine("");
            }

            //Method Termination
            Console.WriteLine("\nPress any key to return to MAIN MENU"); //display
            Console.ReadKey(); //exit
            Console.Clear(); //clear
        }
        public static void picalculator()
        {
            //Variable Declaration
            int intInvertor = 1; //used to switch between positive and negative regarding signs
            decimal decRunningTotal = 0, decAccuracy = 0, decRoundedTotal, decChanger = 0;
            double dblRound = 0;
            string strUser;

            //Input
            Console.WriteLine("Gregory & Leibniz formula is a formula that can be used to get the value of pi. \nBy adding more terms, you will get an answer closer to pi.");

            Console.WriteLine("How many terms do you want to use?");
            strUser = Console.ReadLine();
            decAccuracy = Decimal.Parse(strUser);

            Console.WriteLine("How accurate is your final answer (decimal places)?");
            strUser = Console.ReadLine();
            dblRound = Double.Parse(strUser);

            //Process
            decAccuracy = (decAccuracy * 2) - 1; //converts suitable to formula
            for (int i = 1; i <= decAccuracy; i += 2)
            {
                decChanger = (decimal)4 / (decimal)i;
                if (intInvertor > 0)
                {
                    decRunningTotal += decChanger;
                }

                else
                {
                    decRunningTotal -= decChanger;
                }
                intInvertor *= -1;
            }

            decRunningTotal = (decimal)Math.Round((double)decRunningTotal, (int)dblRound);

            //Output
            Console.WriteLine("PI = " + decRunningTotal);

            //Method Termination
            Console.WriteLine("\nPress any key to return to MAIN MENU"); //display
            Console.ReadKey(); //exit
            Console.Clear(); //clear
        }
    }
}







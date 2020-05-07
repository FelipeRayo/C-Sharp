using System;

namespace Ejercicios_csharp
{
    class Program
    {

         const double PI = 3.141593764;
         const int weeks = 52, months = 12;

         const string birthday = "06.10.2001";


        static void Main(string[] args)
        {
            #region TypeData
            /*int num = 124567;
            long bigNum = num;

            float myFloat = 13.73F;
            double myNewDouble = myFloat;

            double myDouble = 13.73;
            int myInt;
            myInt = (int)myDouble;

            string myString = myDouble.ToString();
            string myFloatString = myFloat.ToString();
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.Read();
            */
            #endregion TypeData

            #region Strings
            /*
            string myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;
            string result = myString + mySecondString;

            Console.WriteLine(resultInt);
            Console.Read();
            */
            #endregion Strings


            /*
            Console.WriteLine("My birthday is always going to be: {0}", birthday);
            Console.Read();
            */

            /*
            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from a method");
            Console.Read();
            */
            #region Methods
            /*
            int DoubleSum = Add(Add(1, 2), Add(3, 4));
            Console.WriteLine(DoubleSum);
            Console.WriteLine(Add(15,31));
            Console.WriteLine(Multiply(25,25));
            Console.WriteLine(Devide(25,13));
            Console.Read();*/
            #endregion

            #region User Input

            //Console.WriteLine(Calculate());
            //Console.Read();

            #endregion User Input

            #region TryCatch and Finally
            /*
            Console.WriteLine("Please enter a number");
            string UserInput = Console.ReadLine();

            try
            {            
                int userInputAsInt = int.Parse(UserInput);

            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNull Exception, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }


            Console.ReadKey();
            */
            #endregion

            #region Operators
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", isSunny);

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            Console.WriteLine("num is {0}", ++ num);

            // decrement operators
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            Console.WriteLine("num is {0}", --num);


            Console.ReadKey();

            #endregion
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1Imput = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Imput = Console.ReadLine();

            int num1 = int.Parse(number1Imput);
            int num2 = int.Parse(number2Imput);

            int result = num1 + num2;
            return result;
        }

        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");

        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Devide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}

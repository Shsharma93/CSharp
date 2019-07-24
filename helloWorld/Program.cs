using System;
using helloWorld.Maths;

namespace helloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //variablesDemo();
            //typeConversion();
            //operatorsDemo();
            //classesDemo();
            //getInput();
            arrayDemo();

        }


        public static void arrayDemo()
        {
            drawLine("Array Demo");

            var numbers = new int[3];
            numbers[0] = 2;
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[0]);

            var names = new string[3] { "John", "Phil", "Mike" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
        }


        //draw line
        public static void drawLine(string which)
        {
            Console.WriteLine("\n---------{0}---------\n", which);
        }

        // getting input from commandline
        public static void getInput()
        {
            drawLine("Input Demo");

            var a = new Calculator();
            Console.Write("Enter first number : ");
            var xa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            var xb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a.addition(xa, xb));
        }


        //classes demo
        public static void classesDemo()
        {
            drawLine("Classes Demo");

            var john = new Person();
            john.firstName = "John";
            john.lastName = "Woakes";
            john.introduce();

        }


        //variables
        public static void variablesDemo()
        {
            drawLine("Variable Demo");

            int number = 5;
            byte count = 2;
            float totalPrice = 2.3f;
            char character = 'A';
            string firstName = "John";
            bool isCool = true;
            Console.WriteLine("int : " + number + "\n" + "byte : " + count + "\n" + "float : " + totalPrice
                + "\n" + "char : " + character + "\n" + "string : " + firstName + "\n" + "bool : " + isCool);

            const float pi = 3.14f;
            Console.WriteLine("pie value : {0}", pi);
            
        }


        //type conversion
        public static void typeConversion()
        {
            drawLine("Type Conversion Demo");

            var s = "1099";
            int i = int.Parse(s);

            int j = 1000;
            byte b = (byte)j;

            byte k = 200;
            int m = k;

            Console.WriteLine("i : {0}, b : {1}, m : {2}", i, b, m);
        }


        //operators
        public static void operatorsDemo ()
        {
            drawLine("Operators Demo");

            var a = 23;
            var c = 9;
            Console.WriteLine("sum : " + (a + c));
            Console.WriteLine("divide : " + (a / c));
            Console.WriteLine("remainder : " + (a % c));
            Console.WriteLine("divide : " + ((float)a / (float)c));

            Console.WriteLine(a < c);
        }
    }
}

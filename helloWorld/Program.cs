using System;
using System.Collections.Generic;
using helloWorld.Maths;

namespace helloWorld
{
    class MainClass
    {
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }

        public static void Main(string[] args)
        {
            //variablesDemo();
            //typeConversion();
            //operatorsDemo();
            //classesDemo();
            //getInput();
            //arrayDemo();
            //stringDemo();
            //enumDemo();
            //controlFlowDemo();
            //switchDemo();
            //speedCameraCalculation();
            //forLoopDemo();
            //randomClassDemo();
            //exerciseSolutions();
            //arraysDemo();
            //listsDemo();
            //exercise2Solutions();
            dateTimeDemo();
        }


        public static void dateTimeDemo()
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine("Date Time : {0}", dateTime);
            Console.WriteLine("Now - {0}", now.Hour);
            Console.WriteLine("Now - {0}", now.AddDays(1));
            Console.WriteLine("Today - {0}", today.DayOfYear);
            Console.WriteLine(now.ToString("dd-MM-yyyy"));
        }


        public static void exercise2Solutions()
        {
            var ex2 = new Exercise2();
            ex2.exerciseProblems();
        }


        public static void listsDemo()
        {
            var numbers = new List<int>() { 5, 2, 8, 6, 3};
            numbers.Add(6); //insert element at the end of the list
            Console.WriteLine(numbers.IndexOf(6));
            Console.WriteLine(numbers.LastIndexOf(6));
            numbers.Insert(0, 7); //insert element at specific position
            Console.WriteLine("Count : {0}", numbers.Count);
            numbers.Remove(6);
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Clear(); //now count is 0

        }


        public static void arraysDemo()
        {
            var numbers = new int[] { 8, 1, 6, 2, 4, 7 };

            //length
            Console.WriteLine(numbers.Length);

            //indexof
            Console.WriteLine(Array.IndexOf(numbers, 7));

            //clear
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("After clear");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            //copy
            var newList = new int[3];
            Array.Copy(numbers, newList, 3);

            Console.WriteLine("After copy");
            foreach (int number in newList)
            {
                Console.WriteLine(number);
            }

            //sort
            Array.Sort(numbers);

            Console.WriteLine("After sort");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //reverse
            Array.Reverse(numbers);

            Console.WriteLine("After reverse");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }

        public static void exerciseSolutions()
        {
            var solutions = new Exercise();
            solutions.exerciseProblems();
        }

        public static void randomClassDemo()
        {
            var random = new Random();
            for (int i = 0; i < 12; i++)
                Console.Write((char)random.Next(65, 122)); //to generate random password
        }

        public static void forLoopDemo()
        {
            for(int i = 0; i < 10; i++)
            {
                if(i%2 == 0) 
                Console.WriteLine(i);
            }

            var name = "Shashank Kumar";

            foreach(var chars in name)
            {
                Console.WriteLine(chars);
            }
        }

        public static void speedCameraCalculation()
        {
            var car = new SpeedCamera();
            car.getSpeedInput();
        }

        public static void switchDemo()
        {
            var season = Season.Summer;

            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("Its autumn season.");
                    break;
                case Season.Spring:
                    Console.WriteLine("Its spring season");
                    break;
                case Season.Summer:
                    Console.WriteLine("Its summer season");
                    break;
                case Season.Winter:
                    Console.WriteLine("Its winter season");
                    break;
                default:
                    Console.WriteLine("Not found");
                    break;
            }
        }

        public static void controlFlowDemo()
        {
            int hour = 0;

            int minute = 24;

            var time = minute > 15 ? "past 15" : "past 30";
            Console.WriteLine(time);

            if(hour >= 0 && hour < 4 || hour >= 20 && hour < 24)
            {
                Console.WriteLine("Its night time");
            } else if(hour >= 4 && hour < 12)
            {
                Console.WriteLine("Its morning time");
            } else if(hour >= 12 && hour <= 15) {
                Console.WriteLine("Its afternoon time");
            } else
            {
                Console.WriteLine("Its evening time");
            }
        }


        public static void enumDemo()
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int) method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod) methodId);
        }


        public static void stringDemo()
        {
            var firstName = "Jack";
            var lastName = "Ball";
            var age = 25;
            var name = string.Format("{0} {1} {2}", firstName, lastName, age);
            var fullName = firstName + " " + lastName;
            var firstChar = firstName[0];
            Console.WriteLine(name + " " + firstChar);
            var path = @"c:\projects\CSharp\hello";
            Console.WriteLine(path);
            Console.WriteLine(fullName);

            var names = new String[3] { "Jack", "Mike", "Johnathan" };
            Console.WriteLine(String.Join(", ", names));
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

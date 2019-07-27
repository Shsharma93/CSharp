using System;
using System.Collections.Generic;
using System.Linq;

namespace helloWorld
{
    public class Exercise2
    {
        public void exerciseProblems()
        {
            //calculateLikes();
            //reverseName();
            //uniqueNumber();
        }


        public static void uniqueNumber()
        {
            var isExit = false;
            var numberList = new List<int>();
            while(!isExit)
            {
                if (numberList.Count == 5)
                    break;
                Console.Write("Enter the number : ");
                var number = Convert.ToInt32(Console.ReadLine());
                bool isUnique = checkUniquness(number, numberList);
                if(!isUnique)
                {
                    numberList.Add(number);
                } else
                {
                    Console.WriteLine("Number repeated. Try Again!");
                }
            }
            int[] newList = numberList.ToArray();

            Array.Sort(newList);
            foreach(int number in newList)
            {
                Console.WriteLine(number);
            }
        }

        public static bool checkUniquness(int number,List<int> numberList)
        {
            
            return numberList.Contains(number);
        }


        public static void reverseName()
        {
            Console.Write("Enter your name : ");
            var name = Console.ReadLine();
            var nameChar = name.ToCharArray();
            Array.Reverse(nameChar);
            var reverseName = new String(nameChar);
            Console.WriteLine(reverseName);
        }

        public static void calculateLikes()
        {
            var isExit = false;
            var nameLists = new List<string>();
            while(!isExit)
            {
                Console.Write("Enter the new name : ");
                var name = Console.ReadLine();

                if (String.IsNullOrEmpty(name))
                {
                    isExit = true;
                } else
                {
                    nameLists.Add(name);
                }
            }

            int count = nameLists.Count;
            switch(count) {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post", nameLists[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} like your post", nameLists[0], nameLists[1]);
                    break;
                default:
                    Console.WriteLine("{0}, {1} and {2} others like your post",
                        nameLists[0], nameLists[1], count-2 );
                    break;

            }
        }
    }
}

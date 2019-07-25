using System;
using System.Collections.Generic;

namespace helloWorld
{
    public class Exercise2
    {
        public void exerciseProblems()
        {
            calculateLikes();
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

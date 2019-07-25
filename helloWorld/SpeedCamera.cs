using System;
namespace helloWorld
{
    public class SpeedCamera
    {
        public void getSpeedInput()
        {
            Console.Write("Enter the Speed Limit : ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Speed : ");
            var speed = Convert.ToInt32(Console.ReadLine());
            calculateSpeed( speed, speedLimit);
        }
        public static void calculateSpeed(int speed, int speedLimit)
        {
            if(speed <= speedLimit)
            {
                Console.WriteLine("OK");
            } else
            {
                var extraSpeed = speed - speedLimit;
                var demeritPoints = extraSpeed / 5;
                printWarnings(demeritPoints);
            }
        }

        public static void printWarnings(int demeritPoints)
        {
            if (demeritPoints < 12)
            {
                Console.WriteLine("{0} Demerit Point(s)", demeritPoints);
            }
            else
            {
                Console.WriteLine("Licence Cancelled");
            }
        }
    }
}

using System;

namespace Homework_Workshop_Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            double positionX = double.Parse(Console.ReadLine());
            double positionY = double.Parse(Console.ReadLine());

            if (mode == "time" || mode == "price")
            {
                if (positionX >= 0)
                {
                    double t = Math.Sqrt(positionY)+1; //t ไม่น้อยกว่า 0
                    double p = Math.Pow((positionX - 1),2);
                    if(mode == "time")
                    {
                        Console.WriteLine("{0},{1}",positionX,p);
                    }
                    else if(mode == "price")
                    {
                        Console.WriteLine("{0},{1}", t, positionY);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid mouse position");
                }
            }
            else
            {
                Console.WriteLine("Invalid mode");
            }
            Console.ReadLine();
        }
    }
}

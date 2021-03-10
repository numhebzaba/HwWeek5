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
                    double t1 = Math.Sqrt(positionY)+1;
                    double t2 = (-1*Math.Sqrt(positionY))+1;
                    double p = Math.Pow((positionX - 1),2);
                    if(mode == "time")
                    {
                        Console.WriteLine("{0},{1}",positionX,p);
                    }
                    else if(mode == "price")
                    {
                        double tbar = (t1 + t2) / 2;
                        if (positionX >= tbar)
                        {
                            Console.WriteLine("{0},{1}", t1, positionY);
                        }
                        else
                        {
                            Console.WriteLine("{0},{1}", t2, positionY);
                        }
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

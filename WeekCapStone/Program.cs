using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




public class Coordinate
{



    static void Main(string[] args)
    {


        bool toContinue = fal            

        while (toContinue)
        {
            Console.Write("\nEnter an X coordinate :");

            double xCoordinate = int.Parse(Console.ReadLine());

            Console.Write("\nEnter an Y coordinate :");

            double yCoordinate = int.Parse(Console.ReadLine());


            Point GetCor = new Point(xCoordinate, yCoordinate);

            Console.WriteLine("\nYou created a point object " + " ( " + xCoordinate + "," + yCoordinate + " ) ");



            Console.WriteLine("Continue? y/n\t");

            var getContinue = Console.ReadKey().KeyChar;

            if (getContinue != 'y')
            {
                toContinue = true;


            }



        }



    }


    public class Point
    {


        public Point(double x, double y)
        {
            double X = x;

            double Y = y;


        }





    }


}
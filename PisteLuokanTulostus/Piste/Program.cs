using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piste
{
    class PointTest
    {
        static void Main(string[] args)
        {
            Point pointA = new Point(3, 4);
            Console.WriteLine(pointA.X + ", " + pointA.Y);
            pointA.X = 6;
            pointA.Y = 9;
            Console.WriteLine(pointA);



            /*Point startingPoint = new Point(3, 4);
            Console.WriteLine(startingPoint.X + ", " + startingPoint.Y);
            startingPoint.X= 6;
            startingPoint.Y= 9;
            Console.WriteLine(startingPoint.X + ", " + startingPoint.Y);*/
        Console.ReadLine();
        }

    }
}

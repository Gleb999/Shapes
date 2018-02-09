using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.Name);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");

            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"),
                new Circle("Beth"), new Hexagon("Linda")};

            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
            ThreeDCitcle o = new ThreeDCitcle();
            o.Draw();
            ((Circle)o).Draw();

            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours
{
    class Triangle : Shape
    {
        public Triangle(Coord a, Coord b, Coord c)
        {
            Coords = new Coord[] { a, b, c };
        }
        public Triangle()
        {
            Coords = new Coord[] { new Coord(), new Coord(), new Coord()};
        }

        public static Triangle Parse(string[] inputs)
        {
            return
                new Triangle(
                    Coord.Parse(inputs[0], inputs[1]),
                    Coord.Parse(inputs[2], inputs[3]),
                    Coord.Parse(inputs[4], inputs[5]));
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Triangle");
            sb.Append(base.ToString());

            return sb.ToString();
        }

        public static Triangle ToTriangle(Shape shape)
        {
            Triangle tr = new Triangle(shape.Coords[0], shape.Coords[1], shape.Coords[2]);
            return tr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours
{
    class Quadrangle : Shape
    {
        
        


        public Quadrangle(Coord a, Coord b, Coord c, Coord d)
        {
            Coords = new Coord[] { a, b, c, d };
        }

        public Quadrangle()
        {
            Coords = new Coord[] { new Coord(), new Coord(), new Coord(), new Coord() };
        }

        public static Quadrangle Parse(string[] inputs)
        {
            return
                new Quadrangle(
                    Coord.Parse(inputs[0], inputs[1]),
                    Coord.Parse(inputs[2], inputs[3]),
                    Coord.Parse(inputs[4], inputs[5]),
                    Coord.Parse(inputs[6], inputs[7]));
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Quadrangle");
            sb.Append(base.ToString());

            return sb.ToString();
        }
        public static Quadrangle ToQuadrangle(Shape shape)
        {
            Quadrangle qa = new Quadrangle(shape.Coords[0], shape.Coords[1], shape.Coords[2], shape.Coords[3]);
            return qa;
        }
    }
}

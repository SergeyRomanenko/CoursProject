using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cours
{
    class DataReader
    {
        


        public static List<Shape> GetData(string filePath)
        {
            using (var sr = new StreamReader(filePath))
            {
                var shapes = new List<Shape>();

                while (!sr.EndOfStream)
                {
                    var inputs = sr.ReadLine().Split();

                    if (inputs.Length == 6)
                        shapes.Add(Triangle.Parse(inputs));
                    else if (inputs.Length == 8)
                        shapes.Add(Quadrangle.Parse(inputs));
                }
                return shapes;
                
            }
        }


    }
}

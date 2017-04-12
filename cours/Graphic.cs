using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours
{
    class Graphic
    {
        System.Windows.Forms.PictureBox Pb;
        
        public void PB(System.Windows.Forms.PictureBox v)
        {
            Pb = v;
        }
        

        public void Draw(Shape fig)
        {
            Graphics g = Graphics.FromHwnd(Pb.Handle);

            for (int i=0;i<fig.Coords.Length;i++)
            {
                int a = fig.Coords.Length - 1;
                if (i < a)
                {
                    g.DrawLine(fig.pen,
                    new Point((int)fig.Coords[i].X, (int)fig.Coords[i].Y),
                    new Point((int)fig.Coords[i + 1].X, (int)fig.Coords[i + 1].Y));
                }
                else
                {
                    g.DrawLine(fig.pen,
                    new Point((int)fig.Coords[i].X, (int)fig.Coords[i].Y),
                    new Point((int)fig.Coords[0].X, (int)fig.Coords[0].Y));
                }

                if (fig.diagonal)
                {
                    DrawDiagonal(fig);
                }
                
            }


           
        }

        public void Draw(List<Shape> shapes)
        {
            foreach (var s in shapes)
            Draw(s);
        }

        public void Draw(List<Quadrangle> shapes)
        {
            foreach (var s in shapes)
                Draw(s);
        }

        public void Draw(List<Triangle> shapes)
        {
            foreach (var s in shapes)
                Draw(s);
        }


        public void DrawDiagonal(Shape q)
        {
            Graphics g = Graphics.FromHwnd(Pb.Handle);
            g.DrawLine(q.pen, 
                (int)q.Coords[0].X, (int)q.Coords[0].Y,
                (int)q.Coords[2].X, (int)q.Coords[2].Y);

            g.DrawLine(q.pen,
                (int)q.Coords[1].X, (int)q.Coords[1].Y,
                (int)q.Coords[3].X, (int)q.Coords[3].Y);


        }

    }
}

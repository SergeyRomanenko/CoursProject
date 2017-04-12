using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cours
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            Graphic gr = new Graphic();
            gr.PB(pb1);
            var shapes = DataReader.GetData("Shapes.txt");//Зчитування з файлу, запис у список фігур
            
            gr.Draw(shapes);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            pb1.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txb1.Text = null;
            using (var sr = new StreamReader("Shapes.txt"))
            {
                var shapes = new List<string>();

                while (!sr.EndOfStream)
                {
                    var inputs = sr.ReadLine();
                        shapes.Add(inputs);
                    txb1.Text +=inputs + Environment.NewLine;
                    
                }
            }

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txb1.Text = null;
            var shapes = DataReader.GetData("Shapes.txt");
            var sb = new StringBuilder();
            shapes.ForEach(t => sb.AppendLine(t.ToString()));
            var shapesInfo = sb.ToString();
            MessageBox.Show(shapesInfo);
            using (var sw = new StreamWriter("Result.txt"))
                sw.Write(shapesInfo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txb1.Text = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити програму?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txb1.Text = null;
            using (var sr = new StreamReader("Result.txt"))
            {
                var shapes = new List<string>();

                while (!sr.EndOfStream)
                {
                    var inputs = sr.ReadLine();
                    shapes.Add(inputs);
                    txb1.Text += inputs + Environment.NewLine;

                }
            }
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            double max_q_area = 0; 
            double min_q_area = 3000000;

            double max_t_area1 = 0;
            double max_t_area = 0;
            Shape max = null;
            
            var maxTriangle = new List<Shape>();
            

            Graphic gr = new Graphic();
            gr.PB(pb1);
            var shapes = DataReader.GetData("Shapes.txt");//Зчитування з файлу, запис у список фігур

            foreach (var s in shapes)//max area
            {

                if (s.Coords.Length == 4 && s.Area > max_q_area)
                {
                    max_q_area = s.Area;
                }
            }

            foreach (var s in shapes)//min area
            {

                if (s.Coords.Length == 4 && s.Area < min_q_area)
                {
                    min_q_area = s.Area;
                }
            }

            foreach (var s in shapes)//diagonal
            {

                if (s.Coords.Length == 4 && (s.Area == max_q_area || s.Area == min_q_area))
                {
                    s.diagonal = true;
                }
            }

            foreach (var s in shapes)//трикутник
            {
                
                if (s.Coords.Length == 3 && s.Area < max_q_area / 2)
                {   
                    s.pen = new Pen(Brushes.Green, 4);
                    maxTriangle.Add(s);
                }
            }

            foreach (var s in maxTriangle)//max area
            {
                if(s.Area > max_t_area)
                {
                    max_t_area = s.Area;
                }

            }

            foreach (var s in maxTriangle)//max triangle 1
            {
                if (max_t_area == s.Area)
                {
                    s.pen= new Pen(Brushes.Blue, 4);
      max = s;
                   
                }
            }

            foreach (var s in maxTriangle)//max area2
            {
                if (s.Area > max_t_area1 && s!=max)
                {
                    max_t_area1 = s.Area;
                }

            }
            foreach (var s in maxTriangle)//max triangle 2
            {   
                if (max_t_area1 == s.Area)
                {
                    s.pen = new Pen(Brushes.Blue, 4);
                }
            }



            gr.Draw(shapes);
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити програму?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void вихідToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити програму?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void вихідToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити програму?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cours
{
    partial class AboutBox2 : Form
    {
        public AboutBox2()
        {
            InitializeComponent();
            this.Text = String.Format("{0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Версия {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.TBD.Text = AssemblyDescription;
        }

        #region Методы доступа к атрибутам сборки

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void відкритиПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
          

        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Shapes.txt");
        }

        private void вихідToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити програму?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TBD.Text = "У файлі задано координати вершин трикутників та чотирикутників. Вивести їх на екран.Ті трикутники периметр яких меншийніж половина периметра найбільшого чотирикутника, виділити окремим кольором. Іншим кольором виділити два трикутники, що відповідають умові та мають найбільший периметр.В найбільшому і найменшому чотирикутнику провести діагоналі.";

        }

        private void виконавToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TBD.Text=@"                      Автор програми:
                      Романенко Сергій
                      Студент групи 4-ОК-2
                      ВК НУХТ";
            System.IO.FileStream fs = new System.IO.FileStream("photo.jpg", System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            logoPictureBox.Image = img;
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void вихідніДаніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Result.txt");
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void завданняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TBD.Text = "У файлі задано координати вершин трикутників та чотирикутників. Вивести їх на екран.Ті трикутники периметр яких меншийніж половина периметра найбільшого чотирикутника, виділити окремим кольором. Іншим кольором виділити два трикутники, що відповідають умові та мають найбільший периметр.В найбільшому і найменшому чотирикутнику провести діагоналі.";
        }

        private void кодПрограмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("cours.sln");
        }
    }
}

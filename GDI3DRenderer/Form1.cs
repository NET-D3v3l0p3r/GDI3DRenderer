using GDI3DRenderer.Maths;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI3DRenderer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vector4 v = new Vector4(0, 0, 0);

            Console.WriteLine(v * Matrix4x4.CreateTranslation(new Vector4(1, 15, 1)));

        }
    }
}

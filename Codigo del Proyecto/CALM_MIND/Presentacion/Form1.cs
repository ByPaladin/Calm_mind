using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Obtén el objeto Graphics
            Graphics g = e.Graphics;

            // Activa el suavizado para mejorar la calidad
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Define el color y el tamaño del círculo
            Brush brush = new SolidBrush(Color.Blue);
            int x = 50;
            int y = 50;
            int diameter = 100;

            // Dibuja el círculo
            g.FillEllipse(brush, x, y, diameter, diameter);
        
        }
    }
}

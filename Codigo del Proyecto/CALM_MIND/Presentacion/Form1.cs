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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderRadius = 10; // Ajusta el radio de los bordes según tus preferencias
            Rectangle rect = new Rectangle(100, 100, 200, 20); // Coordenadas y tamaño del rectángulo

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, 2 * borderRadius, 2 * borderRadius, 180, 90); // Esquina superior izquierda
                path.AddArc(rect.X + rect.Width - 2 * borderRadius, rect.Y, 2 * borderRadius, 2 * borderRadius, 270, 90); // Esquina superior derecha
                path.AddArc(rect.X + rect.Width - 2 * borderRadius, rect.Y + rect.Height - 2 * borderRadius, 2 * borderRadius, 2 * borderRadius, 0, 90); // Esquina inferior derecha
                path.AddArc(rect.X, rect.Y + rect.Height - 2 * borderRadius, 2 * borderRadius, 2 * borderRadius, 90, 90); // Esquina inferior izquierda
                path.CloseFigure();

                e.Graphics.FillPath(Brushes.Transparent, path); // Sin fondo
                e.Graphics.DrawPath(Pens.Black, path); // Borde
            }
        }

    }
}

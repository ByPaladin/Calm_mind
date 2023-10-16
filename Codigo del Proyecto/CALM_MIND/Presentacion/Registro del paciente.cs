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
    public partial class Registro_del_paciente : Form
    {
        public Registro_del_paciente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Registro del paciente";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Registro_del_paciente_Paint(object sender, PaintEventArgs e)
        {
            // Obtén el objeto Graphics
            Graphics gc1 = e.Graphics;

            // Activa el suavizado para mejorar la calidad
            gc1.SmoothingMode = SmoothingMode.AntiAlias;

            // Define el color y el tamaño del círculo
            // Define el color en formato RGB
            Color circleColorc1 = Color.FromArgb(215, 116, 233);
            Brush brushc1 = new SolidBrush(circleColorc1);
            int xc1 = 250;
            int yc1 = -25;
            int diameterc1 = 80;

            // Dibuja el círculo
            gc1.FillEllipse(brushc1, xc1, yc1, diameterc1, diameterc1);

            //C2
            Graphics gc2 = e.Graphics;

            gc2.SmoothingMode = SmoothingMode.AntiAlias;

            Color circleColorc2 = Color.FromArgb(121, 96, 209);
            Brush brushc2 = new SolidBrush(circleColorc2);
            int xc2 = -30;
            int yc2 = 42;
            int diameterc2 = 80;

            gc2.FillEllipse(brushc2, xc2, yc2, diameterc2, diameterc2);
            //
            //C3
            Graphics gc3 = e.Graphics;

            gc3.SmoothingMode = SmoothingMode.AntiAlias;

            Color circleColorc3 = Color.FromArgb(121, 96, 209);
            Brush brushc3 = new SolidBrush(circleColorc3);
            int xc3 = 4;
            int yc3 = 8;
            int diameterc3 = 80;

            gc3.FillEllipse(brushc3, xc3, yc3, diameterc3, diameterc3);
            //
            //C4
            Graphics gc4 = e.Graphics;

            gc3.SmoothingMode = SmoothingMode.AntiAlias;

            Color circleColorc4 = Color.FromArgb(207, 147, 218);
            Brush brushc4 = new SolidBrush(circleColorc4);
            int xc4 = 254;
            int yc4 = 210;
            int diameterc4 = 80;

            gc4.FillEllipse(brushc4, xc4, yc4, diameterc4, diameterc4);
            //
            //C5
            Graphics gc5 = e.Graphics;

            gc5.SmoothingMode = SmoothingMode.AntiAlias;

            Color circleColorc5 = Color.FromArgb(228, 180, 237);
            Brush brushc5 = new SolidBrush(circleColorc5);
            int xc5 = -20;
            int yc5 = 250;
            int diameterc5 = 80;

            gc5.FillEllipse(brushc5, xc5, yc5, diameterc5, diameterc5);
            //
            //C6
            Graphics gc6 = e.Graphics;

            gc6.SmoothingMode = SmoothingMode.AntiAlias;

            Color circleColorc6 = Color.FromArgb(228, 180, 237);
            Brush brushc6 = new SolidBrush(circleColorc6);
            int xc6 = 5;
            int yc6 = 275;
            int diameterc6 = 80;

            gc6.FillEllipse(brushc6, xc6, yc6, diameterc6, diameterc6);
            //
            //A1
            Graphics ga1 = e.Graphics;
            ga1.SmoothingMode = SmoothingMode.AntiAlias;

            // Define el color del borde en formato RGB
            Color borderColor = Color.FromArgb(147, 112, 219);

            Pen pena1 = new Pen(borderColor, 10); // 12 es el ancho del borde
            int xa1 = 244;
            int ya1 = 162;
            int diametera1 = 70;

            ga1.DrawEllipse(pena1, xa1, ya1, diametera1, diametera1);
            //
        }
    }
}

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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);
            progressBar1.Visible = false;
            if (progressBar1.Value == 100) 
            {
                timer1.Enabled = false;
                Form inicio = new Ventana_de_inicio();
                inicio.FormClosed += (s, args) => this.Close();
                inicio.Show();
                this.Hide(); 
            }
        }

    }
}

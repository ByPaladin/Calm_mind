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
    public partial class Ventana_de_inicio : Form
    {
        public Ventana_de_inicio()
        {
            InitializeComponent(); 
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Ventana de inicio";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Ventana_de_inicio_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form registro_p = new Registro_del_psicologo();
            registro_p.FormClosed += (s, args) => this.Close();
            registro_p.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

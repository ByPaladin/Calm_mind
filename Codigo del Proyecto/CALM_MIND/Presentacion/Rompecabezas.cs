using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Rompecabezas : Form
    {
        public int Contador;

        List<PictureBox> pictureboxlist = new List<PictureBox>();
        List<Bitmap> images = new List<Bitmap>();
        List<string> locations = new List<string>();
        List<string> current_locations = new List<string>();

        string win_position;
        string current_position;

        Bitmap MainBitmap;

        public Rompecabezas()
        {
            InitializeComponent();
            Contador = 0;
        }

       
        private void TSMI_Abrir_Click(object sender, EventArgs e)
        {
            if (pictureboxlist != null)
            {

                foreach (PictureBox pics in pictureboxlist.ToList())
                {
                    this.Controls.Remove(pics);
                }

                pictureboxlist.Clear();
                images.Clear();
                locations.Clear();
                current_locations.Clear();
                win_position = string.Empty;
                current_position = string.Empty;
                Lbl_Estado.Text = string.Empty;
            }

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files Only | *.jpg; *.jpeg; *.gif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                MainBitmap = new Bitmap(open.FileName);
                CreatePictureBoxes();
                AddImages();
            }
            Temporizador.Enabled = true;
        }

        private void CreatePictureBoxes()
        {
            for (int i = 0; i < 9; i++)
            {

                PictureBox temp_pic = new PictureBox();
                temp_pic.Size = new Size(130, 130);
                temp_pic.Tag = i.ToString();
                temp_pic.Click += OnPicClick;
                pictureboxlist.Add(temp_pic);
                locations.Add(temp_pic.Tag.ToString());
            }
        }

        private void OnPicClick(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            PictureBox emptyBox = pictureboxlist.Find(x => x.Tag.ToString() == "0");

            Point pic1 = new Point(pictureBox.Location.X, pictureBox.Location.Y);
            Point pic2 = new Point(emptyBox.Location.X, emptyBox.Location.Y);

            var index1 = this.Controls.IndexOf(pictureBox);
            var index2 = this.Controls.IndexOf(emptyBox);

            if (pictureBox.Right == emptyBox.Left && pictureBox.Location.Y == emptyBox.Location.Y
                || pictureBox.Left == emptyBox.Right && pictureBox.Location.Y == emptyBox.Location.Y
                || pictureBox.Top == emptyBox.Bottom && pictureBox.Location.X == emptyBox.Location.X
                || pictureBox.Bottom == emptyBox.Top && pictureBox.Location.X == emptyBox.Location.X
                )
            {
                pictureBox.Location = pic2;
                emptyBox.Location = pic1;

                this.Controls.SetChildIndex(pictureBox, index2);
                this.Controls.SetChildIndex(emptyBox, index1);
            }

            Lbl_Estado.Text = "";
            current_locations.Clear();
            CheckGame();
        }

        private void CropImage(Bitmap main_bitmap, int height, int width)
        {
            int x, y;
            x = 0;
            y = 0;

            for (int blocks = 0; blocks < 9; blocks++)
            {
                Bitmap cropped_image = new Bitmap(height, width);

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        cropped_image.SetPixel(i, j, main_bitmap.GetPixel((i + x), (j + y)));
                    }
                }
                images.Add(cropped_image);
                x += 130;
                if (x == 390)
                {
                    x = 0;
                    y += 130;
                }
            }
        }

        private void AddImages()
        {
            Bitmap tempBitmap = new Bitmap(MainBitmap, new Size(390, 390));

            CropImage(tempBitmap, 130, 130);

            for (int i = 1; i < pictureboxlist.Count; i++)
            {
                pictureboxlist[i].BackgroundImage = (Image)images[i];
            }

            PlacePictureBoxesToForm();
        }

        private void PlacePictureBoxesToForm()
        {
            var shuffleImages = pictureboxlist.OrderBy(a => Guid.NewGuid()).ToList();
            pictureboxlist = shuffleImages;
            int x = 200;
            int y = 25;

            for (int i = 0; i < pictureboxlist.Count; i++)
            {
                pictureboxlist[i].BackColor = Color.HotPink;

                if (i == 3 || i == 6)
                {
                    y += 130;
                    x = 200;
                }

                pictureboxlist[i].BorderStyle = BorderStyle.FixedSingle;
                pictureboxlist[i].Location = new Point(x, y);

                this.Controls.Add(pictureboxlist[i]);
                x += 130;

                win_position += locations[i];
            }
        }

        private void CheckGame()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    current_locations.Add(x.Tag.ToString());
                }
            }

            current_position = string.Join("", current_locations);
            Lbl_Lista.Text = win_position;
            Lbl_Estado.Text = current_position;

            if (win_position == current_position)
            {
                Lbl_Estado.Text = "!Ganaste!";
                Temporizador.Stop();

                //Una vez finalice se debe pasar el valor del Temporizador a la base de datos
                MessageBox.Show("!!!Felicidades has Ganado, Pasar la Variable del temporizador a la base de datos!!!", "Fin del Juego");
                this.Close();
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Contador++;
        }

        private void Btn_Detener_Click(object sender, EventArgs e)
        {
            Temporizador.Enabled = false;
            DialogResult r = MessageBox.Show("! La consulta se dentendra !", "Precaución", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                Temporizador.Enabled = false;
                this.Close();
            }
            else if (r == DialogResult.Cancel)
            {
                Temporizador.Enabled = true;
            }
            
        }
    }
}

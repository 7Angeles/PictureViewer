using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butonMostar_Click(object sender, EventArgs e)
        {
        //Muestra el cuadro de dialogo abir archibo.Si el usuario hace click en aceptar
        //carga la imagen que el usuario eligio
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void butonCerrar_Click(object sender, EventArgs e)
        {
            //Cerrar formulario
            this.Close();
        }

        private void butonBorrar_Click(object sender, EventArgs e)
        {
            //Borrar la imagen
            pictureBox1.Image = null;
        }

        private void butonFondo_Click(object sender, EventArgs e)
        {
            //Muestra el cuadro dialogo de color. Si el usuario ase click en aseptar canbie el
            //fondo del control PictureBox al color elegido por el usuario 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //si el usuario selexsiona la casilla de verificasion estirar
            //canbiar el PictureBox
            //Propiedades SizeMode para "estirar".si el usuario borra
            //la casilla de verificasion canbiala a "normal"
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

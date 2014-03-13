using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuerraDeEstrellas
{
    public partial class BancoPreguntas : Form
    {
        public BancoPreguntas()
        {
            InitializeComponent();
        }

        private void BancoPreguntas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdeDPreguntasDataSet.Pregunta' table. You can move, or remove it, as needed.
            this.preguntaTableAdapter.Fill(this.bdeDPreguntasDataSet.Pregunta);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class RegistroJug : Form
    {
        String nomJugUno;
        String nomJugDos;

        public RegistroJug()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btonAccJuego_Click(object sender, EventArgs e)
        {
            if (this.txtJugUno.Text == "")
            {
                this.nomJugUno = "Jugador 1";
            }
            else
            {
                this.nomJugUno = txtJugUno.Text.ToString();
            }

            if (this.txtJugDos.Text == "")
            {
                this.nomJugDos = "Jugador2";
            }
            else
            {
                this.nomJugDos = this.txtJugDos.Text.ToString();
            }

            Juego nuevo = new Juego(nomJugUno, nomJugDos);
            this.Visible = false;            
            nuevo.ShowDialog();
            if (nuevo.cerro)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
            }


        }

        private void linkAdmon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BancoPreguntas preguntas = new BancoPreguntas();
            this.Visible = false;
            preguntas.ShowDialog();
            this.Visible = true;
        }
    }
}

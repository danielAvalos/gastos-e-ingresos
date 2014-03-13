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
    public partial class Juego : Form
    {
        public Boolean cerro = false;
        int incorrectaUno;
        int incorrectaDos;
        int contestadasUno;
        int contestadasDos;
        Boolean ganoJugUno;
        Boolean ganoJugDos;
        bool turnoJugUno;
        bool turnoJugDos;
        List<int> btonesJugadorUno;
        List<int> btonesJugadorDos;

        //Constructor de la clase
        public Juego(String jugUno, String JugDos)
        {
            InitializeComponent();
            this.lblJugUno.Text = jugUno;
            this.lblJugDos.Text = JugDos;
            desabilitarBotones();
        }

        //evento cargar se ejecuta cuando se crea el objeto
        private void Form1_Load(object sender, EventArgs e)
        {            
            this.StartPosition = FormStartPosition.CenterParent;
            this.btonesJugadorUno = new List<int>();
            this.btonesJugadorDos = new List<int>();
            InicializarJuego();
        }

        private void habilitarBotones()
        {
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
            this.button10.Enabled = true;
            this.button11.Enabled = true;
            this.button12.Enabled = true;
            this.button13.Enabled = true;
            this.button14.Enabled = true;
            this.button15.Enabled = true;
            this.button16.Enabled = true;
            this.button17.Enabled = true;
            this.button18.Enabled = true;
            this.button19.Enabled = true;
            this.button20.Enabled = true;
            this.button21.Enabled = true;
            this.button22.Enabled = true;
            this.button23.Enabled = true;
            this.button24.Enabled = true;
            this.button25.Enabled = true;

        }

        private void desabilitarBotones()
        {
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button7.Enabled = false;
            this.button8.Enabled = false;
            this.button9.Enabled = false;
            this.button10.Enabled = false;
            this.button11.Enabled = false;
            this.button12.Enabled = false;
            this.button13.Enabled = false;
            this.button14.Enabled = false;
            this.button15.Enabled = false;
            this.button16.Enabled = false;
            this.button17.Enabled = false;
            this.button18.Enabled = false;
            this.button19.Enabled = false;
            this.button20.Enabled = false;
            this.button21.Enabled = false;
            this.button22.Enabled = false;
            this.button23.Enabled = false;
            this.button24.Enabled = false;
            this.button25.Enabled = false;
        }

        private void pintarBotones()
        {
            this.button1.BackColor = System.Drawing.Color.White;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button4.BackColor = System.Drawing.Color.White;
            this.button5.BackColor = System.Drawing.Color.White;
            this.button6.BackColor = System.Drawing.Color.White;
            this.button7.BackColor = System.Drawing.Color.White;
            this.button8.BackColor = System.Drawing.Color.White;
            this.button9.BackColor = System.Drawing.Color.White;
            this.button10.BackColor = System.Drawing.Color.White;
            this.button11.BackColor = System.Drawing.Color.White;
            this.button12.BackColor = System.Drawing.Color.White;
            this.button13.BackColor = System.Drawing.Color.White;
            this.button14.BackColor = System.Drawing.Color.White;
            this.button15.BackColor = System.Drawing.Color.White;
            this.button16.BackColor = System.Drawing.Color.White;
            this.button17.BackColor = System.Drawing.Color.White;
            this.button18.BackColor = System.Drawing.Color.White;
            this.button19.BackColor = System.Drawing.Color.White;
            this.button20.BackColor = System.Drawing.Color.White;
            this.button21.BackColor = System.Drawing.Color.White;
            this.button22.BackColor = System.Drawing.Color.White;
            this.button23.BackColor = System.Drawing.Color.White;
            this.button24.BackColor = System.Drawing.Color.White;
            this.button25.BackColor = System.Drawing.Color.White;

        }

        private void InicializarJuego()
        {
            turnoJugUno = true;
            turnoJugDos = true;
            desabilitarBotones();
            this.btonIniciar.Enabled = true;
            pintarBotones();
            this.lblContestadasJugDos.Text = "0";
            this.lblContestadasJugUno.Text = "0";
            this.lblPregIncUno.Text = "0";
            this.lblPregIncDos.Text = "0";
            this.btonTerminar.Enabled = false;
            this.btonesJugadorUno.Clear();
            this.btonesJugadorDos.Clear();
            contestadasDos = 0;
            contestadasUno = 0;
            incorrectaUno = 0;
            incorrectaDos = 0;
            this.lblTurnoActual.Text = "[  ]";
        }

        //Configuraciones para inicializar los botones y puntajes del juego
        private void btonIniciar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            pintarBotones();
            this.btonIniciar.Enabled = false;
            this.btonTerminar.Enabled = true;
            this.lblTurnoActual.ForeColor = System.Drawing.Color.Purple;
            this.lblTurnoActual.Text = this.lblJugUno.Text;
        }

        //metodo para validar si el boton que se presiono es valido  o no
        private Boolean esVecino(String boton)
        {
            int bton = Convert.ToInt32(boton);
            //si es el turno del jugador 1 entra a esta opcion para validar sus posibles vecinos
            if (this.turnoJugUno)
            {
                //si el jugador 1 nunca a presionado un boton los posibles q puede presionar la primera vez
                if (this.btonesJugadorUno.Count == 0)
                {
                    for (int i = 1; i <= 21; i = i +5)
                    {
                        if (bton == i)
                        {
                            return true;
                        }                        
                    }
                }
                //Aqui se valida cuando ya el jugador 1 a presionado por lo menos un boton
                else
                {
                    if (this.btonesJugadorUno.Contains(bton + 1) || this.btonesJugadorUno.Contains(bton + 5)
                    || this.btonesJugadorUno.Contains(bton - 1) || this.btonesJugadorUno.Contains(bton - 5))
                    {                        
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            //Cuando el jugador 2 presiona un boton se ejecuuta 
            else if (this.turnoJugDos)
            {
                if (this.btonesJugadorDos.Count == 0)
                {
                    //cuando el jugador 2 presiona 1 boton la primera vez valida si es correcto
                    for (int i = 5; i <= 25; i = i + 5)
                    {
                        if (bton == i)
                        {                            
                            return true;
                        }
                    }
                }
                else
                {
                    if (this.btonesJugadorDos.Contains(bton + 1) || this.btonesJugadorDos.Contains(bton - 5)
                    || this.btonesJugadorDos.Contains(bton + 5) || this.btonesJugadorDos.Contains(bton - 1))
                    {                        
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        //Metodo para validar si el jugador actual gano
        private Boolean Gano()
        {
            //se activa si el jugador 1 contesto correctamente
            if (this.turnoJugUno)
            {
                //estos son los posibles botones a los q debe llegar el jugador 1 para poder ganas
                for (int i = 5; i <= 25; i= i + 5)
                {
                    if (this.btonesJugadorUno.Contains(i))
                    {
                        this.ganoJugUno = true;
                        return this.ganoJugUno;
                    }
                }
                return false;
            }
                //Si es el turno del jugador 2 
            else 
            {
                //Estos son los botones a los que debe llegar el jugador 2 para poder ganar
                for (int i = 1; i <= 21; i = i + 5)
                {
                    if (this.btonesJugadorDos.Contains(i))
                    {
                        this.ganoJugDos = true;
                        return this.ganoJugDos;
                    }
                }
                return false;
            }
            
        }

        //Este es el evento click cuando le damos click a un boton del juego
        private void btonJuego_click(object sender, EventArgs e)
        {
            //Aqui valida si es vecino, si no lo es entonces muestra este mensaje
            if (!esVecino(((Button)sender).Text.ToString()))
            {
                MessageBox.Show("Solo se puede seleccionar puntos Vecinos", "Espera");
            }
            else
            {              
                 //Aqui instancio una nueva pregunta             
                Pregunta nueva = new Pregunta();                
                //Aqui entra si es el turno del jugador 1
                if (turnoJugUno)
                {
                    //Abre la pregunta
                    nueva.ShowDialog();
                    //valida si la pregunta esta correcta si es asi entra aqui
                    if (nueva.Correcta)
                    {
                        //Agrega los valores respectivos al jugador 1
                        contestadasUno += 1;
                        this.lblContestadasJugUno.Text = contestadasUno.ToString();
                        //Añade a las lista del jugador 1 el boton ganado para desbloquiar nuevos vecinos
                        this.btonesJugadorUno.Add((Convert.ToInt32(((Button)sender).Text)));
                        ((Button)sender).BackColor = System.Drawing.Color.Purple;                        
                        ((Button)sender).Enabled = false;
                        //Valida si el jugador 1 gano
                        Gano();
                        if (ganoJugUno)
                        {
                            MessageBox.Show("Ha Ganado El jugador " + lblJugUno.Text, "FELICITACIONES");
                            DialogResult result = MessageBox.Show("Deseas Iniciar una nueva Partida? ", "Confirmacion", MessageBoxButtons.YesNo);
                            if (result.ToString().Equals("Yes"))
                            {
                                InicializarJuego();
                            }
                            else
                            {

                                this.Close();
                            }
                        }
                    }
                    //Si la pregunta es incorrecta entra por aqui y pinta     
                    else
                    {
                        incorrectaUno += 1;
                        this.lblPregIncUno.Text = incorrectaUno.ToString();
                    }
                    this.turnoJugUno = false;
                    this.lblTurnoActual.ForeColor = System.Drawing.Color.Red;
                    this.lblTurnoActual.Text = this.lblJugDos.Text;
                    this.turnoJugDos = true;
                }
                    //Aqui entra si es turno del jugador 2
                else if (turnoJugDos)
                {
                    nueva.ShowDialog();
                    if (nueva.Correcta)
                    {
                        ((Button)sender).Enabled = false;
                        contestadasDos += 1;
                        this.lblContestadasJugDos.Text = contestadasDos.ToString();
                        //Aqui añade a la lista del jugador 2 el Boton que acabo de desbloquiar 
                        //para asi poder tener nuevos vecinos
                        this.btonesJugadorDos.Add((Convert.ToInt32(((Button)sender).Text)));
                        ((Button)sender).BackColor = System.Drawing.Color.Red;
                        Gano();
                        if (ganoJugDos)
                        {
                            MessageBox.Show("Ha Ganado El jugador " + lblJugDos.Text, "FELICITACIONES");
                            DialogResult result = MessageBox.Show("Deseas Iniciar una nueva Partida? ", "Confirmacion", MessageBoxButtons.YesNo);
                            if (result.ToString().Equals("Yes"))
                            {
                                InicializarJuego();
                            }
                            else
                            {

                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        incorrectaDos += 1;
                        this.lblPregIncDos.Text = incorrectaDos.ToString();
                    }
                    this.turnoJugUno = true;
                    this.lblTurnoActual.ForeColor = System.Drawing.Color.Purple;
                    this.lblTurnoActual.Text = this.lblJugUno.Text;
                    this.turnoJugDos = false;
                }

            }
        }

        //Este es el evento para cerra el juego y terminarlo 

        private void btonTerminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Perdera El progeso de esta partida \n"+
                                                      "Desea Continuar? ","Advertencia",MessageBoxButtons.YesNo);
            if (resultado.ToString().Equals("Yes"))
            {
                MessageBox.Show("Respuestas Correctas jugador 1: " + lblContestadasJugUno.Text +
                    "\n" + "Respuestas Correctas Jugador 2: " + lblContestadasJugDos.Text, "Resultados");
                DialogResult result = MessageBox.Show("Desea Volver a iniciar la partida", "Confirmacion", MessageBoxButtons.YesNo);
                if (result.ToString().Equals("Yes"))
                {
                    InicializarJuego();
                }
                else
                {
                    cerro = true;
                    this.Close();                      
                }
            }
        }

        //Este es el evento para volver a la pagina principal  (Registro Juego)
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!this.btonIniciar.Enabled)
            {
                DialogResult resultado = MessageBox.Show("Ya has iniciado la partida, perderas el progreso \n" +
                                                       "Desea Continuar? ", "Advertencia", MessageBoxButtons.YesNo);
                if (resultado.ToString().Equals("Yes"))
                {
                    MessageBox.Show("Respuestas Correctas jugador 1: " + lblContestadasJugUno.Text +
                        "\n" + "Respuestas Correctas Jugador 2: " + lblContestadasJugDos.Text, "Resultados");
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}

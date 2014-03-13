using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GuerraDeEstrellas
{
    public partial class Pregunta : Form
    {
        public Boolean Correcta;
        String coneccion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\BdeDPreguntas.mdb;Persist Security Info=True";
        String respuesta;

        //Constructor de la clase
        public Pregunta()
        {
            InitializeComponent();
            Correcta = false;
            crearPregunta();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Metodo para crear una pregunta aleatoriamente
        public void crearPregunta()
        {
            DataTable dt = new DataTable();
            //numero aleatorio
            Random r = new Random();
            int numAleatorio = r.Next(2, 30);
            //Busqueda en la base de datos
            String seleccion = "SELECT * FROM Pregunta WHERE Id= " + numAleatorio;
            OleDbDataAdapter da = new OleDbDataAdapter(seleccion, coneccion);
            da.Fill(dt);
            lblPregunta.Text = dt.Rows[0][1].ToString();
            //Aqui añande las posibles respuestas al combo box
            for (int i = 2; i < 6; i++)
            {
                this.comboBox1.Items.Add(dt.Rows[0][i].ToString());
            }
            respuesta = dt.Rows[0][7].ToString();            
        }

        private void btonAceptar_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debes Seleccionar una respuesta", "Advertencia");
            }
            else if (this.comboBox1.SelectedItem.Equals(respuesta))
            {
                Correcta = true;                
                this.Close();
            }
            else
            {                
                this.Close();
            }
        }
    }
}

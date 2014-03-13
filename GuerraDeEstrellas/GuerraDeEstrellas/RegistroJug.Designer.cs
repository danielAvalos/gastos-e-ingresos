namespace GuerraDeEstrellas
{
    partial class RegistroJug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtJugUno = new System.Windows.Forms.TextBox();
            this.txtJugDos = new System.Windows.Forms.TextBox();
            this.lblJugUno = new System.Windows.Forms.Label();
            this.lblJugdos = new System.Windows.Forms.Label();
            this.btonAccJuego = new System.Windows.Forms.Button();
            this.linkAdmon = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtJugUno
            // 
            this.txtJugUno.Location = new System.Drawing.Point(142, 31);
            this.txtJugUno.Name = "txtJugUno";
            this.txtJugUno.Size = new System.Drawing.Size(100, 20);
            this.txtJugUno.TabIndex = 0;
            // 
            // txtJugDos
            // 
            this.txtJugDos.Location = new System.Drawing.Point(142, 76);
            this.txtJugDos.Name = "txtJugDos";
            this.txtJugDos.Size = new System.Drawing.Size(100, 20);
            this.txtJugDos.TabIndex = 1;
            // 
            // lblJugUno
            // 
            this.lblJugUno.AutoSize = true;
            this.lblJugUno.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugUno.Location = new System.Drawing.Point(12, 33);
            this.lblJugUno.Name = "lblJugUno";
            this.lblJugUno.Size = new System.Drawing.Size(114, 15);
            this.lblJugUno.TabIndex = 2;
            this.lblJugUno.Text = "Nombre Jugador1: ";
            // 
            // lblJugdos
            // 
            this.lblJugdos.AutoSize = true;
            this.lblJugdos.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugdos.Location = new System.Drawing.Point(12, 78);
            this.lblJugdos.Name = "lblJugdos";
            this.lblJugdos.Size = new System.Drawing.Size(111, 15);
            this.lblJugdos.TabIndex = 3;
            this.lblJugdos.Text = "Nombre Jugador2:";
            // 
            // btonAccJuego
            // 
            this.btonAccJuego.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonAccJuego.Location = new System.Drawing.Point(68, 123);
            this.btonAccJuego.Name = "btonAccJuego";
            this.btonAccJuego.Size = new System.Drawing.Size(128, 23);
            this.btonAccJuego.TabIndex = 4;
            this.btonAccJuego.Text = "Acceder al  juego";
            this.btonAccJuego.UseVisualStyleBackColor = true;
            this.btonAccJuego.Click += new System.EventHandler(this.btonAccJuego_Click);
            // 
            // linkAdmon
            // 
            this.linkAdmon.AutoSize = true;
            this.linkAdmon.Location = new System.Drawing.Point(101, 178);
            this.linkAdmon.Name = "linkAdmon";
            this.linkAdmon.Size = new System.Drawing.Size(141, 13);
            this.linkAdmon.TabIndex = 5;
            this.linkAdmon.TabStop = true;
            this.linkAdmon.Text = "Ingresar Como Administrador";
            this.linkAdmon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdmon_LinkClicked);
            // 
            // RegistroJug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(276, 202);
            this.Controls.Add(this.linkAdmon);
            this.Controls.Add(this.btonAccJuego);
            this.Controls.Add(this.lblJugdos);
            this.Controls.Add(this.lblJugUno);
            this.Controls.Add(this.txtJugDos);
            this.Controls.Add(this.txtJugUno);
            this.Name = "RegistroJug";
            this.Text = "Registro Jugadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJugUno;
        private System.Windows.Forms.TextBox txtJugDos;
        private System.Windows.Forms.Label lblJugUno;
        private System.Windows.Forms.Label lblJugdos;
        private System.Windows.Forms.Button btonAccJuego;
        private System.Windows.Forms.LinkLabel linkAdmon;
    }
}
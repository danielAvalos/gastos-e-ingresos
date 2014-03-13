namespace GuerraDeEstrellas
{
    partial class BancoPreguntas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BancoPreguntas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preguntaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcion1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcion2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcion3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcion4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcion5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respuestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preguntaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdeDPreguntasDataSet = new GuerraDeEstrellas.BdeDPreguntasDataSet();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.preguntaTableAdapter = new GuerraDeEstrellas.BdeDPreguntasDataSetTableAdapters.PreguntaTableAdapter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preguntaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdeDPreguntasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.preguntaDataGridViewTextBoxColumn,
            this.opcion1DataGridViewTextBoxColumn,
            this.opcion2DataGridViewTextBoxColumn,
            this.opcion3DataGridViewTextBoxColumn,
            this.opcion4DataGridViewTextBoxColumn,
            this.opcion5DataGridViewTextBoxColumn,
            this.respuestaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.preguntaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(359, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // preguntaDataGridViewTextBoxColumn
            // 
            this.preguntaDataGridViewTextBoxColumn.DataPropertyName = "Pregunta";
            this.preguntaDataGridViewTextBoxColumn.HeaderText = "Pregunta";
            this.preguntaDataGridViewTextBoxColumn.Name = "preguntaDataGridViewTextBoxColumn";
            // 
            // opcion1DataGridViewTextBoxColumn
            // 
            this.opcion1DataGridViewTextBoxColumn.DataPropertyName = "opcion1";
            this.opcion1DataGridViewTextBoxColumn.HeaderText = "opcion1";
            this.opcion1DataGridViewTextBoxColumn.Name = "opcion1DataGridViewTextBoxColumn";
            // 
            // opcion2DataGridViewTextBoxColumn
            // 
            this.opcion2DataGridViewTextBoxColumn.DataPropertyName = "opcion2";
            this.opcion2DataGridViewTextBoxColumn.HeaderText = "opcion2";
            this.opcion2DataGridViewTextBoxColumn.Name = "opcion2DataGridViewTextBoxColumn";
            // 
            // opcion3DataGridViewTextBoxColumn
            // 
            this.opcion3DataGridViewTextBoxColumn.DataPropertyName = "opcion3";
            this.opcion3DataGridViewTextBoxColumn.HeaderText = "opcion3";
            this.opcion3DataGridViewTextBoxColumn.Name = "opcion3DataGridViewTextBoxColumn";
            // 
            // opcion4DataGridViewTextBoxColumn
            // 
            this.opcion4DataGridViewTextBoxColumn.DataPropertyName = "opcion4";
            this.opcion4DataGridViewTextBoxColumn.HeaderText = "opcion4";
            this.opcion4DataGridViewTextBoxColumn.Name = "opcion4DataGridViewTextBoxColumn";
            // 
            // opcion5DataGridViewTextBoxColumn
            // 
            this.opcion5DataGridViewTextBoxColumn.DataPropertyName = "opcion 5";
            this.opcion5DataGridViewTextBoxColumn.HeaderText = "opcion 5";
            this.opcion5DataGridViewTextBoxColumn.Name = "opcion5DataGridViewTextBoxColumn";
            // 
            // respuestaDataGridViewTextBoxColumn
            // 
            this.respuestaDataGridViewTextBoxColumn.DataPropertyName = "Respuesta";
            this.respuestaDataGridViewTextBoxColumn.HeaderText = "Respuesta";
            this.respuestaDataGridViewTextBoxColumn.Name = "respuestaDataGridViewTextBoxColumn";
            // 
            // preguntaBindingSource
            // 
            this.preguntaBindingSource.DataMember = "Pregunta";
            this.preguntaBindingSource.DataSource = this.bdeDPreguntasDataSet;
            // 
            // bdeDPreguntasDataSet
            // 
            this.bdeDPreguntasDataSet.DataSetName = "BdeDPreguntasDataSet";
            this.bdeDPreguntasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Location = new System.Drawing.Point(12, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(359, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Preguntas y Respuestas";
            // 
            // preguntaTableAdapter
            // 
            this.preguntaTableAdapter.ClearBeforeFill = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(239, 418);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 17);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Regresar A Principal";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BancoPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(403, 444);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BancoPreguntas";
            this.Text = "Banco de Preguntas";
            this.Load += new System.EventHandler(this.BancoPreguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preguntaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdeDPreguntasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitulo;
        private BdeDPreguntasDataSet bdeDPreguntasDataSet;
        private System.Windows.Forms.BindingSource preguntaBindingSource;
        private BdeDPreguntasDataSetTableAdapters.PreguntaTableAdapter preguntaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preguntaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcion1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcion2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcion3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcion4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcion5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
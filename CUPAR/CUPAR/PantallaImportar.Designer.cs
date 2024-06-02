namespace CUPAR
{
    partial class PantallaImportar
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblBodega = new System.Windows.Forms.Label();
            this.btnImportarDatos = new System.Windows.Forms.Button();
            this.dtgBodegaSeleccionada = new System.Windows.Forms.DataGridView();
            this.aniada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDeCata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varietal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maridaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBodegaSeleccionada)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(254, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblBodega
            // 
            this.lblBodega.AutoSize = true;
            this.lblBodega.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodega.Location = new System.Drawing.Point(251, 122);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(306, 19);
            this.lblBodega.TabIndex = 2;
            this.lblBodega.Text = "Bodegas con Actualizaciones";
            this.lblBodega.Visible = false;
            // 
            // btnImportarDatos
            // 
            this.btnImportarDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImportarDatos.Location = new System.Drawing.Point(273, 63);
            this.btnImportarDatos.Name = "btnImportarDatos";
            this.btnImportarDatos.Size = new System.Drawing.Size(237, 42);
            this.btnImportarDatos.TabIndex = 3;
            this.btnImportarDatos.Text = "Boton Importar Datos Vinos";
            this.btnImportarDatos.UseVisualStyleBackColor = false;
            this.btnImportarDatos.Click += new System.EventHandler(this.btnImportarDatos_Click);
            // 
            // dtgBodegaSeleccionada
            // 
            this.dtgBodegaSeleccionada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBodegaSeleccionada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aniada,
            this.nombre,
            this.notaDeCata,
            this.varietal,
            this.maridaje,
            this.precio});
            this.dtgBodegaSeleccionada.Location = new System.Drawing.Point(83, 200);
            this.dtgBodegaSeleccionada.Name = "dtgBodegaSeleccionada";
            this.dtgBodegaSeleccionada.Size = new System.Drawing.Size(643, 216);
            this.dtgBodegaSeleccionada.TabIndex = 4;
            // 
            // aniada
            // 
            this.aniada.HeaderText = "Aniada";
            this.aniada.Name = "aniada";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // notaDeCata
            // 
            this.notaDeCata.HeaderText = "Nota de Cata";
            this.notaDeCata.Name = "notaDeCata";
            // 
            // varietal
            // 
            this.varietal.HeaderText = "Varietal";
            this.varietal.Name = "varietal";
            //
            // maridaje
            // 
            this.maridaje.HeaderText = "Maridaje";
            this.maridaje.Name = "maridaje";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // PantallaImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgBodegaSeleccionada);
            this.Controls.Add(this.btnImportarDatos);
            this.Controls.Add(this.lblBodega);
            this.Controls.Add(this.comboBox1);
            this.Name = "PantallaImportar";
            this.Text = "PantallaImportar";
            this.Load += new System.EventHandler(this.PantallaImportar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBodegaSeleccionada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.Button btnImportarDatos;
        private System.Windows.Forms.DataGridView dtgBodegaSeleccionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniada;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDeCata;
        private System.Windows.Forms.DataGridViewTextBoxColumn varietal;
        private System.Windows.Forms.DataGridViewTextBoxColumn maridaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}
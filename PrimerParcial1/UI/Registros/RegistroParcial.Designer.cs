namespace PrimerParcial1
{
    partial class RegistroParcial
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ID = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.BotonNuevo = new System.Windows.Forms.Button();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.DatepickerFecha = new System.Windows.Forms.DateTimePicker();
            this.DescripcionText = new System.Windows.Forms.TextBox();
            this.CantidadNumeric = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.Fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(92, 33);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(43, 35);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(45, 13);
            this.ID.TabIndex = 1;
            this.ID.Text = "IdGrupo";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(135, 23);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(73, 36);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // BotonNuevo
            // 
            this.BotonNuevo.Location = new System.Drawing.Point(46, 350);
            this.BotonNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonNuevo.Name = "BotonNuevo";
            this.BotonNuevo.Size = new System.Drawing.Size(78, 43);
            this.BotonNuevo.TabIndex = 3;
            this.BotonNuevo.Text = "nuevo";
            this.BotonNuevo.UseVisualStyleBackColor = true;
            this.BotonNuevo.Click += new System.EventHandler(this.BotonNuevo_Click);
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Location = new System.Drawing.Point(176, 350);
            this.BotonGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(82, 43);
            this.BotonGuardar.TabIndex = 4;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(314, 350);
            this.BotonEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(78, 43);
            this.BotonEliminar.TabIndex = 5;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            // 
            // DatepickerFecha
            // 
            this.DatepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatepickerFecha.Location = new System.Drawing.Point(92, 64);
            this.DatepickerFecha.Name = "DatepickerFecha";
            this.DatepickerFecha.Size = new System.Drawing.Size(109, 20);
            this.DatepickerFecha.TabIndex = 6;
            // 
            // DescripcionText
            // 
            this.DescripcionText.Location = new System.Drawing.Point(92, 114);
            this.DescripcionText.Multiline = true;
            this.DescripcionText.Name = "DescripcionText";
            this.DescripcionText.Size = new System.Drawing.Size(200, 48);
            this.DescripcionText.TabIndex = 7;
            // 
            // CantidadNumeric
            // 
            this.CantidadNumeric.Location = new System.Drawing.Point(149, 180);
            this.CantidadNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.CantidadNumeric.Name = "CantidadNumeric";
            this.CantidadNumeric.Size = new System.Drawing.Size(52, 20);
            this.CantidadNumeric.TabIndex = 8;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(149, 213);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown3.TabIndex = 9;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(149, 247);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown4.TabIndex = 10;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(42, 70);
            this.Fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(37, 13);
            this.Fecha.TabIndex = 11;
            this.Fecha.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cantidad de estudiantes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cantidad de Grupos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cantidad de Integrantes";
            // 
            // RegistroParcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 437);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.CantidadNumeric);
            this.Controls.Add(this.DescripcionText);
            this.Controls.Add(this.DatepickerFecha);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonGuardar);
            this.Controls.Add(this.BotonNuevo);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.numericUpDown1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistroParcial";
            this.Text = "Registro De Personas";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button BotonNuevo;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.DateTimePicker DatepickerFecha;
        private System.Windows.Forms.TextBox DescripcionText;
        private System.Windows.Forms.NumericUpDown CantidadNumeric;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


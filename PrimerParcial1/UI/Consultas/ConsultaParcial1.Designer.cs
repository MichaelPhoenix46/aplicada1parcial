namespace PrimerParcial1.UI.Consultas
{
    partial class ConsultaParcial1
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
            this.FiltroId = new System.Windows.Forms.Label();
            this.FiltrarComboBox = new System.Windows.Forms.ComboBox();
            this.CriterioTexto = new System.Windows.Forms.TextBox();
            this.criterio = new System.Windows.Forms.Label();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.RangoFecha = new System.Windows.Forms.Label();
            this.Desde = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ConsultaDataGrid = new System.Windows.Forms.DataGridView();
            this.BotonImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroId
            // 
            this.FiltroId.AutoSize = true;
            this.FiltroId.Location = new System.Drawing.Point(37, 27);
            this.FiltroId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FiltroId.Name = "FiltroId";
            this.FiltroId.Size = new System.Drawing.Size(29, 13);
            this.FiltroId.TabIndex = 0;
            this.FiltroId.Text = "Filtro";
            // 
            // FiltrarComboBox
            // 
            this.FiltrarComboBox.FormattingEnabled = true;
            this.FiltrarComboBox.Location = new System.Drawing.Point(70, 24);
            this.FiltrarComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrarComboBox.Name = "FiltrarComboBox";
            this.FiltrarComboBox.Size = new System.Drawing.Size(98, 21);
            this.FiltrarComboBox.TabIndex = 1;
            this.FiltrarComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CriterioTexto
            // 
            this.CriterioTexto.Location = new System.Drawing.Point(233, 27);
            this.CriterioTexto.Margin = new System.Windows.Forms.Padding(2);
            this.CriterioTexto.Name = "CriterioTexto";
            this.CriterioTexto.Size = new System.Drawing.Size(175, 20);
            this.CriterioTexto.TabIndex = 2;
            // 
            // criterio
            // 
            this.criterio.AutoSize = true;
            this.criterio.Location = new System.Drawing.Point(189, 27);
            this.criterio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.criterio.Name = "criterio";
            this.criterio.Size = new System.Drawing.Size(39, 13);
            this.criterio.TabIndex = 3;
            this.criterio.Text = "Criterio";
            this.criterio.Click += new System.EventHandler(this.criterio_Click);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BotonBuscar.Location = new System.Drawing.Point(412, 16);
            this.BotonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(73, 35);
            this.BotonBuscar.TabIndex = 4;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // RangoFecha
            // 
            this.RangoFecha.AutoSize = true;
            this.RangoFecha.Location = new System.Drawing.Point(18, 55);
            this.RangoFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RangoFecha.Name = "RangoFecha";
            this.RangoFecha.Size = new System.Drawing.Size(157, 13);
            this.RangoFecha.TabIndex = 5;
            this.RangoFecha.Text = "Filtrar Usando Rango De Fecha";
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Location = new System.Drawing.Point(178, 55);
            this.Desde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(38, 13);
            this.Desde.TabIndex = 6;
            this.Desde.Text = "Desde";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(220, 55);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(363, 55);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // ConsultaDataGrid
            // 
            this.ConsultaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGrid.Location = new System.Drawing.Point(20, 114);
            this.ConsultaDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultaDataGrid.Name = "ConsultaDataGrid";
            this.ConsultaDataGrid.RowTemplate.Height = 24;
            this.ConsultaDataGrid.Size = new System.Drawing.Size(514, 132);
            this.ConsultaDataGrid.TabIndex = 9;
            // 
            // BotonImprimir
            // 
            this.BotonImprimir.Location = new System.Drawing.Point(20, 250);
            this.BotonImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.BotonImprimir.Name = "BotonImprimir";
            this.BotonImprimir.Size = new System.Drawing.Size(70, 37);
            this.BotonImprimir.TabIndex = 10;
            this.BotonImprimir.Text = "Imprimir";
            this.BotonImprimir.UseVisualStyleBackColor = true;
            // 
            // ConsultaParcial1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 288);
            this.Controls.Add(this.BotonImprimir);
            this.Controls.Add(this.ConsultaDataGrid);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.RangoFecha);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.criterio);
            this.Controls.Add(this.CriterioTexto);
            this.Controls.Add(this.FiltrarComboBox);
            this.Controls.Add(this.FiltroId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultaParcial1";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FiltroId;
        private System.Windows.Forms.ComboBox FiltrarComboBox;
        private System.Windows.Forms.TextBox CriterioTexto;
        private System.Windows.Forms.Label criterio;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.Label RangoFecha;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView ConsultaDataGrid;
        private System.Windows.Forms.Button BotonImprimir;
    }
}
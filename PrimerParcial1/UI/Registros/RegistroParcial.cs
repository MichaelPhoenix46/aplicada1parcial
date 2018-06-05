using PrimerParcial1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial1
{
    public partial class RegistroParcial : Form
    {
        public RegistroParcial()
        {
            InitializeComponent();
        }

        private Grupos LlenaClase()
        {
            Grupos grupo = new Grupos();
            //grupo.GrupoId = Convert.ToInt32(RegistroParcial.Value);
            grupo.Fecha = DatepickerFecha.Text;
            grupo.Descripcion = DescripcionText.Text;
            //grupo.Cantidad = CantidadNumeric.Value;

            return grupo;
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void BotonNuevo_Click(object sender, EventArgs e)
        {

        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

using PrimerParcial1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial1.UI.Consultas
{
    public partial class ConsultaParcial1 : Form
    {
        public ConsultaParcial1()
        {
            InitializeComponent();
        }

        private void criterio_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            Expression<Func<Grupos, bool>> filtro = x => true;
            int Id;
            switch (FiltrarComboBox.SelectedIndex)
            {
                case 0://id
                    Id = Convert.ToInt32(CriterioTexto.Text);
                    filtro = x => x.GrupoId == Id;
                    break;
                case 1://fecha
                    filtro = x => x.grupos.Equals(CriterioTexto.Text);
                    break;

                case 2://descripcion
                    filtro = x => x.grupos.Equals(CriterioTexto.Text);
                    break;
                case 3://Cantidad de estudiantes
                    filtro = x => x.grupos.Equals(CriterioTexto.Text);
                    break;
                case 4://Cantidad de grupos
                    filtro = x => x.grupos.Equals(CriterioTexto.Text);
                    break;
                case 5://Cantidad de integrantes
                    filtro = x => x.grupos.Equals(CriterioTexto.Text);
                    break;

            }
            ConsultaDataGrid.DataSource = BLL.GruposBLL.GetList(filtro);
        }
    }
}

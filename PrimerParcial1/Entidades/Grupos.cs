using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PrimerParcial1.Entidades
{
    public class Grupos
    {
        [Key]
        public int GrupoId { get; set; }
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string grupos { get; set; }
        public int Integrantes { get; set; }

        public Grupos()
        {
            GrupoId = 0;
            Fecha = string.Empty;
            Descripcion = string.Empty;
            Cantidad = 0;
            grupos = string.Empty;
            Integrantes = 0;

        }

    }
}

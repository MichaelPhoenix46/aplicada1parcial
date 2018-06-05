using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerParcial1.DAL;
using PrimerParcial1.Entidades;
using System.Data.Entity;
using System.Linq.Expressions;

namespace PrimerParcial1.BLL
{
    public class GruposBLL
    {
        private static object grupos;

        public static bool Guardar(Grupos grupos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Grupos.Add(grupos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Grupos grupo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {


                contexto.Entry(grupos).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int GrupoId)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Grupos grupos = contexto.Grupos.Find(GrupoId);
                contexto.Grupos.Remove(grupos);
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static List<Grupos> GetList(Expression<Func<Grupos, bool>> expression)
        {
            List<Grupos> Grupos = new List<Grupos>();
            Contexto contexto = new Contexto();
            try
            {
                Grupos = contexto.Grupos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Grupos;

        }
    }
}

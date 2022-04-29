using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosEF.Data;

namespace DatosEF.AdminDatos
{
    public static class DacAuthor
    {
        static PubContext context = new PubContext();
        public static List<author> Listar()
        {
            var autores = (from a in context.authors
                           select a).ToList();
            return autores;
        }
        public static List<author> Listar(string city)
        {
            List<author> autores = (from a in context.authors
                                    where a.city == city
                                    select a).ToList();
            return autores;

        }
        public static int Insertar(author author)
        {
            //En memoria
            context.authors.Add(author);
            //Enviar el nuevo autor a la base
            int filasafectdas = context.SaveChanges();
            return filasafectdas;

        }

        public static author TraerUno(string au_id)
        {
            author autor = (from a in context.authors
                            where a.au_id == au_id
                            select a).Single();
            return autor;
        }

        public static int Eliminar(string id)
        {
            author author = context.authors.Find(id);
            context.authors.Remove(author);
            return context.SaveChanges();
        }

        public static List<author> ListarPorLetraCiudad(string letra)
        {
            List<author> autores = (from a in context.authors
                                    where a.city.StartsWith(letra)
                                    select a).ToList();
            return autores;
        }
    }
}

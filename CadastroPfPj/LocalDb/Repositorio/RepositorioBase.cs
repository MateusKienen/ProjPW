using Entidades;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDb.Repositorio
{
    public class RepositorioBase<T> : IRepositorio<T> where T : EntidadeBase
    {

        public void Deletar(int id)
        {
            using (var contexto = new Contexto())
            {
                contexto.Set<T>().Remove(contexto.Set<T>().Find(id));
                contexto.SaveChanges();
            }
        }

        public void Inserir(T item)
        {
            using (var contexto = new Contexto())
            {
                contexto.Set<T>().Add(item);
                contexto.SaveChanges();
            }
        }
        
        public List<T> ListaTodos()
        {
            List<T> lista = new List<T>();
            using (var contexto = new Contexto())
            {
                lista = contexto.Set<T>().ToList();
            }
            return lista;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> ListaTodos();
        void Inserir(T item);
        void Deletar(int id);

    }
}

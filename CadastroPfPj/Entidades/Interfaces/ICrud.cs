using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    interface ICrud
    {
        void Inserir();
        void Excluir(string item, int opcao);
        void Alterar();
        string Listar();
    }
}

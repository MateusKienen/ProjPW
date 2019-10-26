using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PessoaJuridica : Pessoa, ICrud
    {
        public string CNPJ { get; set; }

        public void Alterar()
        {

        }

        public void Excluir(string cnpj, int opcao)
        {
            Gravacao.Excluir(cnpj, opcao);
        }

        public void Inserir()
        {
            Gravacao.Gravar(this);
        }

        public string Listar()
        {
            return Gravacao.Listar(TipoPessoa.Juridica);
        }
    }
}

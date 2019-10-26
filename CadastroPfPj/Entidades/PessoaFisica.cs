using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PessoaFisica : Pessoa
    {

        public string CPF { get; set; }

        public void Excluir(string cpf, int opcao)
        {
            Gravacao.Excluir(cpf, opcao);

        }

        public void Inserir()
        {
            Gravacao.Gravar(this);


        }

        public string Listar()
        {
            return Gravacao.Listar(TipoPessoa.Fisica);
        }

    }
}

using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDb
{
    public class  Contexto : DbContext
    {
        public DbSet<PessoaFisica> pessoaFisica { get; set; }
        public DbSet<PessoaJuridica> pessoaJuridica { get; set; }

        public Contexto() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\191019---NewProjPw\CadastroPfPj\LocalDb\LocalDb.mdf;Integrated Security=True")
        {

        }

    }
}

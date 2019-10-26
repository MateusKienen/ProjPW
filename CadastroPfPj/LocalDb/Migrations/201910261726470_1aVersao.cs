namespace LocalDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1aVersao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PessoaFisicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CPF = c.String(),
                        Nome = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Endereco = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PessoaJuridicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CNPJ = c.String(),
                        Nome = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Endereco = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PessoaJuridicas");
            DropTable("dbo.PessoaFisicas");
        }
    }
}

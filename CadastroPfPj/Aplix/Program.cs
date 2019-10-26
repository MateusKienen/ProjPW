using Entidades;
using LocalDb.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplix
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaJuridica pj;
            PessoaFisica pf;
            RepositorioBase<PessoaFisica> repPf;
            RepositorioBase<PessoaJuridica> repPj;

            int opcao = 0;
            do
            {
                MontaMenu();
                Console.WriteLine("Digite uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
              

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Preencha os dados abaixo:");
                        try

                        {
                            //pf = new PessoaFisica();
                            //Console.WriteLine("Nome: ");
                            //pf.Nome = Console.ReadLine();
                            //Console.WriteLine("Data de Nascimento");
                            //pf.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                            //Console.WriteLine("Endereço");
                            //pf.Endereco = Console.ReadLine();
                            //Console.WriteLine("CPF");
                            //pf.CPF = Console.ReadLine();
                            //pf.Inserir();

                            pf = new PessoaFisica();
                            Console.WriteLine("Nome: ");
                            pf.Nome = Console.ReadLine();
                            Console.WriteLine("Data de Nascimento");
                            pf.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Endereço");
                            pf.Endereco = Console.ReadLine();
                            Console.WriteLine("CPF");
                            pf.CPF = Console.ReadLine();
                            repPf = new RepositorioBase<PessoaFisica>();
                            repPf.Inserir(pf);
                            Console.WriteLine("Inserido no Banco de dados");


                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Preencha os dados abaixo:");
                        try
                        {

                            // Estruura para inserir em arquivo

                            /**

                            pj = new PessoaJuridica();
                            Console.WriteLine("Nome: ");
                            pj.Nome = Console.ReadLine();
                            Console.WriteLine("Data de Criação");
                            pj.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Endereço");
                            pj.Endereco = Console.ReadLine();
                            Console.WriteLine("CNPJ");
                            pj.CNPJ = Console.ReadLine();
                            pj.Inserir();
                            */

                            pj = new PessoaJuridica();
                            Console.WriteLine("Nome: ");
                            pj.Nome = Console.ReadLine();
                            Console.WriteLine("Data de Criação");
                            pj.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Endereço");
                            pj.Endereco = Console.ReadLine();
                            Console.WriteLine("CNPJ");
                            pj.CNPJ = Console.ReadLine();
                            repPj = new RepositorioBase<PessoaJuridica>();
                            repPj.Inserir(pj);
                            Console.WriteLine("Inserido no Banco de dados");


                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Lista de PF");
                        repPf = ListarPf();
                        //Console.WriteLine(Gravacao.Listar(TipoPessoa.Fisica));
                        Console.WriteLine("\n\nPressione qualquer tecla para retornar ao Menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Lista de PJ");

                        repPj = ListarPj();
                        //Console.WriteLine(Gravacao.Listar(TipoPessoa.Juridica));
                        Console.WriteLine("\n\nPressione qualquer tecla para retornar ao Menu");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Lista de Pessoas Cadastradas");
                        ListarPf();
                        ListarPj();

                        //Console.WriteLine(Gravacao.Listar(TipoPessoa.Fisica | TipoPessoa.Juridica));
                        Console.WriteLine("\n\nPressione qualquer tecla para retornar ao Menu");
                        Console.ReadKey();
                        break;
                    case 6:
                        ListarPf();
                        Console.WriteLine("Digite o ID da pessoa que deseja excluir: ");
                        repPf = new RepositorioBase<PessoaFisica>();
                        repPf.Deletar(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
                        Console.ReadKey();
                        break;
                    case 7:
                        ListarPj();
                        Console.WriteLine("Digite o ID da empresa que deseja excluir: ");
                        repPj = new RepositorioBase<PessoaJuridica>();
                        repPj.Deletar(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("Excluíndo registros");
                        
                        Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (opcao != 0);
        }

        private static RepositorioBase<PessoaFisica> ListarPf()
        {
            RepositorioBase<PessoaFisica> repPf = new RepositorioBase<PessoaFisica>();
            List<PessoaFisica> listapf = repPf.ListaTodos();
            foreach (var item in listapf)
            {
                Console.WriteLine($"{item.Id} - {item.Nome} - {item.CPF} - {item.DataNascimento} - {item.Endereco}");
            }

            return repPf;
        }

        private static RepositorioBase<PessoaJuridica> ListarPj()
        {
            RepositorioBase<PessoaJuridica> repPj = new RepositorioBase<PessoaJuridica>();
            List<PessoaJuridica> listapj = repPj.ListaTodos();
            foreach (var item in listapj)
            {
                Console.WriteLine($"{item.Id} - {item.Nome} - {item.CNPJ} - {item.DataNascimento} - {item.Endereco}");
            }

            return repPj;
        }

        private static void MontaMenu()
        {

            Console.WriteLine("======  ======");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Cadastro PF");
            Console.WriteLine("2 - Cadastro PJ");
            Console.WriteLine("3 - Listar PF");
            Console.WriteLine("4 - Listar PJ");
            Console.WriteLine("5 - Listar Todos");
            Console.WriteLine("6 - Excluir PF");
            Console.WriteLine("7 - Excluir PJ");
            Console.WriteLine("8 - Excluir todos");

        }
    }
}


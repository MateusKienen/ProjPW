using Entidades;
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
                            pf = new PessoaFisica();
                            Console.WriteLine("Nome: ");
                            pf.Nome = Console.ReadLine();
                            Console.WriteLine("Data de Nascimento");
                            pf.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Endereço");
                            pf.Endereco = Console.ReadLine();
                            Console.WriteLine("CPF");
                            pf.CPF = Console.ReadLine();
                            pf.Inserir();

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

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Lista de PF");
                        Console.WriteLine(Gravacao.Listar(TipoPessoa.Fisica));
                        Console.WriteLine("\n\nPressione qualquer tecla para retornar ao Menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Lista de PJ");
                        Console.WriteLine(Gravacao.Listar(TipoPessoa.Juridica));
                        Console.WriteLine("\n\nPressione qualquer tecla para retornar ao Menu");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Lista de Pessoas Cadastradas");
                        Console.WriteLine(Gravacao.Listar(TipoPessoa.Fisica | TipoPessoa.Juridica));
                        Console.WriteLine("\n\nPressione qualquer tecla para retornar ao Menu");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("Digite o CPF que deseja excluir: ");
                        if (Gravacao.Excluir(Console.ReadLine(), 6))
                        {
                            Console.WriteLine("Registro excluído com sucesso");
                        }
                        Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Digite o CNPJ que deseja excluir: ");
                        if(Gravacao.Excluir(Console.ReadLine(), 7))
                        {
                            Console.WriteLine("Registro excluído com sucesso");
                        }
                        Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("Excluíndo registros");
                        if (Gravacao.Excluir())
                        {
                            Console.WriteLine("Registros excluídos");
                        }
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


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Gravacao
    {
        static string arquivo = @"C:\Users\43336\Documents\Data.txt";
        public static void Gravar(object pessoa)
        {

            StreamWriter file = File.AppendText(arquivo);

            PessoaFisica pf = pessoa as PessoaFisica;
            if (pf != null)
            {
                file.WriteLine($"Nome: {pf.Nome} - Nascimento: {pf.DataNascimento} - Endereço: {pf.Endereco} - CPF: {pf.CPF}");
                file.Close();
                return;
            }

            PessoaJuridica pj = pessoa as PessoaJuridica;
            if (pj != null)
            {
                file.WriteLine($"Nome: {pj.Nome} - Criação: {pj.DataNascimento} - Endereço: {pj.Endereco} - CNPJ: {pj.CNPJ}");
                file.Close();
                return;
            }
        }

        public static string Listar(TipoPessoa tipo)
        {
            int bitnum = (int)tipo;
            string retorno = "";
            StreamReader file = File.OpenText(arquivo);

            /* 
             * Abaixo: Mesma coisa que fazer os códigos que eu fiz...
             * 
             * var f = file.ReadToEnd().Split ("\n");
             * var result = f.Where( item => item.Contains("CNPJ")); 
             * 
             */
            if (bitnum == 1)
            {
                while (file.EndOfStream == false)
                {
                    var linha = file.ReadLine();
                    if (linha.Contains("CPF"))
                    {
                        retorno += linha + "\n";
                    }
                }
                file.Close();
                return retorno;
            }
            else if (bitnum == 2)
            {
                while (file.EndOfStream == false)
                {
                    var linha = file.ReadLine();
                    if (linha.Contains("CNPJ"))
                        retorno += linha + "\n";
                }
                file.Close();
                return retorno;
            }
            else
            {
                while (file.EndOfStream == false)
                {
                    retorno += file.ReadLine() + "\n";
                }
                file.Close();
                return retorno;
            }
        }

        public static bool Excluir()
        {
            try
            {
                File.WriteAllText(arquivo, "");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }
        public static bool Excluir(string registro, int tipo)
        {
            bool excluido = false;
            if (tipo == 6)
            {

                StreamReader file = File.OpenText(arquivo);
                var v = file.ReadToEnd().Split('\n');
                var result = v.SkipWhile(i => i.Contains("CPF") && i.Contains(registro));
                file.Close();
                File.WriteAllText(arquivo, "");
                StreamWriter sw = File.AppendText(arquivo);
                foreach (var item in result)
                {
                    sw.Write(item);
                    excluido = true;
                }
                sw.Close();
            }
            else if(tipo == 7)
            {

                StreamReader file = File.OpenText(arquivo);
                var v = file.ReadToEnd().Split('\n');
                var result = v.SkipWhile(i => i.Contains("CNPJ") && i.Contains(registro));
                file.Close();
                File.WriteAllText(arquivo, "");
                StreamWriter sw = File.AppendText(arquivo);
                foreach (var item in result)
                {
                    sw.Write(item);
                    excluido = true;
                }
                sw.Close();
            }
            return excluido;
        }
    }
}


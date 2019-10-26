using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivo
{
    public class Gravacao
    {


    }

    public void Gravar()
    {
        string arquivo = @"C:\Users\43336\Documents\Data.txt";
        StreamWriter file = File.AppendText(arquivo);
    }
}

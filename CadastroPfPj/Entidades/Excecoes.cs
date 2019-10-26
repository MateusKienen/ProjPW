using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Excecoes
    {

        [Serializable]
        public class InvalidCPForCNPJException : Exception
        {
            public InvalidCPForCNPJException() { }
            public InvalidCPForCNPJException(string message) : base(message) { }
            public InvalidCPForCNPJException(string message, Exception inner) : base(message, inner) { }
            protected InvalidCPForCNPJException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

            public override string Message => "CPF ou CNPJ inválido";
        }
    }
}

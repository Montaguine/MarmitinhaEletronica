using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.TiposFuncionarios
{
    public class Limpeza : Funcionario
    {
        public Limpeza(string nome, int id)
            : base(nome, id)
        {

        }

        public void LimparMesa()
        {
            Console.WriteLine("Limpeza Requisitada");
            Console.WriteLine(".");
            Console.WriteLine("..");
            Console.WriteLine("...");
            Console.WriteLine("Mesa Limpa com sucesso");
        }
    }
}

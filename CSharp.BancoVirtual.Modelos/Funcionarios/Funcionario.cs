using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.BancoVirtual.Modelos.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }

        public string CPF { get; private set; }
        
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

        // Utilizando o "internal protected" o GetBonificacao fica visível dentro do projeto Modelos e para qualquer classe que derive, mesmo fora do projeto
        // internal protected é considerado um modificador de acesso único, não a mistura de dois
        internal protected abstract double GetBonificacao();
    }
}

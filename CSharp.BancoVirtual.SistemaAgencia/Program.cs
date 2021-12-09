using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.BancoVirtual.Modelos;
using CSharp.BancoVirtual.Modelos.Funcionarios;
using Humanizer;

namespace CSharp.BancoVirtual.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021, 10, 1);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;
            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            // Exemplo com minutos: TimeSpan diferenca = TimeSpan.FromMinutes(30);
            Console.WriteLine(mensagem);

            Console.ReadLine();
        }
    }
}
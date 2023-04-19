using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.BancoVirtual.Modelos.Funcionarios;

namespace CSharp.BancoVirtual.SistemaAgencia
{
    public class Estagiario : Funcionario
    {
        public Estagiario(double salario, string cpf)
            : base(salario, cpf)
        {

        }

        public override void AumentarSalario()
        {
            
        }

        protected override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
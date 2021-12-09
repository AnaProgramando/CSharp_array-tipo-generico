using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.BancoVirtual.Modelos
{
    // Essa interface é o contrato com o qual asseguram-se que as classes responsáveis por implementá-la possuem um método público, que retorna um booleano, chama-se Autenticar(), e recebe uma string.
    // Implementada por ParceiroComercial e pela classe FuncionarioAutenticavel, que deriva de Funcionario.
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}

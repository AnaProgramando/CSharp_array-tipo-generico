using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.BancoVirtual.Modelos
{
    // Criada a classe ajudante AutenticacaoHelper para realizar o encapsulando da lógica de comparar as senhas
    // Sufixo Helper especifica a função de ajudar os componentes da biblioteca
    // Adicionado o modificador de acesso internal, pois a classe é validável apenas dentro da biblioteca
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}

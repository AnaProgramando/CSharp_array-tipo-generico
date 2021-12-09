using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.BancoVirtual.Modelos
{
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }

        // Realizada a comparação de "Senha" com a propriedade (string Senha) e o argumento (string senha)
        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}
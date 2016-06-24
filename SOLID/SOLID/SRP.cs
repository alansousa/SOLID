using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace SOLID
{
    /// <summary>
    /// Single Responsability Principle
    /// Princípio da Responsabilidade Única
    /// </summary>
    public class SRP_Errado
    {
        private string _nome;
        void Adicionar(string nome)
        {
            _nome = nome;
        }

        bool ValidarId(int id)
        {
            return id > 0;
        }
    }

    public class SRP_Adicionar
    {
        private string _nome;
        void Adicionar(string nome)
        {
            _nome = nome;
        }
    }

    class SRP_ValidarId
    {
        bool ValidarId(int id)
        {
            return id > 0;
        }
    }
}

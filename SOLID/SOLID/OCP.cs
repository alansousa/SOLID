using System;

namespace SOLID
{
    public class OCP_Zuado_Step_1
    {
        private string _nome;
        void AdicionarNome(string nome)
        {
            _nome = nome;
        }
    }

    public class OCP_Zuado_Step_2
    {
        private string _nome;
        void AdicionarNome(string nome, int id = 0)
        {
            if (id > 0)
                _nome = nome + id;
            else
                _nome = nome;
        }
    }

    class OCP_Zuado_Step_3
    {
        private string _nome;
        void AdicionarNome(string nome, int id = 0, bool validandoAlgumaCoisa = false)
        {
            if (id > 0 && validandoAlgumaCoisa)
                _nome = nome;
            else if (id > 0 && !validandoAlgumaCoisa)
                _nome = id + nome + "BIRL";
            else
                _nome = nome;
        }
    }

    class OCP
    {
        private string _nome;

        void AdicionarNome(string nome)
        {
            _nome = nome;
        }

        void AdicionarNomeComId(string nome, int id)
        {
            _nome = id + nome;
        }

        private void AdicionarNomeComIdEValidacao(string nome, int id, bool validandoAlgumaCoisa)
        {
            if (id > 0 && validandoAlgumaCoisa)
                _nome = nome;
            else if (id > 0 && !validandoAlgumaCoisa)
                _nome = id + nome + "BIRL";
        }
    }
}
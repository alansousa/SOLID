using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID
{
    public class LSP_Zuado
    {
        abstract class Pai
        {
            public abstract void Add();
            public abstract void Consultar();
        }

        class FilhoPrimogenio : Pai
        {
            private List<string> lista = new List<string>();

            public override void Add()
            {
                lista.Add(String.Empty);
            }

            public override void Consultar()
            {
                lista.FirstOrDefault();
            }
        }

        class FilhoBastardo : Pai
        {
            private List<string> lista = new List<string>();
            public override void Add()
            {
                lista.Add(String.Empty);
            }

            public override void Consultar()
            {
                throw new System.NotImplementedException();
            }
        }

        class Executar
        {
            Pai obj = new FilhoPrimogenio();
            Pai obj2 = new FilhoBastardo();

            void Testar()
            {
                obj.Consultar();
                obj2.Consultar();
            }
        }
    }

    public class LSP
    {
        interface IAdd
        {
            void Add();
        }

        interface IConsulta
        {
            void Consultar();
        }

        interface IPai : IAdd, IConsulta
        {
            
        }
        abstract class Pai 
        {
            public abstract void Add();
            public abstract void Consultar();
        }

        class FilhoPrimogenio : Pai, IPai
        {
            private List<string> lista = new List<string>();

            public override void Add()
            {
                lista.Add(String.Empty);
            }

            public override void Consultar()
            {
                lista.FirstOrDefault();
            }
        }

        class FilhoBastardo : IAdd
        {
            private List<string> lista = new List<string>();
            public void Add()
            {
                lista.Add(String.Empty);
            }
        }

        class Executar
        {
            IPai obj = new FilhoPrimogenio();
            IPai obj2 = new FilhoBastardo();

            void Testar()
            {
                obj.Consultar();
                obj2.Consultar();
            }
        }
    }
}
using System;

namespace SOLID
{
    public class ISP_Zuado
    {
        interface IClasse 
        {
            void Add();
            void Consultar();
        }

        class Implementei: IClasse
        {
            public void Add()
            {
                Console.Write("Malandramente");
            }

            public void Consultar()
            {
                Console.Write("Malandramente");
            }
        }

        class NaoImplementei : IClasse
        {
            public void Add()
            {
                Console.Write("Malandramente");
            }

            public void Consultar()
            {
                throw  new NotImplementedException();
            }
        }
    }

    public class ISP
    {
        interface IAdd
        {
            void Add();
        }

        interface IConsulta
        {
            void Consultar();
        }

        interface IClasse : IAdd, IConsulta
        {

        }

        class Implementei : IClasse
        {
            public void Add()
            {
                Console.Write("Malandramente");
            }

            public void Consultar()
            {
                Console.Write("Malandramente");
            }
        }

        class NaoImplementei : IAdd
        {
            public void Add()
            {
                Console.Write("Malandramente");
            }
        }
    }
}
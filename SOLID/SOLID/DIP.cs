using System;

namespace SOLID
{
    public interface IAdd
    {
        void Add();
    }

    public interface IConsulta
    {
        void Consultar();
    }

   public interface IClasse : IAdd, IConsulta
    {

    }

    public class Implementei : IClasse
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

    public class NaoImplementei : IAdd
    {
        public void Add()
        {
            Console.Write("Malandramente");
        }
    }

    public class DIP_Zuado
    {
        void Testa()
        {
            var imp = new Implementei();
            var nimp = new NaoImplementei();
        }
    }

    public class DIP_Menos_Zuado
    {
        private IClasse imp;
        private IAdd nimp;

        public DIP_Menos_Zuado()
        {
            this.imp = imp = new Implementei(); 
            nimp = new NaoImplementei();
        }

        void Testa()
        {
            imp.Add();
            imp.Consultar();
            nimp.Add();
        }
    }

    public class DIP
    {
        private IClasse imp;
        private IAdd nimp;

        public DIP(IClasse imp, IAdd nimp)
        {
            this.imp = imp;
            this.nimp = nimp;
        }

       public void Testa()
        {
            imp.Add();
            imp.Consultar();
            nimp.Add();
        }
    }
}
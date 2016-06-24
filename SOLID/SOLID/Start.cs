using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;

namespace SOLID
{
    class Start
    {

        static void main(string[] args)
        {
            Container container = new Container();
            container.Register<IClasse,Implementei>();
            container.Register<IAdd,NaoImplementei>();
            container.Register<DIP>();
            
            var dip = container.GetInstance<DIP>();

            dip.Testa();
        }
    }
}

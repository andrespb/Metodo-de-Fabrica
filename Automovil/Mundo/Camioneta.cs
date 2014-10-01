using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovil.Mundo
{
    class Camioneta : Auto
    {
        public override void encender()
        {
            Console.WriteLine("El Automovil camioneta se encendió");
        }

        public override void apagar()
        {
            Console.WriteLine("El Automovil camioneta se apagó");
        }
    }
}

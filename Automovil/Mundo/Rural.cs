using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovil.Mundo
{
    class Rural : Auto
    {
        public override void encender()
        {
            Console.WriteLine("El automovil Rural se encendió");
        }

        public override void apagar()
        {
            Console.WriteLine("El automovil Rural se apagó");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automovil.Mundo;

namespace Automovil
{
    static class Automovil
    {
        static void Main()
        {
            int tipo = Convert.ToInt32(Console.ReadLine());
            FabricaAuto fabrica = new FabricaAuto();
            Auto miAuto = fabrica.crearAuto(tipo);
            miAuto.encender();
            
            /*Auto miAuto;
            if (tipo == 1)
                miAuto = new Sedan();
            else if (tipo == 2)
                miAuto = new Rural();
            else if (tipo == 3)
                miAuto = new Camioneta();
            else
                miAuto = null;
            miAuto.encender();
            Auto miAuto = new Sedan();
            miAuto.encender();*/
        }
    }
}

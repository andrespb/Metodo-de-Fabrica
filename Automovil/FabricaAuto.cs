using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Automovil.Mundo
{
    class FabricaAuto
    {
        public Auto crearAuto(int tipo)
        {
            Auto miAuto;
            if (tipo == 1)
                miAuto = new Sedan();
            else if (tipo == 2)
                miAuto = new Rural();
            else if (tipo == 3)
                miAuto = new Camioneta();
            else
            {
                miAuto = null;
                Console.WriteLine("Debe ingresar un numero");
            }
            return miAuto;
        }
    }
}

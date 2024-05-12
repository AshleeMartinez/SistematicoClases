using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSistematica
{
    class Programa
    {
        static void Main(string[] args)
        {
            Automovil autoMovil1 = new Automovil("Toyota", "302789", "Civic","Negro", 20, 30);
            Automovil autoMovil2 = new Automovil("Honda", "DEF456", "Corolla", "Azul", 60, 12);

            autoMovil1.InfoDelAutomovil();
            autoMovil1.ReabastecerCombustible(20);
            autoMovil1.Conducir(200);
            autoMovil1.Conducir(100);
            autoMovil1.ReabastecerCombustible(10);

            autoMovil2.InfoDelAutomovil();
            autoMovil2.ReabastecerCombustible(30);
            autoMovil2.Conducir(150);
            autoMovil2.Conducir(100);



        }
    }
}

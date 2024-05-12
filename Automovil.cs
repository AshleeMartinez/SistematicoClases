using System;


namespace PruebaSistematica
{
    public partial class Automovil
    {
        public int CapacidadTanqueCombustible { get; set; }
        public int NivelCombustible;
        public int RendimientoCombustible { get; set; } //(km/galón)


        public Automovil(string marca, string placa, string modelo, string color, int capacidadTanqueCombustible, int rendimientoCombustible, int NivelCombustible=0)
        {
            this.Marca = marca;
            this.Placa = placa;
            this.Modelo = modelo;
            this.Color = color;
            this.CapacidadTanqueCombustible = capacidadTanqueCombustible;
            this.RendimientoCombustible= rendimientoCombustible;
        }
        public void InfoDelAutomovil()
        {
            Console.WriteLine($"La marca del Automovil es {Marca}, la placa Num: {Placa}, El modelo: {Modelo}, El color: {Color}, " +
                $"capacidad del tanque de combustible {CapacidadTanqueCombustible}, con redimiento de {RendimientoCombustible}");
        }
        public void Conducir(int Distancia)
        {
            if (PuedeConducir(Distancia))
            {
                int gastoDelTanque = Distancia / RendimientoCombustible;
                NivelCombustible -= gastoDelTanque;
                Console.WriteLine($"Se han recorrdio {Distancia}km. El nivel actual del tanque es {NivelCombustible} gal. ");
            }
            else
            {
                Console.WriteLine("No se puede conducir");

            }
        }


        public void ReabastecerCombustible(int Cantidad)
        {
            if (Cantidad > 0)
            {
                int espacioDisponibleDelTanque = CapacidadTanqueCombustible - NivelCombustible;
                if (Cantidad <= espacioDisponibleDelTanque)
                {
                    NivelCombustible += Cantidad;
                    Console.WriteLine($"Se han reabastecido el combustible con la cantidad de {Cantidad}gal. Nivel actual del tanque: {NivelCombustible} gal.");
                }
                else
                {
                    Console.WriteLine($"No es posible reabastecer el combustible.");
                }
            }
            else
            {
                Console.WriteLine("La cantidad de combustible debe ser mayor que cero.");

            }
        }


        
        public bool PuedeConducir(int Distancia)
        {
            double combustibleNecesario = Distancia / RendimientoCombustible;
            return combustibleNecesario <= NivelCombustible;
        }
    }
}

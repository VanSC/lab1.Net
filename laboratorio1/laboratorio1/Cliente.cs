using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio1
{
    //clase derivada de usuario
    public class Cliente : Usuario
    {
        public double LitrosCargados { get; set; }
        public Cliente(string nombre, double saldo, double litroscargados) : base(nombre, saldo)
        {
            LitrosCargados = litroscargados;
        }

        //metodo sobreescrito para cliente
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Listros cargados: " + LitrosCargados);
        }
    }
}

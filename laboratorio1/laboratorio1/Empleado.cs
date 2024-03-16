using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio1
{
    //clase derivada de usuario
    public class Empleado : Usuario
    {
        public double Sueldo { get; set; }
        public Empleado(string nombre, double saldo, double sueldo) : base(nombre, saldo)
        {
            Sueldo = sueldo;
        }

        //metodo sobreescrito para empleado
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Sueldo: " + Sueldo);
        }
    }
}

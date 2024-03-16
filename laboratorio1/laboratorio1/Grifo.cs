using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio1
{
    public class Grifo
    {
        List<Usuario> usuarios = new List<Usuario>();

        public void AddUser(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
        public void MostrarUsuarios() { 

            foreach (var usuario in usuarios)
            {
                usuario.MostrarInformacion();
                Console.WriteLine();
            }
        }
    }
}

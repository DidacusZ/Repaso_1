using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1Repaso.servicios
{
    internal class ImplMenu : InterfaceMenu
    {
        //muestra el menu
        public int Menu()
        {
            Console.WriteLine("\n\t1. Registro empleado");
            Console.WriteLine("\t2. Modificar empleado");
            Console.WriteLine("\t3. Exportar a fichero");
            Console.WriteLine("\t0. Cerrar App");
            Console.Write("\n\tElige una opcion: ");
            return Console.ReadKey(true).KeyChar - '0';
        }
    }
}

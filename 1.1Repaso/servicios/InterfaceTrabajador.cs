using _1._1Repaso.entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1Repaso.servicios
{
    internal interface InterfaceTrabajador
    {
        //crea un nuevo empleado
        List<Trabajador> addEmpleado(List<Trabajador> lista);

        //cambia algun valor o todos de un empleado
        List<Trabajador> ModificarEmpleado(List<Trabajador> lista);

        //exporta todos los empleados a un fichero
        void ExportarFichero(List<Trabajador> lista);
    }
}

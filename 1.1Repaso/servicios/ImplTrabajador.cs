using _1._1Repaso.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1Repaso.servicios
{
    internal class ImplTrabajador : InterfaceTrabajador
    {
        public List<Trabajador> addEmpleado(List<Trabajador> lista)
        {            
            Trabajador empleado = new Trabajador();

            //pedimos todos los campos del empleado            
            empleado.Id = lista.Count+1;
            CargarEmpleadoSinID(empleado);
            
            //añadimos empleado a la lista
            lista.Add(empleado);

            return lista;
        }

        public void ExportarFichero(List<Trabajador> lista)
        {
            //crea txt si ya existe lo destruye y crea uno nuevo
            StreamWriter sw = File.CreateText("Empleados.txt");

            //cabecera
            sw.WriteLine("id, nombre, apellidos, dni, fechaNacimiento, titulacionMasAlta, nSS, nCuenta");

            //imprime la lista
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("\n\t"+lista[i].ToString());
                sw.WriteLine(lista[i].ToString());
            }

            Console.WriteLine("Se ha guardado en el fichero correctamente");
            sw.Close();
        }

        public List<Trabajador> ModificarEmpleado(List<Trabajador> lista)
        {
            //controlamos si la lista esta vacia
            if(lista.Count == 0)
            {
                Console.WriteLine("\n\tNecesistas añadir empleados para poder modificarlos");
                Console.ReadKey();
                return lista;  
            }

            int id = CapturaEntero("Introduce el id del empleado que quieres modificar", 1, lista.Count);
            int opcion;
            Trabajador empleadoModif = lista[id - 1];

            do
            {
                Console.Clear();

                Console.WriteLine("\n\t¿Que quieres modificar?");
                Console.WriteLine("\n\t"+ empleadoModif.ToString());
                opcion = MenuModificarEmpleado();   
                
                Console.Clear();                

                switch (opcion)
                {
                    //Nombre
                    case 1:
                        empleadoModif.Nombre = CapturaString("Introduce el nombre del Trabajador");
                        break;

                    //Apellidos
                    case 2:
                        empleadoModif.Apellidos = CapturaString("Introduce el apellido del Trabajador");     
                        break;

                    //DNI
                    case 3:
                        empleadoModif.Dni = CapturaString("Introduce el DNI del Trabajador");
                        break;

                    //Fecha de Nacimieto
                    case 4:
                        empleadoModif.FechaNacimiento = CapturaString("Introduce la fecha de nacimiento del Trabajador");
                        break;

                    //Titulacion mas alta
                    case 5:
                        empleadoModif.TitulacionMasAlta = CapturaString("Introduce la titulacion mas alta del Trabajador");
                        break;

                    //Nº SS
                    case 6:
                        empleadoModif.NSS = CapturaEntero("Introduce el Nº de la Seguridad Social del Trabajador", 1111111, 9999999);
                        break;

                    //Nº Cuenta
                    case 7:
                        empleadoModif.NCuenta = CapturaString("Introduce el Nº de cuenta del Trabajador");
                        break;

                    //Modificar todos los valores
                    case 8:
                        CargarEmpleadoSinID(empleadoModif);
                        break;
                }

            } while (opcion != 0);//solo sale cuando es 0

            return lista;
        }



        //METODOS PRIVADOS

        //menu para modificar el empleado
        private int MenuModificarEmpleado()
        {            
            Console.WriteLine("\n\t1. Nombre");
            Console.WriteLine("\t2. Apellidos");
            Console.WriteLine("\t3. DNI");
            Console.WriteLine("\t4. Fecha de nacimiento");
            Console.WriteLine("\t5. Titulacion mas alta");
            Console.WriteLine("\t6. Nº Seguridad Social");
            Console.WriteLine("\t7. Nº Cuenta");
            Console.WriteLine("\t8. Modificar todos los valores");
            Console.WriteLine("\t0. Volver al menu");
            Console.Write("\n\tElige una opcion: ");
            return Console.ReadKey(true).KeyChar - '0';
        }

        private void CargarEmpleadoSinID(Trabajador empl)
        {
            empl.Nombre = CapturaString("Introduce el nombre del Trabajador");
            empl.Apellidos = CapturaString("Introduce el apellido del Trabajador");
            empl.Dni = CapturaString("Introduce el DNI del Trabajador");
            empl.FechaNacimiento = CapturaString("Introduce la fecha de nacimiento del Trabajador");
            empl.TitulacionMasAlta = CapturaString("Introduce la titulacion mas alta del Trabajador");
            empl.NSS = CapturaEntero("Introduce el Nº de la Seguridad Social del Trabajador", 1111111, 9999999);
            empl.NCuenta = CapturaString("Introduce el Nº de cuenta del Trabajador");
        }

        //muestra un mensaje y captura un string
        private string CapturaString(string txt)
        {
            Console.Write("\n\t{0}: ", txt);
            return Console.ReadLine();
        }

        //captura solo valores numericos dentro del rango especificado
        private int CapturaEntero(string txt, int min, int max)
        {
            int valor;
            bool verdad;

            do
            {
                Console.Write("\n\t{0} [{1}-{2}]: ", txt, min, max);
                verdad = Int32.TryParse(Console.ReadLine(), out valor);//devuelve true cuando es un numero

                if (!verdad)
                    Console.WriteLine("\terror de formato");

                if (verdad && valor >= min && valor <= max)
                    return valor;

                if (verdad)
                {
                    verdad = false;
                    Console.WriteLine("\tnumero fuera de rango");
                }

            } while (!verdad);

            return valor;
        }
    }
}

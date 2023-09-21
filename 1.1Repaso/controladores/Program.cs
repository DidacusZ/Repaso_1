using _1._1Repaso.entidades;
using _1._1Repaso.servicios;

namespace _1._1Repaso.controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lo meto todo en el try-catch por si hay algun error en la implementacion,menu...
            try
            {
                //variable
                int opcion;

                //implementaciones
                InterfaceMenu menu = new ImplMenu();
                InterfaceTrabajador implTrabajador = new ImplTrabajador();

                //lista
                List<Trabajador> listaEpleados = new List<Trabajador>();

                

                do
                {
                    Console.Clear();
                    opcion = menu.Menu();
                    Console.Clear();

                    switch (opcion)
                    {
                        //Registro empleado
                        case 1:
                            implTrabajador.addEmpleado(listaEpleados);
                            break;

                        //Modificar empleado
                        case 2:
                            implTrabajador.ModificarEmpleado(listaEpleados);
                            break;

                        //Exportar a fichero
                        case 3:
                            implTrabajador.ExportarFichero(listaEpleados);
                            Console.ReadKey();
                            break;
                    }

                } while (opcion != 0);//solo sale cuando es 0

            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\tERROR GENERAL");
            }
        }
    }
}
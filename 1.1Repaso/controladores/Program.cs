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

                /*
                
                descomentar el constructor lleno para que funcione

                //datos de prueba
                Trabajador empl1 = new Trabajador(1, "pepe", "botella", "12512521s", "02-04-2032", "bachiller", 2134532145, "ES24151241234234");
                Trabajador empl2 = new Trabajador(2, "jose", "botella", "12512521s", "02-04-2032", "bachiller", 2134532145, "ES24151241234234");
                Trabajador empl3 = new Trabajador(3, "radfa", "botella", "12512521s", "02-04-2032", "bachiller", 2134532145, "ES24151241234234");

                listaEpleados.Add(empl1);
                listaEpleados.Add(empl2);
                listaEpleados.Add(empl3);

                */

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
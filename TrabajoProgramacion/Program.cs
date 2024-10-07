using System;

namespace TrabajoProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de ControlAsistencia
            ControlAsistencia controlAsistencia = new ControlAsistencia();

            Console.WriteLine("==== SISTEMA DE GESTIÓN DE ASISTENCIA ====\n");

            // Menú principal del programa
            while (true)
            {
                Console.WriteLine("1. Registrar nuevo estudiante");
                Console.WriteLine("2. Mostrar lista de estudiantes");
                Console.WriteLine("3. Salir\n");

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                // Selección de la opción según la entrada del usuario
                switch (opcion)
                {
                    case "1":
                        controlAsistencia.RegistrarEstudiante();
                        break;
                    case "2":
                        controlAsistencia.MostrarEstudiantes();
                        break;
                    case "3":
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                        break;
                }
            }
        }
    }
}
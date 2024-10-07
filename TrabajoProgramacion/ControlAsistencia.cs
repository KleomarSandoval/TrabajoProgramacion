using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoProgramacion
{
    public class ControlAsistencia
    {
        // Lista para almacenar los estudiantes
        private List<Estudiante> listaEstudiantes = new List<Estudiante>();

        // Método para registrar un nuevo estudiante
        public void RegistrarEstudiante()
        {
            Console.Write("\nIngrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el número total de sesiones: ");
            if (!int.TryParse(Console.ReadLine(), out int sesionesTotales))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                return;
            }

            Console.Write("Ingrese el número de sesiones asistidas: ");
            if (!int.TryParse(Console.ReadLine(), out int sesionesAsistidas))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                return;
            }

            // Crear el objeto de Estudiante
            Estudiante nuevoEstudiante = new Estudiante
            {
                Nombre = nombre,
                SesionesTotales = sesionesTotales,
                SesionesAsistidas = sesionesAsistidas
            };

            listaEstudiantes.Add(nuevoEstudiante);
            Console.WriteLine("Estudiante registrado exitosamente.\n");
        }

        // Método para mostrar todos los estudiantes y su información
        public void MostrarEstudiantes()
        {
            Console.WriteLine("\n==== LISTA DE ESTUDIANTES ====\n");
            if (listaEstudiantes.Count == 0)
            {
                Console.WriteLine("No hay estudiantes registrados.");
                return;
            }

            foreach (var estudiante in listaEstudiantes)
            {
                estudiante.MostrarInformacion();
            }
        }
    }
}
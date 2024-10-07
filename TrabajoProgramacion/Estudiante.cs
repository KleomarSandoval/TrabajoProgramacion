using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoProgramacion
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int SesionesTotales { get; set; }
        public int SesionesAsistidas { get; set; }

        // Método para calcular el porcentaje de asistencia
        public double CalcularPorcentajeAsistencia()
        {
            return SesionesTotales > 0 ? (double)SesionesAsistidas / SesionesTotales * 100 : 0;
        }

        // Método para mostrar la información del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Sesiones Totales: {SesionesTotales}");
            Console.WriteLine($"Sesiones Asistidas: {SesionesAsistidas}");
            Console.WriteLine($"Porcentaje de Asistencia: {CalcularPorcentajeAsistencia():F2}%");
            Console.WriteLine($"Cumple con el mínimo del 75%: {(CalcularPorcentajeAsistencia() >= 75 ? "Sí" : "No")}");
            Console.WriteLine("-------------------------------------------\n");
        }
    }
}
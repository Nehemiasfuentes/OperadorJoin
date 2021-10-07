using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metodo Join

            var estudiantes = new List<(string Nombre, int idUniversidad)>
            {
                ("Nehemias",1),
                ("Hola", 2),
                ("Elian",3),
                ("Elias",1)
            };

            var universidad = new List<(int idUniversidad, string Nombre)>
            {
                (1,"UGB"),
                (2,"UNIVO"),
                (3, "UNAB")
            };

            var detalleEstudiantes = estudiantes.Join(universidad, u => u.idUniversidad, e => e.idUniversidad, (alumnos, universidadAlumno) =>
            {
                return new
                {
                    NombreEstudiante = alumnos.Nombre,
                    NombreUniversidad = universidadAlumno.Nombre
                };
            });

            detalleEstudiantes.ToList().ForEach(detalle =>
            {
                Console.WriteLine($"Alumno: {detalle.NombreEstudiante} , Universidad: {detalle.NombreUniversidad}");
            });
        }
    }
    }
}

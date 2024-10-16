using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial2.Controller
{
    interface IExamen
    {
        List<Persona> ObtenerInfo ();
        bool Insertar(string nombre, int edad, DateTime fechaNacimiento, string correoElectronico);
        bool Eliminar(int ID); //int id
        bool Actualizar(string nombre, int edad, DateTime fechaNacimiento, string correoElectronico, int id);
    }
}

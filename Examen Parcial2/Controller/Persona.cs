using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial2.Controller
{
    class Persona
    {
        public Persona() { }
            public Persona(int iD, string nombre, int edad, DateTime fechaNacimiento, string correoElectronico)
        {
            ID = iD;
            Nombre = nombre;
            Edad = edad;
            FechaNacimiento = fechaNacimiento;
            CorreoElectronico = correoElectronico;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; }
    }
}

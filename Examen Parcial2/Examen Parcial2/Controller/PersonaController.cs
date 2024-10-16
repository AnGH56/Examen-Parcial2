using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Examen_Parcial2.Model.DsPersonaTableAdapters;

namespace Examen_Parcial2.Controller
{
    class PersonaController : IExamen
    {
        List<Persona> listapersonas = new List<Persona>();
        Persona per = new Persona();

        public List<Persona> ObtenerInfo()
        {
            try
            {
                using (personasTableAdapter dt = new personasTableAdapter())
                {
                    var datos = dt.GetData();

                    foreach (DataRow row in datos)
                    {
                        per.ID   = Convert.ToInt32(row["ID"]);
                        per.Nombre = Convert.ToString(row["Nombre"]);
                        per.Edad = Convert.ToInt32(row["Edad"]);
                        per.FechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"]);
                        per.CorreoElectronico = Convert.ToString(row["CorreoElectronico"]);

                        listapersonas.Add(new Persona(per.ID, per.Nombre, per.Edad, per.FechaNacimiento, per.CorreoElectronico));
                    }
                    return listapersonas;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
            
        }

        public bool Actualizar(string nombre, int edad, DateTime fechaNacimiento, string correoElectronico, int id)
        {
            try
            {
                using (personasTableAdapter dt = new personasTableAdapter())
                {
                    var actualizar = listapersonas.FirstOrDefault(x => x.ID == id);
                    if (actualizar != null)
                    {
                        actualizar.Nombre = nombre;
                        actualizar.Edad = edad;
                        actualizar.FechaNacimiento = fechaNacimiento;
                        actualizar.CorreoElectronico = correoElectronico;

                        dt.UpdatePersona(nombre, edad, fechaNacimiento, correoElectronico, id);

                        return true;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public bool Eliminar(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(string nombre, int edad, DateTime fechaNacimiento, string correoElectronico)
        {
            try
            {
                using (personasTableAdapter dt = new personasTableAdapter())
                {
                    per.Nombre = nombre;
                    per.Edad = edad;
                    per.FechaNacimiento = fechaNacimiento;
                    per.CorreoElectronico = correoElectronico;

                    var datos = dt.InsertPersona(per.Nombre, per.Edad, per.FechaNacimiento, per.CorreoElectronico);
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        
    }
}

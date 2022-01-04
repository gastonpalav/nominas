using System;

namespace NominasApi.Entities
{
    public class Alumno : EntityBase
    {
        public String NombreApellido { get; set; }
        public Int64 Id_Curso { get; set; }
        public String TipoDocumento { get; set; }
        public Int64 NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Sexo { get; set; }
        public String Ocupacion { get; set; }
        public String EstadoCivil { get; set; }
        public Int64 Celular { get; set; }
        public String Email { get; set; }
    }
}
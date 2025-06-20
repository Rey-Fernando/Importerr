namespace Importerr.Models
{
    /// Representa un alumno del sistema SYSACAD
    public class Alumno
    {
        public int Id { get; set; }
        public string Apellido { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Documento { get; set; } = string.Empty;
        public string Tipo_documento { get; set; } = string.Empty;
        public string Sexo { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Legajo { get; set; } = string.Empty;
        public DateTime FechaIngreso { get; set; }

        /// Valida que los campos obligatorios estén completos
        public bool EsValido() 
{
    return !string.IsNullOrWhiteSpace(Nombre) &&
           !string.IsNullOrWhiteSpace(Apellido) &&
           !string.IsNullOrWhiteSpace(Documento) &&
           !string.IsNullOrWhiteSpace(Tipo_documento) &&
           !string.IsNullOrWhiteSpace(Legajo) &&
           !string.IsNullOrWhiteSpace(Sexo) &&
           FechaNacimiento != default &&
           FechaIngreso != default;
}

    }
}
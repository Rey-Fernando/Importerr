using Importerr.Models;
using Xunit;

namespace Importerr.alumno.Tests
{
    /// Pruebas unitarias para el modelo Alumno
    /// Aplicando TDD: Primero las pruebas, luego la implementación
    public class AlumnoTests
    {
        [Fact]
        public void EsValido_ConDatosCompletos_RetornaTrue()
        {
            // Arrange
            var alumno = new Alumno
            {
                Apellido = "Pérez",
                Nombre = "Juan",
                Documento = "12345678",
                Tipo_documento = "Pasaporte",
                FechaNacimiento = new DateTime(1995, 5, 15),
                Sexo = "M",
                Legajo = "6",
                FechaIngreso = new DateTime(2023, 3, 1)
            };

            // Act
            var resultado = alumno.EsValido();

            // Assert
            Assert.True(resultado);
        }




        [Fact]
        public void EsValido_ConFechaNacimientoDefault_RetornaFalse()
        {
            // Arrange
            var alumno = new Alumno
            {
                Nombre = "Juan",
                Apellido = "Pérez",
                Documento = "12345678",
                Tipo_documento = "Pasaporte",
                FechaNacimiento = default(DateTime), // Fecha inválida
                Sexo = "M",
                Legajo = "6",
                FechaIngreso = new DateTime(2023, 3, 1)
            };

            // Act
            var resultado = alumno.EsValido();

            // Assert
            Assert.False(resultado);
        }
        [Theory]
        [InlineData("", "Pérez", "12345678", "Pasaporte", "M", "6")]
        [InlineData("Juan", "", "12345678", "Pasaporte", "M", "6")]
        [InlineData("Juan", "Pérez", "", "Pasaporte", "M", "6")]
        [InlineData("Juan", "Pérez", "12345678", "", "M", "6")]
        [InlineData("Juan", "Pérez", "12345678", "Pasaporte", "", "6")]
        [InlineData("Juan", "Pérez", "12345678", "Pasaporte", "M", "")]


        public void EsValido_ConCamposNulosOVacios_RetornaFalse(
            string nombre, string apellido, string documento, string tipoDocumento, string sexo, string legajo)
        {
            // Arrange
            var alumno = new Alumno
            {
                Nombre = nombre,
                Apellido = apellido,
                Documento = documento,
                Tipo_documento = tipoDocumento,
                Sexo = sexo,
                Legajo = legajo,
                FechaNacimiento = new DateTime(1995, 5, 15),
                FechaIngreso = new DateTime(2023, 3, 1)
            };

            // Act
            var resultado = alumno.EsValido();

            // Assert
            Assert.False(resultado);
        }


    }
}
    
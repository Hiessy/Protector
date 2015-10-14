using System;
using System.Runtime.Serialization;

namespace BusinessObject
{
    /// <summary>
    /// Clase base de excepción de error de capa de negocio.
    /// También puede ser utilizada para lanzar una excepción genérica.
    /// </summary>
    public class boException : Exception
    {
        public boException(string mensaje) : base(mensaje)       
        {
        }

        public boException(Exception ex) : base("Se produjo un error en la aplicación.", ex)
        {
        }
    }
}

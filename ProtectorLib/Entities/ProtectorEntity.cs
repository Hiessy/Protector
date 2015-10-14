using System;

namespace Entities
{
    public class ProtectorEntity
    {
        private string correo;
        private string nombre;
        private string apellido;
        private string organizacion;
        private string clave;
        private string direccion;
        private string telefono;
        private string tipo;
        private double latitud;
        private double longitud;   
        
        public ProtectorEntity()
        {
            correo = "";
            nombre = "";
            apellido = "";
            organizacion = "";
            clave = "";
            direccion = "";
            telefono = "";
            tipo = "";                      
        }

        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Organizacion { get; set; }
        public string Clave { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Tipo { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}
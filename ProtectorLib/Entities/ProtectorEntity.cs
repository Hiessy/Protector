using System;

namespace Entities
{
    public class ProtectorEntity
    {        
        private string nombre;
        private string apellido;
        private string contrase;
        private string tipo;
        private string direccion;
        private string telefono;
        private string organizacion;
        private string correo;

        public ProtectorEntity()
        {

            nombre = "";
            apellido = "";
            contrase = "";
            tipo = "";
            organizacion = "";
            direccion = "";
            telefono = "";
            correo = "";
        }
        public string Organizacion
        {
            get
            {
                return organizacion;
            }

            set
            {
                organizacion = value.Trim();
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Contrase
        {
            get
            {
                return contrase;
            }

            set
            {
                contrase = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }
        
        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = (value.Trim() != "" ? value.Trim() : null);
            }
        }

    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using DataObject;
using ODBC;
using Entities;


namespace BusinessObject
{
    public class boProtectors
    {
        private daProtectors protector;

        public boProtectors()
        {
            protector = new daProtectors();
        }

        private void Validar(ProtectorEntity entidad)
        {
            // TODO agregar validacion
            /* if (entidad.Organizacion == "" ||
                 entidad.Nombre == "" ||
                 entidad.Apellido == "" ||
                 entidad.Telefono == "")
             {
                 throw new DatosObligatoriosException();
             }*/
        }

        public List<ProtectorEntity> Buscar(string organizacion, string nombre, string apellido)
        {
            try
            {
                return protector.Buscar(organizacion, nombre, apellido);
            }
            catch (daException ex)
            {
                throw new boException(ex);
            }
        }


        public ProtectorEntity BuscarPorId(string organizacion)
        {
            //TODO buscar method devuelve un entity
            /*  try
              {
                  // Busca el protector utilizando la capa de datos.
                  return protector.BuscarPorClavePrimaria(organizacion);
              }
              catch (daException ex)
              {
                  throw new boException(ex);
              }*/

            return null;
        }

        public void Insertar(ProtectorEntity entidad)
        {
            protector.Insertar(entidad);
            /*   try
            {

                Validar(entidad);//TODAVIA no implementado

                // TODO Si el usuario existe en la base de datos...
                if (protector.BuscarPorClavePrimaria(entidad.Id_protector) != null)
                   {
                       // ...se lanza la excepción correspondiente.
                       throw new protectorExisteException(entidad.Id_protector);
                   }

                // Si no existe el empleado, se crea.
                
            }
            catch (daException ex)
            {
                throw new boException(ex);
            }*/
        }

        public void Actualizar(ProtectorEntity entidad)
        {

            // TODO implementar metodo actualizar
            /*  try
              {
                  // Valida los datos cargados por el usuario.
                  Validar(entidad);

                  // Si el empleado no existe en la base de datos...
                  if (protector.BuscarPorClavePrimaria(entidad.Id_protector) == null)
                  {
                      // ...se lanza la excepción correspondiente.
                      throw new protectorNoExisteException(entidad.Id_protector);
                  }

                  // Si existe, se actualizan los datos.
                  protector.Actualizar(entidad);
              }
              catch (daException ex)
              {
                  throw new boException(ex);
              }*/
        }


        public void Eliminar(int iprotectorid)
        {
            //TODO implementar metoido dar dar de baja.
            /*  try
              {
                  // Se borra el usuario.
                  protector.Eliminar(id_protector);
              }
              catch (daException ex)
              {
                  throw new boException(ex);
              }*/
        }
    }
}

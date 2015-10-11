using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using DataObject;
using Entities;

namespace ODBC
{
    public class daProtectors
    {

        //TODO realizar las consultas SQL
        //private const string SQLSearchByPrimaryKey = 
        private const string SQLSearch = "SELECT * FROM Protectores WHERE CORREO LIKE ? AND CLAVE LIKE ?";
        private const string SQLInsert = "INSERT INTO PROTECTORES (CORREO, NOMBRE, APELLIDO, ORGANIZACION, CLAVE, DIRECCION, TELEFONO) VALUES (?, ?, ?, ?, ?, ?, ?)";
        //"INSERT INTO TIPOS (CORREO, TIPO) VALUES (?,?)";
        //	private const string SQLUpdate = "UPDATE Empleado SET EmpleadoApellido = ?, EmpleadoNombre = ?, EmpleadoTelefono = ?, EmpleadoEmail = ?, EmpleadoFechaNacimiento = ?, EmpleadoSueldo = ? WHERE EmpleadoLegajo = ?";
        //	private const string SQLDelete = "DELETE FROM Empleado WHERE EmpleadoLegajo = ?";

        private daConexion connectionDA = new daConexion();

        public daProtectors()
        {
        }

        private ProtectorEntity CrearEntidad(OdbcDataReader dr)
        {
            ProtectorEntity entidad = new ProtectorEntity();

            entidad.Correo = dr["CORREO"].ToString();
            entidad.Nombre = dr["NOMBRE"].ToString();
            entidad.Apellido = dr["APELLIDO"].ToString();
            entidad.Organizacion = dr["ORGANIZACION"].ToString();
            entidad.Contrase = dr["CLAVE"].ToString();
            entidad.Direccion = dr["DIRECCION"].ToString();
            entidad.Telefono = dr["TELEFONO"].ToString();
            //entidad.Tipo = dr["TIPO"].ToString();
            
            

            return entidad;
        }

        private void CrearParametros(OdbcCommand command, ProtectorEntity entidad)
        {
            OdbcParameter parameter = null;
            parameter = command.Parameters.Add("?", OdbcType.VarChar);
            parameter.Value = entidad.Correo;

            parameter = command.Parameters.Add("?", OdbcType.VarChar);
            parameter.Value = entidad.Nombre;

            parameter = command.Parameters.Add("?", OdbcType.VarChar);
            parameter.Value = entidad.Apellido;

            parameter = command.Parameters.Add("?", OdbcType.VarChar);
            parameter.Value = entidad.Organizacion;

            parameter = command.Parameters.Add("?", OdbcType.VarChar);
            parameter.Value = entidad.Contrase;

            parameter = command.Parameters.Add("?", OdbcType.VarChar);
            parameter.Value = entidad.Direccion;

            parameter = command.Parameters.Add("?", OdbcType.VarChar);
            parameter.Value = entidad.Telefono;

            /*parameter = command.Parameters.Add("?", OdbcType.VarChar);
            parameter.Value = entidad.Tipo;  */          
            
            

            /*	Validacion de campos no necesario en la entidad
             * if (entidad.TieneCorreoE())
                    parameter.Value = entidad.CorreoE;
                else
                    parameter.Value = System.DBNull.Value;*/
        }

        
        private void EjecutarComando(daComun.TipoComandoEnum sqlCommandType, ProtectorEntity entidad)
        {
            //asignando protectorID manual para prueba
            //entidad.Correo = "";


            // Conexión a la base de datos.
            OdbcConnection connection = null;
            // Comando a ejecutar en la base de datos.
            OdbcCommand command = null;

            try
            {
                // Se obtiene una conexión abierta.
                connection = (OdbcConnection)connectionDA.GetOpenedConnection();

                // Se crea el parámetro Legajo y se le asigna el valor.
                //IDataParameter paramProtectorId = new OdbcParameter("?", OdbcType.VarChar);
                //paramProtectorId.Value = entidad.Correo;

                // Dependiendo de la acción que se quiera realizar:
                switch (sqlCommandType)
                {
                    case daComun.TipoComandoEnum.Insertar:
                        // Se crea el comando con la sentendia Insert,
                        // se le agrega el parámetro legajo y luego el resto de
                        // los parámetros.
                        command = new OdbcCommand(SQLInsert, connection);
                        //command.Parameters.Add(paramProtectorId);
                        CrearParametros(command, entidad);
                        break;

                    //TODO actualizar info del protector
                    /*case daComun.TipoComandoEnum.Actualizar:
                        // Se crea el comando con la sentendia Update,
                        // se crean los parámetros comunes y luego se 
                        // agrega el parámetro Legajo.
                        // Esto se hace en este orden porque si miramos la 
                        // sentencia Update, veremos que el parámetro Legajo
                        // es el último.
                        command = new OdbcCommand(SQLUpdate, connection);
                        CrearParametros(command, entidad);
                        command.Parameters.Add(paramLegajo);
                        break;*/

                    // TODO borrar info de la DB
                    /*case daComun.TipoComandoEnum.Eliminar:
                        // Se crea el comando con la sentendia Delete y
                        // se agrega el parámetro Legajo.
                        command = new OdbcCommand(SQLDelete, connection);
                        command.Parameters.Add(paramLegajo);
                        break;*/
                }

                // Se ejecuta el comando en la base de datos.
                command.ExecuteNonQuery();
                // Se cierra la conexión.
                connection.Close();
            }
            catch (Exception ex)
            {
                // En caso de que se produzca un error, se lo lanza hacia la
                // capa superior.
                throw new daException(ex);
            }
            finally
            {
                // Esta parte del código se ejecuta siempre.

                if (command != null)
                {
                    // Se libera el recurso.
                    command.Dispose();
                }

                if (connection != null)
                {
                    // Se libera el recurso.
                    connection.Dispose();
                }
            }
        }


        //TODO Busqueda de resultados
        public ProtectorEntity BuscarPorClavePrimaria(string legajo)
        {

            /*	try
                // Conexión a la base de datos
                OdbcConnection connection = null;
                // Comando a ejecutar en la base de datos.
                OdbcCommand command = null;
                // DataReader con registros de datos.
                OdbcDataReader dr = null;
                // Objeto con datos del empleado.
                ProtectorEntity entidad = null;

                {
                    // Se obtiene una conexión abierta.
                    connection = (OdbcConnection)connectionDA.GetOpenedConnection();
                    // Se crea el comando con la sentencia Select.
                    command = new OdbcCommand(SQLSearchByPrimaryKey, connection);
                    // Se agrega el parámetro Legajo y se le asigna el valor.
                    command.Parameters.Add("?", OdbcType.VarChar);
                    command.Parameters[0].Value = legajo;
                    // Se ejecuta el comando y devuelve un objeto del tipo DataReader
                    // con los datos del empleado.
                    dr = command.ExecuteReader();

                    // Si se puede leer el objeto DataReader.
                    if (dr.Read())
                    {
                        // Se crea el objeto con los datos del empleado.
                        entidad = CrearEntidad(dr);
                    }

                    // Se cierra el DataReader.
                    dr.Close();
                    // Se cierra la conexión.
                    connection.Close();
                }
                catch (Exception ex)
                {
                    // En caso de que se produzca un error, se lo lanza hacia la
                    // capa superior.
                    throw new daException(ex);
                }
                finally
                {
                    // Se marca al objeto para que sea liberado de la memoria.
                    dr = null;
				
                    if (command != null)
                    {
                        // Se libera el recurso.
                        command.Dispose();
                    }
				
                    if (connection != null)
                    {
                        // Se libera el recurso.
                        connection.Dispose();
                    }
                }*/

            return null;
        }

        //TODO buscar una lista de usuario, este va a ser el princial del boton buscar
        public List<ProtectorEntity> Buscar(string organizacion, string nombre, string apellido)
        {
            /*
            // Conexión a la base de datos
            OdbcConnection connection = null;
            // Comando a ejecutar en la base de datos.
            OdbcCommand command = null;
            // DataReader con registros de datos.
            OdbcDataReader dr = null;
            // Lista de objetos con datos de empleados.
            List<ProtectorEntity> protectores = null;
		
            

            try
            {
                // Se obtiene una conexión abierta.
                connection = (OdbcConnection)connectionDA.GetOpenedConnection();
                // Se crea el comando con la sentencia Select.
                command = new OdbcCommand(SQLSearch, connection);
                // Se agrega el parámetro Legajo.
                command.Parameters.Add("?", OdbcType.VarChar);
                command.Parameters[0].Value = "%" + legajo + "%";
                // Se agrega el parámetro Apellido.
                command.Parameters.Add("?", OdbcType.VarChar);
                command.Parameters[1].Value = "%" + apellido + "%";
                // Se agrega el parámetro Nombre.
                command.Parameters.Add("?", OdbcType.VarChar);
                command.Parameters[2].Value = "%" + nombre + "%";
                // Se ejecuta el comando SQL en la base de datos y se devuelve 
                // una instancia de DataReader con los registros encontrados.
                dr = command.ExecuteReader();

                // Se crea una instancia de la lista de empleados.
                empleados = new List<ProtectorEntity>();

                // Mientras que se pueda leer el DataReader.
                while (dr.Read())
                {
                    // Se agrega un objeto con los datos del empleado a la lista.
                    empleados.Add(CrearEntidad(dr));
                }

                // Se cierra el DataReader.
                dr.Close();
                // Se cierra la conexión.
                connection.Close();
            }
            catch (Exception ex)
            {
                // En caso de que se produzca un error, se lo lanza hacia la
                // capa superior.
                throw new daException(ex);
            }
            finally
            {
                dr = null;
				
                if (command != null)
                {
                    // Se libera el recurso.
                    command.Dispose();
                }
				
                if (connection != null)
                {
                    // Se libera el recurso.s
                    connection.Dispose();
                }
            }*/

            return null;
        }

        public void Insertar(ProtectorEntity entidad)
        {
            EjecutarComando(daComun.TipoComandoEnum.Insertar, entidad);
        }

        // TODO actualizar el usuario 
        public void Actualizar(ProtectorEntity entidad)
        {/*
            EjecutarComando(daComun.TipoComandoEnum.Actualizar, entidad);*/
        }



        public void Eliminar(int id_protector)
        {
            // TODO dar de baja entidad
            /*
                ProtectorEntity entidad = new ProtectorEntity();
                entidad.Id_protector = id_protector;

                EjecutarComando(daComun.TipoComandoEnum.Eliminar, entidad);*/
        }
    }
}

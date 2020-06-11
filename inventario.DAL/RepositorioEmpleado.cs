using inventario.COMMON.Entidades;
using inventario.COMMON.interfaces;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// esta capa es para acceder a los datos del iventario DAL (Layer Access Data)
namespace inventario.DAL
{
    //Se implementa la Interfaz Repositorio
    public class RepositorioEmpleado : IRepositorio<empleado>
    {
        // varibales
        private string DBName = "Inventario.db";//nombre de la base de datos
        private string TableName = "empleados";//Nombre de la tabla donde se guardaran los datos 
        public List<empleado> Read {
            get
            {
                List<empleado> datos = new List<empleado>(); //la palabra datos es un nombre cualquiera para la lista
                using (var db = new LiteDatabase(DBName)) // using, instruccion para insertar una base de datos o crearlos
                {
                    datos = db.GetCollection<empleado>(TableName).FindAll().ToList(); // busca los datos de la tabla empleados para agregarlos a una lista, la ultima condicion lo transforma a una lista
                                                                                      // comando sencillo para evitar una busqueda con for
                }
                return datos;
            }
            
            }

        public bool Crear(empleado entidad)
        {
            entidad.Id = Guid.NewGuid().ToString(); // Genera el id; guid, genera numeros aleatorios de 37 digitos
            //intenta usando la base de datos -> obtiene la coleccion de la tabla -> a la coleccion la inserta la entidad que se esta pasando (id) 
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<empleado>(TableName);
                    coleccion.Insert(entidad);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Editar(empleado entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<empleado>(TableName);
                    coleccion.Update(entidadModificada);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Eliminar(string id, empleado entidad)
        {
            try
            {
                
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<empleado>(TableName);
                    coleccion.Delete(entidad.Id == id);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

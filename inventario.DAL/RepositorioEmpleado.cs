using inventario.COMMON.Entidades;
using inventario.COMMON.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
// esta capa es para acceder a los datos del iventario DAL (Layer Access Data)
namespace inventario.DAL
{
    //Se implementa la Interfaz Repositorio
    public class RepositorioEmpleado : IRepositorio<empleado>
    {
        public List<empleado> Read => throw new NotImplementedException();

        public bool Crear(empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Editar(string id, empleado entidadModificada)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(empleado entidad)
        {
            throw new NotImplementedException();
        }
    }
}

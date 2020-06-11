using inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.interfaces
{
    // Inventario general, pertenece a cualquier clase que se quiera asignar
    public interface IRepositorio<T> where T:Base // se coloca <T> where T:class para decirle que pertenesca a cualquir entidad de clase (herencia)
    {
        //creo un metodo
        bool Crear(T entidad);
        List<T> Read { get; }
        bool Editar(T entidadModificada);
        bool Eliminar(string id, empleado entidad);
        
    }
}

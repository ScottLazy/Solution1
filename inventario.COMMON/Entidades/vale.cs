using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.Entidades
{
    public class vale:Base
    {
        
        public DateTime FechaHoraSolicitud { set; get; }
        public DateTime FechaEntrega { set; get; }
        public DateTime? FechaEntregaReal { set; get; }
        public List<materiales> 
            MaterilesPrestados { set; get; }
        public empleado Solicitante { get; set; }
        public empleado EncargadoAlmacen { get; set; }
    }
}

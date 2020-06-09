using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.Entidades
{
    public class materiales:Base
    {
        public string nombre { get; set; }
        public string categoria { set; get; }
        public string descripcion { set; get; }
    }
}

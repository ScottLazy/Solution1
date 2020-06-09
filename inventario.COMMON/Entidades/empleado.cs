using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.Entidades
{
    public class empleado:Base
    {
        public string nombre { set; get; }
        public string apellidos { set; get; }
        public string area { set; get; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public Producto()
        {
            this.Venta = new HashSet<Venta>();
        }
    
        public int codigo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string tipo { get; set; }
        public int precio { get; set; }
    
        public virtual ICollection<Venta> Venta { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedidoresModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lectura
    {
        public int idLecturas { get; set; }
        public System.DateTime date { get; set; }
        public string consumo { get; set; }
        public string FK_Usuario { get; set; }
        public int FK_Medidor { get; set; }
    
        public virtual Medidore Medidore { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
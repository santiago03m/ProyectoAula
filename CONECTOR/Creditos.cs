//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CONECTOR
{
    using System;
    using System.Collections.Generic;
    
    public partial class Creditos
    {
        public int ID_Credito { get; set; }
        public Nullable<int> ID_Cliente { get; set; }
        public Nullable<decimal> Monto_Total { get; set; }
        public Nullable<System.DateTime> Fecha_Inicio { get; set; }
        public Nullable<System.DateTime> Fecha_Vencimiento { get; set; }
        public Nullable<decimal> Tasa_Interes { get; set; }
        public string Estado { get; set; }
    }
}

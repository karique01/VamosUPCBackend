//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vamosupcapi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class busStopByRoute
    {
        public int id { get; set; }
        public int routeId { get; set; }
        public int busStopId { get; set; }
        public bool active { get; set; }
    
        [Newtonsoft.Json.JsonIgnore] public virtual busStop busStop { get; set; }
        [Newtonsoft.Json.JsonIgnore] public virtual route route { get; set; }
    }
}

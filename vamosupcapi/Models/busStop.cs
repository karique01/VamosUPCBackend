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
    
    public partial class busStop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public busStop()
        {
            this.busStopByRoutes = new HashSet<busStopByRoute>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public bool active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [Newtonsoft.Json.JsonIgnore] public virtual ICollection<busStopByRoute> busStopByRoutes { get; set; }
    }
}
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
    
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.busByUsers = new HashSet<busByUser>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string dni { get; set; }
        [Newtonsoft.Json.JsonIgnore] public string password { get; set; }
        public int userTypeId { get; set; }
        public string currentLat { get; set; }
        public string currentLng { get; set; }
        public bool active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [Newtonsoft.Json.JsonIgnore] public virtual ICollection<busByUser> busByUsers { get; set; }
        [Newtonsoft.Json.JsonIgnore] public virtual userType userType { get; set; }
    }
}

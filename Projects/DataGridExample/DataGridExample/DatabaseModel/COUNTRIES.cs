//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataGridExample.DatabaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class COUNTRIES
    {
        public COUNTRIES()
        {
            this.LOCATIONS = new HashSet<LOCATIONS>();
        }
    
        public string COUNTRY_ID { get; set; }
        public string COUNTRY_NAME { get; set; }
        public Nullable<decimal> REGION_ID { get; set; }
    
        public virtual REGIONS REGIONS { get; set; }
        public virtual ICollection<LOCATIONS> LOCATIONS { get; set; }
    }
}

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
    
    public partial class DOCACCSTORE
    {
        public string NODOC { get; set; }
        public string TYPDOC { get; set; }
        public short POS { get; set; }
        public short SEQ { get; set; }
        public string TYPE_FIELD { get; set; }
        public Nullable<decimal> KOL { get; set; }
        public string COLOR_ID { get; set; }
        public Nullable<decimal> T_LEN { get; set; }
        public Nullable<decimal> T_BON { get; set; }
        public string SIZE_ID { get; set; }
    
        public virtual DOCACC DOCACC { get; set; }
    }
}
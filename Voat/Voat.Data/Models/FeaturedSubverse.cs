//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voat.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeaturedSubverse
    {
        public int ID { get; set; }
        public string Subverse { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreationDate { get; set; }
    
        public virtual Subverse Subverse1 { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomReports.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dimension
    {
        public int Id { get; set; }
        public int BlocId { get; set; }
        public string FieldName { get; set; }
        public string Alias { get; set; }
    
        public virtual Bloc Bloc { get; set; }
    }
}
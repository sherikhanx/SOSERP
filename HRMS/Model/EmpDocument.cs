//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpDocument
    {
        public System.Guid DocumentId { get; set; }
        public System.Guid EmployeeId { get; set; }
        public string DocumentType { get; set; }
        public string Title { get; set; }
        public string Extension { get; set; }
        public string ContentType { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}

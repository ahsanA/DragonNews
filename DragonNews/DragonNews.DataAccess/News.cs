//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DragonNews.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        public System.Guid ID { get; set; }
        public int Category { get; set; }
        public string Details { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.Guid UserID { get; set; }
        public string Title { get; set; }
    
        public virtual Member Member { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Books
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string year { get; set; }
        public string type { get; set; }
        public Nullable<int> price { get; set; }
    }
}
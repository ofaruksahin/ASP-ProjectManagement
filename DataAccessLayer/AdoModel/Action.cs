//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.AdoModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Action
    {
        public int Id { get; set; }
        public string User_Id { get; set; }
        public string Message { get; set; }
        public bool Completed { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}

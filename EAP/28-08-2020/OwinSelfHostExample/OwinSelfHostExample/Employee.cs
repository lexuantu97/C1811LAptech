//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OwinSelfHostExample
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int DeptID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DOJ { get; set; }
        public Nullable<bool> Gender { get; set; }
        public Nullable<int> YearOfBirth { get; set; }
    
        public virtual Department Department { get; set; }
    }
}

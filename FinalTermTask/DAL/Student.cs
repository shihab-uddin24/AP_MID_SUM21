//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int Id { get; set; }
        public int Dept_Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public int Credit { get; set; }
        public Nullable<double> CGPA { get; set; }
    
        public virtual Department Department { get; set; }
    }
}

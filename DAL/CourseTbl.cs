//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseTbl
    {
        public CourseTbl()
        {
            this.TuteeTbls = new HashSet<TuteeTbl>();
        }
    
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int TutorId { get; set; }
    
        public virtual TutorTbl TutorTbl { get; set; }
        public virtual ICollection<TuteeTbl> TuteeTbls { get; set; }
    }
}

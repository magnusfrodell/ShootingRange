//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShootingRange.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_session
    {
        public t_session()
        {
            this.t_rankignoresession = new HashSet<t_rankignoresession>();
            this.t_sessionsubtotal = new HashSet<t_sessionsubtotal>();
        }
    
        public int SessionId { get; set; }
        public int ShooterId { get; set; }
        public int LaneNumber { get; set; }
        public int ProgramNumber { get; set; }
    
        public virtual ICollection<t_rankignoresession> t_rankignoresession { get; set; }
        public virtual t_shooter t_shooter { get; set; }
        public virtual ICollection<t_sessionsubtotal> t_sessionsubtotal { get; set; }
    }
}

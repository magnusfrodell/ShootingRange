//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShootingRange.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_bestshot
    {
        public t_bestshot()
        {
            this.t_sessionsubtotal = new HashSet<t_sessionsubtotal>();
        }
    
        public int BestShotId { get; set; }
        public int ShotId { get; set; }
    
        public virtual t_shot t_shot { get; set; }
        public virtual ICollection<t_sessionsubtotal> t_sessionsubtotal { get; set; }
    }
}

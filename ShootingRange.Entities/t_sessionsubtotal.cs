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
    
    public partial class t_sessionsubtotal
    {
        public t_sessionsubtotal()
        {
            this.t_shot = new HashSet<t_shot>();
        }
    
        public int SessionSubtotalId { get; set; }
        public int SessionId { get; set; }
        public Nullable<int> BestShotId { get; set; }
        public int SubtotalOrdinal { get; set; }
    
        public virtual t_session t_session { get; set; }
        public virtual ICollection<t_shot> t_shot { get; set; }
        public virtual t_shot t_shot1 { get; set; }
    }
}

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
    
    public partial class t_group
    {
        public t_group()
        {
            this.t_shooter = new HashSet<t_shooter>();
        }
    
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public Nullable<int> GroupDescriptionId { get; set; }
    
        public virtual ICollection<t_shooter> t_shooter { get; set; }
        public virtual t_groupdescription t_groupdescription { get; set; }
    }
}
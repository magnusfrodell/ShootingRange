//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShootingRange.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_bestshot
    {
        public int BestShotId { get; set; }
        public int ShotId { get; set; }
    
        public virtual t_shot t_shot { get; set; }
    }
}

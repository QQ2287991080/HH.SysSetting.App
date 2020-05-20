
namespace HH.SysSetting.App.Models
{
    using Dapper;
    using System;
    using System.Collections.Generic;
    
    public partial class BA_MenuTree
    {
        [Key]
        public decimal Id { get; set; }
        public Nullable<decimal> IdParent { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public Nullable<byte> IconType { get; set; }
        public string IconColor { get; set; }
        public Nullable<bool> IsSysDefine { get; set; }
        public Nullable<short> Order { get; set; }
    
        
        public virtual ICollection<BA_MenuTree> BA_MenuTree1 { get; set; }
        public virtual BA_MenuTree BA_MenuTree2 { get; set; }
        public virtual ICollection<BA_MenuTreeRelation> BA_MenuTreeRelation { get; set; }
    }
}

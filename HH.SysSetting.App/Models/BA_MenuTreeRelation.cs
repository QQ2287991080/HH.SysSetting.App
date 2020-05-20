
namespace HH.SysSetting.App.Models
{
    using Dapper;
    using System;
    using System.Collections.Generic;
    
    public partial class BA_MenuTreeRelation
    {
        [Key]
        public string MenuCode { get; set; }
        public decimal TreeId { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsSysDefine { get; set; }
        public Nullable<short> Order { get; set; }
    
        public virtual BA_MenuTree BA_MenuTree { get; set; }
        public virtual BA_SysMenu BA_SysMenu { get; set; }
    }
}

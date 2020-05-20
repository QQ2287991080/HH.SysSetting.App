namespace HH.SysSetting.App.Models
{
    using Dapper;
    using System;
    using System.Collections.Generic;

    public partial class BA_SysMenu
    {
        [Key]
        [Column("Code")]
        public string BaseMenuCode { get; set; }
        [Column("CodeParent")]
        public string BaseCodeParent { get; set; }
        [Column("Name")]
        public string BaseMenuName { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        [Column("Description")]
        public string BaseDescription { get; set; }
        [Column("Icon")]
        public string BaseIcon { get; set; }
        [Column("IconType")]
        public Nullable<byte> BaseIconType { get; set; }
        [Column("IconColor")]
        public string BaseIconColor { get; set; }
        public byte MenuType { get; set; }
        public string Url { get; set; }
        [Column("Order")]
        public Nullable<short> MenuOrder { get; set; }
        public Nullable<bool> IsSysDefine { get; set; }
        public bool IsAuthority { get; set; }
        public bool IsVisibled { get; set; }
        public bool IsEndGrade { get; set; }
        //public virtual ICollection<BA_FunctionAuth> BA_FunctionAuth { get; set; }
        //public virtual ICollection<BA_SysMenu> BA_SysMenu1 { get; set; }
        //public virtual BA_SysMenu BA_SysMenu2 { get; set; }
        //public virtual ICollection<BA_MenuTreeRelation> BA_MenuTreeRelation { get; set; }
    }
}

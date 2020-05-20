namespace HH.SysSetting.App.Models
{
    using Dapper;
    using System;
    using System.Collections.Generic;
    
    public  class BA_FunctionAuth
    {
        [Key]
        public decimal Id { get; set; }
        public string MenuCode { get; set; }
        public string InIdCode { get; set; }
        public string Code { get; set; }
        [Column("Name")]
        public string FuncName { get; set; }
        public string Description { get; set; }
        [Column("Icon")]
        public string FuncIcon { get; set; }
        public Nullable<byte> IconType { get; set; }
        public string IconColor { get; set; }
       
    }
}

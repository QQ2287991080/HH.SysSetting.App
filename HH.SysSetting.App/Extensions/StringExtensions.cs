using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.SysSetting.App.Extensions
{
    public static class StringExtensions
    {
        public static string CombineCode(this string str,string code)
        {
            return str.ToUpper() + "_" + code.ToUpper();
        }
        public static string IsNull(this string str)
        {
            if (string.IsNullOrEmpty(str)) return null;
            return str;
        }
    }
}

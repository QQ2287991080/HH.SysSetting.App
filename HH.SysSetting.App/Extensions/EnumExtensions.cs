using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HH.SysSetting.App.Extensions
{
    public static class EnumExtensions
    {
        public static string GetEnumDesciption(this Enum anyEnum)
        {
            var type= anyEnum.GetType();
            var name = Enum.GetName(type, anyEnum);
            if (name == null) return null;
            var filed = type.GetField(name);
            var attribute = Attribute.GetCustomAttribute(filed, typeof(DescriptionAttribute)) as DescriptionAttribute;
            if (attribute == null) return name;
            return attribute?.Description;
        }

        public static object GetEunmInDesciption(this string str,Type enumType)
        {
            var names = Enum.GetNames(enumType);
            foreach (var item in names)
            {
                var filed = enumType.GetField(item);
                var attribute = Attribute.GetCustomAttribute(filed, typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute == null)continue;
                if (attribute.Description.Equals(str)) { str = item; break; }
            }
            return Enum.Parse(enumType, str);
        }
        private static object GetValue(Enum anyEnum)
        {
            var type = Enum.GetUnderlyingType(anyEnum.GetType());
            return Convert.ChangeType(anyEnum, type);
        }

        public static List<CBModel> GetEnumValues(Type type) 
        {
            var value = Enum.GetValues(type);
            List<CBModel> list = new List<CBModel>();
            foreach (var item in value)
            {
                CBModel cB = new CBModel
                {
                    Value = Convert.ToInt32(((Enum)item).ToString("d")),
                    Name = item.ToString()
                };
                
                list.Add(cB);
            }
            return list;
        }
    }
    public class CBModel
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }
}

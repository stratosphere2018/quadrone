using System;

namespace Stratosphere
{
    public static class Common
    {
        public static string EnumToString(this Enum value)
        {
            Type type = value.GetType();

            System.Reflection.FieldInfo fieldInfo = type.GetField(value.ToString());
            if (fieldInfo == null) return null;

            StringValueAttributeAttribute[] attrs = fieldInfo.GetCustomAttributes(typeof(StringValueAttributeAttribute), false) as StringValueAttributeAttribute[];

            return attrs.Length > 0 ? attrs[0].GetString : null;
        }
    }
}

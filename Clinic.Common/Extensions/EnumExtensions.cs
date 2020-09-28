using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Clinic.Common.Extensions
{
    public static class EnumExtensions
    {
        public static string GetEnumDescription(this Enum value)
        {
            if (value != null)
            {
                IReadOnlyCollection<Attribute> attributes = value.GetEnumAttributes();
                DescriptionAttribute descriptionAttribute = attributes.OfType<DescriptionAttribute>().FirstOrDefault();
                return descriptionAttribute != null ? descriptionAttribute.Description : value.ToString();
            }

            return null;
        }
        public static IReadOnlyCollection<Attribute> GetEnumAttributes(this Enum value)
        {
            value.ThrowIfArgumentNull("value");

            FieldInfo field = value.GetType().GetField(value.ToString());
            return Attribute.GetCustomAttributes(field);
        }
    }
}

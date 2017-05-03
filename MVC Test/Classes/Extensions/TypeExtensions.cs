using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Test.Classes.Extensions
{
    public static class TypeExtensions
    {
        public static string ToGenericTypeString(this Type t)
        {
            if (!t.IsGenericType)
            {
                return t.Name;
            }

            var genericTypeName = t.GetGenericTypeDefinition().Name;
            genericTypeName = genericTypeName.Substring(0, genericTypeName.IndexOf('`'));
            var genericArgs = string.Join(",", t.GetGenericArguments().Select(ToGenericTypeString).ToArray());

            return genericTypeName + "<" + genericArgs + ">";
        }
    }
}
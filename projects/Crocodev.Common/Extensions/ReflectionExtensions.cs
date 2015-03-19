// Crocodev (c) 2015 Crocodev
// Crocodev.Common
// ReflectionExtensions.cs
// romak_000, 2015-03-19 15:29

using System;
using System.Reflection;

namespace Crocodev.Common.Extensions
{
    public static class ReflectionExtensions
    {
        /// <summary>
        /// Obtain attribute settled type. Can obtain inheretted attributes. Returns nillif attribute is not found.
        /// </summary>
        public static T GetAttribute<T>(
            this MemberInfo member,
            bool inherit = false) where T : Attribute
        {
            var attr = Attribute.GetCustomAttribute(member, typeof (T), inherit);
            return attr as T;
        }
    }
}
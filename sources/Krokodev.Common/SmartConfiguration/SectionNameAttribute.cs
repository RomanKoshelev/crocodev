// Crocodev (c) 2015 Crocodev
// Crocodev.Common
// SectionNameAttribute.cs
// romak_000, 2015-03-19 15:29

using System;

namespace Krokodev.Common.SmartConfiguration
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class SectionNameAttribute : Attribute
    {
        public SectionNameAttribute(string sectionName)
        {
            Name = sectionName;
        }

        public string Name { get; private set; }
    }
}
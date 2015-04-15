// Crocodev (c) 2015 Crocodev
// Crocodev.Common
// SmartConfigurationSection.cs
// romak_000, 2015-03-19 15:29

using System;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Krokodev.Common.Extensions;

namespace Krokodev.Common.SmartConfiguration
{
    public class SmartConfigurationSection<T> : ConfigurationSection
    {
        private static readonly Lazy<T> InstanceValue =
            new Lazy<T>(
                CreateInstance,
                LazyThreadSafetyMode.ExecutionAndPublication
                );

        public static T Instance
        {
            get { return InstanceValue.Value; }
        }

        private static T CreateInstance()
        {
            var attr = typeof (T).GetAttribute<SectionNameAttribute>();
            Trace.Assert(attr != null);

            return (T) ConfigurationManager.GetSection(attr.Name);
        }

        protected static string GetMethodName([CallerMemberName] string name = "")
        {
            return name;
        }
    }
}
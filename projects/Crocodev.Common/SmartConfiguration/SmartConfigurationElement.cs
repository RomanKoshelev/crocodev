// Crocodev (c) 2015 Crocodev
// Crocodev.Common
// SmartConfigurationElement.cs
// romak_000, 2015-03-19 15:29

using System.Configuration;
using System.Runtime.CompilerServices;

namespace Crocodev.Common.SmartConfiguration
{
    public class SmartConfigurationElement : ConfigurationElement
    {
        protected static string GetPropertyName([CallerMemberName] string name = "")
        {
            return name;
        }
    }
}
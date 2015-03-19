// Crocodev (c) 2015 Crocodev
// Crocodev.Common
// FileSystemExtensions.cs
// romak_000, 2015-03-19 15:29

using System;

namespace Crocodev.Common.Extensions
{
    public static class FileSystemExtensions
    {
        public static string MapPathToDataDirectory(this string path)
        {
            return AppDomain.CurrentDomain.GetData("DataDirectory") + path;
        }
    }
}
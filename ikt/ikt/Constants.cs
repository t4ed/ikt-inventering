using ikt.DAL;
using ikt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt
{
    public class Constants
    {
        public static string SiteName { get; } = "IKT";

        public static int UserNameLength { get; } = 5;

        public static string[] Developers { get; } =
        {
            "9810pema",
            "9824leda",
            "9709ekch",
            "9628hujo",
            "9801riji",
            "9826skma",
            "9825faed"
        };

        public static int ItemsPerPage { get; } = 12;

        public static int MaxFileSizeMB { get; } = 10;
        public static string FilePath { get; } = "~/Content/ProjectFiles/";

        public static long MegabytesToBytes(int MB)
        {
            return (MB * 1048576);
        }

        public static int BytesToMegabytes(long bytes)
        {
            return (int)(bytes / 1048576);
        }

        public static int DescriptionLengthIndex { get; } = 65;
    }
}
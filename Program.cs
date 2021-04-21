using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Stride.Core;
using Stride.Core.Storage;

namespace StrideFileSystemPreview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opening database at '{0}'", Path.Combine(PlatformFolders.ApplicationDataDirectory, "db"));

            using var database = ObjectDatabase.CreateDefaultDatabase();

            foreach (var obj in database.EnumerateObjects())
            {
                string url = database.ContentIndexMap
                        .SearchValues(kvp => kvp.Value == obj)
                        .FirstOrDefault().Key ?? "(undefined)";

                int size = database.GetSize(obj);

                Console.WriteLine("{0}\t{1}", ConvertToHumanReadable(size).PadLeft(6, ' '), url);
            }
        }

        private static string ConvertToHumanReadable(int size)
        {
            if (size < 1024)
                return size + "B";
            if (size < 1024 * 1024)
                return (size / 1024) + "KB";
            if (size < 1024 * 1024 * 1024)
                return (size / 1024 / 1024) + "MB";

            // I'm not really expecting to see that
            return (size / 1024 / 1024 / 2014) + "GB";
        }
    }
}

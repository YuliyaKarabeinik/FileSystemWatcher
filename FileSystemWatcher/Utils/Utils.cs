using System.Text.RegularExpressions;

namespace FileSystemWatcher.Utils
{
    static class Utils
    {
        public static bool IsMatched(this string fileName, string pattern)
        {
            var regexp = new Regex(pattern);
            return regexp.IsMatch(fileName);
        }

        public static string GetFileName(this string fullPath)
        {
            return fullPath.Substring(fullPath.LastIndexOf('\\') + 1);
        }
        
        public static string GetDestinationFileName(this string fullDestPath, string fileName)
        {
            return $"{fullDestPath}\\{fileName}";
        }
    }
}

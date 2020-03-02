using System.Globalization;
using System.Threading;
using FileSystemWatcher.Configuration;

namespace FileSystemWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUpCulture();
            Watcher.Run(Config.Folders);
        }

        public static void SetUpCulture()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Config.Culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Config.Culture);
        }
    }
}

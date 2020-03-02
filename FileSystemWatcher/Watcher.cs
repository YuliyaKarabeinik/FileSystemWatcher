using System;
using System.Collections.Generic;
using System.IO;
using FileSystemWatcher.Resources;

namespace FileSystemWatcher
{
    public static class Watcher
    {
        public static void Run(List<string> folders)
        {
            foreach (string path in folders)
            {
                Watch(path);
            }

            Console.WriteLine(Messages.Quit);
            while (true)
            {
                Console.CancelKeyPress -= CancelKeyPress;
            }
        }

        private static void CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            if (e.SpecialKey == ConsoleSpecialKey.ControlC || e.SpecialKey == ConsoleSpecialKey.ControlBreak)
            {
                e.Cancel = true;
            }
        }

        private static void Watch(string watchFolder)
        {
            var watcher = new System.IO.FileSystemWatcher
            {
                Path = watchFolder,
                NotifyFilter = NotifyFilters.LastAccess
                                   | NotifyFilters.LastWrite
                                   | NotifyFilters.FileName
                                   | NotifyFilters.DirectoryName
            };
            watcher.Created += OnCreated;
            watcher.Changed += OnChanged;
            watcher.Deleted += OnChanged;
            watcher.Renamed += OnRenamed;

            watcher.EnableRaisingEvents = true;
        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(Messages.OnChanged, e.FullPath, e.ChangeType);
            var rulesExecutor = new RulesExecutor();
            rulesExecutor.RunRules(e.FullPath);
        }

        private static void OnChanged(object source, FileSystemEventArgs e) =>
            Console.WriteLine(Messages.OnChanged, e.FullPath, e.ChangeType);

        private static void OnRenamed(object source, RenamedEventArgs e) =>
            Console.WriteLine(Messages.OnRenamed, e.OldFullPath, e.FullPath);
    }
}
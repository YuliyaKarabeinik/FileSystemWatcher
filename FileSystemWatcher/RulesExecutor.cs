using System;
using System.Globalization;
using System.IO;
using FileSystemWatcher.Configuration;
using FileSystemWatcher.Resources;
using FileSystemWatcher.Utils;

namespace FileSystemWatcher
{
    public class RulesExecutor
    {
        private int Index { get; set; }

        private string CurrentDate => 
            DateTime.Now.ToString(CultureInfo.CurrentCulture).Replace(':', '-').Replace('/', '-');

        public void RunRules(string fullPath)
        {
            var fileName = fullPath.GetFileName();
            bool isMatched = false;

            foreach (var rule in Config.Rules)
            {
                if (!File.Exists(fullPath)) break;

                if (fileName.IsMatched(rule.Pattern))
                {
                    Console.WriteLine(Messages.MatchesRule, fileName, rule.Pattern);
                    MoveFile(fullPath, rule.Destination, rule.AddIndex, rule.AddDate);
                    isMatched = true;
                }
                else
                {
                    Console.WriteLine(Messages.DoesNotMatch, fileName, rule.Pattern);
                }
            }
            if (!isMatched && File.Exists(fullPath)) MoveFile(fullPath, Config.DefaultFolder);
        }

        private void MoveFile(string sourceFilePath, string destination, bool addIndex = false, bool addDate = false)
        { 
            AddDirectoryIfNotExist(destination);
            var fileName = sourceFilePath.GetFileName();
            if (addIndex) fileName = AddIndex(fileName);
            if (addDate) fileName = AddDate(fileName);

            var destPath = destination.GetDestinationFileName(fileName);

            if (File.Exists(destPath))
            {
                Console.WriteLine(Messages.UnableToMove, sourceFilePath, destPath);
            }
            else
            {
                File.Move(sourceFilePath, destPath);
                Console.WriteLine(Messages.FileWasMoved, sourceFilePath, destPath);
            }
        }

        private void AddDirectoryIfNotExist(string path)
        {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }
        
        private string AddDate(string fileName)
        {
            return $"{CurrentDate}{fileName}";
        }

        private string AddIndex(string fileName)
        {
            Index++;
            return $"{Index}{fileName}";
        }
        
    }
}

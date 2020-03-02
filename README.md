# FileSystemWatcher

Configuration.
Contains Custom configuration section, which includes:
  - Culture configuration
  - Folders to monitor
  - Rules (according to the specified pattern new file should be moved to specified folder)
      - pattern
      - destination folder
      - add or do not add an index
      - add or do not add current date time
#    
Watcher.
Watcher class monitors the specified folders and call RulesExecutor when any event happens.

#
RulesExecutor.
Checks whether a new file matches the specified pattern or not.
  - In case of success it performs file name modifications and moves the file to specified folder.
  - In case of failure it moves the file to default folder (default folder is defined in config also)

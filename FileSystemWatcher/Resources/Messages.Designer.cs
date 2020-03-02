﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileSystemWatcher.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FileSystemWatcher.Resources.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} does not match rule: {1}.
        /// </summary>
        internal static string DoesNotMatch {
            get {
                return ResourceManager.GetString("DoesNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} was moved to {1}.
        /// </summary>
        internal static string FileWasMoved {
            get {
                return ResourceManager.GetString("FileWasMoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} matches the rule: {1}.
        /// </summary>
        internal static string MatchesRule {
            get {
                return ResourceManager.GetString("MatchesRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File: {0} {1}.
        /// </summary>
        internal static string OnChanged {
            get {
                return ResourceManager.GetString("OnChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File: {0} renamed to {1}.
        /// </summary>
        internal static string OnRenamed {
            get {
                return ResourceManager.GetString("OnRenamed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press &apos;ctrl+c&apos; or &apos;ctrl+break&apos; to quit..
        /// </summary>
        internal static string Quit {
            get {
                return ResourceManager.GetString("Quit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to move {0}.
        ///{1} already exists..
        /// </summary>
        internal static string UnableToMove {
            get {
                return ResourceManager.GetString("UnableToMove", resourceCulture);
            }
        }
    }
}

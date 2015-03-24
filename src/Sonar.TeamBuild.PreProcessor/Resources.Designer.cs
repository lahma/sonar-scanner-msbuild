﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sonar.TeamBuild.PreProcessor {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sonar.TeamBuild.PreProcessor.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Creating directory: {0}.
        /// </summary>
        internal static string DIAG_CreatingDirectory {
            get {
                return ResourceManager.GetString("DIAG_CreatingDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating config and output folders....
        /// </summary>
        internal static string DIAG_CreatingFolders {
            get {
                return ResourceManager.GetString("DIAG_CreatingFolders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing the existing directory: {0}.
        /// </summary>
        internal static string DIAG_DeletingDirectory {
            get {
                return ResourceManager.GetString("DIAG_DeletingDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating the FxCop ruleset....
        /// </summary>
        internal static string DIAG_GeneratingRuleset {
            get {
                return ResourceManager.GetString("DIAG_GeneratingRuleset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Located the runner properties file: {0}.
        /// </summary>
        internal static string DIAG_LocatedRunnerProperties {
            get {
                return ResourceManager.GetString("DIAG_LocatedRunnerProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path to the sonar-runner.properties file was not supplied on the command line. Attempting to locate the file....
        /// </summary>
        internal static string DIAG_LocatingRunnerProperties {
            get {
                return ResourceManager.GetString("DIAG_LocatingRunnerProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing command line and environment variables.
        /// </summary>
        internal static string DIAG_ProcessingCommandLine {
            get {
                return ResourceManager.GetString("DIAG_ProcessingCommandLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saving the config file to {0}.
        /// </summary>
        internal static string DIAG_SavingConfigFile {
            get {
                return ResourceManager.GetString("DIAG_SavingConfigFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sonar pre-processing cannot be performed - required settings are missing.
        /// </summary>
        internal static string ERROR_CannotPerformProcessing {
            get {
                return ResourceManager.GetString("ERROR_CannotPerformProcessing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following CheckId should not appear multiple times: {0}.
        /// </summary>
        internal static string ERROR_DuplicateCheckId {
            get {
                return ResourceManager.GetString("ERROR_DuplicateCheckId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to locate the sonar-runner.properties file. Unable to proceed..
        /// </summary>
        internal static string ERROR_FailedToLocateRunnerProperties {
            get {
                return ResourceManager.GetString("ERROR_FailedToLocateRunnerProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting at least three command line arguments:
        ///- Sonar project key
        ///- Sonar project name
        ///- Sonar project version
        ///The full path to the sonar-runner.properties file can also be supplied as a fourth parameter. If it is not supplied, the exe will attempt to locate the file on the path..
        /// </summary>
        internal static string ERROR_InvalidCommandLineArgs {
            get {
                return ResourceManager.GetString("ERROR_InvalidCommandLineArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified file does not exist: {0}.
        /// </summary>
        internal static string ERROR_InvalidRunnerPropertiesLocationSupplied {
            get {
                return ResourceManager.GetString("ERROR_InvalidRunnerPropertiesLocationSupplied", resourceCulture);
            }
        }
    }
}
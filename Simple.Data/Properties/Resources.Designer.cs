﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simple.Data.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Simple.Data.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to select fkcu.TABLE_SCHEMA, fkcu.TABLE_NAME, fkcu.COLUMN_NAME,
        ///pkcu.TABLE_SCHEMA AS UNIQUE_TABLE_SCHEMA, pkcu.TABLE_NAME AS UNIQUE_TABLE_NAME, pkcu.COLUMN_NAME AS UNIQUE_COLUMN_NAME
        ///FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS rc
        ///JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE fkcu ON rc.CONSTRAINT_NAME = fkcu.CONSTRAINT_NAME
        ///JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE pkcu ON rc.CONSTRAINT_NAME = pkcu.CONSTRAINT_NAME
        ///WHERE fkcu.ORDINAL_POSITION = pkcu.ORDINAL_POSITION.
        /// </summary>
        internal static string ForeignKeysSql {
            get {
                return ResourceManager.GetString("ForeignKeysSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select kcu.TABLE_SCHEMA, kcu.TABLE_NAME, kcu.CONSTRAINT_NAME, tc.CONSTRAINT_TYPE, kcu.COLUMN_NAME, kcu.ORDINAL_POSITION
        ///  from INFORMATION_SCHEMA.TABLE_CONSTRAINTS as tc
        ///  join INFORMATION_SCHEMA.KEY_COLUMN_USAGE as kcu
        ///    on kcu.CONSTRAINT_SCHEMA = tc.CONSTRAINT_SCHEMA
        ///   and kcu.CONSTRAINT_NAME = tc.CONSTRAINT_NAME
        ///   and kcu.TABLE_SCHEMA = tc.TABLE_SCHEMA
        ///   and kcu.TABLE_NAME = tc.TABLE_NAME
        /// where tc.CONSTRAINT_TYPE = &apos;PRIMARY KEY&apos;.
        /// </summary>
        internal static string PrimaryKeySql {
            get {
                return ResourceManager.GetString("PrimaryKeySql", resourceCulture);
            }
        }
    }
}
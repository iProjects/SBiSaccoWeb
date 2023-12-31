//====================================================================================================
// Base code generated with Inertia: BE Gen (Build 2.5.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 12/31/2014 17:26:24 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;


namespace SBiSaccoWeb.Entities
{
    /// <summary>
    /// Represents a row of User data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class User
    {
        /// <summary>
        /// Gets or sets a int value for the id column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the deleted column.
        /// </summary>
        [DataMember]
        public bool deleted { get; set; }

        /// <summary>
        /// Gets or sets a string value for the user_name column.
        /// </summary>
        [DataMember]
        public string user_name { get; set; }

        /// <summary>
        /// Gets or sets a string value for the user_pass column.
        /// </summary>
        [DataMember]
        public string user_pass { get; set; }

        /// <summary>
        /// Gets or sets a string value for the role_code column.
        /// </summary>
        [DataMember]
        public string role_code { get; set; }

        /// <summary>
        /// Gets or sets a string value for the first_name column.
        /// </summary>
        [DataMember]
        public string first_name { get; set; }

        /// <summary>
        /// Gets or sets a string value for the last_name column.
        /// </summary>
        [DataMember]
        public string last_name { get; set; }

        /// <summary>
        /// Gets or sets a string value for the mail column.
        /// </summary>
        [DataMember]
        public string mail { get; set; }

        /// <summary>
        /// Gets or sets a char value for the sex column.
        /// </summary>
        [DataMember]
        public char sex { get; set; }

        /// <summary>
        /// Gets or sets a string value for the phone column.
        /// </summary>
        [DataMember]
        public string phone { get; set; }
    }
}

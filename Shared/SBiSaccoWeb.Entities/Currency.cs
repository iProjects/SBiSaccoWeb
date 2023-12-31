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
    /// Represents a row of Currency data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class Currency
    {
        /// <summary>
        /// Gets or sets a int value for the id column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets a string value for the name column.
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the is_pivot column.
        /// </summary>
        [DataMember]
        public bool is_pivot { get; set; }

        /// <summary>
        /// Gets or sets a string value for the code column.
        /// </summary>
        [DataMember]
        public string code { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the is_swapped column.
        /// </summary>
        [DataMember]
        public bool is_swapped { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the use_cents column.
        /// </summary>
        [DataMember]
        public bool use_cents { get; set; }
    }
}

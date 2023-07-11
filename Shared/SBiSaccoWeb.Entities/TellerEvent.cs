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
    /// Represents a row of TellerEvent data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class TellerEvent
    {
        /// <summary>
        /// Gets or sets a int value for the id column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets a int value for the teller_id column.
        /// </summary>
        [DataMember]
        public int teller_id { get; set; }

        /// <summary>
        /// Gets or sets a string value for the event_code column.
        /// </summary>
        [DataMember]
        public string event_code { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the amount column.
        /// </summary>
        [DataMember]
        public decimal amount { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the date column.
        /// </summary>
        [DataMember]
        public DateTime date { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the is_exported column.
        /// </summary>
        [DataMember]
        public bool is_exported { get; set; }

        /// <summary>
        /// Gets or sets a string value for the description column.
        /// </summary>
        [DataMember]
        public string description { get; set; }

        /// <summary>
        /// Gets or sets a int value for the user_id column.
        /// </summary>
        [DataMember]
        public int user_id { get; set; }
    }
}
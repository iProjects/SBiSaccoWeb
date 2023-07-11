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
    /// Represents a row of Rep_Active_Loans_Data data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class Rep_Active_Loans_Data
    {
        /// <summary>
        /// Gets or sets a int value for the id column.
        /// </summary>
        [DataMember]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets a string value for the branch_name column.
        /// </summary>
        [DataMember]
        public string branch_name { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the load_date column.
        /// </summary>
        [DataMember]
        public DateTime load_date { get; set; }

        /// <summary>
        /// Gets or sets a string value for the break_down column.
        /// </summary>
        [DataMember]
        public string break_down { get; set; }

        /// <summary>
        /// Gets or sets a string value for the break_down_type column.
        /// </summary>
        [DataMember]
        public string break_down_type { get; set; }

        /// <summary>
        /// Gets or sets a int value for the contracts column.
        /// </summary>
        [DataMember]
        public int contracts { get; set; }

        /// <summary>
        /// Gets or sets a int value for the individual column.
        /// </summary>
        [DataMember]
        public int individual { get; set; }

        /// <summary>
        /// Gets or sets a int value for the group column.
        /// </summary>
        [DataMember]
        public int group { get; set; }

        /// <summary>
        /// Gets or sets a int value for the corporate column.
        /// </summary>
        [DataMember]
        public int corporate { get; set; }

        /// <summary>
        /// Gets or sets a int value for the clients column.
        /// </summary>
        [DataMember]
        public int clients { get; set; }

        /// <summary>
        /// Gets or sets a int value for the in_groups column.
        /// </summary>
        [DataMember]
        public int in_groups { get; set; }

        /// <summary>
        /// Gets or sets a int value for the projects column.
        /// </summary>
        [DataMember]
        public int projects { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the olb column.
        /// </summary>
        [DataMember]
        public decimal olb { get; set; }

        /// <summary>
        /// Gets or sets a int value for the break_down_id column.
        /// </summary>
        [DataMember]
        public int break_down_id { get; set; }
    }
}
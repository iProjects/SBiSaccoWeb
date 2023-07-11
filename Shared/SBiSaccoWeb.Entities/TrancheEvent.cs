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
    /// Represents a row of TrancheEvent data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class TrancheEvent
    {
        /// <summary>
        /// Gets or sets a int value for the id column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the amount column.
        /// </summary>
        [DataMember]
        public decimal amount { get; set; }

        /// <summary>
        /// Gets or sets a int value for the maturity column.
        /// </summary>
        [DataMember]
        public int maturity { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the start_date column.
        /// </summary>
        [DataMember]
        public DateTime start_date { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the interest_rate column.
        /// </summary>
        [DataMember]
        public decimal interest_rate { get; set; }

        /// <summary>
        /// Gets or sets a int value for the started_from_installment column.
        /// </summary>
        [DataMember]
        public int started_from_installment { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the applied_new_interest column.
        /// </summary>
        [DataMember]
        public bool applied_new_interest { get; set; }
    }
}

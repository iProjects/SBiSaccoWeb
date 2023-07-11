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
    /// Represents a row of CreditEntryFee data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class CreditEntryFee
    {
        /// <summary>
        /// Gets or sets a int value for the id column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets a int value for the credit_id column.
        /// </summary>
        [DataMember]
        public int credit_id { get; set; }

        /// <summary>
        /// Gets or sets a int value for the entry_fee_id column.
        /// </summary>
        [DataMember]
        public int entry_fee_id { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the fee_value column.
        /// </summary>
        [DataMember]
        public decimal fee_value { get; set; }
    }
}

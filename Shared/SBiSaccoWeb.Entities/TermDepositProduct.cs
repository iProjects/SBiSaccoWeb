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
    /// Represents a row of TermDepositProduct data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class TermDepositProduct
    {
        /// <summary>
        /// Gets or sets a int value for the id column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets a int value for the installment_types_id column.
        /// </summary>
        [DataMember]
        public int installment_types_id { get; set; }

        /// <summary>
        /// Gets or sets a int value for the number_period column.
        /// </summary>
        [DataMember]
        public int number_period { get; set; }

        /// <summary>
        /// Gets or sets a int value for the number_period_min column.
        /// </summary>
        [DataMember]
        public int number_period_min { get; set; }

        /// <summary>
        /// Gets or sets a int value for the number_period_max column.
        /// </summary>
        [DataMember]
        public int number_period_max { get; set; }

        /// <summary>
        /// Gets or sets a short value for the interest_frequency column.
        /// </summary>
        [DataMember]
        public short interest_frequency { get; set; }

        /// <summary>
        /// Gets or sets a short value for the withdrawal_fees_type column.
        /// </summary>
        [DataMember]
        public short withdrawal_fees_type { get; set; }

        /// <summary>
        /// Gets or sets a double value for the withdrawal_fees_min column.
        /// </summary>
        [DataMember]
        public double withdrawal_fees_min { get; set; }

        /// <summary>
        /// Gets or sets a double value for the withdrawal_fees_max column.
        /// </summary>
        [DataMember]
        public double withdrawal_fees_max { get; set; }

        /// <summary>
        /// Gets or sets a double value for the withdrawal_fees column.
        /// </summary>
        [DataMember]
        public double withdrawal_fees { get; set; }
    }
}
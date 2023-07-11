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
    /// Represents a row of SavingDepositContract data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class SavingDepositContract
    {
        /// <summary>
        /// Gets or sets a int value for the id column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets a int value for the number_periods column.
        /// </summary>
        [DataMember]
        public int number_periods { get; set; }

        /// <summary>
        /// Gets or sets a short value for the rollover column.
        /// </summary>
        [DataMember]
        public short rollover { get; set; }

        /// <summary>
        /// Gets or sets a string value for the transfer_account column.
        /// </summary>
        [DataMember]
        public string transfer_account { get; set; }

        /// <summary>
        /// Gets or sets a double value for the withdrawal_fees column.
        /// </summary>
        [DataMember]
        public double withdrawal_fees { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the next_maturity column.
        /// </summary>
        [DataMember]
        public DateTime next_maturity { get; set; }
    }
}
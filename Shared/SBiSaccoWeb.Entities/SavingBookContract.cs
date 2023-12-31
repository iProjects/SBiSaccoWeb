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
    /// Represents a row of SavingBookContract data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class SavingBookContract
    {
        /// <summary>
        /// Gets or sets a int value for the id column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the flat_withdraw_fees column.
        /// </summary>
        [DataMember]
        public decimal flat_withdraw_fees { get; set; }

        /// <summary>
        /// Gets or sets a double value for the rate_withdraw_fees column.
        /// </summary>
        [DataMember]
        public double rate_withdraw_fees { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the flat_transfer_fees column.
        /// </summary>
        [DataMember]
        public decimal flat_transfer_fees { get; set; }

        /// <summary>
        /// Gets or sets a double value for the rate_transfer_fees column.
        /// </summary>
        [DataMember]
        public double rate_transfer_fees { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the flat_deposit_fees column.
        /// </summary>
        [DataMember]
        public decimal flat_deposit_fees { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the flat_close_fees column.
        /// </summary>
        [DataMember]
        public decimal flat_close_fees { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the flat_management_fees column.
        /// </summary>
        [DataMember]
        public decimal flat_management_fees { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the flat_overdraft_fees column.
        /// </summary>
        [DataMember]
        public decimal flat_overdraft_fees { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the in_overdraft column.
        /// </summary>
        [DataMember]
        public bool in_overdraft { get; set; }

        /// <summary>
        /// Gets or sets a double value for the rate_agio_fees column.
        /// </summary>
        [DataMember]
        public double rate_agio_fees { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the cheque_deposit_fees column.
        /// </summary>
        [DataMember]
        public decimal cheque_deposit_fees { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the flat_reopen_fees column.
        /// </summary>
        [DataMember]
        public decimal flat_reopen_fees { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the flat_ibt_fee column.
        /// </summary>
        [DataMember]
        public decimal flat_ibt_fee { get; set; }

        /// <summary>
        /// Gets or sets a double value for the rate_ibt_fee column.
        /// </summary>
        [DataMember]
        public double rate_ibt_fee { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the use_term_deposit column.
        /// </summary>
        [DataMember]
        public bool use_term_deposit { get; set; }

        /// <summary>
        /// Gets or sets a int value for the term_deposit_period column.
        /// </summary>
        [DataMember]
        public int term_deposit_period { get; set; }

        /// <summary>
        /// Gets or sets a int value for the term_deposit_period_min column.
        /// </summary>
        [DataMember]
        public int term_deposit_period_min { get; set; }

        /// <summary>
        /// Gets or sets a int value for the term_deposit_period_max column.
        /// </summary>
        [DataMember]
        public int term_deposit_period_max { get; set; }

        /// <summary>
        /// Gets or sets a string value for the transfer_account column.
        /// </summary>
        [DataMember]
        public string transfer_account { get; set; }

        /// <summary>
        /// Gets or sets a int value for the rollover column.
        /// </summary>
        [DataMember]
        public int rollover { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the next_maturity column.
        /// </summary>
        [DataMember]
        public DateTime next_maturity { get; set; }
    }
}

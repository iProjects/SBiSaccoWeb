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
    /// Represents a row of Package data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class Package
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
        /// Gets or sets a string value for the code column.
        /// </summary>
        [DataMember]
        public string code { get; set; }

        /// <summary>
        /// Gets or sets a string value for the name column.
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        /// Gets or sets a char value for the client_type column.
        /// </summary>
        [DataMember]
        public char client_type { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the amount column.
        /// </summary>
        [DataMember]
        public decimal amount { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the amount_min column.
        /// </summary>
        [DataMember]
        public decimal amount_min { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the amount_max column.
        /// </summary>
        [DataMember]
        public decimal amount_max { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the interest_rate column.
        /// </summary>
        [DataMember]
        public decimal interest_rate { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the interest_rate_min column.
        /// </summary>
        [DataMember]
        public decimal interest_rate_min { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the interest_rate_max column.
        /// </summary>
        [DataMember]
        public decimal interest_rate_max { get; set; }

        /// <summary>
        /// Gets or sets a int value for the installment_type column.
        /// </summary>
        [DataMember]
        public int installment_type { get; set; }

        /// <summary>
        /// Gets or sets a int value for the grace_period column.
        /// </summary>
        [DataMember]
        public int grace_period { get; set; }

        /// <summary>
        /// Gets or sets a int value for the grace_period_min column.
        /// </summary>
        [DataMember]
        public int grace_period_min { get; set; }

        /// <summary>
        /// Gets or sets a int value for the grace_period_max column.
        /// </summary>
        [DataMember]
        public int grace_period_max { get; set; }

        /// <summary>
        /// Gets or sets a int value for the number_of_installments column.
        /// </summary>
        [DataMember]
        public int number_of_installments { get; set; }

        /// <summary>
        /// Gets or sets a int value for the number_of_installments_min column.
        /// </summary>
        [DataMember]
        public int number_of_installments_min { get; set; }

        /// <summary>
        /// Gets or sets a int value for the number_of_installments_max column.
        /// </summary>
        [DataMember]
        public int number_of_installments_max { get; set; }

        /// <summary>
        /// Gets or sets a double value for the anticipated_total_repayment_penalties column.
        /// </summary>
        [DataMember]
        public double anticipated_total_repayment_penalties { get; set; }

        /// <summary>
        /// Gets or sets a double value for the anticipated_total_repayment_penalties_min column.
        /// </summary>
        [DataMember]
        public double anticipated_total_repayment_penalties_min { get; set; }

        /// <summary>
        /// Gets or sets a double value for the anticipated_total_repayment_penalties_max column.
        /// </summary>
        [DataMember]
        public double anticipated_total_repayment_penalties_max { get; set; }

        /// <summary>
        /// Gets or sets a short value for the loan_type column.
        /// </summary>
        [DataMember]
        public short loan_type { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the keep_expected_installment column.
        /// </summary>
        [DataMember]
        public bool keep_expected_installment { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the charge_interest_within_grace_period column.
        /// </summary>
        [DataMember]
        public bool charge_interest_within_grace_period { get; set; }

        /// <summary>
        /// Gets or sets a int value for the cycle_id column.
        /// </summary>
        [DataMember]
        public int cycle_id { get; set; }

        /// <summary>
        /// Gets or sets a double value for the non_repayment_penalties_based_on_overdue_interest column.
        /// </summary>
        [DataMember]
        public double non_repayment_penalties_based_on_overdue_interest { get; set; }

        /// <summary>
        /// Gets or sets a double value for the non_repayment_penalties_based_on_initial_amount column.
        /// </summary>
        [DataMember]
        public double non_repayment_penalties_based_on_initial_amount { get; set; }

        /// <summary>
        /// Gets or sets a double value for the non_repayment_penalties_based_on_olb column.
        /// </summary>
        [DataMember]
        public double non_repayment_penalties_based_on_olb { get; set; }

        /// <summary>
        /// Gets or sets a double value for the non_repayment_penalties_based_on_overdue_principal column.
        /// </summary>
        [DataMember]
        public double non_repayment_penalties_based_on_overdue_principal { get; set; }

        /// <summary>
        /// Gets or sets a double value for the non_repayment_penalties_based_on_overdue_interest_min column.
        /// </summary>
        [DataMember]
        public double non_repayment_penalties_based_on_overdue_interest_min { get; set; }

        /// <summary>
        /// Gets or sets a double value for the non_repayment_penalties_based_on_initial_amount_min column.
        /// </summary>
        [DataMember]
        public double non_repayment_penalties_based_on_initial_amount_min { get; set; }

        /// <summary>
        /// Gets or sets a double value for the non_repayment_penalties_based_on_olb_min column.
        /// </summary>
        [DataMember]
        public double non_repayment_penalties_based_on_olb_min { get; set; }

        /// <summary>
        /// Gets or sets a double value for the non_repayment_penalties_based_on_overdue_principal_min column.
        /// </summary>
        [DataMember]
        public double non_repayment_penalties_based_on_overdue_principal_min { get; set; }

        /// <summary>
        /// Gets or sets a double value for the non_repayment_penalties_based_on_overdue_interest_max column.
        /// </summary>
        [DataMember]
        public double non_repayment_penalties_based_on_overdue_interest_max { get; set; }

        /// <summary>
        /// Gets or sets a double value for the non_repayment_penalties_based_on_initial_amount_max column.
        /// </summary>
        [DataMember]
        public double non_repayment_penalties_based_on_initial_amount_max { get; set; }

        /// <summary>
        /// Gets or sets a double value for the non_repayment_penalties_based_on_olb_max column.
        /// </summary>
        [DataMember]
        public double non_repayment_penalties_based_on_olb_max { get; set; }

        /// <summary>
        /// Gets or sets a double value for the non_repayment_penalties_based_on_overdue_principal_max column.
        /// </summary>
        [DataMember]
        public double non_repayment_penalties_based_on_overdue_principal_max { get; set; }

        /// <summary>
        /// Gets or sets a int value for the fundingLine_id column.
        /// </summary>
        [DataMember]
        public int fundingLine_id { get; set; }

        /// <summary>
        /// Gets or sets a int value for the currency_id column.
        /// </summary>
        [DataMember]
        public int currency_id { get; set; }

        /// <summary>
        /// Gets or sets a short value for the rounding_type column.
        /// </summary>
        [DataMember]
        public short rounding_type { get; set; }

        /// <summary>
        /// Gets or sets a int value for the grace_period_of_latefees column.
        /// </summary>
        [DataMember]
        public int grace_period_of_latefees { get; set; }

        /// <summary>
        /// Gets or sets a double value for the anticipated_partial_repayment_penalties column.
        /// </summary>
        [DataMember]
        public double anticipated_partial_repayment_penalties { get; set; }

        /// <summary>
        /// Gets or sets a double value for the anticipated_partial_repayment_penalties_min column.
        /// </summary>
        [DataMember]
        public double anticipated_partial_repayment_penalties_min { get; set; }

        /// <summary>
        /// Gets or sets a double value for the anticipated_partial_repayment_penalties_max column.
        /// </summary>
        [DataMember]
        public double anticipated_partial_repayment_penalties_max { get; set; }

        /// <summary>
        /// Gets or sets a short value for the anticipated_partial_repayment_base column.
        /// </summary>
        [DataMember]
        public short anticipated_partial_repayment_base { get; set; }

        /// <summary>
        /// Gets or sets a short value for the anticipated_total_repayment_base column.
        /// </summary>
        [DataMember]
        public short anticipated_total_repayment_base { get; set; }

        /// <summary>
        /// Gets or sets a int value for the number_of_drawings_loc column.
        /// </summary>
        [DataMember]
        public int number_of_drawings_loc { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the amount_under_loc column.
        /// </summary>
        [DataMember]
        public decimal amount_under_loc { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the amount_under_loc_min column.
        /// </summary>
        [DataMember]
        public decimal amount_under_loc_min { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the amount_under_loc_max column.
        /// </summary>
        [DataMember]
        public decimal amount_under_loc_max { get; set; }

        /// <summary>
        /// Gets or sets a int value for the maturity_loc column.
        /// </summary>
        [DataMember]
        public int maturity_loc { get; set; }

        /// <summary>
        /// Gets or sets a int value for the maturity_loc_min column.
        /// </summary>
        [DataMember]
        public int maturity_loc_min { get; set; }

        /// <summary>
        /// Gets or sets a int value for the maturity_loc_max column.
        /// </summary>
        [DataMember]
        public int maturity_loc_max { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the activated_loc column.
        /// </summary>
        [DataMember]
        public bool activated_loc { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the allow_flexible_schedule column.
        /// </summary>
        [DataMember]
        public bool allow_flexible_schedule { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the use_guarantor_collateral column.
        /// </summary>
        [DataMember]
        public bool use_guarantor_collateral { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the set_separate_guarantor_collateral column.
        /// </summary>
        [DataMember]
        public bool set_separate_guarantor_collateral { get; set; }

        /// <summary>
        /// Gets or sets a int value for the percentage_total_guarantor_collateral column.
        /// </summary>
        [DataMember]
        public int percentage_total_guarantor_collateral { get; set; }

        /// <summary>
        /// Gets or sets a int value for the percentage_separate_guarantor column.
        /// </summary>
        [DataMember]
        public int percentage_separate_guarantor { get; set; }

        /// <summary>
        /// Gets or sets a int value for the percentage_separate_collateral column.
        /// </summary>
        [DataMember]
        public int percentage_separate_collateral { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the use_compulsory_savings column.
        /// </summary>
        [DataMember]
        public bool use_compulsory_savings { get; set; }

        /// <summary>
        /// Gets or sets a int value for the compulsory_amount column.
        /// </summary>
        [DataMember]
        public int compulsory_amount { get; set; }

        /// <summary>
        /// Gets or sets a int value for the compulsory_amount_min column.
        /// </summary>
        [DataMember]
        public int compulsory_amount_min { get; set; }

        /// <summary>
        /// Gets or sets a int value for the compulsory_amount_max column.
        /// </summary>
        [DataMember]
        public int compulsory_amount_max { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the insurance_min column.
        /// </summary>
        [DataMember]
        public decimal insurance_min { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the insurance_max column.
        /// </summary>
        [DataMember]
        public decimal insurance_max { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the use_entry_fees_cycles column.
        /// </summary>
        [DataMember]
        public bool use_entry_fees_cycles { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the is_balloon column.
        /// </summary>
        [DataMember]
        public bool is_balloon { get; set; }
    }
}
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
    /// Represents a row of Tier data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class Tier
    {
        /// <summary>
        /// Gets or sets a int value for the id column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets a char value for the client_type_code column.
        /// </summary>
        [DataMember]
        public char client_type_code { get; set; }

        /// <summary>
        /// Gets or sets a double value for the scoring column.
        /// </summary>
        [DataMember]
        public double scoring { get; set; }

        /// <summary>
        /// Gets or sets a int value for the loan_cycle column.
        /// </summary>
        [DataMember]
        public int loan_cycle { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the active column.
        /// </summary>
        [DataMember]
        public bool active { get; set; }

        /// <summary>
        /// Gets or sets a string value for the other_org_name column.
        /// </summary>
        [DataMember]
        public string other_org_name { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the other_org_amount column.
        /// </summary>
        [DataMember]
        public decimal other_org_amount { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the other_org_debts column.
        /// </summary>
        [DataMember]
        public decimal other_org_debts { get; set; }

        /// <summary>
        /// Gets or sets a int value for the district_id column.
        /// </summary>
        [DataMember]
        public int district_id { get; set; }

        /// <summary>
        /// Gets or sets a string value for the city column.
        /// </summary>
        [DataMember]
        public string city { get; set; }

        /// <summary>
        /// Gets or sets a string value for the address column.
        /// </summary>
        [DataMember]
        public string address { get; set; }

        /// <summary>
        /// Gets or sets a int value for the secondary_district_id column.
        /// </summary>
        [DataMember]
        public int secondary_district_id { get; set; }

        /// <summary>
        /// Gets or sets a string value for the secondary_city column.
        /// </summary>
        [DataMember]
        public string secondary_city { get; set; }

        /// <summary>
        /// Gets or sets a string value for the secondary_address column.
        /// </summary>
        [DataMember]
        public string secondary_address { get; set; }

        /// <summary>
        /// Gets or sets a int value for the cash_input_voucher_number column.
        /// </summary>
        [DataMember]
        public int cash_input_voucher_number { get; set; }

        /// <summary>
        /// Gets or sets a int value for the cash_output_voucher_number column.
        /// </summary>
        [DataMember]
        public int cash_output_voucher_number { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the creation_date column.
        /// </summary>
        [DataMember]
        public DateTime creation_date { get; set; }

        /// <summary>
        /// Gets or sets a string value for the home_phone column.
        /// </summary>
        [DataMember]
        public string home_phone { get; set; }

        /// <summary>
        /// Gets or sets a string value for the personal_phone column.
        /// </summary>
        [DataMember]
        public string personal_phone { get; set; }

        /// <summary>
        /// Gets or sets a string value for the secondary_home_phone column.
        /// </summary>
        [DataMember]
        public string secondary_home_phone { get; set; }

        /// <summary>
        /// Gets or sets a string value for the secondary_personal_phone column.
        /// </summary>
        [DataMember]
        public string secondary_personal_phone { get; set; }

        /// <summary>
        /// Gets or sets a string value for the e_mail column.
        /// </summary>
        [DataMember]
        public string e_mail { get; set; }

        /// <summary>
        /// Gets or sets a string value for the secondary_e_mail column.
        /// </summary>
        [DataMember]
        public string secondary_e_mail { get; set; }

        /// <summary>
        /// Gets or sets a short value for the status column.
        /// </summary>
        [DataMember]
        public short status { get; set; }

        /// <summary>
        /// Gets or sets a string value for the other_org_comment column.
        /// </summary>
        [DataMember]
        public string other_org_comment { get; set; }

        /// <summary>
        /// Gets or sets a string value for the sponsor1 column.
        /// </summary>
        [DataMember]
        public string sponsor1 { get; set; }

        /// <summary>
        /// Gets or sets a string value for the sponsor1_comment column.
        /// </summary>
        [DataMember]
        public string sponsor1_comment { get; set; }

        /// <summary>
        /// Gets or sets a string value for the sponsor2 column.
        /// </summary>
        [DataMember]
        public string sponsor2 { get; set; }

        /// <summary>
        /// Gets or sets a string value for the sponsor2_comment column.
        /// </summary>
        [DataMember]
        public string sponsor2_comment { get; set; }

        /// <summary>
        /// Gets or sets a string value for the follow_up_comment column.
        /// </summary>
        [DataMember]
        public string follow_up_comment { get; set; }

        /// <summary>
        /// Gets or sets a string value for the home_type column.
        /// </summary>
        [DataMember]
        public string home_type { get; set; }

        /// <summary>
        /// Gets or sets a string value for the secondary_homeType column.
        /// </summary>
        [DataMember]
        public string secondary_homeType { get; set; }

        /// <summary>
        /// Gets or sets a string value for the zipCode column.
        /// </summary>
        [DataMember]
        public string zipCode { get; set; }

        /// <summary>
        /// Gets or sets a string value for the secondary_zipCode column.
        /// </summary>
        [DataMember]
        public string secondary_zipCode { get; set; }

        /// <summary>
        /// Gets or sets a int value for the branch_id column.
        /// </summary>
        [DataMember]
        public int branch_id { get; set; }
    }
}

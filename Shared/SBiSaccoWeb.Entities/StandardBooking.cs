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
    /// Represents a row of StandardBooking data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class StandardBooking
    {
        /// <summary>
        /// Gets or sets a int value for the Id column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Name column.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a int value for the debit_account_id column.
        /// </summary>
        [DataMember]
        public int debit_account_id { get; set; }

        /// <summary>
        /// Gets or sets a int value for the credit_account_id column.
        /// </summary>
        [DataMember]
        public int credit_account_id { get; set; }
    }
}
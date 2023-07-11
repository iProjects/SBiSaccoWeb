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
    /// Represents a row of Corporate data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class Corporate
    {
        /// <summary>
        /// Gets or sets a int value for the id column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets a string value for the name column.
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the deleted column.
        /// </summary>
        [DataMember]
        public bool deleted { get; set; }

        /// <summary>
        /// Gets or sets a string value for the sigle column.
        /// </summary>
        [DataMember]
        public string sigle { get; set; }

        /// <summary>
        /// Gets or sets a string value for the small_name column.
        /// </summary>
        [DataMember]
        public string small_name { get; set; }

        /// <summary>
        /// Gets or sets a int value for the volunteer_count column.
        /// </summary>
        [DataMember]
        public int volunteer_count { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the agrement_date column.
        /// </summary>
        [DataMember]
        public DateTime agrement_date { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the agrement_solidarity column.
        /// </summary>
        [DataMember]
        public bool agrement_solidarity { get; set; }

        /// <summary>
        /// Gets or sets a int value for the employee_count column.
        /// </summary>
        [DataMember]
        public int employee_count { get; set; }

        /// <summary>
        /// Gets or sets a string value for the siret column.
        /// </summary>
        [DataMember]
        public string siret { get; set; }

        /// <summary>
        /// Gets or sets a int value for the activity_id column.
        /// </summary>
        [DataMember]
        public int activity_id { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the date_create column.
        /// </summary>
        [DataMember]
        public DateTime date_create { get; set; }

        /// <summary>
        /// Gets or sets a string value for the fiscal_status column.
        /// </summary>
        [DataMember]
        public string fiscal_status { get; set; }

        /// <summary>
        /// Gets or sets a string value for the registre column.
        /// </summary>
        [DataMember]
        public string registre { get; set; }

        /// <summary>
        /// Gets or sets a string value for the legalForm column.
        /// </summary>
        [DataMember]
        public string legalForm { get; set; }

        /// <summary>
        /// Gets or sets a string value for the insertionType column.
        /// </summary>
        [DataMember]
        public string insertionType { get; set; }

        /// <summary>
        /// Gets or sets a int value for the loan_officer_id column.
        /// </summary>
        [DataMember]
        public int loan_officer_id { get; set; }
    }
}
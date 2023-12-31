//====================================================================================================
// Base code generated with Motion: BC Gen (Build 2.2.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 06/12/2014 11:45:03 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SBiSaccoWeb.Entities;
using SBiSaccoWeb.Data;


namespace SBiSaccoWeb.Business
{
    /// <summary>
    /// SolidarityGroups business component.
    /// </summary>
    public partial class SolidarityGroupsComponent
    {
        /// <summary>
        /// GetAllSolidarityGroups business method. 
        /// </summary>
        /// <returns>Returns a List<Group> object.</returns>
        public List<Group> GetAllSolidarityGroups()
        {
            List<Group> result = default(List<Group>);

            // Data access component declarations.
            GroupDAC groupDAC = new GroupDAC();

            // Step 1 - Calling Select on GroupDAC.
            result = groupDAC.Select();
            return result;

        }

        /// <summary>
        /// GetSolidarityGroup business method. 
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>Returns a Group object.</returns>
        public Group GetSolidarityGroup(int id)
        {
            Group result = default(Group);

            // Data access component declarations.
            GroupDAC groupDAC = new GroupDAC();

            // Step 1 - Calling SelectById on GroupDAC.
            result = groupDAC.SelectById(id);
            return result;

        }

        /// <summary>
        /// CreateSolidarityGroup business method. 
        /// </summary>
        /// <param name="group">A group value.</param>
        /// <returns>Returns a Group object.</returns>
        public Group CreateSolidarityGroup(Group group)
        {
            Group result = default(Group);

            // Data access component declarations.
            GroupDAC groupDAC = new GroupDAC();

            // Step 1 - Calling Create on GroupDAC.
            result = groupDAC.Create(group);
            return result;

        }

        /// <summary>
        /// UpdateSolidarityGroup business method. 
        /// </summary>
        /// <param name="group">A group value.</param>
        public void UpdateSolidarityGroup(Group group)
        {
            // Data access component declarations.
            GroupDAC groupDAC = new GroupDAC();

            // Step 1 - Calling UpdateById on GroupDAC.
            groupDAC.UpdateById(group);

        }

        /// <summary>
        /// DeleteSolidarityGroup business method. 
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteSolidarityGroup(int id)
        {
            // Data access component declarations.
            GroupDAC groupDAC = new GroupDAC();

            // Step 1 - Calling DeleteById on GroupDAC.
            groupDAC.DeleteById(id);

        }
    }
}

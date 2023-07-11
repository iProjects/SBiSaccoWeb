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
    /// FundingLines business component.
    /// </summary>
    public partial class FundingLinesComponent
    {
        /// <summary>
        /// GetAllFundingLines business method. 
        /// </summary>
        /// <returns>Returns a List<FundingLine> object.</returns>
        public List<FundingLine> GetAllFundingLines()
        {
            List<FundingLine> result = default(List<FundingLine>);

            // Data access component declarations.
            FundingLineDAC fundingLineDAC = new FundingLineDAC();

            // Step 1 - Calling Select on FundingLineDAC.
            result = fundingLineDAC.Select();
            return result;

        }

        /// <summary>
        /// GetFundingLine business method. 
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>Returns a FundingLine object.</returns>
        public FundingLine GetFundingLine(int id)
        {
            FundingLine result = default(FundingLine);

            // Data access component declarations.
            FundingLineDAC fundingLineDAC = new FundingLineDAC();

            // Step 1 - Calling SelectById on FundingLineDAC.
            result = fundingLineDAC.SelectById(id);
            return result;

        }

        /// <summary>
        /// CreateFundingLine business method. 
        /// </summary>
        /// <param name="fundingLine">A fundingLine value.</param>
        /// <returns>Returns a FundingLine object.</returns>
        public FundingLine CreateFundingLine(FundingLine fundingLine)
        {
            FundingLine result = default(FundingLine);

            // Data access component declarations.
            FundingLineDAC fundingLineDAC = new FundingLineDAC();

            // Step 1 - Calling Create on FundingLineDAC.
            result = fundingLineDAC.Create(fundingLine);
            return result;

        }

        /// <summary>
        /// UpdateFundingLine business method. 
        /// </summary>
        /// <param name="fundingLine">A fundingLine value.</param>
        public void UpdateFundingLine(FundingLine fundingLine)
        {
            // Data access component declarations.
            FundingLineDAC fundingLineDAC = new FundingLineDAC();

            // Step 1 - Calling UpdateById on FundingLineDAC.
            fundingLineDAC.UpdateById(fundingLine);

        }

        /// <summary>
        /// DeleteFundingLine business method. 
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteFundingLine(int id)
        {
            // Data access component declarations.
            FundingLineDAC fundingLineDAC = new FundingLineDAC();

            // Step 1 - Calling DeleteById on FundingLineDAC.
            fundingLineDAC.DeleteById(id);

        }
    }
}
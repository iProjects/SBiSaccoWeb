//====================================================================================================
// Base code generated with Momentum: DAC Gen (Build 2.5.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 12/31/2014 17:44:45 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using SBiSaccoWeb.Entities;

namespace SBiSaccoWeb.Data
{
    /// <summary>
    /// Rep_OLB_and_LLP_Data data access component. Manages CRUD operations for the Rep_OLB_and_LLP_Data table.
    /// </summary>
    public partial class Rep_OLB_and_LLP_DataDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Rep_OLB_and_LLP_Data table.
        /// </summary>
        /// <param name="rep_OLB_and_LLP_Data">A Rep_OLB_and_LLP_Data object.</param>
        /// <returns>An updated Rep_OLB_and_LLP_Data object.</returns>
        public Rep_OLB_and_LLP_Data Create(Rep_OLB_and_LLP_Data rep_OLB_and_LLP_Data)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Rep_OLB_and_LLP_Data ([id], [branch_name], [load_date], [contract_code], [olb], [interest], [late_days], [client_name], [loan_officer_name], [product_name], [district_name], [start_date], [close_date], [range_from], [range_to], [llp_rate], [llp], [rescheduled]) " +
                "VALUES(@id, @branch_name, @load_date, @contract_code, @olb, @interest, @late_days, @client_name, @loan_officer_name, @product_name, @district_name, @start_date, @close_date, @range_from, @range_to, @llp_rate, @llp, @rescheduled);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@id", DbType.Int32, rep_OLB_and_LLP_Data.id);
                db.AddInParameter(cmd, "@branch_name", DbType.String, rep_OLB_and_LLP_Data.branch_name);
                db.AddInParameter(cmd, "@load_date", DbType.DateTime, rep_OLB_and_LLP_Data.load_date);
                db.AddInParameter(cmd, "@contract_code", DbType.String, rep_OLB_and_LLP_Data.contract_code);
                db.AddInParameter(cmd, "@olb", DbType.Currency, rep_OLB_and_LLP_Data.olb);
                db.AddInParameter(cmd, "@interest", DbType.Currency, rep_OLB_and_LLP_Data.interest);
                db.AddInParameter(cmd, "@late_days", DbType.Int32, rep_OLB_and_LLP_Data.late_days);
                db.AddInParameter(cmd, "@client_name", DbType.String, rep_OLB_and_LLP_Data.client_name);
                db.AddInParameter(cmd, "@loan_officer_name", DbType.String, rep_OLB_and_LLP_Data.loan_officer_name);
                db.AddInParameter(cmd, "@product_name", DbType.String, rep_OLB_and_LLP_Data.product_name);
                db.AddInParameter(cmd, "@district_name", DbType.String, rep_OLB_and_LLP_Data.district_name);
                db.AddInParameter(cmd, "@start_date", DbType.DateTime, rep_OLB_and_LLP_Data.start_date);
                db.AddInParameter(cmd, "@close_date", DbType.DateTime, rep_OLB_and_LLP_Data.close_date);
                db.AddInParameter(cmd, "@range_from", DbType.Int32, rep_OLB_and_LLP_Data.range_from);
                db.AddInParameter(cmd, "@range_to", DbType.Int32, rep_OLB_and_LLP_Data.range_to);
                db.AddInParameter(cmd, "@llp_rate", DbType.Int32, rep_OLB_and_LLP_Data.llp_rate);
                db.AddInParameter(cmd, "@llp", DbType.Currency, rep_OLB_and_LLP_Data.llp);
                db.AddInParameter(cmd, "@rescheduled", DbType.Boolean, rep_OLB_and_LLP_Data.rescheduled);

                db.ExecuteNonQuery(cmd);
            }

            return rep_OLB_and_LLP_Data;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Rep_OLB_and_LLP_Data table.
        /// </summary>
        /// <returns>A collection of Rep_OLB_and_LLP_Data objects.</returns>		
        public List<Rep_OLB_and_LLP_Data> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [branch_name], [load_date], [contract_code], [olb], [interest], [late_days]" +
                        ", [client_name], [loan_officer_name], [product_name], [district_name], [start_date]" +
                        ", [close_date], [range_from], [range_to], [llp_rate], [llp], [rescheduled] " +
                "FROM dbo.Rep_OLB_and_LLP_Data ";

            List<Rep_OLB_and_LLP_Data> result = new List<Rep_OLB_and_LLP_Data>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Rep_OLB_and_LLP_Data
                        Rep_OLB_and_LLP_Data rep_OLB_and_LLP_Data = new Rep_OLB_and_LLP_Data();

                        // Read values.
                        rep_OLB_and_LLP_Data.id = base.GetDataValue<int>(dr, "id");
                        rep_OLB_and_LLP_Data.branch_name = base.GetDataValue<string>(dr, "branch_name");
                        rep_OLB_and_LLP_Data.load_date = base.GetDataValue<DateTime>(dr, "load_date");
                        rep_OLB_and_LLP_Data.contract_code = base.GetDataValue<string>(dr, "contract_code");
                        rep_OLB_and_LLP_Data.olb = base.GetDataValue<decimal>(dr, "olb");
                        rep_OLB_and_LLP_Data.interest = base.GetDataValue<decimal>(dr, "interest");
                        rep_OLB_and_LLP_Data.late_days = base.GetDataValue<int>(dr, "late_days");
                        rep_OLB_and_LLP_Data.client_name = base.GetDataValue<string>(dr, "client_name");
                        rep_OLB_and_LLP_Data.loan_officer_name = base.GetDataValue<string>(dr, "loan_officer_name");
                        rep_OLB_and_LLP_Data.product_name = base.GetDataValue<string>(dr, "product_name");
                        rep_OLB_and_LLP_Data.district_name = base.GetDataValue<string>(dr, "district_name");
                        rep_OLB_and_LLP_Data.start_date = base.GetDataValue<DateTime>(dr, "start_date");
                        rep_OLB_and_LLP_Data.close_date = base.GetDataValue<DateTime>(dr, "close_date");
                        rep_OLB_and_LLP_Data.range_from = base.GetDataValue<int>(dr, "range_from");
                        rep_OLB_and_LLP_Data.range_to = base.GetDataValue<int>(dr, "range_to");
                        rep_OLB_and_LLP_Data.llp_rate = base.GetDataValue<int>(dr, "llp_rate");
                        rep_OLB_and_LLP_Data.llp = base.GetDataValue<decimal>(dr, "llp");
                        rep_OLB_and_LLP_Data.rescheduled = base.GetDataValue<bool>(dr, "rescheduled");

                        // Add to List.
                        result.Add(rep_OLB_and_LLP_Data);
                    }
                }
            }

            return result;
        }
    }
}


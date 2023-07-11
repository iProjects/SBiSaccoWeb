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
    /// Rep_Disbursements_Data data access component. Manages CRUD operations for the Rep_Disbursements_Data table.
    /// </summary>
    public partial class Rep_Disbursements_DataDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Rep_Disbursements_Data table.
        /// </summary>
        /// <param name="rep_Disbursements_Data">A Rep_Disbursements_Data object.</param>
        /// <returns>An updated Rep_Disbursements_Data object.</returns>
        public Rep_Disbursements_Data Create(Rep_Disbursements_Data rep_Disbursements_Data)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Rep_Disbursements_Data ([id], [branch_name], [load_date], [contract_code], [district], [loan_product], [client_name], [loan_cycle], [loan_officer], [disbursement_date], [amount], [interest], [fees]) " +
                "VALUES(@id, @branch_name, @load_date, @contract_code, @district, @loan_product, @client_name, @loan_cycle, @loan_officer, @disbursement_date, @amount, @interest, @fees);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@id", DbType.Int32, rep_Disbursements_Data.id);
                db.AddInParameter(cmd, "@branch_name", DbType.String, rep_Disbursements_Data.branch_name);
                db.AddInParameter(cmd, "@load_date", DbType.DateTime, rep_Disbursements_Data.load_date);
                db.AddInParameter(cmd, "@contract_code", DbType.String, rep_Disbursements_Data.contract_code);
                db.AddInParameter(cmd, "@district", DbType.String, rep_Disbursements_Data.district);
                db.AddInParameter(cmd, "@loan_product", DbType.String, rep_Disbursements_Data.loan_product);
                db.AddInParameter(cmd, "@client_name", DbType.String, rep_Disbursements_Data.client_name);
                db.AddInParameter(cmd, "@loan_cycle", DbType.Int32, rep_Disbursements_Data.loan_cycle);
                db.AddInParameter(cmd, "@loan_officer", DbType.String, rep_Disbursements_Data.loan_officer);
                db.AddInParameter(cmd, "@disbursement_date", DbType.DateTime, rep_Disbursements_Data.disbursement_date);
                db.AddInParameter(cmd, "@amount", DbType.Currency, rep_Disbursements_Data.amount);
                db.AddInParameter(cmd, "@interest", DbType.Currency, rep_Disbursements_Data.interest);
                db.AddInParameter(cmd, "@fees", DbType.Currency, rep_Disbursements_Data.fees);

                db.ExecuteNonQuery(cmd);
            }

            return rep_Disbursements_Data;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Rep_Disbursements_Data table.
        /// </summary>
        /// <returns>A collection of Rep_Disbursements_Data objects.</returns>		
        public List<Rep_Disbursements_Data> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [branch_name], [load_date], [contract_code], [district], [loan_product], [client_name]" +
                        ", [loan_cycle], [loan_officer], [disbursement_date], [amount], [interest], [fees]" +
                        " " +
                "FROM dbo.Rep_Disbursements_Data ";

            List<Rep_Disbursements_Data> result = new List<Rep_Disbursements_Data>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Rep_Disbursements_Data
                        Rep_Disbursements_Data rep_Disbursements_Data = new Rep_Disbursements_Data();

                        // Read values.
                        rep_Disbursements_Data.id = base.GetDataValue<int>(dr, "id");
                        rep_Disbursements_Data.branch_name = base.GetDataValue<string>(dr, "branch_name");
                        rep_Disbursements_Data.load_date = base.GetDataValue<DateTime>(dr, "load_date");
                        rep_Disbursements_Data.contract_code = base.GetDataValue<string>(dr, "contract_code");
                        rep_Disbursements_Data.district = base.GetDataValue<string>(dr, "district");
                        rep_Disbursements_Data.loan_product = base.GetDataValue<string>(dr, "loan_product");
                        rep_Disbursements_Data.client_name = base.GetDataValue<string>(dr, "client_name");
                        rep_Disbursements_Data.loan_cycle = base.GetDataValue<int>(dr, "loan_cycle");
                        rep_Disbursements_Data.loan_officer = base.GetDataValue<string>(dr, "loan_officer");
                        rep_Disbursements_Data.disbursement_date = base.GetDataValue<DateTime>(dr, "disbursement_date");
                        rep_Disbursements_Data.amount = base.GetDataValue<decimal>(dr, "amount");
                        rep_Disbursements_Data.interest = base.GetDataValue<decimal>(dr, "interest");
                        rep_Disbursements_Data.fees = base.GetDataValue<decimal>(dr, "fees");

                        // Add to List.
                        result.Add(rep_Disbursements_Data);
                    }
                }
            }

            return result;
        }
    }
}

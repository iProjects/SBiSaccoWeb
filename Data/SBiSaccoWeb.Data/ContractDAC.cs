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
    /// Contracts data access component. Manages CRUD operations for the Contracts table.
    /// </summary>
    public partial class ContractDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Contracts table.
        /// </summary>
        /// <param name="contract">A Contract object.</param>
        /// <returns>An updated Contract object.</returns>
        public Contract Create(Contract contract)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Contracts ([contract_code], [branch_code], [creation_date], [start_date], [close_date], [closed], [project_id], [status], [credit_commitee_date], [credit_commitee_comment], [credit_commitee_code], [align_disbursed_date], [loan_purpose], [comments], [nsg_id], [activity_id], [first_installment_date]) " +
                "VALUES(@contract_code, @branch_code, @creation_date, @start_date, @close_date, @closed, @project_id, @status, @credit_commitee_date, @credit_commitee_comment, @credit_commitee_code, @align_disbursed_date, @loan_purpose, @comments, @nsg_id, @activity_id, @first_installment_date); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@contract_code", DbType.String, contract.contract_code);
                db.AddInParameter(cmd, "@branch_code", DbType.AnsiString, contract.branch_code);
                db.AddInParameter(cmd, "@creation_date", DbType.DateTime, contract.creation_date);
                db.AddInParameter(cmd, "@start_date", DbType.DateTime, contract.start_date);
                db.AddInParameter(cmd, "@close_date", DbType.DateTime, contract.close_date);
                db.AddInParameter(cmd, "@closed", DbType.Boolean, contract.closed);
                db.AddInParameter(cmd, "@project_id", DbType.Int32, contract.project_id);
                db.AddInParameter(cmd, "@status", DbType.Int16, contract.status);
                db.AddInParameter(cmd, "@credit_commitee_date", DbType.DateTime, contract.credit_commitee_date);
                db.AddInParameter(cmd, "@credit_commitee_comment", DbType.String, contract.credit_commitee_comment);
                db.AddInParameter(cmd, "@credit_commitee_code", DbType.String, contract.credit_commitee_code);
                db.AddInParameter(cmd, "@align_disbursed_date", DbType.DateTime, contract.align_disbursed_date);
                db.AddInParameter(cmd, "@loan_purpose", DbType.String, contract.loan_purpose);
                db.AddInParameter(cmd, "@comments", DbType.String, contract.comments);
                db.AddInParameter(cmd, "@nsg_id", DbType.Int32, contract.nsg_id);
                db.AddInParameter(cmd, "@activity_id", DbType.Int32, contract.activity_id);
                db.AddInParameter(cmd, "@first_installment_date", DbType.DateTime, contract.first_installment_date);

                // Get the primary key value.
                contract.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return contract;
        }

        /// <summary>
        /// Updates an existing row in the Contracts table.
        /// </summary>
        /// <param name="contract">A Contract entity object.</param>
        public void UpdateById(Contract contract)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Contracts " +
                "SET " +
                    "[contract_code]=@contract_code, " +
                    "[branch_code]=@branch_code, " +
                    "[creation_date]=@creation_date, " +
                    "[start_date]=@start_date, " +
                    "[close_date]=@close_date, " +
                    "[closed]=@closed, " +
                    "[project_id]=@project_id, " +
                    "[status]=@status, " +
                    "[credit_commitee_date]=@credit_commitee_date, " +
                    "[credit_commitee_comment]=@credit_commitee_comment, " +
                    "[credit_commitee_code]=@credit_commitee_code, " +
                    "[align_disbursed_date]=@align_disbursed_date, " +
                    "[loan_purpose]=@loan_purpose, " +
                    "[comments]=@comments, " +
                    "[nsg_id]=@nsg_id, " +
                    "[activity_id]=@activity_id, " +
                    "[first_installment_date]=@first_installment_date " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@contract_code", DbType.String, contract.contract_code);
                db.AddInParameter(cmd, "@branch_code", DbType.AnsiString, contract.branch_code);
                db.AddInParameter(cmd, "@creation_date", DbType.DateTime, contract.creation_date);
                db.AddInParameter(cmd, "@start_date", DbType.DateTime, contract.start_date);
                db.AddInParameter(cmd, "@close_date", DbType.DateTime, contract.close_date);
                db.AddInParameter(cmd, "@closed", DbType.Boolean, contract.closed);
                db.AddInParameter(cmd, "@project_id", DbType.Int32, contract.project_id);
                db.AddInParameter(cmd, "@status", DbType.Int16, contract.status);
                db.AddInParameter(cmd, "@credit_commitee_date", DbType.DateTime, contract.credit_commitee_date);
                db.AddInParameter(cmd, "@credit_commitee_comment", DbType.String, contract.credit_commitee_comment);
                db.AddInParameter(cmd, "@credit_commitee_code", DbType.String, contract.credit_commitee_code);
                db.AddInParameter(cmd, "@align_disbursed_date", DbType.DateTime, contract.align_disbursed_date);
                db.AddInParameter(cmd, "@loan_purpose", DbType.String, contract.loan_purpose);
                db.AddInParameter(cmd, "@comments", DbType.String, contract.comments);
                db.AddInParameter(cmd, "@nsg_id", DbType.Int32, contract.nsg_id);
                db.AddInParameter(cmd, "@activity_id", DbType.Int32, contract.activity_id);
                db.AddInParameter(cmd, "@first_installment_date", DbType.DateTime, contract.first_installment_date);
                db.AddInParameter(cmd, "@id", DbType.Int32, contract.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the Contracts table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.Contracts " +
                                         "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@id", DbType.Int32, id);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Returns a row from the Contracts table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A Contract object with data populated from the database.</returns>
        public Contract SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [contract_code], [branch_code], [creation_date], [start_date], [close_date]" +
                        ", [closed], [project_id], [status], [credit_commitee_date], [credit_commitee_comment]" +
                        ", [credit_commitee_code], [align_disbursed_date], [loan_purpose], [comments], [nsg_id]" +
                        ", [activity_id], [first_installment_date] " +
                "FROM dbo.Contracts  " +
                "WHERE [id]=@id ";

            Contract contract = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new Contract
                        contract = new Contract();

                        // Read values.
                        contract.id = base.GetDataValue<int>(dr, "id");
                        contract.contract_code = base.GetDataValue<string>(dr, "contract_code");
                        contract.branch_code = base.GetDataValue<string>(dr, "branch_code");
                        contract.creation_date = base.GetDataValue<DateTime>(dr, "creation_date");
                        contract.start_date = base.GetDataValue<DateTime>(dr, "start_date");
                        contract.close_date = base.GetDataValue<DateTime>(dr, "close_date");
                        contract.closed = base.GetDataValue<bool>(dr, "closed");
                        contract.project_id = base.GetDataValue<int>(dr, "project_id");
                        contract.status = base.GetDataValue<short>(dr, "status");
                        contract.credit_commitee_date = base.GetDataValue<DateTime>(dr, "credit_commitee_date");
                        contract.credit_commitee_comment = base.GetDataValue<string>(dr, "credit_commitee_comment");
                        contract.credit_commitee_code = base.GetDataValue<string>(dr, "credit_commitee_code");
                        contract.align_disbursed_date = base.GetDataValue<DateTime>(dr, "align_disbursed_date");
                        contract.loan_purpose = base.GetDataValue<string>(dr, "loan_purpose");
                        contract.comments = base.GetDataValue<string>(dr, "comments");
                        contract.nsg_id = base.GetDataValue<int>(dr, "nsg_id");
                        contract.activity_id = base.GetDataValue<int>(dr, "activity_id");
                        contract.first_installment_date = base.GetDataValue<DateTime>(dr, "first_installment_date");
                    }
                }
            }

            return contract;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Contracts table.
        /// </summary>
        /// <returns>A collection of Contract objects.</returns>		
        public List<Contract> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [contract_code], [branch_code], [creation_date], [start_date], [close_date]" +
                        ", [closed], [project_id], [status], [credit_commitee_date], [credit_commitee_comment]" +
                        ", [credit_commitee_code], [align_disbursed_date], [loan_purpose], [comments], [nsg_id]" +
                        ", [activity_id], [first_installment_date] " +
                "FROM dbo.Contracts ";

            List<Contract> result = new List<Contract>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Contract
                        Contract contract = new Contract();

                        // Read values.
                        contract.id = base.GetDataValue<int>(dr, "id");
                        contract.contract_code = base.GetDataValue<string>(dr, "contract_code");
                        contract.branch_code = base.GetDataValue<string>(dr, "branch_code");
                        contract.creation_date = base.GetDataValue<DateTime>(dr, "creation_date");
                        contract.start_date = base.GetDataValue<DateTime>(dr, "start_date");
                        contract.close_date = base.GetDataValue<DateTime>(dr, "close_date");
                        contract.closed = base.GetDataValue<bool>(dr, "closed");
                        contract.project_id = base.GetDataValue<int>(dr, "project_id");
                        contract.status = base.GetDataValue<short>(dr, "status");
                        contract.credit_commitee_date = base.GetDataValue<DateTime>(dr, "credit_commitee_date");
                        contract.credit_commitee_comment = base.GetDataValue<string>(dr, "credit_commitee_comment");
                        contract.credit_commitee_code = base.GetDataValue<string>(dr, "credit_commitee_code");
                        contract.align_disbursed_date = base.GetDataValue<DateTime>(dr, "align_disbursed_date");
                        contract.loan_purpose = base.GetDataValue<string>(dr, "loan_purpose");
                        contract.comments = base.GetDataValue<string>(dr, "comments");
                        contract.nsg_id = base.GetDataValue<int>(dr, "nsg_id");
                        contract.activity_id = base.GetDataValue<int>(dr, "activity_id");
                        contract.first_installment_date = base.GetDataValue<DateTime>(dr, "first_installment_date");

                        // Add to List.
                        result.Add(contract);
                    }
                }
            }

            return result;
        }
    }
}

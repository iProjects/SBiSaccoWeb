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
    /// SavingContracts data access component. Manages CRUD operations for the SavingContracts table.
    /// </summary>
    public partial class SavingContractDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the SavingContracts table.
        /// </summary>
        /// <param name="savingContract">A SavingContract object.</param>
        /// <returns>An updated SavingContract object.</returns>
        public SavingContract Create(SavingContract savingContract)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.SavingContracts ([product_id], [user_id], [code], [tiers_id], [creation_date], [interest_rate], [status], [closed_date], [savings_officer_id], [initial_amount], [entry_fees], [nsg_id]) " +
                "VALUES(@product_id, @user_id, @code, @tiers_id, @creation_date, @interest_rate, @status, @closed_date, @savings_officer_id, @initial_amount, @entry_fees, @nsg_id); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@product_id", DbType.Int32, savingContract.product_id);
                db.AddInParameter(cmd, "@user_id", DbType.Int32, savingContract.user_id);
                db.AddInParameter(cmd, "@code", DbType.String, savingContract.code);
                db.AddInParameter(cmd, "@tiers_id", DbType.Int32, savingContract.tiers_id);
                db.AddInParameter(cmd, "@creation_date", DbType.DateTime, savingContract.creation_date);
                db.AddInParameter(cmd, "@interest_rate", DbType.Double, savingContract.interest_rate);
                db.AddInParameter(cmd, "@status", DbType.Int16, savingContract.status);
                db.AddInParameter(cmd, "@closed_date", DbType.DateTime, savingContract.closed_date);
                db.AddInParameter(cmd, "@savings_officer_id", DbType.Int32, savingContract.savings_officer_id);
                db.AddInParameter(cmd, "@initial_amount", DbType.Currency, savingContract.initial_amount);
                db.AddInParameter(cmd, "@entry_fees", DbType.Currency, savingContract.entry_fees);
                db.AddInParameter(cmd, "@nsg_id", DbType.Int32, savingContract.nsg_id);

                // Get the primary key value.
                savingContract.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return savingContract;
        }

        /// <summary>
        /// Updates an existing row in the SavingContracts table.
        /// </summary>
        /// <param name="savingContract">A SavingContract entity object.</param>
        public void UpdateById(SavingContract savingContract)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.SavingContracts " +
                "SET " +
                    "[product_id]=@product_id, " +
                    "[user_id]=@user_id, " +
                    "[code]=@code, " +
                    "[tiers_id]=@tiers_id, " +
                    "[creation_date]=@creation_date, " +
                    "[interest_rate]=@interest_rate, " +
                    "[status]=@status, " +
                    "[closed_date]=@closed_date, " +
                    "[savings_officer_id]=@savings_officer_id, " +
                    "[initial_amount]=@initial_amount, " +
                    "[entry_fees]=@entry_fees, " +
                    "[nsg_id]=@nsg_id " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@product_id", DbType.Int32, savingContract.product_id);
                db.AddInParameter(cmd, "@user_id", DbType.Int32, savingContract.user_id);
                db.AddInParameter(cmd, "@code", DbType.String, savingContract.code);
                db.AddInParameter(cmd, "@tiers_id", DbType.Int32, savingContract.tiers_id);
                db.AddInParameter(cmd, "@creation_date", DbType.DateTime, savingContract.creation_date);
                db.AddInParameter(cmd, "@interest_rate", DbType.Double, savingContract.interest_rate);
                db.AddInParameter(cmd, "@status", DbType.Int16, savingContract.status);
                db.AddInParameter(cmd, "@closed_date", DbType.DateTime, savingContract.closed_date);
                db.AddInParameter(cmd, "@savings_officer_id", DbType.Int32, savingContract.savings_officer_id);
                db.AddInParameter(cmd, "@initial_amount", DbType.Currency, savingContract.initial_amount);
                db.AddInParameter(cmd, "@entry_fees", DbType.Currency, savingContract.entry_fees);
                db.AddInParameter(cmd, "@nsg_id", DbType.Int32, savingContract.nsg_id);
                db.AddInParameter(cmd, "@id", DbType.Int32, savingContract.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the SavingContracts table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.SavingContracts " +
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
        /// Returns a row from the SavingContracts table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A SavingContract object with data populated from the database.</returns>
        public SavingContract SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [product_id], [user_id], [code], [tiers_id], [creation_date], [interest_rate]" +
                        ", [status], [closed_date], [savings_officer_id], [initial_amount], [entry_fees], [nsg_id]" +
                        " " +
                "FROM dbo.SavingContracts  " +
                "WHERE [id]=@id ";

            SavingContract savingContract = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new SavingContract
                        savingContract = new SavingContract();

                        // Read values.
                        savingContract.id = base.GetDataValue<int>(dr, "id");
                        savingContract.product_id = base.GetDataValue<int>(dr, "product_id");
                        savingContract.user_id = base.GetDataValue<int>(dr, "user_id");
                        savingContract.code = base.GetDataValue<string>(dr, "code");
                        savingContract.tiers_id = base.GetDataValue<int>(dr, "tiers_id");
                        savingContract.creation_date = base.GetDataValue<DateTime>(dr, "creation_date");
                        savingContract.interest_rate = base.GetDataValue<double>(dr, "interest_rate");
                        savingContract.status = base.GetDataValue<short>(dr, "status");
                        savingContract.closed_date = base.GetDataValue<DateTime>(dr, "closed_date");
                        savingContract.savings_officer_id = base.GetDataValue<int>(dr, "savings_officer_id");
                        savingContract.initial_amount = base.GetDataValue<decimal>(dr, "initial_amount");
                        savingContract.entry_fees = base.GetDataValue<decimal>(dr, "entry_fees");
                        savingContract.nsg_id = base.GetDataValue<int>(dr, "nsg_id");
                    }
                }
            }

            return savingContract;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the SavingContracts table.
        /// </summary>
        /// <returns>A collection of SavingContract objects.</returns>		
        public List<SavingContract> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [product_id], [user_id], [code], [tiers_id], [creation_date], [interest_rate]" +
                        ", [status], [closed_date], [savings_officer_id], [initial_amount], [entry_fees], [nsg_id]" +
                        " " +
                "FROM dbo.SavingContracts ";

            List<SavingContract> result = new List<SavingContract>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new SavingContract
                        SavingContract savingContract = new SavingContract();

                        // Read values.
                        savingContract.id = base.GetDataValue<int>(dr, "id");
                        savingContract.product_id = base.GetDataValue<int>(dr, "product_id");
                        savingContract.user_id = base.GetDataValue<int>(dr, "user_id");
                        savingContract.code = base.GetDataValue<string>(dr, "code");
                        savingContract.tiers_id = base.GetDataValue<int>(dr, "tiers_id");
                        savingContract.creation_date = base.GetDataValue<DateTime>(dr, "creation_date");
                        savingContract.interest_rate = base.GetDataValue<double>(dr, "interest_rate");
                        savingContract.status = base.GetDataValue<short>(dr, "status");
                        savingContract.closed_date = base.GetDataValue<DateTime>(dr, "closed_date");
                        savingContract.savings_officer_id = base.GetDataValue<int>(dr, "savings_officer_id");
                        savingContract.initial_amount = base.GetDataValue<decimal>(dr, "initial_amount");
                        savingContract.entry_fees = base.GetDataValue<decimal>(dr, "entry_fees");
                        savingContract.nsg_id = base.GetDataValue<int>(dr, "nsg_id");

                        // Add to List.
                        result.Add(savingContract);
                    }
                }
            }

            return result;
        }
    }
}


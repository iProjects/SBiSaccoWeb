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
    /// CreditEntryFees data access component. Manages CRUD operations for the CreditEntryFees table.
    /// </summary>
    public partial class CreditEntryFeeDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the CreditEntryFees table.
        /// </summary>
        /// <param name="creditEntryFee">A CreditEntryFee object.</param>
        /// <returns>An updated CreditEntryFee object.</returns>
        public CreditEntryFee Create(CreditEntryFee creditEntryFee)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.CreditEntryFees ([credit_id], [entry_fee_id], [fee_value]) " +
                "VALUES(@credit_id, @entry_fee_id, @fee_value); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@credit_id", DbType.Int32, creditEntryFee.credit_id);
                db.AddInParameter(cmd, "@entry_fee_id", DbType.Int32, creditEntryFee.entry_fee_id);
                db.AddInParameter(cmd, "@fee_value", DbType.Decimal, creditEntryFee.fee_value);

                // Get the primary key value.
                creditEntryFee.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return creditEntryFee;
        }

        /// <summary>
        /// Updates an existing row in the CreditEntryFees table.
        /// </summary>
        /// <param name="creditEntryFee">A CreditEntryFee entity object.</param>
        public void UpdateById(CreditEntryFee creditEntryFee)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.CreditEntryFees " +
                "SET " +
                    "[credit_id]=@credit_id, " +
                    "[entry_fee_id]=@entry_fee_id, " +
                    "[fee_value]=@fee_value " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@credit_id", DbType.Int32, creditEntryFee.credit_id);
                db.AddInParameter(cmd, "@entry_fee_id", DbType.Int32, creditEntryFee.entry_fee_id);
                db.AddInParameter(cmd, "@fee_value", DbType.Decimal, creditEntryFee.fee_value);
                db.AddInParameter(cmd, "@id", DbType.Int32, creditEntryFee.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the CreditEntryFees table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.CreditEntryFees " +
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
        /// Returns a row from the CreditEntryFees table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A CreditEntryFee object with data populated from the database.</returns>
        public CreditEntryFee SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [credit_id], [entry_fee_id], [fee_value] " +
                "FROM dbo.CreditEntryFees  " +
                "WHERE [id]=@id ";

            CreditEntryFee creditEntryFee = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new CreditEntryFee
                        creditEntryFee = new CreditEntryFee();

                        // Read values.
                        creditEntryFee.id = base.GetDataValue<int>(dr, "id");
                        creditEntryFee.credit_id = base.GetDataValue<int>(dr, "credit_id");
                        creditEntryFee.entry_fee_id = base.GetDataValue<int>(dr, "entry_fee_id");
                        creditEntryFee.fee_value = base.GetDataValue<decimal>(dr, "fee_value");
                    }
                }
            }

            return creditEntryFee;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the CreditEntryFees table.
        /// </summary>
        /// <returns>A collection of CreditEntryFee objects.</returns>		
        public List<CreditEntryFee> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [credit_id], [entry_fee_id], [fee_value] " +
                "FROM dbo.CreditEntryFees ";

            List<CreditEntryFee> result = new List<CreditEntryFee>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new CreditEntryFee
                        CreditEntryFee creditEntryFee = new CreditEntryFee();

                        // Read values.
                        creditEntryFee.id = base.GetDataValue<int>(dr, "id");
                        creditEntryFee.credit_id = base.GetDataValue<int>(dr, "credit_id");
                        creditEntryFee.entry_fee_id = base.GetDataValue<int>(dr, "entry_fee_id");
                        creditEntryFee.fee_value = base.GetDataValue<decimal>(dr, "fee_value");

                        // Add to List.
                        result.Add(creditEntryFee);
                    }
                }
            }

            return result;
        }
    }
}


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
    /// LoansLinkSavingsBook data access component. Manages CRUD operations for the LoansLinkSavingsBook table.
    /// </summary>
    public partial class LoansLinkSavingsBookDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the LoansLinkSavingsBook table.
        /// </summary>
        /// <param name="loansLinkSavingsBook">A LoansLinkSavingsBook object.</param>
        /// <returns>An updated LoansLinkSavingsBook object.</returns>
        public LoansLinkSavingsBook Create(LoansLinkSavingsBook loansLinkSavingsBook)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.LoansLinkSavingsBook ([loan_id], [savings_id], [loan_percentage]) " +
                "VALUES(@loan_id, @savings_id, @loan_percentage); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@loan_id", DbType.Int32, loansLinkSavingsBook.loan_id);
                db.AddInParameter(cmd, "@savings_id", DbType.Int32, loansLinkSavingsBook.savings_id);
                db.AddInParameter(cmd, "@loan_percentage", DbType.Int32, loansLinkSavingsBook.loan_percentage);

                // Get the primary key value.
                loansLinkSavingsBook.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return loansLinkSavingsBook;
        }

        /// <summary>
        /// Updates an existing row in the LoansLinkSavingsBook table.
        /// </summary>
        /// <param name="loansLinkSavingsBook">A LoansLinkSavingsBook entity object.</param>
        public void UpdateById(LoansLinkSavingsBook loansLinkSavingsBook)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.LoansLinkSavingsBook " +
                "SET " +
                    "[loan_id]=@loan_id, " +
                    "[savings_id]=@savings_id, " +
                    "[loan_percentage]=@loan_percentage " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@loan_id", DbType.Int32, loansLinkSavingsBook.loan_id);
                db.AddInParameter(cmd, "@savings_id", DbType.Int32, loansLinkSavingsBook.savings_id);
                db.AddInParameter(cmd, "@loan_percentage", DbType.Int32, loansLinkSavingsBook.loan_percentage);
                db.AddInParameter(cmd, "@id", DbType.Int32, loansLinkSavingsBook.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the LoansLinkSavingsBook table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.LoansLinkSavingsBook " +
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
        /// Returns a row from the LoansLinkSavingsBook table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A LoansLinkSavingsBook object with data populated from the database.</returns>
        public LoansLinkSavingsBook SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [loan_id], [savings_id], [loan_percentage] " +
                "FROM dbo.LoansLinkSavingsBook  " +
                "WHERE [id]=@id ";

            LoansLinkSavingsBook loansLinkSavingsBook = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new LoansLinkSavingsBook
                        loansLinkSavingsBook = new LoansLinkSavingsBook();

                        // Read values.
                        loansLinkSavingsBook.id = base.GetDataValue<int>(dr, "id");
                        loansLinkSavingsBook.loan_id = base.GetDataValue<int>(dr, "loan_id");
                        loansLinkSavingsBook.savings_id = base.GetDataValue<int>(dr, "savings_id");
                        loansLinkSavingsBook.loan_percentage = base.GetDataValue<int>(dr, "loan_percentage");
                    }
                }
            }

            return loansLinkSavingsBook;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the LoansLinkSavingsBook table.
        /// </summary>
        /// <returns>A collection of LoansLinkSavingsBook objects.</returns>		
        public List<LoansLinkSavingsBook> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [loan_id], [savings_id], [loan_percentage] " +
                "FROM dbo.LoansLinkSavingsBook ";

            List<LoansLinkSavingsBook> result = new List<LoansLinkSavingsBook>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new LoansLinkSavingsBook
                        LoansLinkSavingsBook loansLinkSavingsBook = new LoansLinkSavingsBook();

                        // Read values.
                        loansLinkSavingsBook.id = base.GetDataValue<int>(dr, "id");
                        loansLinkSavingsBook.loan_id = base.GetDataValue<int>(dr, "loan_id");
                        loansLinkSavingsBook.savings_id = base.GetDataValue<int>(dr, "savings_id");
                        loansLinkSavingsBook.loan_percentage = base.GetDataValue<int>(dr, "loan_percentage");

                        // Add to List.
                        result.Add(loansLinkSavingsBook);
                    }
                }
            }

            return result;
        }
    }
}


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
    /// FiscalYear data access component. Manages CRUD operations for the FiscalYear table.
    /// </summary>
    public partial class FiscalYearDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the FiscalYear table.
        /// </summary>
        /// <param name="fiscalYear">A FiscalYear object.</param>
        /// <returns>An updated FiscalYear object.</returns>
        public FiscalYear Create(FiscalYear fiscalYear)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.FiscalYear ([name], [open_date], [close_date]) " +
                "VALUES(@name, @open_date, @close_date); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@name", DbType.String, fiscalYear.name);
                db.AddInParameter(cmd, "@open_date", DbType.DateTime, fiscalYear.open_date);
                db.AddInParameter(cmd, "@close_date", DbType.DateTime, fiscalYear.close_date);

                // Get the primary key value.
                fiscalYear.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return fiscalYear;
        }

        /// <summary>
        /// Updates an existing row in the FiscalYear table.
        /// </summary>
        /// <param name="fiscalYear">A FiscalYear entity object.</param>
        public void UpdateById(FiscalYear fiscalYear)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.FiscalYear " +
                "SET " +
                    "[name]=@name, " +
                    "[open_date]=@open_date, " +
                    "[close_date]=@close_date " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@name", DbType.String, fiscalYear.name);
                db.AddInParameter(cmd, "@open_date", DbType.DateTime, fiscalYear.open_date);
                db.AddInParameter(cmd, "@close_date", DbType.DateTime, fiscalYear.close_date);
                db.AddInParameter(cmd, "@id", DbType.Int32, fiscalYear.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the FiscalYear table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.FiscalYear " +
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
        /// Returns a row from the FiscalYear table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A FiscalYear object with data populated from the database.</returns>
        public FiscalYear SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [name], [open_date], [close_date] " +
                "FROM dbo.FiscalYear  " +
                "WHERE [id]=@id ";

            FiscalYear fiscalYear = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new FiscalYear
                        fiscalYear = new FiscalYear();

                        // Read values.
                        fiscalYear.id = base.GetDataValue<int>(dr, "id");
                        fiscalYear.name = base.GetDataValue<string>(dr, "name");
                        fiscalYear.open_date = base.GetDataValue<DateTime>(dr, "open_date");
                        fiscalYear.close_date = base.GetDataValue<DateTime>(dr, "close_date");
                    }
                }
            }

            return fiscalYear;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the FiscalYear table.
        /// </summary>
        /// <returns>A collection of FiscalYear objects.</returns>		
        public List<FiscalYear> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [name], [open_date], [close_date] " +
                "FROM dbo.FiscalYear ";

            List<FiscalYear> result = new List<FiscalYear>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new FiscalYear
                        FiscalYear fiscalYear = new FiscalYear();

                        // Read values.
                        fiscalYear.id = base.GetDataValue<int>(dr, "id");
                        fiscalYear.name = base.GetDataValue<string>(dr, "name");
                        fiscalYear.open_date = base.GetDataValue<DateTime>(dr, "open_date");
                        fiscalYear.close_date = base.GetDataValue<DateTime>(dr, "close_date");

                        // Add to List.
                        result.Add(fiscalYear);
                    }
                }
            }

            return result;
        }
    }
}

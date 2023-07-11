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
    /// Currencies data access component. Manages CRUD operations for the Currencies table.
    /// </summary>
    public partial class CurrencyDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Currencies table.
        /// </summary>
        /// <param name="currency">A Currency object.</param>
        /// <returns>An updated Currency object.</returns>
        public Currency Create(Currency currency)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Currencies ([name], [is_pivot], [code], [is_swapped], [use_cents]) " +
                "VALUES(@name, @is_pivot, @code, @is_swapped, @use_cents); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@name", DbType.String, currency.name);
                db.AddInParameter(cmd, "@is_pivot", DbType.Boolean, currency.is_pivot);
                db.AddInParameter(cmd, "@code", DbType.String, currency.code);
                db.AddInParameter(cmd, "@is_swapped", DbType.Boolean, currency.is_swapped);
                db.AddInParameter(cmd, "@use_cents", DbType.Boolean, currency.use_cents);

                // Get the primary key value.
                currency.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return currency;
        }

        /// <summary>
        /// Updates an existing row in the Currencies table.
        /// </summary>
        /// <param name="currency">A Currency entity object.</param>
        public void UpdateById(Currency currency)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Currencies " +
                "SET " +
                    "[name]=@name, " +
                    "[is_pivot]=@is_pivot, " +
                    "[code]=@code, " +
                    "[is_swapped]=@is_swapped, " +
                    "[use_cents]=@use_cents " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@name", DbType.String, currency.name);
                db.AddInParameter(cmd, "@is_pivot", DbType.Boolean, currency.is_pivot);
                db.AddInParameter(cmd, "@code", DbType.String, currency.code);
                db.AddInParameter(cmd, "@is_swapped", DbType.Boolean, currency.is_swapped);
                db.AddInParameter(cmd, "@use_cents", DbType.Boolean, currency.use_cents);
                db.AddInParameter(cmd, "@id", DbType.Int32, currency.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the Currencies table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.Currencies " +
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
        /// Returns a row from the Currencies table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A Currency object with data populated from the database.</returns>
        public Currency SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [name], [is_pivot], [code], [is_swapped], [use_cents] " +
                "FROM dbo.Currencies  " +
                "WHERE [id]=@id ";

            Currency currency = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new Currency
                        currency = new Currency();

                        // Read values.
                        currency.id = base.GetDataValue<int>(dr, "id");
                        currency.name = base.GetDataValue<string>(dr, "name");
                        currency.is_pivot = base.GetDataValue<bool>(dr, "is_pivot");
                        currency.code = base.GetDataValue<string>(dr, "code");
                        currency.is_swapped = base.GetDataValue<bool>(dr, "is_swapped");
                        currency.use_cents = base.GetDataValue<bool>(dr, "use_cents");
                    }
                }
            }

            return currency;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Currencies table.
        /// </summary>
        /// <returns>A collection of Currency objects.</returns>		
        public List<Currency> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [name], [is_pivot], [code], [is_swapped], [use_cents] " +
                "FROM dbo.Currencies ";

            List<Currency> result = new List<Currency>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Currency
                        Currency currency = new Currency();

                        // Read values.
                        currency.id = base.GetDataValue<int>(dr, "id");
                        currency.name = base.GetDataValue<string>(dr, "name");
                        currency.is_pivot = base.GetDataValue<bool>(dr, "is_pivot");
                        currency.code = base.GetDataValue<string>(dr, "code");
                        currency.is_swapped = base.GetDataValue<bool>(dr, "is_swapped");
                        currency.use_cents = base.GetDataValue<bool>(dr, "use_cents");

                        // Add to List.
                        result.Add(currency);
                    }
                }
            }

            return result;
        }
    }
}

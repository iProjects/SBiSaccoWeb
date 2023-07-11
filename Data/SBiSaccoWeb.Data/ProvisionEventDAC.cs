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
    /// ProvisionEvents data access component. Manages CRUD operations for the ProvisionEvents table.
    /// </summary>
    public partial class ProvisionEventDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the ProvisionEvents table.
        /// </summary>
        /// <param name="provisionEvent">A ProvisionEvent object.</param>
        /// <returns>An updated ProvisionEvent object.</returns>
        public ProvisionEvent Create(ProvisionEvent provisionEvent)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.ProvisionEvents ([id], [amount], [rate], [overdue_days]) " +
                "VALUES(@id, @amount, @rate, @overdue_days);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@id", DbType.Int32, provisionEvent.id);
                db.AddInParameter(cmd, "@amount", DbType.Currency, provisionEvent.amount);
                db.AddInParameter(cmd, "@rate", DbType.Double, provisionEvent.rate);
                db.AddInParameter(cmd, "@overdue_days", DbType.Int32, provisionEvent.overdue_days);

                db.ExecuteNonQuery(cmd);
            }

            return provisionEvent;
        }

        /// <summary>
        /// Updates an existing row in the ProvisionEvents table.
        /// </summary>
        /// <param name="provisionEvent">A ProvisionEvent entity object.</param>
        public void UpdateById(ProvisionEvent provisionEvent)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.ProvisionEvents " +
                "SET " +
                    "[amount]=@amount, " +
                    "[rate]=@rate, " +
                    "[overdue_days]=@overdue_days " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@amount", DbType.Currency, provisionEvent.amount);
                db.AddInParameter(cmd, "@rate", DbType.Double, provisionEvent.rate);
                db.AddInParameter(cmd, "@overdue_days", DbType.Int32, provisionEvent.overdue_days);
                db.AddInParameter(cmd, "@id", DbType.Int32, provisionEvent.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the ProvisionEvents table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.ProvisionEvents " +
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
        /// Returns a row from the ProvisionEvents table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A ProvisionEvent object with data populated from the database.</returns>
        public ProvisionEvent SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [amount], [rate], [overdue_days] " +
                "FROM dbo.ProvisionEvents  " +
                "WHERE [id]=@id ";

            ProvisionEvent provisionEvent = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new ProvisionEvent
                        provisionEvent = new ProvisionEvent();

                        // Read values.
                        provisionEvent.id = base.GetDataValue<int>(dr, "id");
                        provisionEvent.amount = base.GetDataValue<decimal>(dr, "amount");
                        provisionEvent.rate = base.GetDataValue<double>(dr, "rate");
                        provisionEvent.overdue_days = base.GetDataValue<int>(dr, "overdue_days");
                    }
                }
            }

            return provisionEvent;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the ProvisionEvents table.
        /// </summary>
        /// <returns>A collection of ProvisionEvent objects.</returns>		
        public List<ProvisionEvent> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [amount], [rate], [overdue_days] " +
                "FROM dbo.ProvisionEvents ";

            List<ProvisionEvent> result = new List<ProvisionEvent>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new ProvisionEvent
                        ProvisionEvent provisionEvent = new ProvisionEvent();

                        // Read values.
                        provisionEvent.id = base.GetDataValue<int>(dr, "id");
                        provisionEvent.amount = base.GetDataValue<decimal>(dr, "amount");
                        provisionEvent.rate = base.GetDataValue<double>(dr, "rate");
                        provisionEvent.overdue_days = base.GetDataValue<int>(dr, "overdue_days");

                        // Add to List.
                        result.Add(provisionEvent);
                    }
                }
            }

            return result;
        }
    }
}


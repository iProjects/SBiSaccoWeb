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
    /// WriteOffEvents data access component. Manages CRUD operations for the WriteOffEvents table.
    /// </summary>
    public partial class WriteOffEventDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the WriteOffEvents table.
        /// </summary>
        /// <param name="writeOffEvent">A WriteOffEvent object.</param>
        /// <returns>An updated WriteOffEvent object.</returns>
        public WriteOffEvent Create(WriteOffEvent writeOffEvent)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.WriteOffEvents ([id], [olb], [accrued_interests], [accrued_penalties], [past_due_days], [overdue_principal]) " +
                "VALUES(@id, @olb, @accrued_interests, @accrued_penalties, @past_due_days, @overdue_principal);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@id", DbType.Int32, writeOffEvent.id);
                db.AddInParameter(cmd, "@olb", DbType.Currency, writeOffEvent.olb);
                db.AddInParameter(cmd, "@accrued_interests", DbType.Currency, writeOffEvent.accrued_interests);
                db.AddInParameter(cmd, "@accrued_penalties", DbType.Currency, writeOffEvent.accrued_penalties);
                db.AddInParameter(cmd, "@past_due_days", DbType.Int32, writeOffEvent.past_due_days);
                db.AddInParameter(cmd, "@overdue_principal", DbType.Currency, writeOffEvent.overdue_principal);

                db.ExecuteNonQuery(cmd);
            }

            return writeOffEvent;
        }

        /// <summary>
        /// Updates an existing row in the WriteOffEvents table.
        /// </summary>
        /// <param name="writeOffEvent">A WriteOffEvent entity object.</param>
        public void UpdateById(WriteOffEvent writeOffEvent)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.WriteOffEvents " +
                "SET " +
                    "[olb]=@olb, " +
                    "[accrued_interests]=@accrued_interests, " +
                    "[accrued_penalties]=@accrued_penalties, " +
                    "[past_due_days]=@past_due_days, " +
                    "[overdue_principal]=@overdue_principal " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@olb", DbType.Currency, writeOffEvent.olb);
                db.AddInParameter(cmd, "@accrued_interests", DbType.Currency, writeOffEvent.accrued_interests);
                db.AddInParameter(cmd, "@accrued_penalties", DbType.Currency, writeOffEvent.accrued_penalties);
                db.AddInParameter(cmd, "@past_due_days", DbType.Int32, writeOffEvent.past_due_days);
                db.AddInParameter(cmd, "@overdue_principal", DbType.Currency, writeOffEvent.overdue_principal);
                db.AddInParameter(cmd, "@id", DbType.Int32, writeOffEvent.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the WriteOffEvents table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.WriteOffEvents " +
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
        /// Returns a row from the WriteOffEvents table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A WriteOffEvent object with data populated from the database.</returns>
        public WriteOffEvent SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [olb], [accrued_interests], [accrued_penalties], [past_due_days], [overdue_principal]" +
                        " " +
                "FROM dbo.WriteOffEvents  " +
                "WHERE [id]=@id ";

            WriteOffEvent writeOffEvent = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new WriteOffEvent
                        writeOffEvent = new WriteOffEvent();

                        // Read values.
                        writeOffEvent.id = base.GetDataValue<int>(dr, "id");
                        writeOffEvent.olb = base.GetDataValue<decimal>(dr, "olb");
                        writeOffEvent.accrued_interests = base.GetDataValue<decimal>(dr, "accrued_interests");
                        writeOffEvent.accrued_penalties = base.GetDataValue<decimal>(dr, "accrued_penalties");
                        writeOffEvent.past_due_days = base.GetDataValue<int>(dr, "past_due_days");
                        writeOffEvent.overdue_principal = base.GetDataValue<decimal>(dr, "overdue_principal");
                    }
                }
            }

            return writeOffEvent;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the WriteOffEvents table.
        /// </summary>
        /// <returns>A collection of WriteOffEvent objects.</returns>		
        public List<WriteOffEvent> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [olb], [accrued_interests], [accrued_penalties], [past_due_days], [overdue_principal]" +
                        " " +
                "FROM dbo.WriteOffEvents ";

            List<WriteOffEvent> result = new List<WriteOffEvent>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new WriteOffEvent
                        WriteOffEvent writeOffEvent = new WriteOffEvent();

                        // Read values.
                        writeOffEvent.id = base.GetDataValue<int>(dr, "id");
                        writeOffEvent.olb = base.GetDataValue<decimal>(dr, "olb");
                        writeOffEvent.accrued_interests = base.GetDataValue<decimal>(dr, "accrued_interests");
                        writeOffEvent.accrued_penalties = base.GetDataValue<decimal>(dr, "accrued_penalties");
                        writeOffEvent.past_due_days = base.GetDataValue<int>(dr, "past_due_days");
                        writeOffEvent.overdue_principal = base.GetDataValue<decimal>(dr, "overdue_principal");

                        // Add to List.
                        result.Add(writeOffEvent);
                    }
                }
            }

            return result;
        }
    }
}


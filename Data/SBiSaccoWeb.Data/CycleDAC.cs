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
    /// Cycles data access component. Manages CRUD operations for the Cycles table.
    /// </summary>
    public partial class CycleDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Cycles table.
        /// </summary>
        /// <param name="cycle">A Cycle object.</param>
        /// <returns>An updated Cycle object.</returns>
        public Cycle Create(Cycle cycle)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Cycles ([name]) " +
                "VALUES(@name); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@name", DbType.String, cycle.name);

                // Get the primary key value.
                cycle.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return cycle;
        }

        /// <summary>
        /// Updates an existing row in the Cycles table.
        /// </summary>
        /// <param name="cycle">A Cycle entity object.</param>
        public void UpdateById(Cycle cycle)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Cycles " +
                "SET " +
                    "[name]=@name " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@name", DbType.String, cycle.name);
                db.AddInParameter(cmd, "@id", DbType.Int32, cycle.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the Cycles table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.Cycles " +
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
        /// Returns a row from the Cycles table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A Cycle object with data populated from the database.</returns>
        public Cycle SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [name] " +
                "FROM dbo.Cycles  " +
                "WHERE [id]=@id ";

            Cycle cycle = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new Cycle
                        cycle = new Cycle();

                        // Read values.
                        cycle.id = base.GetDataValue<int>(dr, "id");
                        cycle.name = base.GetDataValue<string>(dr, "name");
                    }
                }
            }

            return cycle;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Cycles table.
        /// </summary>
        /// <returns>A collection of Cycle objects.</returns>		
        public List<Cycle> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [name] " +
                "FROM dbo.Cycles ";

            List<Cycle> result = new List<Cycle>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Cycle
                        Cycle cycle = new Cycle();

                        // Read values.
                        cycle.id = base.GetDataValue<int>(dr, "id");
                        cycle.name = base.GetDataValue<string>(dr, "name");

                        // Add to List.
                        result.Add(cycle);
                    }
                }
            }

            return result;
        }
    }
}


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
    /// CycleParameters data access component. Manages CRUD operations for the CycleParameters table.
    /// </summary>
    public partial class CycleParameterDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the CycleParameters table.
        /// </summary>
        /// <param name="cycleParameter">A CycleParameter object.</param>
        /// <returns>An updated CycleParameter object.</returns>
        public CycleParameter Create(CycleParameter cycleParameter)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.CycleParameters ([loan_cycle], [min], [max], [cycle_object_id], [cycle_id]) " +
                "VALUES(@loan_cycle, @min, @max, @cycle_object_id, @cycle_id); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@loan_cycle", DbType.Int32, cycleParameter.loan_cycle);
                db.AddInParameter(cmd, "@min", DbType.Currency, cycleParameter.min);
                db.AddInParameter(cmd, "@max", DbType.Currency, cycleParameter.max);
                db.AddInParameter(cmd, "@cycle_object_id", DbType.Int32, cycleParameter.cycle_object_id);
                db.AddInParameter(cmd, "@cycle_id", DbType.Int32, cycleParameter.cycle_id);

                // Get the primary key value.
                cycleParameter.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return cycleParameter;
        }

        /// <summary>
        /// Updates an existing row in the CycleParameters table.
        /// </summary>
        /// <param name="cycleParameter">A CycleParameter entity object.</param>
        public void UpdateById(CycleParameter cycleParameter)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.CycleParameters " +
                "SET " +
                    "[loan_cycle]=@loan_cycle, " +
                    "[min]=@min, " +
                    "[max]=@max, " +
                    "[cycle_object_id]=@cycle_object_id, " +
                    "[cycle_id]=@cycle_id " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@loan_cycle", DbType.Int32, cycleParameter.loan_cycle);
                db.AddInParameter(cmd, "@min", DbType.Currency, cycleParameter.min);
                db.AddInParameter(cmd, "@max", DbType.Currency, cycleParameter.max);
                db.AddInParameter(cmd, "@cycle_object_id", DbType.Int32, cycleParameter.cycle_object_id);
                db.AddInParameter(cmd, "@cycle_id", DbType.Int32, cycleParameter.cycle_id);
                db.AddInParameter(cmd, "@id", DbType.Int32, cycleParameter.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the CycleParameters table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.CycleParameters " +
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
        /// Returns a row from the CycleParameters table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A CycleParameter object with data populated from the database.</returns>
        public CycleParameter SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [loan_cycle], [min], [max], [cycle_object_id], [cycle_id] " +
                "FROM dbo.CycleParameters  " +
                "WHERE [id]=@id ";

            CycleParameter cycleParameter = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new CycleParameter
                        cycleParameter = new CycleParameter();

                        // Read values.
                        cycleParameter.id = base.GetDataValue<int>(dr, "id");
                        cycleParameter.loan_cycle = base.GetDataValue<int>(dr, "loan_cycle");
                        cycleParameter.min = base.GetDataValue<decimal>(dr, "min");
                        cycleParameter.max = base.GetDataValue<decimal>(dr, "max");
                        cycleParameter.cycle_object_id = base.GetDataValue<int>(dr, "cycle_object_id");
                        cycleParameter.cycle_id = base.GetDataValue<int>(dr, "cycle_id");
                    }
                }
            }

            return cycleParameter;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the CycleParameters table.
        /// </summary>
        /// <returns>A collection of CycleParameter objects.</returns>		
        public List<CycleParameter> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [loan_cycle], [min], [max], [cycle_object_id], [cycle_id] " +
                "FROM dbo.CycleParameters ";

            List<CycleParameter> result = new List<CycleParameter>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new CycleParameter
                        CycleParameter cycleParameter = new CycleParameter();

                        // Read values.
                        cycleParameter.id = base.GetDataValue<int>(dr, "id");
                        cycleParameter.loan_cycle = base.GetDataValue<int>(dr, "loan_cycle");
                        cycleParameter.min = base.GetDataValue<decimal>(dr, "min");
                        cycleParameter.max = base.GetDataValue<decimal>(dr, "max");
                        cycleParameter.cycle_object_id = base.GetDataValue<int>(dr, "cycle_object_id");
                        cycleParameter.cycle_id = base.GetDataValue<int>(dr, "cycle_id");

                        // Add to List.
                        result.Add(cycleParameter);
                    }
                }
            }

            return result;
        }
    }
}


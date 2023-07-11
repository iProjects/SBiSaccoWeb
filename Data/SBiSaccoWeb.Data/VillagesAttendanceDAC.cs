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
    /// VillagesAttendance data access component. Manages CRUD operations for the VillagesAttendance table.
    /// </summary>
    public partial class VillagesAttendanceDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the VillagesAttendance table.
        /// </summary>
        /// <param name="villagesAttendance">A VillagesAttendance object.</param>
        /// <returns>An updated VillagesAttendance object.</returns>
        public VillagesAttendance Create(VillagesAttendance villagesAttendance)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.VillagesAttendance ([village_id], [person_id], [date], [attended], [comment], [loan_id]) " +
                "VALUES(@village_id, @person_id, @date, @attended, @comment, @loan_id); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@village_id", DbType.Int32, villagesAttendance.village_id);
                db.AddInParameter(cmd, "@person_id", DbType.Int32, villagesAttendance.person_id);
                db.AddInParameter(cmd, "@date", DbType.DateTime, villagesAttendance.date);
                db.AddInParameter(cmd, "@attended", DbType.Boolean, villagesAttendance.attended);
                db.AddInParameter(cmd, "@comment", DbType.String, villagesAttendance.comment);
                db.AddInParameter(cmd, "@loan_id", DbType.Int32, villagesAttendance.loan_id);

                // Get the primary key value.
                villagesAttendance.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return villagesAttendance;
        }

        /// <summary>
        /// Updates an existing row in the VillagesAttendance table.
        /// </summary>
        /// <param name="villagesAttendance">A VillagesAttendance entity object.</param>
        public void UpdateById(VillagesAttendance villagesAttendance)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.VillagesAttendance " +
                "SET " +
                    "[village_id]=@village_id, " +
                    "[person_id]=@person_id, " +
                    "[date]=@date, " +
                    "[attended]=@attended, " +
                    "[comment]=@comment, " +
                    "[loan_id]=@loan_id " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@village_id", DbType.Int32, villagesAttendance.village_id);
                db.AddInParameter(cmd, "@person_id", DbType.Int32, villagesAttendance.person_id);
                db.AddInParameter(cmd, "@date", DbType.DateTime, villagesAttendance.date);
                db.AddInParameter(cmd, "@attended", DbType.Boolean, villagesAttendance.attended);
                db.AddInParameter(cmd, "@comment", DbType.String, villagesAttendance.comment);
                db.AddInParameter(cmd, "@loan_id", DbType.Int32, villagesAttendance.loan_id);
                db.AddInParameter(cmd, "@id", DbType.Int32, villagesAttendance.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the VillagesAttendance table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.VillagesAttendance " +
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
        /// Returns a row from the VillagesAttendance table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A VillagesAttendance object with data populated from the database.</returns>
        public VillagesAttendance SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [village_id], [person_id], [date], [attended], [comment], [loan_id] " +
                "FROM dbo.VillagesAttendance  " +
                "WHERE [id]=@id ";

            VillagesAttendance villagesAttendance = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new VillagesAttendance
                        villagesAttendance = new VillagesAttendance();

                        // Read values.
                        villagesAttendance.id = base.GetDataValue<int>(dr, "id");
                        villagesAttendance.village_id = base.GetDataValue<int>(dr, "village_id");
                        villagesAttendance.person_id = base.GetDataValue<int>(dr, "person_id");
                        villagesAttendance.date = base.GetDataValue<DateTime>(dr, "date");
                        villagesAttendance.attended = base.GetDataValue<bool>(dr, "attended");
                        villagesAttendance.comment = base.GetDataValue<string>(dr, "comment");
                        villagesAttendance.loan_id = base.GetDataValue<int>(dr, "loan_id");
                    }
                }
            }

            return villagesAttendance;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the VillagesAttendance table.
        /// </summary>
        /// <returns>A collection of VillagesAttendance objects.</returns>		
        public List<VillagesAttendance> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [village_id], [person_id], [date], [attended], [comment], [loan_id] " +
                "FROM dbo.VillagesAttendance ";

            List<VillagesAttendance> result = new List<VillagesAttendance>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new VillagesAttendance
                        VillagesAttendance villagesAttendance = new VillagesAttendance();

                        // Read values.
                        villagesAttendance.id = base.GetDataValue<int>(dr, "id");
                        villagesAttendance.village_id = base.GetDataValue<int>(dr, "village_id");
                        villagesAttendance.person_id = base.GetDataValue<int>(dr, "person_id");
                        villagesAttendance.date = base.GetDataValue<DateTime>(dr, "date");
                        villagesAttendance.attended = base.GetDataValue<bool>(dr, "attended");
                        villagesAttendance.comment = base.GetDataValue<string>(dr, "comment");
                        villagesAttendance.loan_id = base.GetDataValue<int>(dr, "loan_id");

                        // Add to List.
                        result.Add(villagesAttendance);
                    }
                }
            }

            return result;
        }
    }
}

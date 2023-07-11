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
    /// PersonGroupBelonging data access component. Manages CRUD operations for the PersonGroupBelonging table.
    /// </summary>
    public partial class PersonGroupBelongingDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the PersonGroupBelonging table.
        /// </summary>
        /// <param name="personGroupBelonging">A PersonGroupBelonging object.</param>
        /// <returns>An updated PersonGroupBelonging object.</returns>
        public PersonGroupBelonging Create(PersonGroupBelonging personGroupBelonging)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.PersonGroupBelonging ([person_id], [group_id], [is_leader], [currently_in], [joined_date], [left_date]) " +
                "VALUES(@person_id, @group_id, @is_leader, @currently_in, @joined_date, @left_date);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@person_id", DbType.Int32, personGroupBelonging.person_id);
                db.AddInParameter(cmd, "@group_id", DbType.Int32, personGroupBelonging.group_id);
                db.AddInParameter(cmd, "@is_leader", DbType.Boolean, personGroupBelonging.is_leader);
                db.AddInParameter(cmd, "@currently_in", DbType.Boolean, personGroupBelonging.currently_in);
                db.AddInParameter(cmd, "@joined_date", DbType.DateTime, personGroupBelonging.joined_date);
                db.AddInParameter(cmd, "@left_date", DbType.DateTime, personGroupBelonging.left_date);

                db.ExecuteNonQuery(cmd);
            }

            return personGroupBelonging;
        }

        /// <summary>
        /// Updates an existing row in the PersonGroupBelonging table.
        /// </summary>
        /// <param name="personGroupBelonging">A PersonGroupBelonging entity object.</param>
        public void UpdateById(PersonGroupBelonging personGroupBelonging)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.PersonGroupBelonging " +
                "SET " +
                    "[is_leader]=@is_leader, " +
                    "[currently_in]=@currently_in, " +
                    "[joined_date]=@joined_date, " +
                    "[left_date]=@left_date " +
                "WHERE [person_id]=@person_id " +
                      "AND [group_id]=@group_id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@is_leader", DbType.Boolean, personGroupBelonging.is_leader);
                db.AddInParameter(cmd, "@currently_in", DbType.Boolean, personGroupBelonging.currently_in);
                db.AddInParameter(cmd, "@joined_date", DbType.DateTime, personGroupBelonging.joined_date);
                db.AddInParameter(cmd, "@left_date", DbType.DateTime, personGroupBelonging.left_date);
                db.AddInParameter(cmd, "@person_id", DbType.Int32, personGroupBelonging.person_id);
                db.AddInParameter(cmd, "@group_id", DbType.Int32, personGroupBelonging.group_id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the PersonGroupBelonging table.
        /// </summary>
        /// <param name="person_id">A person_id value.</param>
        public void DeleteById(int person_id)
        {
            const string SQL_STATEMENT = "DELETE dbo.PersonGroupBelonging " +
                                         "WHERE [person_id]=@person_id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@person_id", DbType.Int32, person_id);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Returns a row from the PersonGroupBelonging table.
        /// </summary>
        /// <param name="person_id">A person_id value.</param>
        /// <param name="group_id">A group_id value.</param>
        /// <returns>A PersonGroupBelonging object with data populated from the database.</returns>
        public PersonGroupBelonging SelectById(int person_id, int group_id)
        {
            const string SQL_STATEMENT =
                "SELECT [person_id], [group_id], [is_leader], [currently_in], [joined_date], [left_date]" +
                        " " +
                "FROM dbo.PersonGroupBelonging  " +
                "WHERE [person_id]=@person_id " +
                      "AND [group_id]=@group_id ";

            PersonGroupBelonging personGroupBelonging = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@person_id", DbType.Int32, person_id);
                db.AddInParameter(cmd, "@group_id", DbType.Int32, group_id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new PersonGroupBelonging
                        personGroupBelonging = new PersonGroupBelonging();

                        // Read values.
                        personGroupBelonging.person_id = base.GetDataValue<int>(dr, "person_id");
                        personGroupBelonging.group_id = base.GetDataValue<int>(dr, "group_id");
                        personGroupBelonging.is_leader = base.GetDataValue<bool>(dr, "is_leader");
                        personGroupBelonging.currently_in = base.GetDataValue<bool>(dr, "currently_in");
                        personGroupBelonging.joined_date = base.GetDataValue<DateTime>(dr, "joined_date");
                        personGroupBelonging.left_date = base.GetDataValue<DateTime>(dr, "left_date");
                    }
                }
            }

            return personGroupBelonging;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the PersonGroupBelonging table.
        /// </summary>
        /// <returns>A collection of PersonGroupBelonging objects.</returns>		
        public List<PersonGroupBelonging> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [person_id], [group_id], [is_leader], [currently_in], [joined_date], [left_date]" +
                        " " +
                "FROM dbo.PersonGroupBelonging ";

            List<PersonGroupBelonging> result = new List<PersonGroupBelonging>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new PersonGroupBelonging
                        PersonGroupBelonging personGroupBelonging = new PersonGroupBelonging();

                        // Read values.
                        personGroupBelonging.person_id = base.GetDataValue<int>(dr, "person_id");
                        personGroupBelonging.group_id = base.GetDataValue<int>(dr, "group_id");
                        personGroupBelonging.is_leader = base.GetDataValue<bool>(dr, "is_leader");
                        personGroupBelonging.currently_in = base.GetDataValue<bool>(dr, "currently_in");
                        personGroupBelonging.joined_date = base.GetDataValue<DateTime>(dr, "joined_date");
                        personGroupBelonging.left_date = base.GetDataValue<DateTime>(dr, "left_date");

                        // Add to List.
                        result.Add(personGroupBelonging);
                    }
                }
            }

            return result;
        }
    }
}


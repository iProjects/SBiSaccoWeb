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
    /// Districts data access component. Manages CRUD operations for the Districts table.
    /// </summary>
    public partial class DistrictDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Districts table.
        /// </summary>
        /// <param name="district">A District object.</param>
        /// <returns>An updated District object.</returns>
        public District Create(District district)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Districts ([name], [province_id], [deleted]) " +
                "VALUES(@name, @province_id, @deleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@name", DbType.String, district.name);
                db.AddInParameter(cmd, "@province_id", DbType.Int32, district.province_id);
                db.AddInParameter(cmd, "@deleted", DbType.Boolean, district.deleted);

                // Get the primary key value.
                district.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return district;
        }

        /// <summary>
        /// Updates an existing row in the Districts table.
        /// </summary>
        /// <param name="district">A District entity object.</param>
        public void UpdateById(District district)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Districts " +
                "SET " +
                    "[name]=@name, " +
                    "[province_id]=@province_id, " +
                    "[deleted]=@deleted " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@name", DbType.String, district.name);
                db.AddInParameter(cmd, "@province_id", DbType.Int32, district.province_id);
                db.AddInParameter(cmd, "@deleted", DbType.Boolean, district.deleted);
                db.AddInParameter(cmd, "@id", DbType.Int32, district.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the Districts table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.Districts " +
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
        /// Returns a row from the Districts table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A District object with data populated from the database.</returns>
        public District SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [name], [province_id], [deleted] " +
                "FROM dbo.Districts  " +
                "WHERE [id]=@id ";

            District district = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new District
                        district = new District();

                        // Read values.
                        district.id = base.GetDataValue<int>(dr, "id");
                        district.name = base.GetDataValue<string>(dr, "name");
                        district.province_id = base.GetDataValue<int>(dr, "province_id");
                        district.deleted = base.GetDataValue<bool>(dr, "deleted");
                    }
                }
            }

            return district;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Districts table.
        /// </summary>
        /// <returns>A collection of District objects.</returns>		
        public List<District> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [name], [province_id], [deleted] " +
                "FROM dbo.Districts ";

            List<District> result = new List<District>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new District
                        District district = new District();

                        // Read values.
                        district.id = base.GetDataValue<int>(dr, "id");
                        district.name = base.GetDataValue<string>(dr, "name");
                        district.province_id = base.GetDataValue<int>(dr, "province_id");
                        district.deleted = base.GetDataValue<bool>(dr, "deleted");

                        // Add to List.
                        result.Add(district);
                    }
                }
            }

            return result;
        }
    }
}


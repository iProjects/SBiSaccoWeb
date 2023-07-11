//====================================================================================================
// Base code generated with Momentum: DAC Gen (Build 2.5.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 12/31/2014 17:44:44 
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
    /// AdvancedFieldsEntities data access component. Manages CRUD operations for the AdvancedFieldsEntities table.
    /// </summary>
    public partial class AdvancedFieldsEntityDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the AdvancedFieldsEntities table.
        /// </summary>
        /// <param name="advancedFieldsEntity">A AdvancedFieldsEntity object.</param>
        /// <returns>An updated AdvancedFieldsEntity object.</returns>
        public AdvancedFieldsEntity Create(AdvancedFieldsEntity advancedFieldsEntity)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.AdvancedFieldsEntities ([name]) " +
                "VALUES(@name); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@name", DbType.String, advancedFieldsEntity.name);

                // Get the primary key value.
                advancedFieldsEntity.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return advancedFieldsEntity;
        }

        /// <summary>
        /// Updates an existing row in the AdvancedFieldsEntities table.
        /// </summary>
        /// <param name="advancedFieldsEntity">A AdvancedFieldsEntity entity object.</param>
        public void UpdateById(AdvancedFieldsEntity advancedFieldsEntity)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.AdvancedFieldsEntities " +
                "SET " +
                    "[name]=@name " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@name", DbType.String, advancedFieldsEntity.name);
                db.AddInParameter(cmd, "@id", DbType.Int32, advancedFieldsEntity.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the AdvancedFieldsEntities table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.AdvancedFieldsEntities " +
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
        /// Returns a row from the AdvancedFieldsEntities table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A AdvancedFieldsEntity object with data populated from the database.</returns>
        public AdvancedFieldsEntity SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [name] " +
                "FROM dbo.AdvancedFieldsEntities  " +
                "WHERE [id]=@id ";

            AdvancedFieldsEntity advancedFieldsEntity = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new AdvancedFieldsEntity
                        advancedFieldsEntity = new AdvancedFieldsEntity();

                        // Read values.
                        advancedFieldsEntity.id = base.GetDataValue<int>(dr, "id");
                        advancedFieldsEntity.name = base.GetDataValue<string>(dr, "name");
                    }
                }
            }

            return advancedFieldsEntity;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the AdvancedFieldsEntities table.
        /// </summary>
        /// <returns>A collection of AdvancedFieldsEntity objects.</returns>		
        public List<AdvancedFieldsEntity> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [name] " +
                "FROM dbo.AdvancedFieldsEntities ";

            List<AdvancedFieldsEntity> result = new List<AdvancedFieldsEntity>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new AdvancedFieldsEntity
                        AdvancedFieldsEntity advancedFieldsEntity = new AdvancedFieldsEntity();

                        // Read values.
                        advancedFieldsEntity.id = base.GetDataValue<int>(dr, "id");
                        advancedFieldsEntity.name = base.GetDataValue<string>(dr, "name");

                        // Add to List.
                        result.Add(advancedFieldsEntity);
                    }
                }
            }

            return result;
        }
    }
}

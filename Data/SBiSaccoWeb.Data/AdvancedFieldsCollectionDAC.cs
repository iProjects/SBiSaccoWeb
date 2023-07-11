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
    /// AdvancedFieldsCollections data access component. Manages CRUD operations for the AdvancedFieldsCollections table.
    /// </summary>
    public partial class AdvancedFieldsCollectionDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the AdvancedFieldsCollections table.
        /// </summary>
        /// <param name="advancedFieldsCollection">A AdvancedFieldsCollection object.</param>
        /// <returns>An updated AdvancedFieldsCollection object.</returns>
        public AdvancedFieldsCollection Create(AdvancedFieldsCollection advancedFieldsCollection)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.AdvancedFieldsCollections ([field_id], [value]) " +
                "VALUES(@field_id, @value); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@field_id", DbType.Int32, advancedFieldsCollection.field_id);
                db.AddInParameter(cmd, "@value", DbType.String, advancedFieldsCollection.value);

                // Get the primary key value.
                advancedFieldsCollection.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return advancedFieldsCollection;
        }

        /// <summary>
        /// Updates an existing row in the AdvancedFieldsCollections table.
        /// </summary>
        /// <param name="advancedFieldsCollection">A AdvancedFieldsCollection entity object.</param>
        public void UpdateById(AdvancedFieldsCollection advancedFieldsCollection)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.AdvancedFieldsCollections " +
                "SET " +
                    "[field_id]=@field_id, " +
                    "[value]=@value " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@field_id", DbType.Int32, advancedFieldsCollection.field_id);
                db.AddInParameter(cmd, "@value", DbType.String, advancedFieldsCollection.value);
                db.AddInParameter(cmd, "@id", DbType.Int32, advancedFieldsCollection.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the AdvancedFieldsCollections table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.AdvancedFieldsCollections " +
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
        /// Returns a row from the AdvancedFieldsCollections table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A AdvancedFieldsCollection object with data populated from the database.</returns>
        public AdvancedFieldsCollection SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [field_id], [value] " +
                "FROM dbo.AdvancedFieldsCollections  " +
                "WHERE [id]=@id ";

            AdvancedFieldsCollection advancedFieldsCollection = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new AdvancedFieldsCollection
                        advancedFieldsCollection = new AdvancedFieldsCollection();

                        // Read values.
                        advancedFieldsCollection.id = base.GetDataValue<int>(dr, "id");
                        advancedFieldsCollection.field_id = base.GetDataValue<int>(dr, "field_id");
                        advancedFieldsCollection.value = base.GetDataValue<string>(dr, "value");
                    }
                }
            }

            return advancedFieldsCollection;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the AdvancedFieldsCollections table.
        /// </summary>
        /// <returns>A collection of AdvancedFieldsCollection objects.</returns>		
        public List<AdvancedFieldsCollection> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [field_id], [value] " +
                "FROM dbo.AdvancedFieldsCollections ";

            List<AdvancedFieldsCollection> result = new List<AdvancedFieldsCollection>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new AdvancedFieldsCollection
                        AdvancedFieldsCollection advancedFieldsCollection = new AdvancedFieldsCollection();

                        // Read values.
                        advancedFieldsCollection.id = base.GetDataValue<int>(dr, "id");
                        advancedFieldsCollection.field_id = base.GetDataValue<int>(dr, "field_id");
                        advancedFieldsCollection.value = base.GetDataValue<string>(dr, "value");

                        // Add to List.
                        result.Add(advancedFieldsCollection);
                    }
                }
            }

            return result;
        }
    }
}


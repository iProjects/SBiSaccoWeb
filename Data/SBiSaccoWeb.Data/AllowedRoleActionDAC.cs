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
    /// AllowedRoleActions data access component. Manages CRUD operations for the AllowedRoleActions table.
    /// </summary>
    public partial class AllowedRoleActionDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the AllowedRoleActions table.
        /// </summary>
        /// <param name="allowedRoleAction">A AllowedRoleAction object.</param>
        /// <returns>An updated AllowedRoleAction object.</returns>
        public AllowedRoleAction Create(AllowedRoleAction allowedRoleAction)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.AllowedRoleActions ([action_item_id], [role_id], [allowed]) " +
                "VALUES(@action_item_id, @role_id, @allowed);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@action_item_id", DbType.Int32, allowedRoleAction.action_item_id);
                db.AddInParameter(cmd, "@role_id", DbType.Int32, allowedRoleAction.role_id);
                db.AddInParameter(cmd, "@allowed", DbType.Boolean, allowedRoleAction.allowed);

                db.ExecuteNonQuery(cmd);
            }

            return allowedRoleAction;
        }

        /// <summary>
        /// Updates an existing row in the AllowedRoleActions table.
        /// </summary>
        /// <param name="allowedRoleAction">A AllowedRoleAction entity object.</param>
        public void UpdateById(AllowedRoleAction allowedRoleAction)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.AllowedRoleActions " +
                "SET " +
                    "[allowed]=@allowed " +
                "WHERE [action_item_id]=@action_item_id " +
                      "AND [role_id]=@role_id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@allowed", DbType.Boolean, allowedRoleAction.allowed);
                db.AddInParameter(cmd, "@action_item_id", DbType.Int32, allowedRoleAction.action_item_id);
                db.AddInParameter(cmd, "@role_id", DbType.Int32, allowedRoleAction.role_id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the AllowedRoleActions table.
        /// </summary>
        /// <param name="action_item_id">A action_item_id value.</param>
        public void DeleteById(int action_item_id)
        {
            const string SQL_STATEMENT = "DELETE dbo.AllowedRoleActions " +
                                         "WHERE [action_item_id]=@action_item_id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@action_item_id", DbType.Int32, action_item_id);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Returns a row from the AllowedRoleActions table.
        /// </summary>
        /// <param name="action_item_id">A action_item_id value.</param>
        /// <param name="role_id">A role_id value.</param>
        /// <returns>A AllowedRoleAction object with data populated from the database.</returns>
        public AllowedRoleAction SelectById(int action_item_id, int role_id)
        {
            const string SQL_STATEMENT =
                "SELECT [action_item_id], [role_id], [allowed] " +
                "FROM dbo.AllowedRoleActions  " +
                "WHERE [action_item_id]=@action_item_id " +
                      "AND [role_id]=@role_id ";

            AllowedRoleAction allowedRoleAction = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@action_item_id", DbType.Int32, action_item_id);
                db.AddInParameter(cmd, "@role_id", DbType.Int32, role_id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new AllowedRoleAction
                        allowedRoleAction = new AllowedRoleAction();

                        // Read values.
                        allowedRoleAction.action_item_id = base.GetDataValue<int>(dr, "action_item_id");
                        allowedRoleAction.role_id = base.GetDataValue<int>(dr, "role_id");
                        allowedRoleAction.allowed = base.GetDataValue<bool>(dr, "allowed");
                    }
                }
            }

            return allowedRoleAction;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the AllowedRoleActions table.
        /// </summary>
        /// <returns>A collection of AllowedRoleAction objects.</returns>		
        public List<AllowedRoleAction> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [action_item_id], [role_id], [allowed] " +
                "FROM dbo.AllowedRoleActions ";

            List<AllowedRoleAction> result = new List<AllowedRoleAction>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new AllowedRoleAction
                        AllowedRoleAction allowedRoleAction = new AllowedRoleAction();

                        // Read values.
                        allowedRoleAction.action_item_id = base.GetDataValue<int>(dr, "action_item_id");
                        allowedRoleAction.role_id = base.GetDataValue<int>(dr, "role_id");
                        allowedRoleAction.allowed = base.GetDataValue<bool>(dr, "allowed");

                        // Add to List.
                        result.Add(allowedRoleAction);
                    }
                }
            }

            return result;
        }
    }
}


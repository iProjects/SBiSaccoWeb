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
    /// AllowedRoleMenus data access component. Manages CRUD operations for the AllowedRoleMenus table.
    /// </summary>
    public partial class AllowedRoleMenusDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the AllowedRoleMenus table.
        /// </summary>
        /// <param name="allowedRoleMenus">A AllowedRoleMenus object.</param>
        /// <returns>An updated AllowedRoleMenus object.</returns>
        public AllowedRoleMenus Create(AllowedRoleMenus allowedRoleMenus)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.AllowedRoleMenus ([menu_item_id], [role_id], [allowed]) " +
                "VALUES(@menu_item_id, @role_id, @allowed);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@menu_item_id", DbType.Int32, allowedRoleMenus.menu_item_id);
                db.AddInParameter(cmd, "@role_id", DbType.Int32, allowedRoleMenus.role_id);
                db.AddInParameter(cmd, "@allowed", DbType.Boolean, allowedRoleMenus.allowed);

                db.ExecuteNonQuery(cmd);
            }

            return allowedRoleMenus;
        }

        /// <summary>
        /// Updates an existing row in the AllowedRoleMenus table.
        /// </summary>
        /// <param name="allowedRoleMenus">A AllowedRoleMenus entity object.</param>
        public void UpdateById(AllowedRoleMenus allowedRoleMenus)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.AllowedRoleMenus " +
                "SET " +
                    "[allowed]=@allowed " +
                "WHERE [menu_item_id]=@menu_item_id " +
                      "AND [role_id]=@role_id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@allowed", DbType.Boolean, allowedRoleMenus.allowed);
                db.AddInParameter(cmd, "@menu_item_id", DbType.Int32, allowedRoleMenus.menu_item_id);
                db.AddInParameter(cmd, "@role_id", DbType.Int32, allowedRoleMenus.role_id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the AllowedRoleMenus table.
        /// </summary>
        /// <param name="menu_item_id">A menu_item_id value.</param>
        public void DeleteById(int menu_item_id)
        {
            const string SQL_STATEMENT = "DELETE dbo.AllowedRoleMenus " +
                                         "WHERE [menu_item_id]=@menu_item_id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@menu_item_id", DbType.Int32, menu_item_id);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Returns a row from the AllowedRoleMenus table.
        /// </summary>
        /// <param name="menu_item_id">A menu_item_id value.</param>
        /// <param name="role_id">A role_id value.</param>
        /// <returns>A AllowedRoleMenus object with data populated from the database.</returns>
        public AllowedRoleMenus SelectById(int menu_item_id, int role_id)
        {
            const string SQL_STATEMENT =
                "SELECT [menu_item_id], [role_id], [allowed] " +
                "FROM dbo.AllowedRoleMenus  " +
                "WHERE [menu_item_id]=@menu_item_id " +
                      "AND [role_id]=@role_id ";

            AllowedRoleMenus allowedRoleMenus = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@menu_item_id", DbType.Int32, menu_item_id);
                db.AddInParameter(cmd, "@role_id", DbType.Int32, role_id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new AllowedRoleMenus
                        allowedRoleMenus = new AllowedRoleMenus();

                        // Read values.
                        allowedRoleMenus.menu_item_id = base.GetDataValue<int>(dr, "menu_item_id");
                        allowedRoleMenus.role_id = base.GetDataValue<int>(dr, "role_id");
                        allowedRoleMenus.allowed = base.GetDataValue<bool>(dr, "allowed");
                    }
                }
            }

            return allowedRoleMenus;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the AllowedRoleMenus table.
        /// </summary>
        /// <returns>A collection of AllowedRoleMenus objects.</returns>		
        public List<AllowedRoleMenus> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [menu_item_id], [role_id], [allowed] " +
                "FROM dbo.AllowedRoleMenus ";

            List<AllowedRoleMenus> result = new List<AllowedRoleMenus>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new AllowedRoleMenus
                        AllowedRoleMenus allowedRoleMenus = new AllowedRoleMenus();

                        // Read values.
                        allowedRoleMenus.menu_item_id = base.GetDataValue<int>(dr, "menu_item_id");
                        allowedRoleMenus.role_id = base.GetDataValue<int>(dr, "role_id");
                        allowedRoleMenus.allowed = base.GetDataValue<bool>(dr, "allowed");

                        // Add to List.
                        result.Add(allowedRoleMenus);
                    }
                }
            }

            return result;
        }
    }
}


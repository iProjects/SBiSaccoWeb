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
    /// MenuItems data access component. Manages CRUD operations for the MenuItems table.
    /// </summary>
    public partial class MenuItemDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the MenuItems table.
        /// </summary>
        /// <param name="menuItem">A MenuItem object.</param>
        /// <returns>An updated MenuItem object.</returns>
        public MenuItem Create(MenuItem menuItem)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.MenuItems ([component_name], [type]) " +
                "VALUES(@component_name, @type); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@component_name", DbType.String, menuItem.component_name);
                db.AddInParameter(cmd, "@type", DbType.Int32, menuItem.type);

                // Get the primary key value.
                menuItem.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return menuItem;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the MenuItems table.
        /// </summary>
        /// <returns>A collection of MenuItem objects.</returns>		
        public List<MenuItem> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [component_name], [type] " +
                "FROM dbo.MenuItems ";

            List<MenuItem> result = new List<MenuItem>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new MenuItem
                        MenuItem menuItem = new MenuItem();

                        // Read values.
                        menuItem.id = base.GetDataValue<int>(dr, "id");
                        menuItem.component_name = base.GetDataValue<string>(dr, "component_name");
                        menuItem.type = base.GetDataValue<int>(dr, "type");

                        // Add to List.
                        result.Add(menuItem);
                    }
                }
            }

            return result;
        }
    }
}

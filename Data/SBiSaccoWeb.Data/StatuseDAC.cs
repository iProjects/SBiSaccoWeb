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
    /// Statuses data access component. Manages CRUD operations for the Statuses table.
    /// </summary>
    public partial class StatuseDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Statuses table.
        /// </summary>
        /// <param name="statuse">A Statuse object.</param>
        /// <returns>An updated Statuse object.</returns>
        public Statuse Create(Statuse statuse)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Statuses ([status_name]) " +
                "VALUES(@status_name); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@status_name", DbType.String, statuse.status_name);

                // Get the primary key value.
                statuse.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return statuse;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Statuses table.
        /// </summary>
        /// <returns>A collection of Statuse objects.</returns>		
        public List<Statuse> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [status_name] " +
                "FROM dbo.Statuses ";

            List<Statuse> result = new List<Statuse>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Statuse
                        Statuse statuse = new Statuse();

                        // Read values.
                        statuse.id = base.GetDataValue<int>(dr, "id");
                        statuse.status_name = base.GetDataValue<string>(dr, "status_name");

                        // Add to List.
                        result.Add(statuse);
                    }
                }
            }

            return result;
        }
    }
}

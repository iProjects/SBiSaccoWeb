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
    /// GeneralParameters data access component. Manages CRUD operations for the GeneralParameters table.
    /// </summary>
    public partial class GeneralParameterDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the GeneralParameters table.
        /// </summary>
        /// <param name="generalParameter">A GeneralParameter object.</param>
        /// <returns>An updated GeneralParameter object.</returns>
        public GeneralParameter Create(GeneralParameter generalParameter)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.GeneralParameters ([key], [value]) " +
                "VALUES(@key, @value);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@key", DbType.AnsiString, generalParameter.key);
                db.AddInParameter(cmd, "@value", DbType.String, generalParameter.value);

                db.ExecuteNonQuery(cmd);
            }

            return generalParameter;
        }

        /// <summary>
        /// Updates an existing row in the GeneralParameters table.
        /// </summary>
        /// <param name="generalParameter">A GeneralParameter entity object.</param>
        public void UpdateById(GeneralParameter generalParameter)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.GeneralParameters " +
                "SET " +
                    "[value]=@value " +
                "WHERE [key]=@key ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@value", DbType.String, generalParameter.value);
                db.AddInParameter(cmd, "@key", DbType.AnsiString, generalParameter.key);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the GeneralParameters table.
        /// </summary>
        /// <param name="key">A key value.</param>
        public void DeleteById(string key)
        {
            const string SQL_STATEMENT = "DELETE dbo.GeneralParameters " +
                                         "WHERE [key]=@key ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@key", DbType.AnsiString, key);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Returns a row from the GeneralParameters table.
        /// </summary>
        /// <param name="key">A key value.</param>
        /// <returns>A GeneralParameter object with data populated from the database.</returns>
        public GeneralParameter SelectById(string key)
        {
            const string SQL_STATEMENT =
                "SELECT [key], [value] " +
                "FROM dbo.GeneralParameters  " +
                "WHERE [key]=@key ";

            GeneralParameter generalParameter = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@key", DbType.AnsiString, key);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new GeneralParameter
                        generalParameter = new GeneralParameter();

                        // Read values.
                        generalParameter.key = base.GetDataValue<string>(dr, "key");
                        generalParameter.value = base.GetDataValue<string>(dr, "value");
                    }
                }
            }

            return generalParameter;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the GeneralParameters table.
        /// </summary>
        /// <returns>A collection of GeneralParameter objects.</returns>		
        public List<GeneralParameter> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [key], [value] " +
                "FROM dbo.GeneralParameters ";

            List<GeneralParameter> result = new List<GeneralParameter>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new GeneralParameter
                        GeneralParameter generalParameter = new GeneralParameter();

                        // Read values.
                        generalParameter.key = base.GetDataValue<string>(dr, "key");
                        generalParameter.value = base.GetDataValue<string>(dr, "value");

                        // Add to List.
                        result.Add(generalParameter);
                    }
                }
            }

            return result;
        }
    }
}


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
    /// ProvisioningRules data access component. Manages CRUD operations for the ProvisioningRules table.
    /// </summary>
    public partial class ProvisioningRuleDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the ProvisioningRules table.
        /// </summary>
        /// <param name="provisioningRule">A ProvisioningRule object.</param>
        /// <returns>An updated ProvisioningRule object.</returns>
        public ProvisioningRule Create(ProvisioningRule provisioningRule)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.ProvisioningRules ([id], [number_of_days_min], [number_of_days_max], [provisioning_value]) " +
                "VALUES(@id, @number_of_days_min, @number_of_days_max, @provisioning_value);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@id", DbType.Int32, provisioningRule.id);
                db.AddInParameter(cmd, "@number_of_days_min", DbType.Int32, provisioningRule.number_of_days_min);
                db.AddInParameter(cmd, "@number_of_days_max", DbType.Int32, provisioningRule.number_of_days_max);
                db.AddInParameter(cmd, "@provisioning_value", DbType.Double, provisioningRule.provisioning_value);

                db.ExecuteNonQuery(cmd);
            }

            return provisioningRule;
        }

        /// <summary>
        /// Updates an existing row in the ProvisioningRules table.
        /// </summary>
        /// <param name="provisioningRule">A ProvisioningRule entity object.</param>
        public void UpdateById(ProvisioningRule provisioningRule)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.ProvisioningRules " +
                "SET " +
                    "[number_of_days_min]=@number_of_days_min, " +
                    "[number_of_days_max]=@number_of_days_max, " +
                    "[provisioning_value]=@provisioning_value " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@number_of_days_min", DbType.Int32, provisioningRule.number_of_days_min);
                db.AddInParameter(cmd, "@number_of_days_max", DbType.Int32, provisioningRule.number_of_days_max);
                db.AddInParameter(cmd, "@provisioning_value", DbType.Double, provisioningRule.provisioning_value);
                db.AddInParameter(cmd, "@id", DbType.Int32, provisioningRule.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the ProvisioningRules table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.ProvisioningRules " +
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
        /// Returns a row from the ProvisioningRules table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A ProvisioningRule object with data populated from the database.</returns>
        public ProvisioningRule SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [number_of_days_min], [number_of_days_max], [provisioning_value] " +
                "FROM dbo.ProvisioningRules  " +
                "WHERE [id]=@id ";

            ProvisioningRule provisioningRule = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new ProvisioningRule
                        provisioningRule = new ProvisioningRule();

                        // Read values.
                        provisioningRule.id = base.GetDataValue<int>(dr, "id");
                        provisioningRule.number_of_days_min = base.GetDataValue<int>(dr, "number_of_days_min");
                        provisioningRule.number_of_days_max = base.GetDataValue<int>(dr, "number_of_days_max");
                        provisioningRule.provisioning_value = base.GetDataValue<double>(dr, "provisioning_value");
                    }
                }
            }

            return provisioningRule;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the ProvisioningRules table.
        /// </summary>
        /// <returns>A collection of ProvisioningRule objects.</returns>		
        public List<ProvisioningRule> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [number_of_days_min], [number_of_days_max], [provisioning_value] " +
                "FROM dbo.ProvisioningRules ";

            List<ProvisioningRule> result = new List<ProvisioningRule>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new ProvisioningRule
                        ProvisioningRule provisioningRule = new ProvisioningRule();

                        // Read values.
                        provisioningRule.id = base.GetDataValue<int>(dr, "id");
                        provisioningRule.number_of_days_min = base.GetDataValue<int>(dr, "number_of_days_min");
                        provisioningRule.number_of_days_max = base.GetDataValue<int>(dr, "number_of_days_max");
                        provisioningRule.provisioning_value = base.GetDataValue<double>(dr, "provisioning_value");

                        // Add to List.
                        result.Add(provisioningRule);
                    }
                }
            }

            return result;
        }
    }
}


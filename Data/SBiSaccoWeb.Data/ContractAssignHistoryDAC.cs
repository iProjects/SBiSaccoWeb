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
    /// ContractAssignHistory data access component. Manages CRUD operations for the ContractAssignHistory table.
    /// </summary>
    public partial class ContractAssignHistoryDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the ContractAssignHistory table.
        /// </summary>
        /// <param name="contractAssignHistory">A ContractAssignHistory object.</param>
        /// <returns>An updated ContractAssignHistory object.</returns>
        public ContractAssignHistory Create(ContractAssignHistory contractAssignHistory)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.ContractAssignHistory ([DateChanged], [loanofficerFrom_id], [loanofficerTo_id], [contract_id]) " +
                "VALUES(@DateChanged, @loanofficerFrom_id, @loanofficerTo_id, @contract_id); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@DateChanged", DbType.DateTime, contractAssignHistory.DateChanged);
                db.AddInParameter(cmd, "@loanofficerFrom_id", DbType.Int32, contractAssignHistory.loanofficerFrom_id);
                db.AddInParameter(cmd, "@loanofficerTo_id", DbType.Int32, contractAssignHistory.loanofficerTo_id);
                db.AddInParameter(cmd, "@contract_id", DbType.Int32, contractAssignHistory.contract_id);

                // Get the primary key value.
                contractAssignHistory.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return contractAssignHistory;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the ContractAssignHistory table.
        /// </summary>
        /// <returns>A collection of ContractAssignHistory objects.</returns>		
        public List<ContractAssignHistory> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [DateChanged], [loanofficerFrom_id], [loanofficerTo_id], [contract_id] " +
                "FROM dbo.ContractAssignHistory ";

            List<ContractAssignHistory> result = new List<ContractAssignHistory>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new ContractAssignHistory
                        ContractAssignHistory contractAssignHistory = new ContractAssignHistory();

                        // Read values.
                        contractAssignHistory.id = base.GetDataValue<int>(dr, "id");
                        contractAssignHistory.DateChanged = base.GetDataValue<DateTime>(dr, "DateChanged");
                        contractAssignHistory.loanofficerFrom_id = base.GetDataValue<int>(dr, "loanofficerFrom_id");
                        contractAssignHistory.loanofficerTo_id = base.GetDataValue<int>(dr, "loanofficerTo_id");
                        contractAssignHistory.contract_id = base.GetDataValue<int>(dr, "contract_id");

                        // Add to List.
                        result.Add(contractAssignHistory);
                    }
                }
            }

            return result;
        }
    }
}


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
    /// Rep_Active_Loans_Data data access component. Manages CRUD operations for the Rep_Active_Loans_Data table.
    /// </summary>
    public partial class Rep_Active_Loans_DataDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Rep_Active_Loans_Data table.
        /// </summary>
        /// <param name="rep_Active_Loans_Data">A Rep_Active_Loans_Data object.</param>
        /// <returns>An updated Rep_Active_Loans_Data object.</returns>
        public Rep_Active_Loans_Data Create(Rep_Active_Loans_Data rep_Active_Loans_Data)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Rep_Active_Loans_Data ([id], [branch_name], [load_date], [break_down], [break_down_type], [contracts], [individual], [group], [corporate], [clients], [in_groups], [projects], [olb], [break_down_id]) " +
                "VALUES(@id, @branch_name, @load_date, @break_down, @break_down_type, @contracts, @individual, @group, @corporate, @clients, @in_groups, @projects, @olb, @break_down_id);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@id", DbType.Int32, rep_Active_Loans_Data.id);
                db.AddInParameter(cmd, "@branch_name", DbType.String, rep_Active_Loans_Data.branch_name);
                db.AddInParameter(cmd, "@load_date", DbType.DateTime, rep_Active_Loans_Data.load_date);
                db.AddInParameter(cmd, "@break_down", DbType.String, rep_Active_Loans_Data.break_down);
                db.AddInParameter(cmd, "@break_down_type", DbType.String, rep_Active_Loans_Data.break_down_type);
                db.AddInParameter(cmd, "@contracts", DbType.Int32, rep_Active_Loans_Data.contracts);
                db.AddInParameter(cmd, "@individual", DbType.Int32, rep_Active_Loans_Data.individual);
                db.AddInParameter(cmd, "@group", DbType.Int32, rep_Active_Loans_Data.group);
                db.AddInParameter(cmd, "@corporate", DbType.Int32, rep_Active_Loans_Data.corporate);
                db.AddInParameter(cmd, "@clients", DbType.Int32, rep_Active_Loans_Data.clients);
                db.AddInParameter(cmd, "@in_groups", DbType.Int32, rep_Active_Loans_Data.in_groups);
                db.AddInParameter(cmd, "@projects", DbType.Int32, rep_Active_Loans_Data.projects);
                db.AddInParameter(cmd, "@olb", DbType.Currency, rep_Active_Loans_Data.olb);
                db.AddInParameter(cmd, "@break_down_id", DbType.Int32, rep_Active_Loans_Data.break_down_id);

                db.ExecuteNonQuery(cmd);
            }

            return rep_Active_Loans_Data;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Rep_Active_Loans_Data table.
        /// </summary>
        /// <returns>A collection of Rep_Active_Loans_Data objects.</returns>		
        public List<Rep_Active_Loans_Data> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [branch_name], [load_date], [break_down], [break_down_type], [contracts], [individual]" +
                        ", [group], [corporate], [clients], [in_groups], [projects], [olb], [break_down_id]" +
                        " " +
                "FROM dbo.Rep_Active_Loans_Data ";

            List<Rep_Active_Loans_Data> result = new List<Rep_Active_Loans_Data>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Rep_Active_Loans_Data
                        Rep_Active_Loans_Data rep_Active_Loans_Data = new Rep_Active_Loans_Data();

                        // Read values.
                        rep_Active_Loans_Data.id = base.GetDataValue<int>(dr, "id");
                        rep_Active_Loans_Data.branch_name = base.GetDataValue<string>(dr, "branch_name");
                        rep_Active_Loans_Data.load_date = base.GetDataValue<DateTime>(dr, "load_date");
                        rep_Active_Loans_Data.break_down = base.GetDataValue<string>(dr, "break_down");
                        rep_Active_Loans_Data.break_down_type = base.GetDataValue<string>(dr, "break_down_type");
                        rep_Active_Loans_Data.contracts = base.GetDataValue<int>(dr, "contracts");
                        rep_Active_Loans_Data.individual = base.GetDataValue<int>(dr, "individual");
                        rep_Active_Loans_Data.group = base.GetDataValue<int>(dr, "group");
                        rep_Active_Loans_Data.corporate = base.GetDataValue<int>(dr, "corporate");
                        rep_Active_Loans_Data.clients = base.GetDataValue<int>(dr, "clients");
                        rep_Active_Loans_Data.in_groups = base.GetDataValue<int>(dr, "in_groups");
                        rep_Active_Loans_Data.projects = base.GetDataValue<int>(dr, "projects");
                        rep_Active_Loans_Data.olb = base.GetDataValue<decimal>(dr, "olb");
                        rep_Active_Loans_Data.break_down_id = base.GetDataValue<int>(dr, "break_down_id");

                        // Add to List.
                        result.Add(rep_Active_Loans_Data);
                    }
                }
            }

            return result;
        }
    }
}


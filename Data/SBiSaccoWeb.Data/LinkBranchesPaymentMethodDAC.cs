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
    /// LinkBranchesPaymentMethods data access component. Manages CRUD operations for the LinkBranchesPaymentMethods table.
    /// </summary>
    public partial class LinkBranchesPaymentMethodDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the LinkBranchesPaymentMethods table.
        /// </summary>
        /// <param name="linkBranchesPaymentMethod">A LinkBranchesPaymentMethod object.</param>
        /// <returns>An updated LinkBranchesPaymentMethod object.</returns>
        public LinkBranchesPaymentMethod Create(LinkBranchesPaymentMethod linkBranchesPaymentMethod)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.LinkBranchesPaymentMethods ([branch_id], [payment_method_id], [deleted], [date]) " +
                "VALUES(@branch_id, @payment_method_id, @deleted, @date); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@branch_id", DbType.Int32, linkBranchesPaymentMethod.branch_id);
                db.AddInParameter(cmd, "@payment_method_id", DbType.Int32, linkBranchesPaymentMethod.payment_method_id);
                db.AddInParameter(cmd, "@deleted", DbType.Boolean, linkBranchesPaymentMethod.deleted);
                db.AddInParameter(cmd, "@date", DbType.DateTime, linkBranchesPaymentMethod.date);

                // Get the primary key value.
                linkBranchesPaymentMethod.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return linkBranchesPaymentMethod;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the LinkBranchesPaymentMethods table.
        /// </summary>
        /// <returns>A collection of LinkBranchesPaymentMethod objects.</returns>		
        public List<LinkBranchesPaymentMethod> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [branch_id], [payment_method_id], [deleted], [date] " +
                "FROM dbo.LinkBranchesPaymentMethods ";

            List<LinkBranchesPaymentMethod> result = new List<LinkBranchesPaymentMethod>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new LinkBranchesPaymentMethod
                        LinkBranchesPaymentMethod linkBranchesPaymentMethod = new LinkBranchesPaymentMethod();

                        // Read values.
                        linkBranchesPaymentMethod.id = base.GetDataValue<int>(dr, "id");
                        linkBranchesPaymentMethod.branch_id = base.GetDataValue<int>(dr, "branch_id");
                        linkBranchesPaymentMethod.payment_method_id = base.GetDataValue<int>(dr, "payment_method_id");
                        linkBranchesPaymentMethod.deleted = base.GetDataValue<bool>(dr, "deleted");
                        linkBranchesPaymentMethod.date = base.GetDataValue<DateTime>(dr, "date");

                        // Add to List.
                        result.Add(linkBranchesPaymentMethod);
                    }
                }
            }

            return result;
        }
    }
}


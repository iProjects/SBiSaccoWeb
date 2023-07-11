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
    /// webpages_OAuthMembership data access component. Manages CRUD operations for the webpages_OAuthMembership table.
    /// </summary>
    public partial class webpages_OAuthMembershipDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the webpages_OAuthMembership table.
        /// </summary>
        /// <param name="webpages_OAuthMembership">A webpages_OAuthMembership object.</param>
        /// <returns>An updated webpages_OAuthMembership object.</returns>
        public webpages_OAuthMembership Create(webpages_OAuthMembership webpages_OAuthMembership)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.webpages_OAuthMembership ([Provider], [ProviderUserId], [UserId]) " +
                "VALUES(@Provider, @ProviderUserId, @UserId);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Provider", DbType.String, webpages_OAuthMembership.Provider);
                db.AddInParameter(cmd, "@ProviderUserId", DbType.String, webpages_OAuthMembership.ProviderUserId);
                db.AddInParameter(cmd, "@UserId", DbType.Int32, webpages_OAuthMembership.UserId);

                db.ExecuteNonQuery(cmd);
            }

            return webpages_OAuthMembership;
        }

        /// <summary>
        /// Updates an existing row in the webpages_OAuthMembership table.
        /// </summary>
        /// <param name="webpages_OAuthMembership">A webpages_OAuthMembership entity object.</param>
        public void UpdateById(webpages_OAuthMembership webpages_OAuthMembership)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.webpages_OAuthMembership " +
                "SET " +
                    "[UserId]=@UserId " +
                "WHERE [Provider]=@Provider " +
                      "AND [ProviderUserId]=@ProviderUserId ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@UserId", DbType.Int32, webpages_OAuthMembership.UserId);
                db.AddInParameter(cmd, "@Provider", DbType.String, webpages_OAuthMembership.Provider);
                db.AddInParameter(cmd, "@ProviderUserId", DbType.String, webpages_OAuthMembership.ProviderUserId);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the webpages_OAuthMembership table.
        /// </summary>
        /// <param name="provider">A provider value.</param>
        public void DeleteById(string provider)
        {
            const string SQL_STATEMENT = "DELETE dbo.webpages_OAuthMembership " +
                                         "WHERE [Provider]=@Provider ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Provider", DbType.String, provider);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Returns a row from the webpages_OAuthMembership table.
        /// </summary>
        /// <param name="provider">A Provider value.</param>
        /// <param name="providerUserId">A ProviderUserId value.</param>
        /// <returns>A webpages_OAuthMembership object with data populated from the database.</returns>
        public webpages_OAuthMembership SelectById(string provider, string providerUserId)
        {
            const string SQL_STATEMENT =
                "SELECT [Provider], [ProviderUserId], [UserId] " +
                "FROM dbo.webpages_OAuthMembership  " +
                "WHERE [Provider]=@Provider " +
                      "AND [ProviderUserId]=@ProviderUserId ";

            webpages_OAuthMembership webpages_OAuthMembership = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Provider", DbType.String, provider);
                db.AddInParameter(cmd, "@ProviderUserId", DbType.String, providerUserId);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new webpages_OAuthMembership
                        webpages_OAuthMembership = new webpages_OAuthMembership();

                        // Read values.
                        webpages_OAuthMembership.Provider = base.GetDataValue<string>(dr, "Provider");
                        webpages_OAuthMembership.ProviderUserId = base.GetDataValue<string>(dr, "ProviderUserId");
                        webpages_OAuthMembership.UserId = base.GetDataValue<int>(dr, "UserId");
                    }
                }
            }

            return webpages_OAuthMembership;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the webpages_OAuthMembership table.
        /// </summary>
        /// <returns>A collection of webpages_OAuthMembership objects.</returns>		
        public List<webpages_OAuthMembership> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Provider], [ProviderUserId], [UserId] " +
                "FROM dbo.webpages_OAuthMembership ";

            List<webpages_OAuthMembership> result = new List<webpages_OAuthMembership>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new webpages_OAuthMembership
                        webpages_OAuthMembership webpages_OAuthMembership = new webpages_OAuthMembership();

                        // Read values.
                        webpages_OAuthMembership.Provider = base.GetDataValue<string>(dr, "Provider");
                        webpages_OAuthMembership.ProviderUserId = base.GetDataValue<string>(dr, "ProviderUserId");
                        webpages_OAuthMembership.UserId = base.GetDataValue<int>(dr, "UserId");

                        // Add to List.
                        result.Add(webpages_OAuthMembership);
                    }
                }
            }

            return result;
        }
    }
}

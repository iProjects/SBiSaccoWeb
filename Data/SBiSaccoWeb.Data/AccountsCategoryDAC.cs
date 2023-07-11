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
    /// AccountsCategory data access component. Manages CRUD operations for the AccountsCategory table.
    /// </summary>
    public partial class AccountsCategoryDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the AccountsCategory table.
        /// </summary>
        /// <param name="accountsCategory">A AccountsCategory object.</param>
        /// <returns>An updated AccountsCategory object.</returns>
        public AccountsCategory Create(AccountsCategory accountsCategory)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.AccountsCategory ([name]) " +
                "VALUES(@name); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@name", DbType.String, accountsCategory.name);

                // Get the primary key value.
                accountsCategory.id = Convert.ToInt16(db.ExecuteScalar(cmd));
            }

            return accountsCategory;
        }

        /// <summary>
        /// Updates an existing row in the AccountsCategory table.
        /// </summary>
        /// <param name="accountsCategory">A AccountsCategory entity object.</param>
        public void UpdateById(AccountsCategory accountsCategory)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.AccountsCategory " +
                "SET " +
                    "[name]=@name " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@name", DbType.String, accountsCategory.name);
                db.AddInParameter(cmd, "@id", DbType.Int16, accountsCategory.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the AccountsCategory table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(short id)
        {
            const string SQL_STATEMENT = "DELETE dbo.AccountsCategory " +
                                         "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@id", DbType.Int16, id);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Returns a row from the AccountsCategory table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A AccountsCategory object with data populated from the database.</returns>
        public AccountsCategory SelectById(short id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [name] " +
                "FROM dbo.AccountsCategory  " +
                "WHERE [id]=@id ";

            AccountsCategory accountsCategory = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int16, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new AccountsCategory
                        accountsCategory = new AccountsCategory();

                        // Read values.
                        accountsCategory.id = base.GetDataValue<short>(dr, "id");
                        accountsCategory.name = base.GetDataValue<string>(dr, "name");
                    }
                }
            }

            return accountsCategory;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the AccountsCategory table.
        /// </summary>
        /// <returns>A collection of AccountsCategory objects.</returns>		
        public List<AccountsCategory> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [name] " +
                "FROM dbo.AccountsCategory ";

            List<AccountsCategory> result = new List<AccountsCategory>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new AccountsCategory
                        AccountsCategory accountsCategory = new AccountsCategory();

                        // Read values.
                        accountsCategory.id = base.GetDataValue<short>(dr, "id");
                        accountsCategory.name = base.GetDataValue<string>(dr, "name");

                        // Add to List.
                        result.Add(accountsCategory);
                    }
                }
            }

            return result;
        }
    }
}

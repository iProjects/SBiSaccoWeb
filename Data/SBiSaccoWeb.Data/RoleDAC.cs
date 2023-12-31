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
    /// Roles data access component. Manages CRUD operations for the Roles table.
    /// </summary>
    public partial class RoleDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Roles table.
        /// </summary>
        /// <param name="role">A Role object.</param>
        /// <returns>An updated Role object.</returns>
        public Role Create(Role role)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Roles ([code], [deleted], [description], [role_of_loan], [role_of_saving], [role_of_teller]) " +
                "VALUES(@code, @deleted, @description, @role_of_loan, @role_of_saving, @role_of_teller); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@code", DbType.String, role.code);
                db.AddInParameter(cmd, "@deleted", DbType.Boolean, role.deleted);
                db.AddInParameter(cmd, "@description", DbType.String, role.description);
                db.AddInParameter(cmd, "@role_of_loan", DbType.Boolean, role.role_of_loan);
                db.AddInParameter(cmd, "@role_of_saving", DbType.Boolean, role.role_of_saving);
                db.AddInParameter(cmd, "@role_of_teller", DbType.Boolean, role.role_of_teller);

                // Get the primary key value.
                role.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return role;
        }

        /// <summary>
        /// Updates an existing row in the Roles table.
        /// </summary>
        /// <param name="role">A Role entity object.</param>
        public void UpdateById(Role role)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Roles " +
                "SET " +
                    "[code]=@code, " +
                    "[deleted]=@deleted, " +
                    "[description]=@description, " +
                    "[role_of_loan]=@role_of_loan, " +
                    "[role_of_saving]=@role_of_saving, " +
                    "[role_of_teller]=@role_of_teller " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@code", DbType.String, role.code);
                db.AddInParameter(cmd, "@deleted", DbType.Boolean, role.deleted);
                db.AddInParameter(cmd, "@description", DbType.String, role.description);
                db.AddInParameter(cmd, "@role_of_loan", DbType.Boolean, role.role_of_loan);
                db.AddInParameter(cmd, "@role_of_saving", DbType.Boolean, role.role_of_saving);
                db.AddInParameter(cmd, "@role_of_teller", DbType.Boolean, role.role_of_teller);
                db.AddInParameter(cmd, "@id", DbType.Int32, role.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the Roles table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.Roles " +
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
        /// Returns a row from the Roles table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A Role object with data populated from the database.</returns>
        public Role SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [code], [deleted], [description], [role_of_loan], [role_of_saving], [role_of_teller]" +
                        " " +
                "FROM dbo.Roles  " +
                "WHERE [id]=@id ";

            Role role = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new Role
                        role = new Role();

                        // Read values.
                        role.id = base.GetDataValue<int>(dr, "id");
                        role.code = base.GetDataValue<string>(dr, "code");
                        role.deleted = base.GetDataValue<bool>(dr, "deleted");
                        role.description = base.GetDataValue<string>(dr, "description");
                        role.role_of_loan = base.GetDataValue<bool>(dr, "role_of_loan");
                        role.role_of_saving = base.GetDataValue<bool>(dr, "role_of_saving");
                        role.role_of_teller = base.GetDataValue<bool>(dr, "role_of_teller");
                    }
                }
            }

            return role;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Roles table.
        /// </summary>
        /// <returns>A collection of Role objects.</returns>		
        public List<Role> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [code], [deleted], [description], [role_of_loan], [role_of_saving], [role_of_teller]" +
                        " " +
                "FROM dbo.Roles ";

            List<Role> result = new List<Role>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Role
                        Role role = new Role();

                        // Read values.
                        role.id = base.GetDataValue<int>(dr, "id");
                        role.code = base.GetDataValue<string>(dr, "code");
                        role.deleted = base.GetDataValue<bool>(dr, "deleted");
                        role.description = base.GetDataValue<string>(dr, "description");
                        role.role_of_loan = base.GetDataValue<bool>(dr, "role_of_loan");
                        role.role_of_saving = base.GetDataValue<bool>(dr, "role_of_saving");
                        role.role_of_teller = base.GetDataValue<bool>(dr, "role_of_teller");

                        // Add to List.
                        result.Add(role);
                    }
                }
            }

            return result;
        }
    }
}


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
    /// Users data access component. Manages CRUD operations for the Users table.
    /// </summary>
    public partial class UserDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Users table.
        /// </summary>
        /// <param name="user">A User object.</param>
        /// <returns>An updated User object.</returns>
        public User Create(User user)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Users ([deleted], [user_name], [user_pass], [role_code], [first_name], [last_name], [mail], [sex], [phone]) " +
                "VALUES(@deleted, @user_name, @user_pass, @role_code, @first_name, @last_name, @mail, @sex, @phone); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@deleted", DbType.Boolean, user.deleted);
                db.AddInParameter(cmd, "@user_name", DbType.String, user.user_name);
                db.AddInParameter(cmd, "@user_pass", DbType.String, user.user_pass);
                db.AddInParameter(cmd, "@role_code", DbType.String, user.role_code);
                db.AddInParameter(cmd, "@first_name", DbType.String, user.first_name);
                db.AddInParameter(cmd, "@last_name", DbType.String, user.last_name);
                db.AddInParameter(cmd, "@mail", DbType.String, user.mail);
                db.AddInParameter(cmd, "@sex", DbType.StringFixedLength, user.sex);
                db.AddInParameter(cmd, "@phone", DbType.String, user.phone);

                // Get the primary key value.
                user.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return user;
        }

        /// <summary>
        /// Updates an existing row in the Users table.
        /// </summary>
        /// <param name="user">A User entity object.</param>
        public void UpdateById(User user)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Users " +
                "SET " +
                    "[deleted]=@deleted, " +
                    "[user_name]=@user_name, " +
                    "[user_pass]=@user_pass, " +
                    "[role_code]=@role_code, " +
                    "[first_name]=@first_name, " +
                    "[last_name]=@last_name, " +
                    "[mail]=@mail, " +
                    "[sex]=@sex, " +
                    "[phone]=@phone " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@deleted", DbType.Boolean, user.deleted);
                db.AddInParameter(cmd, "@user_name", DbType.String, user.user_name);
                db.AddInParameter(cmd, "@user_pass", DbType.String, user.user_pass);
                db.AddInParameter(cmd, "@role_code", DbType.String, user.role_code);
                db.AddInParameter(cmd, "@first_name", DbType.String, user.first_name);
                db.AddInParameter(cmd, "@last_name", DbType.String, user.last_name);
                db.AddInParameter(cmd, "@mail", DbType.String, user.mail);
                db.AddInParameter(cmd, "@sex", DbType.StringFixedLength, user.sex);
                db.AddInParameter(cmd, "@phone", DbType.String, user.phone);
                db.AddInParameter(cmd, "@id", DbType.Int32, user.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the Users table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.Users " +
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
        /// Returns a row from the Users table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A User object with data populated from the database.</returns>
        public User SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [deleted], [user_name], [user_pass], [role_code], [first_name], [last_name]" +
                        ", [mail], [sex], [phone] " +
                "FROM dbo.Users  " +
                "WHERE [id]=@id ";

            User user = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new User
                        user = new User();

                        // Read values.
                        user.id = base.GetDataValue<int>(dr, "id");
                        user.deleted = base.GetDataValue<bool>(dr, "deleted");
                        user.user_name = base.GetDataValue<string>(dr, "user_name");
                        user.user_pass = base.GetDataValue<string>(dr, "user_pass");
                        user.role_code = base.GetDataValue<string>(dr, "role_code");
                        user.first_name = base.GetDataValue<string>(dr, "first_name");
                        user.last_name = base.GetDataValue<string>(dr, "last_name");
                        user.mail = base.GetDataValue<string>(dr, "mail");
                        user.sex = Convert.ToChar(base.GetDataValue<string>(dr, "sex"));
                        user.phone = base.GetDataValue<string>(dr, "phone");
                    }
                }
            }

            return user;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Users table.
        /// </summary>
        /// <returns>A collection of User objects.</returns>		
        public List<User> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [deleted], [user_name], [user_pass], [role_code], [first_name], [last_name]" +
                        ", [mail], [sex], [phone] " +
                "FROM dbo.Users ";

            List<User> result = new List<User>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new User
                        User user = new User();

                        // Read values.
                        user.id = base.GetDataValue<int>(dr, "id");
                        user.deleted = base.GetDataValue<bool>(dr, "deleted");
                        user.user_name = base.GetDataValue<string>(dr, "user_name");
                        user.user_pass = base.GetDataValue<string>(dr, "user_pass");
                        user.role_code = base.GetDataValue<string>(dr, "role_code");
                        user.first_name = base.GetDataValue<string>(dr, "first_name");
                        user.last_name = base.GetDataValue<string>(dr, "last_name");
                        user.mail = base.GetDataValue<string>(dr, "mail");
                        user.sex = Convert.ToChar(base.GetDataValue<string>(dr, "sex"));
                        user.phone = base.GetDataValue<string>(dr, "phone");

                        // Add to List.
                        result.Add(user);
                    }
                }
            }

            return result;
        }
    }
}


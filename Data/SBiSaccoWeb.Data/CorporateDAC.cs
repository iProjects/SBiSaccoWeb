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
    /// Corporates data access component. Manages CRUD operations for the Corporates table.
    /// </summary>
    public partial class CorporateDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Corporates table.
        /// </summary>
        /// <param name="corporate">A Corporate object.</param>
        /// <returns>An updated Corporate object.</returns>
        public Corporate Create(Corporate corporate)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Corporates ([id], [name], [deleted], [sigle], [small_name], [volunteer_count], [agrement_date], [agrement_solidarity], [employee_count], [siret], [activity_id], [date_create], [fiscal_status], [registre], [legalForm], [insertionType], [loan_officer_id]) " +
                "VALUES(@id, @name, @deleted, @sigle, @small_name, @volunteer_count, @agrement_date, @agrement_solidarity, @employee_count, @siret, @activity_id, @date_create, @fiscal_status, @registre, @legalForm, @insertionType, @loan_officer_id);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@id", DbType.Int32, corporate.id);
                db.AddInParameter(cmd, "@name", DbType.String, corporate.name);
                db.AddInParameter(cmd, "@deleted", DbType.Boolean, corporate.deleted);
                db.AddInParameter(cmd, "@sigle", DbType.String, corporate.sigle);
                db.AddInParameter(cmd, "@small_name", DbType.String, corporate.small_name);
                db.AddInParameter(cmd, "@volunteer_count", DbType.Int32, corporate.volunteer_count);
                db.AddInParameter(cmd, "@agrement_date", DbType.DateTime, corporate.agrement_date);
                db.AddInParameter(cmd, "@agrement_solidarity", DbType.Boolean, corporate.agrement_solidarity);
                db.AddInParameter(cmd, "@employee_count", DbType.Int32, corporate.employee_count);
                db.AddInParameter(cmd, "@siret", DbType.String, corporate.siret);
                db.AddInParameter(cmd, "@activity_id", DbType.Int32, corporate.activity_id);
                db.AddInParameter(cmd, "@date_create", DbType.DateTime, corporate.date_create);
                db.AddInParameter(cmd, "@fiscal_status", DbType.String, corporate.fiscal_status);
                db.AddInParameter(cmd, "@registre", DbType.String, corporate.registre);
                db.AddInParameter(cmd, "@legalForm", DbType.String, corporate.legalForm);
                db.AddInParameter(cmd, "@insertionType", DbType.String, corporate.insertionType);
                db.AddInParameter(cmd, "@loan_officer_id", DbType.Int32, corporate.loan_officer_id);

                db.ExecuteNonQuery(cmd);
            }

            return corporate;
        }

        /// <summary>
        /// Updates an existing row in the Corporates table.
        /// </summary>
        /// <param name="corporate">A Corporate entity object.</param>
        public void UpdateById(Corporate corporate)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Corporates " +
                "SET " +
                    "[name]=@name, " +
                    "[deleted]=@deleted, " +
                    "[sigle]=@sigle, " +
                    "[small_name]=@small_name, " +
                    "[volunteer_count]=@volunteer_count, " +
                    "[agrement_date]=@agrement_date, " +
                    "[agrement_solidarity]=@agrement_solidarity, " +
                    "[employee_count]=@employee_count, " +
                    "[siret]=@siret, " +
                    "[activity_id]=@activity_id, " +
                    "[date_create]=@date_create, " +
                    "[fiscal_status]=@fiscal_status, " +
                    "[registre]=@registre, " +
                    "[legalForm]=@legalForm, " +
                    "[insertionType]=@insertionType, " +
                    "[loan_officer_id]=@loan_officer_id " +
                "WHERE [id]=@id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@name", DbType.String, corporate.name);
                db.AddInParameter(cmd, "@deleted", DbType.Boolean, corporate.deleted);
                db.AddInParameter(cmd, "@sigle", DbType.String, corporate.sigle);
                db.AddInParameter(cmd, "@small_name", DbType.String, corporate.small_name);
                db.AddInParameter(cmd, "@volunteer_count", DbType.Int32, corporate.volunteer_count);
                db.AddInParameter(cmd, "@agrement_date", DbType.DateTime, corporate.agrement_date);
                db.AddInParameter(cmd, "@agrement_solidarity", DbType.Boolean, corporate.agrement_solidarity);
                db.AddInParameter(cmd, "@employee_count", DbType.Int32, corporate.employee_count);
                db.AddInParameter(cmd, "@siret", DbType.String, corporate.siret);
                db.AddInParameter(cmd, "@activity_id", DbType.Int32, corporate.activity_id);
                db.AddInParameter(cmd, "@date_create", DbType.DateTime, corporate.date_create);
                db.AddInParameter(cmd, "@fiscal_status", DbType.String, corporate.fiscal_status);
                db.AddInParameter(cmd, "@registre", DbType.String, corporate.registre);
                db.AddInParameter(cmd, "@legalForm", DbType.String, corporate.legalForm);
                db.AddInParameter(cmd, "@insertionType", DbType.String, corporate.insertionType);
                db.AddInParameter(cmd, "@loan_officer_id", DbType.Int32, corporate.loan_officer_id);
                db.AddInParameter(cmd, "@id", DbType.Int32, corporate.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the Corporates table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.Corporates " +
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
        /// Returns a row from the Corporates table.
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>A Corporate object with data populated from the database.</returns>
        public Corporate SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [name], [deleted], [sigle], [small_name], [volunteer_count], [agrement_date]" +
                        ", [agrement_solidarity], [employee_count], [siret], [activity_id], [date_create], [fiscal_status]" +
                        ", [registre], [legalForm], [insertionType], [loan_officer_id] " +
                "FROM dbo.Corporates  " +
                "WHERE [id]=@id ";

            Corporate corporate = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new Corporate
                        corporate = new Corporate();

                        // Read values.
                        corporate.id = base.GetDataValue<int>(dr, "id");
                        corporate.name = base.GetDataValue<string>(dr, "name");
                        corporate.deleted = base.GetDataValue<bool>(dr, "deleted");
                        corporate.sigle = base.GetDataValue<string>(dr, "sigle");
                        corporate.small_name = base.GetDataValue<string>(dr, "small_name");
                        corporate.volunteer_count = base.GetDataValue<int>(dr, "volunteer_count");
                        corporate.agrement_date = base.GetDataValue<DateTime>(dr, "agrement_date");
                        corporate.agrement_solidarity = base.GetDataValue<bool>(dr, "agrement_solidarity");
                        corporate.employee_count = base.GetDataValue<int>(dr, "employee_count");
                        corporate.siret = base.GetDataValue<string>(dr, "siret");
                        corporate.activity_id = base.GetDataValue<int>(dr, "activity_id");
                        corporate.date_create = base.GetDataValue<DateTime>(dr, "date_create");
                        corporate.fiscal_status = base.GetDataValue<string>(dr, "fiscal_status");
                        corporate.registre = base.GetDataValue<string>(dr, "registre");
                        corporate.legalForm = base.GetDataValue<string>(dr, "legalForm");
                        corporate.insertionType = base.GetDataValue<string>(dr, "insertionType");
                        corporate.loan_officer_id = base.GetDataValue<int>(dr, "loan_officer_id");
                    }
                }
            }

            return corporate;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Corporates table.
        /// </summary>
        /// <returns>A collection of Corporate objects.</returns>		
        public List<Corporate> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [id], [name], [deleted], [sigle], [small_name], [volunteer_count], [agrement_date]" +
                        ", [agrement_solidarity], [employee_count], [siret], [activity_id], [date_create], [fiscal_status]" +
                        ", [registre], [legalForm], [insertionType], [loan_officer_id] " +
                "FROM dbo.Corporates ";

            List<Corporate> result = new List<Corporate>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Corporate
                        Corporate corporate = new Corporate();

                        // Read values.
                        corporate.id = base.GetDataValue<int>(dr, "id");
                        corporate.name = base.GetDataValue<string>(dr, "name");
                        corporate.deleted = base.GetDataValue<bool>(dr, "deleted");
                        corporate.sigle = base.GetDataValue<string>(dr, "sigle");
                        corporate.small_name = base.GetDataValue<string>(dr, "small_name");
                        corporate.volunteer_count = base.GetDataValue<int>(dr, "volunteer_count");
                        corporate.agrement_date = base.GetDataValue<DateTime>(dr, "agrement_date");
                        corporate.agrement_solidarity = base.GetDataValue<bool>(dr, "agrement_solidarity");
                        corporate.employee_count = base.GetDataValue<int>(dr, "employee_count");
                        corporate.siret = base.GetDataValue<string>(dr, "siret");
                        corporate.activity_id = base.GetDataValue<int>(dr, "activity_id");
                        corporate.date_create = base.GetDataValue<DateTime>(dr, "date_create");
                        corporate.fiscal_status = base.GetDataValue<string>(dr, "fiscal_status");
                        corporate.registre = base.GetDataValue<string>(dr, "registre");
                        corporate.legalForm = base.GetDataValue<string>(dr, "legalForm");
                        corporate.insertionType = base.GetDataValue<string>(dr, "insertionType");
                        corporate.loan_officer_id = base.GetDataValue<int>(dr, "loan_officer_id");

                        // Add to List.
                        result.Add(corporate);
                    }
                }
            }

            return result;
        }
    }
}


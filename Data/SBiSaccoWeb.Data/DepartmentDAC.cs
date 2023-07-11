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
    /// Departments data access component. Manages CRUD operations for the Departments table.
    /// </summary>
    public partial class DepartmentDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Departments table.
        /// </summary>
        /// <param name="department">A Department object.</param>
        /// <returns>An updated Department object.</returns>
        public Department Create(Department department)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Departments ([Code], [Description], [IsDeleted]) " +
                "VALUES(@Code, @Description, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Code", DbType.String, department.Code);
                db.AddInParameter(cmd, "@Description", DbType.String, department.Description);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, department.IsDeleted);

                // Get the primary key value.
                department.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return department;
        }

        /// <summary>
        /// Updates an existing row in the Departments table.
        /// </summary>
        /// <param name="department">A Department entity object.</param>
        public void UpdateById(Department department)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Departments " +
                "SET " +
                    "[Code]=@Code, " +
                    "[Description]=@Description, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Code", DbType.String, department.Code);
                db.AddInParameter(cmd, "@Description", DbType.String, department.Description);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, department.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, department.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the Departments table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.Departments " +
                                         "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Returns a row from the Departments table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A Department object with data populated from the database.</returns>
        public Department SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [Code], [Description], [IsDeleted] " +
                "FROM dbo.Departments  " +
                "WHERE [Id]=@Id ";

            Department department = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new Department
                        department = new Department();

                        // Read values.
                        department.Id = base.GetDataValue<int>(dr, "Id");
                        department.Code = base.GetDataValue<string>(dr, "Code");
                        department.Description = base.GetDataValue<string>(dr, "Description");
                        department.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return department;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Departments table.
        /// </summary>
        /// <returns>A collection of Department objects.</returns>		
        public List<Department> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [Code], [Description], [IsDeleted] " +
                "FROM dbo.Departments ";

            List<Department> result = new List<Department>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Department
                        Department department = new Department();

                        // Read values.
                        department.Id = base.GetDataValue<int>(dr, "Id");
                        department.Code = base.GetDataValue<string>(dr, "Code");
                        department.Description = base.GetDataValue<string>(dr, "Description");
                        department.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(department);
                    }
                }
            }

            return result;
        }
    }
}

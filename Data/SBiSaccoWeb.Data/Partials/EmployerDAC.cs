//====================================================================================================
// Base code generated with Momentum: DAC Gen (Build 2.5.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 12/31/2014 06:25:02 
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
    /// Employers data access component. Manages CRUD operations for the Employers table.
    /// </summary>
    public partial class EmployerDAC
    {

        public void UploadEmployerLogo(Employer employer)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Employers " +
                "SET " +
                    "[Logo]=@Logo " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values. 
                db.AddInParameter(cmd, "@Logo", DbType.String, employer.Logo);
                db.AddInParameter(cmd, "@Id", DbType.Int32, employer.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        public Employer SelectDefaultEmployer()
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [Name], [Email], [Telephone], [Address1], [Address2], [Slogan], [AuthorizedSignatory]" +
                        ", [PIN], [NHIF], [NSSF], [BankBranchSortCode], [AccountName], [AccountNo], [Logo]" +
                        ", [IsDefault], [IsActive], [IsDeleted]  " +
                "FROM dbo.Employers  " +
                "WHERE [IsDefault]=@IsDefault ";

            Employer employer = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@IsDefault", DbType.Boolean, true);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new Employer
                        employer = new Employer();

                        // Read values.
                        employer.Id = base.GetDataValue<int>(dr, "Id");
                        employer.Name = base.GetDataValue<string>(dr, "Name");
                        employer.Email = base.GetDataValue<string>(dr, "Email");
                        employer.Telephone = base.GetDataValue<string>(dr, "Telephone");
                        employer.Address1 = base.GetDataValue<string>(dr, "Address1");
                        employer.Address2 = base.GetDataValue<string>(dr, "Address2");
                        employer.Slogan = base.GetDataValue<string>(dr, "Slogan");
                        employer.AuthorizedSignatory = base.GetDataValue<string>(dr, "AuthorizedSignatory");
                        employer.PIN = base.GetDataValue<string>(dr, "PIN");
                        employer.NHIF = base.GetDataValue<string>(dr, "NHIF");
                        employer.NSSF = base.GetDataValue<string>(dr, "NSSF");
                        employer.BankBranchSortCode = base.GetDataValue<string>(dr, "BankBranchSortCode");
                        employer.AccountName = base.GetDataValue<string>(dr, "AccountName");
                        employer.AccountNo = base.GetDataValue<string>(dr, "AccountNo");
                        employer.Logo = base.GetDataValue<string>(dr, "Logo");
                        employer.IsDefault = base.GetDataValue<bool>(dr, "IsDefault");
                        employer.IsActive = base.GetDataValue<bool>(dr, "IsActive");
                        employer.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return employer;
        }



    }
}


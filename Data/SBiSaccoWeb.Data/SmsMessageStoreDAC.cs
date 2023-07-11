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
    /// SmsMessageStore data access component. Manages CRUD operations for the SmsMessageStore table.
    /// </summary>
    public partial class SmsMessageStoreDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the SmsMessageStore table.
        /// </summary>
        /// <param name="smsMessageStore">A SmsMessageStore object.</param>
        /// <returns>An updated SmsMessageStore object.</returns>
        public SmsMessageStore Create(SmsMessageStore smsMessageStore)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.SmsMessageStore ([UserDataText], [OriginatingAddress], [SCTimestamp], [MessageStatus], [Storage], [SmscAddressType], [SmscAddress], [OriginatingAddressType], [MessageType], [MessageIndex], [MessageBody], [Status], [Processed], [IsDeleted]) " +
                "VALUES(@UserDataText, @OriginatingAddress, @SCTimestamp, @MessageStatus, @Storage, @SmscAddressType, @SmscAddress, @OriginatingAddressType, @MessageType, @MessageIndex, @MessageBody, @Status, @Processed, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@UserDataText", DbType.String, smsMessageStore.UserDataText);
                db.AddInParameter(cmd, "@OriginatingAddress", DbType.String, smsMessageStore.OriginatingAddress);
                db.AddInParameter(cmd, "@SCTimestamp", DbType.String, smsMessageStore.SCTimestamp);
                db.AddInParameter(cmd, "@MessageStatus", DbType.String, smsMessageStore.MessageStatus);
                db.AddInParameter(cmd, "@Storage", DbType.String, smsMessageStore.Storage);
                db.AddInParameter(cmd, "@SmscAddressType", DbType.String, smsMessageStore.SmscAddressType);
                db.AddInParameter(cmd, "@SmscAddress", DbType.String, smsMessageStore.SmscAddress);
                db.AddInParameter(cmd, "@OriginatingAddressType", DbType.String, smsMessageStore.OriginatingAddressType);
                db.AddInParameter(cmd, "@MessageType", DbType.String, smsMessageStore.MessageType);
                db.AddInParameter(cmd, "@MessageIndex", DbType.String, smsMessageStore.MessageIndex);
                db.AddInParameter(cmd, "@MessageBody", DbType.String, smsMessageStore.MessageBody);
                db.AddInParameter(cmd, "@Status", DbType.String, smsMessageStore.Status);
                db.AddInParameter(cmd, "@Processed", DbType.Boolean, smsMessageStore.Processed);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, smsMessageStore.IsDeleted);

                // Get the primary key value.
                smsMessageStore.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return smsMessageStore;
        }

        /// <summary>
        /// Updates an existing row in the SmsMessageStore table.
        /// </summary>
        /// <param name="smsMessageStore">A SmsMessageStore entity object.</param>
        public void UpdateById(SmsMessageStore smsMessageStore)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.SmsMessageStore " +
                "SET " +
                    "[UserDataText]=@UserDataText, " +
                    "[OriginatingAddress]=@OriginatingAddress, " +
                    "[SCTimestamp]=@SCTimestamp, " +
                    "[MessageStatus]=@MessageStatus, " +
                    "[Storage]=@Storage, " +
                    "[SmscAddressType]=@SmscAddressType, " +
                    "[SmscAddress]=@SmscAddress, " +
                    "[OriginatingAddressType]=@OriginatingAddressType, " +
                    "[MessageType]=@MessageType, " +
                    "[MessageIndex]=@MessageIndex, " +
                    "[MessageBody]=@MessageBody, " +
                    "[Status]=@Status, " +
                    "[Processed]=@Processed, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@UserDataText", DbType.String, smsMessageStore.UserDataText);
                db.AddInParameter(cmd, "@OriginatingAddress", DbType.String, smsMessageStore.OriginatingAddress);
                db.AddInParameter(cmd, "@SCTimestamp", DbType.String, smsMessageStore.SCTimestamp);
                db.AddInParameter(cmd, "@MessageStatus", DbType.String, smsMessageStore.MessageStatus);
                db.AddInParameter(cmd, "@Storage", DbType.String, smsMessageStore.Storage);
                db.AddInParameter(cmd, "@SmscAddressType", DbType.String, smsMessageStore.SmscAddressType);
                db.AddInParameter(cmd, "@SmscAddress", DbType.String, smsMessageStore.SmscAddress);
                db.AddInParameter(cmd, "@OriginatingAddressType", DbType.String, smsMessageStore.OriginatingAddressType);
                db.AddInParameter(cmd, "@MessageType", DbType.String, smsMessageStore.MessageType);
                db.AddInParameter(cmd, "@MessageIndex", DbType.String, smsMessageStore.MessageIndex);
                db.AddInParameter(cmd, "@MessageBody", DbType.String, smsMessageStore.MessageBody);
                db.AddInParameter(cmd, "@Status", DbType.String, smsMessageStore.Status);
                db.AddInParameter(cmd, "@Processed", DbType.Boolean, smsMessageStore.Processed);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, smsMessageStore.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, smsMessageStore.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the SmsMessageStore table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.SmsMessageStore " +
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
        /// Returns a row from the SmsMessageStore table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A SmsMessageStore object with data populated from the database.</returns>
        public SmsMessageStore SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [UserDataText], [OriginatingAddress], [SCTimestamp], [MessageStatus], [Storage]" +
                        ", [SmscAddressType], [SmscAddress], [OriginatingAddressType], [MessageType], [MessageIndex]" +
                        ", [MessageBody], [Status], [Processed], [IsDeleted] " +
                "FROM dbo.SmsMessageStore  " +
                "WHERE [Id]=@Id ";

            SmsMessageStore smsMessageStore = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new SmsMessageStore
                        smsMessageStore = new SmsMessageStore();

                        // Read values.
                        smsMessageStore.Id = base.GetDataValue<int>(dr, "Id");
                        smsMessageStore.UserDataText = base.GetDataValue<string>(dr, "UserDataText");
                        smsMessageStore.OriginatingAddress = base.GetDataValue<string>(dr, "OriginatingAddress");
                        smsMessageStore.SCTimestamp = base.GetDataValue<string>(dr, "SCTimestamp");
                        smsMessageStore.MessageStatus = base.GetDataValue<string>(dr, "MessageStatus");
                        smsMessageStore.Storage = base.GetDataValue<string>(dr, "Storage");
                        smsMessageStore.SmscAddressType = base.GetDataValue<string>(dr, "SmscAddressType");
                        smsMessageStore.SmscAddress = base.GetDataValue<string>(dr, "SmscAddress");
                        smsMessageStore.OriginatingAddressType = base.GetDataValue<string>(dr, "OriginatingAddressType");
                        smsMessageStore.MessageType = base.GetDataValue<string>(dr, "MessageType");
                        smsMessageStore.MessageIndex = base.GetDataValue<string>(dr, "MessageIndex");
                        smsMessageStore.MessageBody = base.GetDataValue<string>(dr, "MessageBody");
                        smsMessageStore.Status = base.GetDataValue<string>(dr, "Status");
                        smsMessageStore.Processed = base.GetDataValue<bool>(dr, "Processed");
                        smsMessageStore.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return smsMessageStore;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the SmsMessageStore table.
        /// </summary>
        /// <returns>A collection of SmsMessageStore objects.</returns>		
        public List<SmsMessageStore> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [UserDataText], [OriginatingAddress], [SCTimestamp], [MessageStatus], [Storage]" +
                        ", [SmscAddressType], [SmscAddress], [OriginatingAddressType], [MessageType], [MessageIndex]" +
                        ", [MessageBody], [Status], [Processed], [IsDeleted] " +
                "FROM dbo.SmsMessageStore ";

            List<SmsMessageStore> result = new List<SmsMessageStore>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new SmsMessageStore
                        SmsMessageStore smsMessageStore = new SmsMessageStore();

                        // Read values.
                        smsMessageStore.Id = base.GetDataValue<int>(dr, "Id");
                        smsMessageStore.UserDataText = base.GetDataValue<string>(dr, "UserDataText");
                        smsMessageStore.OriginatingAddress = base.GetDataValue<string>(dr, "OriginatingAddress");
                        smsMessageStore.SCTimestamp = base.GetDataValue<string>(dr, "SCTimestamp");
                        smsMessageStore.MessageStatus = base.GetDataValue<string>(dr, "MessageStatus");
                        smsMessageStore.Storage = base.GetDataValue<string>(dr, "Storage");
                        smsMessageStore.SmscAddressType = base.GetDataValue<string>(dr, "SmscAddressType");
                        smsMessageStore.SmscAddress = base.GetDataValue<string>(dr, "SmscAddress");
                        smsMessageStore.OriginatingAddressType = base.GetDataValue<string>(dr, "OriginatingAddressType");
                        smsMessageStore.MessageType = base.GetDataValue<string>(dr, "MessageType");
                        smsMessageStore.MessageIndex = base.GetDataValue<string>(dr, "MessageIndex");
                        smsMessageStore.MessageBody = base.GetDataValue<string>(dr, "MessageBody");
                        smsMessageStore.Status = base.GetDataValue<string>(dr, "Status");
                        smsMessageStore.Processed = base.GetDataValue<bool>(dr, "Processed");
                        smsMessageStore.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(smsMessageStore);
                    }
                }
            }

            return result;
        }
    }
}


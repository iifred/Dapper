using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Dapper;

using DemoLib.AHInsuranceSDK.Entity;
namespace DemoLib.AHInsuranceSDK.DataAccess
{
    public class SystemLogProvider : BaseProvider
    {
        public SystemLogProvider(string connStr)
            : base(connStr)
        {
        }

        public void Insert(SystemLogEntity log)
        {
            using (IDbConnection conn = new SqlConnection(this.ConnectionString))
            {
                string insertSql = @"Insert into SystemLog(Description,ClientIP,CreateUser,CreateTime) values(@Description,@ClientIP,@CreateUser,@CreateTime)";

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                conn.Execute(insertSql, log);
            }
        }
    }
}

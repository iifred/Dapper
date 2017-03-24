using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Dapper;

using DemoLib.AHInsuranceSDK.Entity;

namespace DemoLib.AHInsuranceSDK.DataAccess
{
    public class CasualtyPolicyProvider : BaseProvider
    {
        public CasualtyPolicyProvider(string connStr)
            : base(connStr)
        {

        }

        public void GetAll()
        {

        }

        public void Get()
        {

        }

        public void Insert(CasualtyPolicyEntity cpolicy)
        {
            using (IDbConnection conn = new SqlConnection(this.ConnectionString))
            {
                //connection.Execute(@"insert MyTable(colA, colB) values (@a, @b)",new[] { new { a=1, b=1 }, new { a=2, b=2 }, new { a=3, b=3 } }).IsEqualTo(3); // 3 rows inserted: "1,1", "2,2" and "3,3"
                string insertSql=@"Insert ";

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                conn.Execute(insertSql, cpolicy);
            }

        }

        public void Update()
        {

        }

        public void Del()
        {

        }
    }
}

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
    public  class NonCarLiabilityPolicyProvider:BaseProvider
    {
            public NonCarLiabilityPolicyProvider(string connstr) : base(connstr)
        {
       
        }
        public void InsertNonCarLiabilityPoli(NonCarLiabilityPolicyEntity entity) {
            using(IDbConnection conn = new SqlConnection(this.ConnectionString))
            {
                string insertSql = @"Insert into PupilInfo(CustomerID,PupilName,PupilIdNoType,PupilNo,PupilBirth,PupilSex,PupilRelation) values(@CustomerID,@PupilName,@PupilIdNoType,@PupilNo,@PupilBirth,@PupilSex,@PupilRelation)";

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                conn.Execute(insertSql, entity);
            }
        }

    }
}

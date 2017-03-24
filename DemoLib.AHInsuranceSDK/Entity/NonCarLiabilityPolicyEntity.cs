using System;
using System.Collections.Generic;

namespace DemoLib.AHInsuranceSDK.Entity
{
    /// <summary>
    /// NonCarLiabilityPolicy(非车责任险信息表)
    /// </summary>
    [Serializable]
    public class NonCarLiabilityPolicyEntity
    {
        public Int64 NCLPID { get; set; }
        public string PolicyNumber { get; set; }
        public string PolicyNumbers { get; set; }
        public string OperatorId { get; set; }
        public string PHMail { get; set; }
        public string PHName { get; set; }
        public string PHIdNoType { get; set; }
        public string PHIdNo { get; set; }
        public string PHBirth { get; set; }
        public string PHTel { get; set; }
        public Int32 PlanID { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string PHAddr { get; set; }
        public string PHPostCd { get; set; }
        public Int32 PHRelationType { get; set; }
        public string Remark { get; set; }
        public string carNo { get; set; }
        public bool InvoiceTag { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string FeeType { get; set; }
        public string Suffix { get; set; }
        public string SerialNo { get; set; }
        public Int32 Pnum { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalPremium { get; set; }
        public string OrderNo { get; set; }
        [NonSerialized]
        public string LoginName;
        [NonSerialized]
        public string LoginPwd;
        [NonSerialized]
        public Int32 BizStatus;
        [NonSerialized]
        public string Operator;
        [NonSerialized]
        public DateTime CreateTime;
        [NonSerialized]
        public DateTime EffectiveTime;
        [NonSerialized]
        public DateTime UpdateTime;

    }
}

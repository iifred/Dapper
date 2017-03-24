using System;
using System.Collections.Generic;

namespace DemoLib.AHInsuranceSDK.Entity
{
    /// <summary>
    /// 意外险保单表
    /// </summary>
    [Serializable]
    public class CasualtyPolicyEntity
    {
        public Int64 CPID { get; set; }
        public string PolicyNumber { get; set; }
        public string PolicyNumbers { get; set; }
        public string OperatorId { get; set; }
        public string PHMail { get; set; }
        public string PHName { get; set; }
        public string PHIdNoType { get; set; }
        public string PHIdNo { get; set; }
        public DateTime PHBirth { get; set; }
        public string PHTel { get; set; }
        public Int32 PlanID { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string PHAddr { get; set; }
        public string PHPostCd { get; set; }
        public string Remark { get; set; }
        public string carNo { get; set; }
        public bool InvoiceTag { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string FeeType { get; set; }
        public string Suffix { get; set; }
        public string SerialNo { get; set; }
        [NonSerialized]
        public decimal Amount;
        [NonSerialized]
        public decimal TotalPremium;
        [NonSerialized]
        public string OrderNo;
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

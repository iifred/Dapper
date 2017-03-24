using System;
using System.Collections.Generic;

namespace DemoLib.AHInsuranceSDK.Entity
{
    /// <summary>
    /// CustomerInfo(客户信息表，被保人和收益人)
    /// </summary>
    [Serializable]
    public class CustomerInfoEntity
    {
        public Int64 CustomerID { get; set; }
        public Int64 PolicyID { get; set; }
        public Int64 PolicyType { get; set; }
        public Int64 ParentID { get; set; }
        public string Name { get; set; }
        public Int64 CustomerType { get; set; }
        public string IdNoType { get; set; }
        public string IdNo { get; set; }
        public string Relation { get; set; }
        public string Assign { get; set; }
        public Int64 Per { get; set; }
        public Int64 Sex { get; set; }
        public string BirthDt { get; set; }
        public string Tel { get; set; }

    }
}

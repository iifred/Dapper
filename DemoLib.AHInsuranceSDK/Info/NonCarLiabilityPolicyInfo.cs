using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DemoLib.AHInsuranceSDK.Entity;

namespace DemoLib.AHInsuranceSDK.Info
{
    [Serializable]
    public class NonCarLiabilityPolicyInfo:NonCarLiabilityPolicyEntity
    {
        public string ProductID { get; set; }
        public List<NonCustomerInsuredInfo> Insured { get; set; }
    }
}

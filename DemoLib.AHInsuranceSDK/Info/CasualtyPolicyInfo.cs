using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoLib.AHInsuranceSDK.Entity;
namespace DemoLib.AHInsuranceSDK.Info
{
    [Serializable]
    public class CasualtyPolicyInfo:CasualtyPolicyEntity
    {
        public List<CustomerInsuredInfo> Insured { get; set; }
        public string ProductID { get; set; }
    }
}

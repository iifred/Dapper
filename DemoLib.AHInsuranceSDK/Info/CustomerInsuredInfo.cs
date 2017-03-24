using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DemoLib.AHInsuranceSDK.Entity;
namespace DemoLib.AHInsuranceSDK.Info
{
    public class CustomerInsuredInfo : CustomerInfoEntity
    {
        public List<CustomerInfoEntity> Bnfs { get; set; }
    }
}

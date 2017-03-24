using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DemoLib.AHInsuranceSDK.Enum
{
    public enum PolicyType
    {
        [Description("意外险")]
        Casualty = 0,
        [Description("非车责任险")]
        Non_carLiability = 1,
    }
}

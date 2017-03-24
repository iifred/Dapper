using System;
using System.Collections.Generic;
using DemoLib.AHInsuranceSDK.Enum;

namespace DemoLib.AHInsuranceSDK.Params
{
    [Serializable]
    public class SessionResponseEntity
    {
        public bool success { get; set; }
        public ErrorCodeEnum code { get; set; }
        public string msg { get; set; }

    }
}

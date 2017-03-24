using System;
using System.Collections.Generic;

namespace DemoLib.AHInsuranceSDK.Entity
{
    /// <summary>
    /// SystemLog（系统日志表）
    /// </summary>
    [Serializable]
    public class SystemLogEntity
    {
        public Int64 LogID { get; set; }
        public string Description { get; set; }
        public string ClientIP { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateTime { get; set; }

    }
}

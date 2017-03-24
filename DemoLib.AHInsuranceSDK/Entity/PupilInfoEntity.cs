using System;
using System.Collections.Generic;

namespace DemoLib.AHInsuranceSDK.Entity
{
    /// <summary>
    /// PupilInfo(被保人被监护人信息表)
    /// </summary>
    [Serializable]
    public class PupilInfoEntity
    {
        public Int64 PupilID { get; set; }
        public Int64 CustomerID { get; set; }
        public string PupilName { get; set; }
        public string PupilIdNoType { get; set; }
        public string PupilNo { get; set; }
        public string PupilBirth { get; set; }
        public Int32 PupilSex { get; set; }
        public string PupilRelation { get; set; }

    }
}

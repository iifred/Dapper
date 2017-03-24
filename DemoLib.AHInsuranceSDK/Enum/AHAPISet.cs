using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DemoLib.AHInsuranceSDK.Enum
{
    public enum AHAPISet
    {
        [Description("ah/session")]
        SESSION_ON = 0,
        [Description("ah/session")]
        SESSION_DEL = 1,
        [Description("ah/policies")]
        BUY_POLICY = 2,
        [Description("ah/policies/{PolicyID}")]
        GET_POLICY = 3,
        [Description("ah/policies/{PolicyID}")]
        CANCEL_POLICY = 4,
        [Description("ah/pdf_printer/policies/PolicyID")]
        PRINT_POLICY = 5,
    }
}

using DemoLib.AHInsuranceSDK.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoLib.AHInsuranceSDK.Common
{
    public class AHInsuranceAPIs
    {
        private static readonly string BaseUrl = "http://ccic2.ins24.com/";
        //static string username = "md_ywx";
        //static string pwd = "md_ywx123456";

        #region .ctor
        public AHInsuranceAPIs()
        {
        }
        #endregion

        public static string GetUrl(AHAPISet api, string pid)
        {
            string currUrl = string.Empty;

            if (api != null)
            {
                switch (api)
                {
                    case AHAPISet.SESSION_ON:
                        currUrl = BaseUrl + "ah/session";
                        break;
                    case AHAPISet.SESSION_DEL:
                        currUrl = BaseUrl + "ah/session";
                        break;
                    case AHAPISet.BUY_POLICY:
                        currUrl = BaseUrl + "ah/policies";
                        break;
                    case AHAPISet.CANCEL_POLICY:
                        if (!string.IsNullOrEmpty(pid))
                        {
                            currUrl = BaseUrl + "ah/policies/" + pid;
                        }
                        break;
                    case AHAPISet.PRINT_POLICY:
                        if (!string.IsNullOrEmpty(pid))
                        {
                            currUrl = BaseUrl + "ah/policies/" + pid;
                        }
                        break;
                    case AHAPISet.GET_POLICY:
                        if (!string.IsNullOrEmpty(pid))
                        {
                            currUrl = BaseUrl + "ah/pdf_printer/policies/" + pid;
                        }
                        break;
                }
            }

            return currUrl;

        }
    }
}

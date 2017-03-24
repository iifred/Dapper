using System;
using System.Collections.Generic;

namespace DemoLib.AHInsuranceSDK.Info
{
    [Serializable]
   public class ReturnInfo
    {
        public bool IsSuccess { get; set; }

        public object Data { get; set; }

        public List<ErrorEntity> Errors { get; set; }
    }

    [Serializable]
    public class ErrorEntity
    {

        /// <summary>
        ///对象
        /// </summary>       
        public string ObjectInstance { get; set; }

        /// <summary>
        ///消息
        /// </summary>
        public string Message { get; set; }
    }


    public class NonCarLiabilityPolicyReturnInfo
    {
        public bool success { get; set; }
        public int  code { get; set; }
        public string msg { get; set; }

    }
}

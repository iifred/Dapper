using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DemoLib.AHInsuranceSDK.Info;
using DemoLib.AHInsuranceWeb.Common;
using DemoLib.AHInsuranceSDK.Common;
using DemoLib.AHInsuranceSDK.DataAccess;
using fastJSON;
using Newtonsoft.Json;
namespace DemoLib.AHInsuranceWeb
{
    public partial class Index : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string reqUrl1 = AHInsuranceAPIs.GetUrl(DemoLib.AHInsuranceSDK.Enum.AHAPISet.SESSION_ON, null);
            string res1 = HttpPost(reqUrl1, "{\"username\":\"md_ywx\",\"password\":\"md_ywx123456\"}");

            ///意外险创建保单
            CasualtyPolicyInfo info = new CasualtyPolicyInfo();
            info.OperatorId = "";
            info.PHMail = "xxx@xxx.com";
            info.PHName = "测试接口";
            info.PHIdNoType = "Other";
            info.PHIdNo = "798465654";
            info.PHBirth = Convert.ToDateTime("1982-01-02");
            info.PHTel = "13511111111";
            info.ProductID = "1017";
            info.PlanID = 2585;
            info.DateStart = "2017-03-11";
            info.DateEnd = "2017-03-25";
            info.PHAddr = "";
            info.PHPostCd = "";
            info.Remark = "";
            info.carNo = "";
            info.InvoiceTag = false;
            info.Departure = "";
            info.Destination = "美国";
            info.FeeType = "other";
            info.Suffix = "";
            info.SerialNo = "";

            info.Insured = new List<CustomerInsuredInfo>() {
                new CustomerInsuredInfo() {
                    Name ="被保人AF",IdNoType="Other",IdNo="664466787545545",
                    BirthDt= "1987-01-01",Tel = "",Sex = 0,
                    Assign = "perct",
                    Bnfs = new List<AHInsuranceSDK.Entity.CustomerInfoEntity>() {
                        new AHInsuranceSDK.Entity.CustomerInfoEntity() { Name="受益人BB",
                        IdNoType= "Officer",
                        IdNo= "664466787545545",
                        Relation="self",
                        Per=40,
                        Sex=0},
                        new AHInsuranceSDK.Entity.CustomerInfoEntity() {
                            Name = "受益人C",
                            IdNoType = "Other",
                            IdNo = "664466787545545",
                            Relation = "children",
                            Per = 60,
                            Sex = 0}
                    }
                }
            };
            //info.Insured.Name = "";
            JSONParameters s = new JSONParameters() { EnableAnonymousTypes = true, UsingGlobalTypes = false, DateTimeMilliseconds = true, UseUTCDateTime=false};
            s.IgnoreAttributes.Add(typeof(NonSerializedAttribute));
            string json = fastJSON.JSON.ToNiceJSON(info, s);
            //string json = JsonConvert.SerializeObject(info);
            Response.Write(json);

            SystemLogProvider p = new SystemLogProvider(System.Configuration.ConfigurationManager.AppSettings["conn"]);
            AHInsuranceSDK.Entity.SystemLogEntity entity = new AHInsuranceSDK.Entity.SystemLogEntity() {
                ClientIP = "fred",
                CreateUser = "fred",
                CreateTime = DateTime.Now,
                Description="详细描述"
            };
            p.Insert(entity);





            ///非车责任险创建保单
            NonCarLiabilityPolicyInfo infos = new NonCarLiabilityPolicyInfo();
            //infos.OperatorId = "";
            //infos.PHMail = "xxx@xxx.com";
            //infos.PHName = "测试接口";
            //infos.PHIdNoType = "Other";
            //infos.PHIdNo = "798465654";
            //infos.PHBirth = "1982-01-02";
            //infos.PHTel = "13511111111";
            //infos.ProductID = "1017";
            //infos.PlanID = 2585;
            //infos.DateStart = "2017-03-11";
            //infos.DateEnd = "2017-03-25";
            //infos.PHAddr = "";
            //infos.PHPostCd = "";
            //infos.Remark = "";
            //infos.carNo = "";
            //infos.InvoiceTag = false;
            //infos.Departure = "";
            //infos.Destination = "美国";
            //infos.FeeType = "other";
            //infos.Suffix = "";
            //infos.Pnum = 1;
            //infos.SerialNo = "";
            //infos.Insured = new List<NonCustomerInsuredInfo>() {
            //    new NonCustomerInsuredInfo() {
            //        Name ="被保人AF",IdNoType="Other",IdNo="664466787545545",
            //        BirthDt= "1987-01-01",Tel = "",Sex = 0,
            //        Assign = "perct",
            //        Bnfs = new List<AHInsuranceSDK.Entity.CustomerInfoEntity>() {
            //            new AHInsuranceSDK.Entity.CustomerInfoEntity() { Name="受益人BB",
            //            IdNoType= "Officer",
            //            IdNo= "664466787545545",
            //            Relation="self",
            //            Per=40,
            //            Sex=0},
            //            new AHInsuranceSDK.Entity.CustomerInfoEntity() {
            //                Name = "受益人C",
            //                IdNoType = "Other",
            //                IdNo = "664466787545545",
            //                Relation = "children",
            //                Per = 60,
            //                Sex = 0}
            //        },Pupils=new List<AHInsuranceSDK.Entity.PupilInfoEntity>() {
            //            new AHInsuranceSDK.Entity.PupilInfoEntity() {
            //                PupilName="",PupilIdNoType="",PupilNo=""
            //                ,PupilBirth="1992-05-11",PupilSex=1,PupilRelation="其他"
            //            }
            //        }
            //    }
            //};



            //string json = JsonConvert.SerializeObject(infos);











            //string reqUrl = AHInsuranceAPIs.GetUrl(DemoLib.AHInsuranceSDK.Enum.AHAPISet.BUY_POLICY, null);
            //string res = HttpPost(reqUrl, json);
            //var obj = fastJSON.JSON.ToObject<NonCarLiabilityPolicyReturnInfo>(res);
            //Response.Write(EnumHelper.GetEnumDescriptionByValue<DemoLib.AHInsuranceSDK.Enum.ErrorCodeEnum>(obj.code));





        }
    }
}
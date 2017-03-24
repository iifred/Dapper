using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DemoLib.AHInsuranceSDK.Enum
{
    public enum ErrorCodeEnum
    {
        [Description("计划为空或者不存在")]
        POLICY_1001 = 1001,
        [Description("保单起始日期为空或格式错误")]
        POLICY_1002 = 1002,
        [Description("保单终止日期为空或格式错误")]
        POLICY_1003 = 1003,
        [Description("保单起始日期小于系统当前时间")]
        POLICY_1004 = 1004,
        [Description("保单终止日期小于系统当前时间")]
        POLICY_1005 = 1005,
        [Description("保单起始日期大于终止日期")]
        POLICY_1006 = 1006,
        [Description("保单被保险人信息为空或格式错误")]
        POLICY_1007 = 1007,
        [Description("投保人姓名为空")]
        POLICY_1008 = 1008,
        [Description("投保人证件类型为空或超出范围")]
        POLICY_1009 = 1009,
        [Description("投保人证件号码为空或格式错误")]
        POLICY_1010 = 1010,
        [Description("投保人出生日期为空或格式错误")]
        POLICY_1011 = 1011,
        [Description("投保人联系电话为空空或格式错误")]
        POLICY_1012 = 1012,
        [Description("保单号为空或不存")]
        POLICY_1013 = 1013,
        [Description("该产品未授权或已经过期")]
        POLICY_1014 = 1014,
        [Description("家庭费率不存在")]
        POLICY_1015 = 1015,
        [Description("个人费率不存在")]
        POLICY_1016 = 1016,
        [Description("儿童费率不存在")]
        POLICY_1017 = 1017,
        [Description("双人费率不存在")]
        POLICY_1018 = 1018,
        [Description("保单状态错误")]
        POLICY_1019 = 1019,
        [Description("批单新的开始时间为空")]
        POLICY_1020 = 1020,
        [Description("批单新的结束时间为空")]
        POLICY_1021 = 1021,
        [Description("保单格式错误")]
        POLICY_1022 = 1022,
        [Description("该计划在该保险区间的保费信息为空")]
        POLICY_1023 = 1023,
        [Description("总保费格式错误")]
        POLICY_1024 = 1024,
        [Description("批改值和原始值相同")]
        POLICY_1025 = 1025,
        [Description("批单格式错误")]
        POLICY_1026 = 1026,
        [Description("没有选择批单的记录")]
        POLICY_1027 = 1027,
        [Description("批改项目为空")]
        POLICY_1028 = 1028,
        [Description("批单类型为空")]
        POLICY_1029 = 1029,
        [Description("保单已取消")]
        POLICY_1030 = 1030,
        [Description("保单已过期")]
        POLICY_1031 = 1031,
        [Description("保单已失效")]
        POLICY_1032 = 1032,
        [Description("保单已生效")]
        POLICY_1033 = 1033,
        [Description("投保的人数为空或格式错误")]
        POLICY_1034 = 1034,
        [Description("营销员编号为空或错误")]
        POLICY_1035 = 1035,
        [Description("会议结束前不得修改被保险人数")]
        POLICY_1036 = 1036,
        [Description("投保人信息列表中被保险人总数大于保单人数")]
        POLICY_1037 = 1037,
        [Description("超过被保险人最大人数限制")]
        POLICY_1038 = 1038,
        [Description("投保人部门信息为空")]
        POLICY_1039 = 1039,
        [Description("投保人联系电话为空或格式错误")]
        POLICY_1040 = 1040,
        [Description("投保人邮箱地址为空或格式错误")]
        POLICY_1041 = 1041,
        [Description("会议结束超过15天，不可以修改")]
        POLICY_1042 = 1042,
        [Description("区域代码错误")]
        POLICY_1043 = 1043,
        [Description("用户权限受限")]
        POLICY_1044 = 1044,
        [Description("被保人数量不符合")]
        POLICY_1045 = 1045,
        [Description("保障天数不符合")]
        POLICY_1046 = 1046,
        [Description("保费错误")]
        POLICY_1047 = 1047,
        [Description("销售人员必填")]
        POLICY_1048 = 1048,
        [Description("序列号已存在")]
        POLICY_1056 = 1056,
        [Description("兑换率为空")]
        POLICY_1060 = 1060,
        [Description("生效日期与当前时间之差必须大于或者等于24小时")]
        POLICY_1063 = 1063,
        [Description("批改时间不在保单时间区间范围内！")]
        POLICY_1064 = 1064,
        [Description("保单开始时间不能大于在3年！")]
        POLICY_1065 = 1065,
        [Description("保单开始时间不在允许范围内")]
        POLICY_1066 = 1066,
        [Description("被监护人信息不能为空")]
        POLICY_1071 = 1071,
        [Description("被监护人证件号码为空或格式错误")]
        POLICY_1072 = 1072,
        [Description("被监护人姓名为空或格式错误")]
        POLICY_1073 = 1073,
        [Description("被监护人生日为空或格式错误")]
        POLICY_1074 = 1074,
        [Description("被监护人性别为空或格式错误")]
        POLICY_1075 = 1075,
        [Description("被监护人证件类型为空")]
        POLICY_1076 = 1076,
        [Description("与被监护人的关系为空")]
        POLICY_1077 = 1077,
        [Description("被监护人年龄必须在1-40之间")]
        POLICY_1078 = 1078,
        [Description("投保人关系类型为空")]
        POLICY_1079 = 1079,
        [Description("投保人关系类型为单位客户时，投保人证件类型必须为组织机构代码")]
        POLICY_1080 = 1080,
        [Description("组织机构代码错误，必须为9位，不带-")]
        POLICY_1081 = 1081,
        [Description("投保人关系类型为个人客户时，投保人证件类型不能为组织机构代码")]
        POLICY_1082 = 1082,
        [Description("被保险人姓名为空")]
        POLICY_1101 = 1101,
        [Description("被保险人证件类型为空或超出范围")]
        POLICY_1102 = 1102,
        [Description("被保险人证件号码为空或格式错误")]
        POLICY_1103 = 1103,
        [Description("被保险人出生日期为空或格式错误")]
        POLICY_1104 = 1104,
        [Description("被保险人人数错误")]
        POLICY_1105 = 1105,
        [Description("被保险人类型错误")]
        POLICY_1106 = 1106,
        [Description("超出儿童的最大年龄限制")]
        POLICY_1107 = 1107,
        [Description("超出个人的最高年龄限制")]
        POLICY_1108 = 1108,
        [Description("低于儿童的最低年龄限制")]
        POLICY_1109 = 1109,
        [Description("低于个人的最低年龄限制")]
        POLICY_1110 = 1110,
        [Description("受益人信息为空或格式错误")]
        POLICY_1111 = 1111,
        [Description("被保险人不存在")]
        POLICY_1112 = 1112,
        [Description("保单中的唯一被保险人不能被删除")]
        POLICY_1113 = 1113,
        [Description("分配方式不在指定的范围内")]
        POLICY_1114 = 1114,
        [Description("被保险人类型错误")]
        POLICY_1115 = 1115,
        [Description("受益人姓名为空")]
        POLICY_1201 = 1201,
        [Description("受益人证件类型为空或超出范围")]
        POLICY_1202 = 1202,
        [Description("受益人证件号码为空或格式错误")]
        POLICY_1203 = 1203,
        [Description("受益人与被保人关系为空或格式错误")]
        POLICY_1204 = 1204,
        [Description("受益比例为空或格式错误")]
        POLICY_1205 = 1205,
        [Description("被保险人下所有受益人比例的综合必须为100")]
        POLICY_1206 = 1206,
        [Description("保单创建成功")]
        POLICY_1301 = 1301,
        [Description("保单取消成功")]
        POLICY_1302 = 1302,
        [Description("保单批改成功")]
        POLICY_1303 = 1303,
        [Description("被保险人添加成功")]
        POLICY_1304 = 1304,
        [Description("保险区间更新成功")]
        POLICY_1305 = 1305,
        [Description("被保险人删除成功")]
        POLICY_1306 = 1306,
        [Description("被保险人信息更新成功")]
        POLICY_1307 = 1307,
        [Description("支付确认成功")]
        POLICY_1308 = 1308,
        [Description("保单创建成功")]
        POLICY_1310 = 1310,
        [Description("保单取消成功")]
        POLICY_1311 = 1311,
        [Description("保单份数必须为整数或份数错误")]
        POLICY_1312 = 1312,
        [Description("保单取消异常")]
        POLICY_1401 = 1401,
        [Description("保单取消失败")]
        POLICY_1402 = 1402,
        [Description("保单创建失败")]
        POLICY_1403 = 1403,
        [Description("保单创建异常")]
        POLICY_1404 = 1404,
        [Description("被保险人添加失败")]
        POLICY_1405 = 1405,
        [Description("被保险人添加异常")]
        POLICY_1406 = 1406,
        [Description("保险区间更新失败")]
        POLICY_1407 = 1407,
        [Description("保险区间更新异常")]
        POLICY_1408 = 1408,
        [Description("被保险人删除异常")]
        POLICY_1409 = 1409,
        [Description("被保险人信息更新异常")]
        POLICY_1410 = 1410,
        [Description("支付确认异常")]
        POLICY_1411 = 1411,
        [Description("请先登录")]
        POLICY_1501 = 1501,
        [Description("没有权限")]
        POLICY_1502 = 1502,
        [Description("登录失败，用户名或密码不正确")]
        POLICY_1503 = 1503,
        [Description("用户被禁用或删除")]
        POLICY_1504 = 1504,
        [Description("你所在的组被禁用")]
        POLICY_1505 = 1505,
        [Description("验证码不正确")]
        POLICY_1506 = 1506,
        [Description("用户在线")]
        POLICY_1507 = 1507,
        [Description("登录成功")]
        POLICY_1508 = 1508,
        [Description("退出成功")]
        POLICY_1509 = 1509,
        [Description("用户名或密码不能为空")]
        POLICY_1510 = 1510,
        [Description("值机人证件号不能为空")]
        POLICY_1601 = 1601,
        [Description("理赔登记信息添加成功")]
        POLICY_1602 = 1602,
        [Description("理赔登记信息修改成功")]
        POLICY_1603 = 1603,
        [Description("信息错误或保单未加入理赔")]
        POLICY_1604 = 1604,
        [Description("该赔付状态不能进行赔付修改")]
        POLICY_1612 = 1612,
        [Description("投诉添加成功")]
        POLICY_1613 = 1613,
        [Description("投诉添加失败")]
        POLICY_1614 = 1614,
        [Description("投诉处理成功")]
        POLICY_1615 = 1615,
        [Description("投诉处理失败")]
        POLICY_1616 = 1616,
        [Description("理赔登记审核成功")]
        POLICY_1617 = 1617,
        [Description("理赔登记审核失败")]
        POLICY_1618 = 1618,
        [Description("该保单已登记")]
        POLICY_1619 = 1619,
        [Description("登记失败")]
        POLICY_1620 = 1620,
        [Description("登记成功")]
        POLICY_1621 = 1621,
        [Description("该保单号不存在")]
        POLICY_1622 = 1622,
        [Description("更新失败")]
        POLICY_1623 = 1623,
        [Description("状态错误")]
        POLICY_1624 = 1624,
        [Description("金额错误")]
        POLICY_1625 = 1625,
        [Description("银行卡号为空或银行卡格式错误")]
        POLICY_1626 = 1626,
        [Description("没有编辑权限")]
        POLICY_1627 = 1627,
        [Description("ID不存在")]
        POLICY_1628 = 1628,
        [Description("数据未发生改变")]
        POLICY_1629 = 1629,
        [Description("编辑成功")]
        POLICY_1630 = 1630,
        [Description("用户理赔表中找不到相关的理赔记录")]
        POLICY_1631 = 1631,
        [Description("银行卡号不能为空")]
        POLICY_1632 = 1632,
        [Description("格式错误")]
        POLICY_1701 = 1701,
        [Description("计划为空或者格式错误")]
        POLICY_1702 = 1702,
        [Description("计划利益项错误")]
        POLICY_1703 = 1703,
        [Description("计划名称错误")]
        POLICY_1704 = 1704,
        [Description("产品类别错误")]
        POLICY_1705 = 1705,
        [Description("计划描述错误")]
        POLICY_1706 = 1706,
        [Description("计费类型错误")]
        POLICY_1707 = 1707,
        [Description("计划计算单位错误")]
        POLICY_1708 = 1708,
        [Description("计划利益项ID错误")]
        POLICY_1709 = 1709,
        [Description("利益项重复")]
        POLICY_1710 = 1710,
        [Description("附加项类型错误")]
        POLICY_1711 = 1711,
        [Description("附加项错误")]
        POLICY_1712 = 1712,
        [Description("附加项名称为空")]
        POLICY_1713 = 1713,
        [Description("附加项下利益项错误")]
        POLICY_1714 = 1714,
        [Description("产品名称已经存在")]
        POLICY_1715 = 1715,
        [Description("分类不存在")]
        POLICY_1716 = 1716,
        [Description("附加项下利益项错误")]
        POLICY_1717 = 1717,
        [Description("团体的识别格式错误")]
        POLICY_1718 = 1718,
        [Description("计划备注未定义")]
        POLICY_1719 = 1719,
        [Description("已出单的附加保障项不能删除")]
        POLICY_1721 = 1721,
        [Description("没有删除权限")]
        POLICY_1752 = 1752,
        [Description("不存在的产品")]
        POLICY_1753 = 1753,
        [Description("该产品已有出单，无法删除")]
        POLICY_1754 = 1754,
        [Description("删除的计划已有出单，无法删除")]
        POLICY_1755 = 1755,
        [Description("投保单模板不能为空")]
        POLICY_1756 = 1756,
        [Description("投保单模板不存在")]
        POLICY_1757 = 1757,
        [Description("版本添加成功")]
        POLICY_1801 = 1801,
        [Description("辨别添加失败")]
        POLICY_1802 = 1802,
        [Description("版本编辑成功")]
        POLICY_1803 = 1803,
        [Description("数据无变化")]
        POLICY_1804 = 1804,
        [Description("代码不能为空")]
        POLICY_1805 = 1805,
        [Description("代码格式有误")]
        POLICY_1806 = 1806,
        [Description("名称不能为空")]
        POLICY_1807 = 1807,
        [Description("类型格式有误")]
        POLICY_1808 = 1808,
        [Description("开始时间格式有误")]
        POLICY_1809 = 1809,
        [Description("结束时间格式有误")]
        POLICY_1810 = 1810,
        [Description("字冠号不能为空")]
        POLICY_1811 = 1811,
        [Description("字冠号格式有误")]
        POLICY_1812 = 1812,
        [Description("有效状态格式有误")]
        POLICY_1813 = 1813,
        [Description("总数量不能为空")]
        POLICY_1814 = 1814,
        [Description("长度不能为空")]
        POLICY_1815 = 1815,
        [Description("总数量格式有误")]
        POLICY_1816 = 1816,
        [Description("长度格式有误")]
        POLICY_1817 = 1817,
        [Description("代码重复")]
        POLICY_1818 = 1818,
        [Description("起始流水号不能为空")]
        POLICY_1819 = 1819,
        [Description("起始流水号格式有误")]
        POLICY_1820 = 1820,
        [Description("不允许删除")]
        POLICY_1821 = 1821,
        [Description("删除成功")]
        POLICY_1822 = 1822,
        [Description("删除失败")]
        POLICY_1823 = 1823,
        [Description("入库失败")]
        POLICY_1824 = 1824,
        [Description("数量过大,入库失败")]
        POLICY_1825 = 1825,
        [Description("起始流水号存在,入库失败")]
        POLICY_1826 = 1826,
        [Description("数量为空,入库失败")]
        POLICY_1827 = 1827,
        [Description("起始流水号为空,入库失败")]
        POLICY_1828 = 1828,
        [Description("数量格式有误，入库失败")]
        POLICY_1829 = 1829,
        [Description("入库成功")]
        POLICY_1830 = 1830,
        [Description("入库失败")]
        POLICY_1831 = 1831,
        [Description("开始使用时间大于结束使用时")]
        POLICY_1832 = 1832,
        [Description("找不到分发对象")]
        POLICY_1833 = 1833,
        [Description("请选择分发机构")]
        POLICY_1834 = 1834,
        [Description("分发成功")]
        POLICY_1835 = 1835,
        [Description("分发失败")]
        POLICY_1836 = 1836,
        [Description("作废成功")]
        POLICY_1837 = 1837,
        [Description("作废失败")]
        POLICY_1838 = 1838,
        [Description("分发库存成功")]
        POLICY_1839 = 1839,
        [Description("分发库存失败")]
        POLICY_1840 = 1840,
        [Description("分发数量为空")]
        POLICY_1841 = 1841,
        [Description("机构为空")]
        POLICY_1842 = 1842,
        [Description("分发类型为空")]
        POLICY_1843 = 1843,
        [Description("不能分发给自己")]
        POLICY_1844 = 1844,
        [Description("版本时间过期")]
        POLICY_1845 = 1845,
        [Description("起始流水号长度有误")]
        POLICY_1846 = 1846,
        [Description("字冠号已经存在")]
        POLICY_1847 = 1847,
        [Description("流水号长度有误")]
        POLICY_1848 = 1848,
        [Description("请输入面额")]
        POLICY_1849 = 1849,
        [Description("面额格式有误")]
        POLICY_1850 = 1850,
        [Description("该状态不能操作")]
        POLICY_1851 = 1851,
        [Description("批扣ID失败")]
        POLICY_1900 = 1900,
        [Description("开户名称不能为空")]
        POLICY_1901 = 1901,
        [Description("银行名称不能为空")]
        POLICY_1902 = 1902,
        [Description("银行卡号不能为空")]
        POLICY_1903 = 1903,
        [Description("账户类型不能为空")]
        POLICY_1904 = 1904,
        [Description("登记成功")]
        POLICY_1905 = 1905,
        [Description("登记失败")]
        POLICY_1906 = 1906,
        [Description("授权操作成功")]
        POLICY_1907 = 1907,
        [Description("授权操作失败")]
        POLICY_1908 = 1908,
        [Description("扣款操作成功")]
        POLICY_1909 = 1909,
        [Description("扣款失败")]
        POLICY_1910 = 1910,
        [Description("批量授权操作成功")]
        POLICY_1911 = 1911,
        [Description("批量授权操作失败")]
        POLICY_1912 = 1912,
        [Description("批量扣款操作成功")]
        POLICY_1913 = 1913,
        [Description("批量扣款操作失败")]
        POLICY_1914 = 1914,
        [Description("批扣修改操作成功")]
        POLICY_1915 = 1915,
        [Description("批扣修改操作失败")]
        POLICY_1916 = 1916,
        [Description("开户支行不能为空")]
        POLICY_1917 = 1917,
        [Description("CVN2码不能为空")]
        POLICY_1918 = 1918,
        [Description("有效开始时间不能为空")]
        POLICY_1919 = 1919,
        [Description("有效结束时间不能为空")]
        POLICY_1920 = 1920,
        [Description("用户代码不能为空")]
        POLICY_1921 = 1921,
        [Description("保单状态错误或者不存在该保")]
        POLICY_1922 = 1922,
        [Description("批扣订单作废失败")]
        POLICY_1923 = 1923,
        [Description("批扣订单作废成功")]
        POLICY_1924 = 1924,
        [Description("拒保失败")]
        POLICY_3000 = 3000,
        [Description("拒保成功")]
        POLICY_3001 = 3001,
        [Description("审核失败")]
        POLICY_3002 = 3002,
        [Description("审核成功")]
        POLICY_3003 = 3003,
        [Description("没选择要上传的文件")]
        POLICY_3004 = 3004,
        [Description("上传文件过大")]
        POLICY_3005 = 3005,
        [Description("上传文件类型错误")]
        POLICY_3006 = 3006,
        [Description("文件上传失败")]
        POLICY_3007 = 3007,
        [Description("批量审核成功")]
        POLICY_3008 = 3008,
        [Description("拒保备注不能为空")]
        POLICY_3009 = 3009,
        [Description("产品切换成功")]
        POLICY_3010 = 3010,
        [Description("产品切换失败")]
        POLICY_3011 = 3011,
        [Description("续保编辑成功")]
        POLICY_3012 = 3012,
        [Description("续保编辑失败")]
        POLICY_3013 = 3013,
        [Description("该状态不能进行此操作")]
        POLICY_3014 = 3014,
        [Description("不续保成功")]
        POLICY_3015 = 3015,
        [Description("不续保失败")]
        POLICY_3016 = 3016,
        [Description("续保成功")]
        POLICY_3017 = 3017,
        [Description("续保失败")]
        POLICY_3018 = 3018,
        [Description("续保数据不存在")]
        POLICY_3019 = 3019,
        [Description("续保计划不存在")]
        POLICY_3020 = 3020,
        [Description("续保计划不变")]
        POLICY_3021 = 3021,
        [Description("该产品不能续保")]
        POLICY_3022 = 3022,
        [Description("保单状态错误")]
        POLICY_4000 = 4000,
        [Description("没有保单数据")]
        POLICY_4001 = 4001,
        [Description("支付申请成功，请等待")]
        POLICY_4002 = 4002,
        [Description("支付申请失败，请重试")]
        POLICY_4003 = 4003,
        [Description("支付申请取消已提交")]
        POLICY_4004 = 4004,
        [Description("支付申请取消失败")]
        POLICY_4005 = 4005,
        [Description("支付申请号已存在")]
        POLICY_4006 = 4006,
        [Description("请登录")]
        POLICY_4007 = 4007,
        [Description("投保人证件类型不能为空")]
        POLICY_1068 = 1068,
        [Description("投保人证件号码不能为空")]
        POLICY_1069 = 1069,
        [Description("投保人生日不能为空")]
        POLICY_1070 = 1070,
    }
}

﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WPF24
{
    class Program
    {
        static void Main(string[] args)
        {
            //string json = "{\"code\":10000,\"message\":\"ok\",\"description\":\"api请求成功\",\"uuid\":\"07c9df3bbc154ebc8e2e4d4c494ae569\",\"result\":{\"page\":2,\"per\":100,\"total\":138013,\"max_page\":1381,\"data_struct\":{\"STUDENTCODE\":\"学号\",\"STUSEX\":\"性别\",\"MAJORNAME\":\"专业名称\",\"COLLEGECODE\":\"学院代码\",\"MAJORCODE\":\"专业代码\",\"CLASSCODE\":\"班级编号\",\"STUNAME\":\"姓名\",\"GRADE\":\"年级\",\"COLLEGENAME\":\"学院名称\",\"XJZT\":\"学籍状态\"},\"data\":[{\"STUDENTCODE\":\"201402050213\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0205化学\",\"COLLEGECODE\":\"206         \",\"MAJORCODE\":\"B014  \",\"CLASSCODE\":\"2016020502  \",\"STUNAME\":\"吕文豪\",\"GRADE\":2016,\"COLLEGENAME\":\"材料与化学化工学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201403010608\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0301土木工程\",\"COLLEGECODE\":\"203         \",\"MAJORCODE\":\"B019  \",\"CLASSCODE\":\"2015030106  \",\"STUNAME\":\"李源\",\"GRADE\":2015,\"COLLEGENAME\":\"环境与土木工程学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201401110218\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0111地理信息科学\",\"COLLEGECODE\":\"201         \",\"MAJORCODE\":\"B006  \",\"CLASSCODE\":\"2015011102  \",\"STUNAME\":\"向权科\",\"GRADE\":2015,\"COLLEGENAME\":\"地球科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201412010104\",\"STUSEX\":\"男\",\"MAJORNAME\":\"1201建筑学\",\"COLLEGECODE\":\"215         \",\"MAJORCODE\":\"B103  \",\"CLASSCODE\":\"2014120102  \",\"STUNAME\":\"郑永彬\",\"GRADE\":2014,\"COLLEGENAME\":\"旅游与城乡规划学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201412010118\",\"STUSEX\":\"男\",\"MAJORNAME\":\"1201建筑学\",\"COLLEGECODE\":\"215         \",\"MAJORCODE\":\"B103  \",\"CLASSCODE\":\"2014120103  \",\"STUNAME\":\"骆宇\",\"GRADE\":2014,\"COLLEGENAME\":\"旅游与城乡规划学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201412010128\",\"STUSEX\":\"女\",\"MAJORNAME\":\"1201建筑学\",\"COLLEGECODE\":\"215         \",\"MAJORCODE\":\"B103  \",\"CLASSCODE\":\"2014120101  \",\"STUNAME\":\"刘婷\",\"GRADE\":2014,\"COLLEGENAME\":\"旅游与城乡规划学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201402060215\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0206新能源材料与器件\",\"COLLEGECODE\":\"206         \",\"MAJORCODE\":\"B015  \",\"CLASSCODE\":\"2016020601  \",\"STUNAME\":\"黄鑫\",\"GRADE\":2016,\"COLLEGENAME\":\"材料与化学化工学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201402070212\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0310地质工程（工程地质）\",\"COLLEGECODE\":\"203         \",\"MAJORCODE\":\"B032  \",\"CLASSCODE\":\"2017031001  \",\"STUNAME\":\"程超\",\"GRADE\":2017,\"COLLEGENAME\":\"环境与土木工程学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201410020240\",\"STUSEX\":\"女\",\"MAJORNAME\":\"1002广告学\",\"COLLEGECODE\":\"212         \",\"MAJORCODE\":\"B087  \",\"CLASSCODE\":\"2016100202  \",\"STUNAME\":\"陈菲\",\"GRADE\":2016,\"COLLEGENAME\":\"传播科学与艺术学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201413070119\",\"STUSEX\":\"男\",\"MAJORNAME\":\"1307通信工程\",\"COLLEGECODE\":\"214         \",\"MAJORCODE\":\"B122  \",\"CLASSCODE\":\"2015130701  \",\"STUNAME\":\"毛凯\",\"GRADE\":2015,\"COLLEGENAME\":\"信息科学与技术学院（网络安全学院、牛津布鲁克斯学院）\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201401060123\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0106测绘工程\",\"COLLEGECODE\":\"201         \",\"MAJORCODE\":\"B004  \",\"CLASSCODE\":\"2015010601  \",\"STUNAME\":\"王培\",\"GRADE\":2014,\"COLLEGENAME\":\"地球科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201413060121\",\"STUSEX\":\"男\",\"MAJORNAME\":\"1306物联网工程\",\"COLLEGECODE\":\"214         \",\"MAJORCODE\":\"B121  \",\"CLASSCODE\":\"2015130601  \",\"STUNAME\":\"张荣川\",\"GRADE\":2015,\"COLLEGENAME\":\"信息科学与技术学院（网络安全学院、牛津布鲁克斯学院）\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"2201410160219\",\"STUSEX\":\"女\",\"MAJORNAME\":\"1016广告设计与制作\",\"COLLEGECODE\":null,\"MAJORCODE\":\"B098  \",\"CLASSCODE\":\"22014101602 \",\"STUNAME\":\"吴忠祺\",\"GRADE\":2014,\"COLLEGENAME\":null,\"XJZT\":\"保留学籍\"},{\"STUDENTCODE\":\"201406020102\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0602核工程与核技术\",\"COLLEGECODE\":\"205         \",\"MAJORCODE\":\"B044  \",\"CLASSCODE\":\"2015060201  \",\"STUNAME\":\"杨帆\",\"GRADE\":2015,\"COLLEGENAME\":\"核技术与自动化工程学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201403030110\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0303工程管理\",\"COLLEGECODE\":\"203         \",\"MAJORCODE\":\"B024  \",\"CLASSCODE\":\"2015030301  \",\"STUNAME\":\"袁志彬\",\"GRADE\":2015,\"COLLEGENAME\":\"环境与土木工程学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201402070310\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0207化学工程与工艺\",\"COLLEGECODE\":\"206         \",\"MAJORCODE\":\"B016  \",\"CLASSCODE\":\"2016020703  \",\"STUNAME\":\"何浩\",\"GRADE\":2016,\"COLLEGENAME\":\"材料与化学化工学院\",\"XJZT\":\"待处理\"},{\"STUDENTCODE\":\"201406130208\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0613产品设计\",\"COLLEGECODE\":\"205         \",\"MAJORCODE\":\"B054  \",\"CLASSCODE\":\"2016061302  \",\"STUNAME\":\"涂杰\",\"GRADE\":2014,\"COLLEGENAME\":\"核技术与自动化工程学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201403030218\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0303工程管理\",\"COLLEGECODE\":\"203         \",\"MAJORCODE\":\"B024  \",\"CLASSCODE\":\"2016030302  \",\"STUNAME\":\"陈永贵\",\"GRADE\":2016,\"COLLEGENAME\":\"环境与土木工程学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201414010225\",\"STUSEX\":\"女\",\"MAJORNAME\":\"0902法学\",\"COLLEGECODE\":\"209         \",\"MAJORCODE\":\"B078  \",\"CLASSCODE\":\"2015090202  \",\"STUNAME\":\"刘芷瑶\",\"GRADE\":2015,\"COLLEGENAME\":\"法学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201302030306\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0203应用化学\",\"COLLEGECODE\":\"206         \",\"MAJORCODE\":\"B012  \",\"CLASSCODE\":\"2016020303  \",\"STUNAME\":\"张浩\",\"GRADE\":2016,\"COLLEGENAME\":\"材料与化学化工学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201302060112\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0206新能源材料与器件\",\"COLLEGECODE\":\"206         \",\"MAJORCODE\":\"B015  \",\"CLASSCODE\":\"2015020601  \",\"STUNAME\":\"陆光鑫\",\"GRADE\":2013,\"COLLEGENAME\":\"材料与化学化工学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"2201313010207\",\"STUSEX\":\"男\",\"MAJORNAME\":\"1313计算机信息管理 （中英）\",\"COLLEGECODE\":null,\"MAJORCODE\":\"B124  \",\"CLASSCODE\":\"22013130102 \",\"STUNAME\":\"邓斯吉\",\"GRADE\":2013,\"COLLEGENAME\":null,\"XJZT\":\"保留学籍\"},{\"STUDENTCODE\":\"201207020218\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0702信息与计算科学\",\"COLLEGECODE\":\"207         \",\"MAJORCODE\":\"B058  \",\"CLASSCODE\":\"2015070201  \",\"STUNAME\":\"张国川\",\"GRADE\":2015,\"COLLEGENAME\":\"管理科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"2201307200325\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0720商务管理（专科）\",\"COLLEGECODE\":\"207         \",\"MAJORCODE\":\"B068  \",\"CLASSCODE\":\"22013072003 \",\"STUNAME\":\"刘永兴\",\"GRADE\":2013,\"COLLEGENAME\":\"管理科学学院\",\"XJZT\":\"保留学籍\"},{\"STUDENTCODE\":\"201601050413\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0105资源勘查工程\",\"COLLEGECODE\":\"201         \",\"MAJORCODE\":\"B003  \",\"CLASSCODE\":\"2016010504  \",\"STUNAME\":\"姚富潭\",\"GRADE\":2016,\"COLLEGENAME\":\"地球科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201601130318\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0112地球化学\",\"COLLEGECODE\":\"201         \",\"MAJORCODE\":\"B007  \",\"CLASSCODE\":\"2016011202  \",\"STUNAME\":\"董鸿\",\"GRADE\":2016,\"COLLEGENAME\":\"地球科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201601050306\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0105资源勘查工程\",\"COLLEGECODE\":\"201         \",\"MAJORCODE\":\"B003  \",\"CLASSCODE\":\"2016010503  \",\"STUNAME\":\"肖斌\",\"GRADE\":2016,\"COLLEGENAME\":\"地球科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201601140622\",\"STUSEX\":\"女\",\"MAJORNAME\":\"0110遥感科学与技术\",\"COLLEGECODE\":\"201         \",\"MAJORCODE\":\"B005  \",\"CLASSCODE\":\"2016011002  \",\"STUNAME\":\"冯显杰\",\"GRADE\":2016,\"COLLEGENAME\":\"地球科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201601130510\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0112地球化学\",\"COLLEGECODE\":\"201         \",\"MAJORCODE\":\"B007  \",\"CLASSCODE\":\"2016011202  \",\"STUNAME\":\"郎蕾瑞\",\"GRADE\":2016,\"COLLEGENAME\":\"地球科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"3200808020406\",\"STUSEX\":\"男\",\"MAJORNAME\":null,\"COLLEGECODE\":null,\"MAJORCODE\":null,\"CLASSCODE\":\"2008080204  \",\"STUNAME\":\"李朋成\",\"GRADE\":2008,\"COLLEGENAME\":null,\"XJZT\":\"保留学籍\"},{\"STUDENTCODE\":\"201307080203\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0708土地资源管理\",\"COLLEGECODE\":\"207         \",\"MAJORCODE\":\"B064  \",\"CLASSCODE\":\"2015070801  \",\"STUNAME\":\"李智华\",\"GRADE\":2015,\"COLLEGENAME\":\"管理科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201310020107\",\"STUSEX\":\"男\",\"MAJORNAME\":\"1002广告学\",\"COLLEGECODE\":\"212         \",\"MAJORCODE\":\"B087  \",\"CLASSCODE\":\"2017100202  \",\"STUNAME\":\"陈宇\",\"GRADE\":2017,\"COLLEGENAME\":\"传播科学与艺术学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201301010102\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0101地质学\",\"COLLEGECODE\":\"201         \",\"MAJORCODE\":\"B001  \",\"CLASSCODE\":\"2015010101  \",\"STUNAME\":\"孙浩洋\",\"GRADE\":2013,\"COLLEGENAME\":\"地球科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201412010116\",\"STUSEX\":\"男\",\"MAJORNAME\":\"1201建筑学\",\"COLLEGECODE\":\"215         \",\"MAJORCODE\":\"B103  \",\"CLASSCODE\":\"2014120101  \",\"STUNAME\":\"方文甫\",\"GRADE\":2014,\"COLLEGENAME\":\"旅游与城乡规划学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201602040104\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0204材料科学与工程\",\"COLLEGECODE\":\"206         \",\"MAJORCODE\":\"B013  \",\"CLASSCODE\":\"2016020401  \",\"STUNAME\":\"孟成勇\",\"GRADE\":2016,\"COLLEGENAME\":\"材料与化学化工学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201708050308\",\"STUSEX\":\"女\",\"MAJORNAME\":\"0805财务管理\",\"COLLEGECODE\":\"211         \",\"MAJORCODE\":\"B073  \",\"CLASSCODE\":\"2017080503  \",\"STUNAME\":\"黄璇珂\",\"GRADE\":2017,\"COLLEGENAME\":\"商学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201606120303\",\"STUSEX\":\"男\",\"MAJORNAME\":\"1103翻译\",\"COLLEGECODE\":\"210         \",\"MAJORCODE\":\"B102  \",\"CLASSCODE\":\"2019110302  \",\"STUNAME\":\"陆俊\",\"GRADE\":2019,\"COLLEGENAME\":\"外国语学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201412050210\",\"STUSEX\":\"男\",\"MAJORNAME\":\"1205人文地理与城乡规划\",\"COLLEGECODE\":\"215         \",\"MAJORCODE\":\"B107  \",\"CLASSCODE\":\"2016120501  \",\"STUNAME\":\"王云龙\",\"GRADE\":2016,\"COLLEGENAME\":\"旅游与城乡规划学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201403010611\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0301土木工程\",\"COLLEGECODE\":\"203         \",\"MAJORCODE\":\"B019  \",\"CLASSCODE\":\"2015030106  \",\"STUNAME\":\"魏代炜\",\"GRADE\":2015,\"COLLEGENAME\":\"环境与土木工程学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201406060207\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0606工业设计\",\"COLLEGECODE\":\"205         \",\"MAJORCODE\":\"B047  \",\"CLASSCODE\":\"2014060602  \",\"STUNAME\":\"任家伟\",\"GRADE\":2014,\"COLLEGENAME\":\"核技术与自动化工程学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201405060324\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0506勘查技术与工程\",\"COLLEGECODE\":\"204         \",\"MAJORCODE\":\"B039  \",\"CLASSCODE\":\"2016050603  \",\"STUNAME\":\"高浩诚\",\"GRADE\":2014,\"COLLEGENAME\":\"地球物理学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201406010326\",\"STUSEX\":\"女\",\"MAJORNAME\":\"0601测控技术与仪器\",\"COLLEGECODE\":\"205         \",\"MAJORCODE\":\"B043  \",\"CLASSCODE\":\"2015060103  \",\"STUNAME\":\"张佩文\",\"GRADE\":2015,\"COLLEGENAME\":\"核技术与自动化工程学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201405050112\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0505地球物理学\",\"COLLEGECODE\":\"204         \",\"MAJORCODE\":\"B038  \",\"CLASSCODE\":\"2015050501  \",\"STUNAME\":\"梁卿山\",\"GRADE\":2014,\"COLLEGENAME\":\"地球物理学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201302050112\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0205化学\",\"COLLEGECODE\":\"206         \",\"MAJORCODE\":\"B014  \",\"CLASSCODE\":\"2015020501  \",\"STUNAME\":\"吴思凯\",\"GRADE\":2013,\"COLLEGENAME\":\"材料与化学化工学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201407030102\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0703信息管理与信息系统\",\"COLLEGECODE\":\"207         \",\"MAJORCODE\":\"B059  \",\"CLASSCODE\":\"2015070301  \",\"STUNAME\":\"邸益琛\",\"GRADE\":2015,\"COLLEGENAME\":\"管理科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201402050114\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0205化学\",\"COLLEGECODE\":\"206         \",\"MAJORCODE\":\"B014  \",\"CLASSCODE\":\"2015020501  \",\"STUNAME\":\"何召飞\",\"GRADE\":2015,\"COLLEGENAME\":\"材料与化学化工学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201402060115\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0206新能源材料与器件\",\"COLLEGECODE\":\"206         \",\"MAJORCODE\":\"B015  \",\"CLASSCODE\":\"2016020601  \",\"STUNAME\":\"王傲\",\"GRADE\":2016,\"COLLEGENAME\":\"材料与化学化工学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201415020121\",\"STUSEX\":\"男\",\"MAJORNAME\":\"1502社会体育指导与管理\",\"COLLEGECODE\":\"213         \",\"MAJORCODE\":\"B130  \",\"CLASSCODE\":\"2015150201  \",\"STUNAME\":\"郭猛\",\"GRADE\":2015,\"COLLEGENAME\":\"体育学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201401010304\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0101地质学\",\"COLLEGECODE\":\"201         \",\"MAJORCODE\":\"B001  \",\"CLASSCODE\":\"2015010103  \",\"STUNAME\":\"贺辉波\",\"GRADE\":2014,\"COLLEGENAME\":\"地球科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201406050225\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0605电气工程及其自动化\",\"COLLEGECODE\":\"205         \",\"MAJORCODE\":\"B046  \",\"CLASSCODE\":\"2016060502  \",\"STUNAME\":\"郭康\",\"GRADE\":2014,\"COLLEGENAME\":\"核技术与自动化工程学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201403030226\",\"STUSEX\":\"女\",\"MAJORNAME\":\"0303工程管理\",\"COLLEGECODE\":\"203         \",\"MAJORCODE\":\"B024  \",\"CLASSCODE\":\"2015030302  \",\"STUNAME\":\"黄思奇\",\"GRADE\":2015,\"COLLEGENAME\":\"环境与土木工程学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201412010110\",\"STUSEX\":\"男\",\"MAJORNAME\":\"1201建筑学\",\"COLLEGECODE\":\"215         \",\"MAJORCODE\":\"B103  \",\"CLASSCODE\":\"2014120102  \",\"STUNAME\":\"李安洪\",\"GRADE\":2014,\"COLLEGENAME\":\"旅游与城乡规划学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201406120229\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0612机械工程\",\"COLLEGECODE\":\"205         \",\"MAJORCODE\":\"B053  \",\"CLASSCODE\":\"2014061202  \",\"STUNAME\":\"杨秀坤\",\"GRADE\":2014,\"COLLEGENAME\":\"核技术与自动化工程学院\",\"XJZT\":\"休学\"},{\"STUDENTCODE\":\"201408030408\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0803经济学\",\"COLLEGECODE\":\"211         \",\"MAJORCODE\":\"B071  \",\"CLASSCODE\":\"2015080301  \",\"STUNAME\":\"周昊晟\",\"GRADE\":2015,\"COLLEGENAME\":\"商学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201403100528\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0311地质工程（钻掘工程）\",\"COLLEGECODE\":\"203         \",\"MAJORCODE\":\"B034  \",\"CLASSCODE\":\"2015031005  \",\"STUNAME\":\"南文泽\",\"GRADE\":2015,\"COLLEGENAME\":\"环境与土木工程学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201404010411\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0401石油工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B035  \",\"CLASSCODE\":\"2017040101  \",\"STUNAME\":\"张鹏飞\",\"GRADE\":2017,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201412020201\",\"STUSEX\":\"男\",\"MAJORNAME\":\"1202旅游管理\",\"COLLEGECODE\":\"215         \",\"MAJORCODE\":\"B104  \",\"CLASSCODE\":\"2015120201  \",\"STUNAME\":\"李凯\",\"GRADE\":2015,\"COLLEGENAME\":\"旅游与城乡规划学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201401010228\",\"STUSEX\":\"女\",\"MAJORNAME\":\"0804会计学\",\"COLLEGECODE\":\"211         \",\"MAJORCODE\":\"B072  \",\"CLASSCODE\":\"2015080405  \",\"STUNAME\":\"寇铭洋\",\"GRADE\":2015,\"COLLEGENAME\":\"商学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201412010137\",\"STUSEX\":\"女\",\"MAJORNAME\":\"1201建筑学\",\"COLLEGECODE\":\"215         \",\"MAJORCODE\":\"B103  \",\"CLASSCODE\":\"2014120101  \",\"STUNAME\":\"刘小玲\",\"GRADE\":2014,\"COLLEGENAME\":\"旅游与城乡规划学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201403010115\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0301土木工程\",\"COLLEGECODE\":\"203         \",\"MAJORCODE\":\"B019  \",\"CLASSCODE\":\"2016030101  \",\"STUNAME\":\"张雪峰\",\"GRADE\":2016,\"COLLEGENAME\":\"环境与土木工程学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201403010127\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0301土木工程\",\"COLLEGECODE\":\"203         \",\"MAJORCODE\":\"B019  \",\"CLASSCODE\":\"2015030101  \",\"STUNAME\":\"张鼎鑫\",\"GRADE\":2015,\"COLLEGENAME\":\"环境与土木工程学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201404020424\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0706人力资源管理\",\"COLLEGECODE\":\"207         \",\"MAJORCODE\":\"B062  \",\"CLASSCODE\":\"2017070601  \",\"STUNAME\":\"王忠浩\",\"GRADE\":2017,\"COLLEGENAME\":\"管理科学学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201405060116\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0506勘查技术与工程\",\"COLLEGECODE\":\"204         \",\"MAJORCODE\":\"B039  \",\"CLASSCODE\":\"2015050601  \",\"STUNAME\":\"徐高阳\",\"GRADE\":2015,\"COLLEGENAME\":\"地球物理学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201804040111\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0404海洋油气工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B149  \",\"CLASSCODE\":\"2018040401  \",\"STUNAME\":\"郑鑫\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804040112\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0404海洋油气工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B149  \",\"CLASSCODE\":\"2018040401  \",\"STUNAME\":\"刘富强\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804040113\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0404海洋油气工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B149  \",\"CLASSCODE\":\"2018040401  \",\"STUNAME\":\"李思远\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804040114\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0404海洋油气工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B149  \",\"CLASSCODE\":\"2018040401  \",\"STUNAME\":\"罗怡平\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804040115\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0404海洋油气工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B149  \",\"CLASSCODE\":\"2018040401  \",\"STUNAME\":\"杨志贤\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804040116\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0404海洋油气工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B149  \",\"CLASSCODE\":\"2018040401  \",\"STUNAME\":\"李富伟\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804040117\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0404海洋油气工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B149  \",\"CLASSCODE\":\"2018040401  \",\"STUNAME\":\"姜志龙\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804040118\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0404海洋油气工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B149  \",\"CLASSCODE\":\"2018040401  \",\"STUNAME\":\"刘毅恒\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201306030110\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0112地球化学\",\"COLLEGECODE\":\"201         \",\"MAJORCODE\":\"B007  \",\"CLASSCODE\":\"2015011201  \",\"STUNAME\":\"杨家琛\",\"GRADE\":2013,\"COLLEGENAME\":\"地球科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201804010224\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0401石油工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B035  \",\"CLASSCODE\":\"2018040102  \",\"STUNAME\":\"李杨淇\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804010226\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0401石油工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B035  \",\"CLASSCODE\":\"2018040102  \",\"STUNAME\":\"余胜\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804010227\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0401石油工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B035  \",\"CLASSCODE\":\"2018040105  \",\"STUNAME\":\"江朋宇\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804010228\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0401石油工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B035  \",\"CLASSCODE\":\"2018040102  \",\"STUNAME\":\"陈泊\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804010229\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0401石油工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B035  \",\"CLASSCODE\":\"2018040102  \",\"STUNAME\":\"唐志淏\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804010230\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0401石油工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B035  \",\"CLASSCODE\":\"2018040105  \",\"STUNAME\":\"张一帆\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804010302\",\"STUSEX\":\"女\",\"MAJORNAME\":\"0401石油工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B035  \",\"CLASSCODE\":\"2018040105  \",\"STUNAME\":\"邹雪飞\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804010303\",\"STUSEX\":\"女\",\"MAJORNAME\":\"1701计算机科学与技术\",\"COLLEGECODE\":\"214         \",\"MAJORCODE\":\"B118  \",\"CLASSCODE\":\"2018170103  \",\"STUNAME\":\"涂明君\",\"GRADE\":2018,\"COLLEGENAME\":\"信息科学与技术学院（网络安全学院、牛津布鲁克斯学院）\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804010304\",\"STUSEX\":\"女\",\"MAJORNAME\":\"1316计算机类\",\"COLLEGECODE\":\"214         \",\"MAJORCODE\":\"B127  \",\"CLASSCODE\":\"2019131607  \",\"STUNAME\":\"宋思佳\",\"GRADE\":2019,\"COLLEGENAME\":\"信息科学与技术学院（网络安全学院、牛津布鲁克斯学院）\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804010307\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0401石油工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B035  \",\"CLASSCODE\":\"2018040103  \",\"STUNAME\":\"张翱\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804010308\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0401石油工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B035  \",\"CLASSCODE\":\"2018040103  \",\"STUNAME\":\"高宪东\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804010309\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0401石油工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B035  \",\"CLASSCODE\":\"2018040105  \",\"STUNAME\":\"王康佳\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"200805070225\",\"STUSEX\":\"男\",\"MAJORNAME\":null,\"COLLEGECODE\":null,\"MAJORCODE\":null,\"CLASSCODE\":\"2008050702  \",\"STUNAME\":\"曹建\",\"GRADE\":2008,\"COLLEGENAME\":null,\"XJZT\":\"保留学籍\"},{\"STUDENTCODE\":\"201805060119\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0506勘查技术与工程\",\"COLLEGECODE\":\"204         \",\"MAJORCODE\":\"B039  \",\"CLASSCODE\":\"2018050601  \",\"STUNAME\":\"汪政洋\",\"GRADE\":2018,\"COLLEGENAME\":\"地球物理学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201805060120\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0506勘查技术与工程\",\"COLLEGECODE\":\"204         \",\"MAJORCODE\":\"B039  \",\"CLASSCODE\":\"2018050601  \",\"STUNAME\":\"陈昌凯\",\"GRADE\":2018,\"COLLEGENAME\":\"地球物理学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201805060121\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0506勘查技术与工程\",\"COLLEGECODE\":\"204         \",\"MAJORCODE\":\"B039  \",\"CLASSCODE\":\"2018050601  \",\"STUNAME\":\"窦汝训\",\"GRADE\":2018,\"COLLEGENAME\":\"地球物理学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201805060122\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0506勘查技术与工程\",\"COLLEGECODE\":\"204         \",\"MAJORCODE\":\"B039  \",\"CLASSCODE\":\"2018050601  \",\"STUNAME\":\"赵以健\",\"GRADE\":2018,\"COLLEGENAME\":\"地球物理学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804030227\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0403新能源科学与工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B037  \",\"CLASSCODE\":\"2018040302  \",\"STUNAME\":\"王浩\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804030228\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0403新能源科学与工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B037  \",\"CLASSCODE\":\"2018040302  \",\"STUNAME\":\"陈福杰\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804030229\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0403新能源科学与工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B037  \",\"CLASSCODE\":\"2018040302  \",\"STUNAME\":\"王宇琪\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804030230\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0403新能源科学与工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B037  \",\"CLASSCODE\":\"2018040302  \",\"STUNAME\":\"杨冕\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201306110124\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0611核化工与核燃料工程\",\"COLLEGECODE\":\"205         \",\"MAJORCODE\":\"B052  \",\"CLASSCODE\":\"2016061101  \",\"STUNAME\":\"王星鉴\",\"GRADE\":2013,\"COLLEGENAME\":\"核技术与自动化工程学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201307080102\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0111地理信息科学\",\"COLLEGECODE\":\"201         \",\"MAJORCODE\":\"B006  \",\"CLASSCODE\":\"2015011101  \",\"STUNAME\":\"李聪\",\"GRADE\":2013,\"COLLEGENAME\":\"地球科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201301050123\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0105资源勘查工程\",\"COLLEGECODE\":\"201         \",\"MAJORCODE\":\"B003  \",\"CLASSCODE\":\"2015010501  \",\"STUNAME\":\"周昆\",\"GRADE\":2013,\"COLLEGENAME\":\"地球科学学院\",\"XJZT\":\"已离校\"},{\"STUDENTCODE\":\"201804030231\",\"STUSEX\":\"男\",\"MAJORNAME\":\"0403新能源科学与工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B037  \",\"CLASSCODE\":\"2018040302  \",\"STUNAME\":\"冯森玄\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804040101\",\"STUSEX\":\"女\",\"MAJORNAME\":\"0404海洋油气工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B149  \",\"CLASSCODE\":\"2018040401  \",\"STUNAME\":\"吴奥琪\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804040102\",\"STUSEX\":\"女\",\"MAJORNAME\":\"0404海洋油气工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B149  \",\"CLASSCODE\":\"2018040401  \",\"STUNAME\":\"王婕熙\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"},{\"STUDENTCODE\":\"201804040103\",\"STUSEX\":\"女\",\"MAJORNAME\":\"0404海洋油气工程\",\"COLLEGECODE\":\"202         \",\"MAJORCODE\":\"B149  \",\"CLASSCODE\":\"2018040401  \",\"STUNAME\":\"兰欣\",\"GRADE\":2018,\"COLLEGENAME\":\"能源学院\",\"XJZT\":\"在籍\"}]}}";

            //StudentsInfo studentsInfo = new JavaScriptSerializer().Deserialize<StudentsInfo>(json);
            //StudentsInfo studentsInfo = JsonConvert.DeserializeObject<StudentsInfo>(json);
            ////Console.WriteLine(studentsInfo.description);
            ////Console.WriteLine(studentsInfo.result.data[0].STUNAME);
            //foreach (var item in studentsInfo.result.data)
            //{
            //    Console.WriteLine(item);
            //}

            string json = @"{""Property1"":[
    {
        ""id"": 17,
        ""t"": ""ECT-0091890"",
        ""z"": ""20083"",
        ""n"": ""检修盖板的碟型垫片更换""
    },
    {
        ""id"": 16,
        ""t"": ""ECT-0127844"",
        ""z"": ""20095"",
        ""n"": ""司机室进风口增加挡板""
    },
    {
        ""id"": 3,
        ""t"": ""0"",
        ""z"": ""20080"",
        ""n"": ""KV阀阀体更换""
    },
    {
        ""id"": 2,
        ""t"": ""ECT-0028187"",
        ""z"": ""20081"",
        ""n"": ""oem控制器改国产控制器""
    },
    {
        ""id"": 1,
        ""t"": ""ECT-0095963"",
        ""z"": ""20070"",
        ""n"": ""手动温控开关整改""
    }
]}
";
            //构建字符串
            //Rootobject rootobject= new JavaScriptSerializer().Deserialize<Rootobject>(json);
            //Rootobject studentsInfo = JsonConvert.DeserializeObject<Rootobject>(json);

            //foreach (var item in rootobject.Property1)
            //{
            //    Console.WriteLine(item);
            //}

            string json0 = @"[
    {
        ""id"": 17,
        ""t"": ""ECT-0091890"",
        ""z"": ""20083"",
        ""n"": ""检修盖板的碟型垫片更换""
    },
    {
        ""id"": 16,
        ""t"": ""ECT-0127844"",
        ""z"": ""20095"",
        ""n"": ""司机室进风口增加挡板""
    },
    {
        ""id"": 3,
        ""t"": ""0"",
        ""z"": ""20080"",
        ""n"": ""KV阀阀体更换""
    },
    {
        ""id"": 2,
        ""t"": ""ECT-0028187"",
        ""z"": ""20081"",
        ""n"": ""oem控制器改国产控制器""
    },
    {
        ""id"": 1,
        ""t"": ""ECT-0095963"",
        ""z"": ""20070"",
        ""n"": ""手动温控开关整改""
    }
]}
";
            //使用List
            var aa0 = new JavaScriptSerializer().Deserialize<List<Class1>>(json0);
            var aa1 = JsonConvert.DeserializeObject<List<Class1>>(json0);

            //使用数组
            var aa2 = new JavaScriptSerializer().Deserialize<Class1[]>(json0);
            var aa3 = JsonConvert.DeserializeObject<Class1[]>(json0);
        }
    }

    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }
    public class Class1
    {
        public int id { get; set; }
        public string t { get; set; }
        public string z { get; set; }
        public string n { get; set; }

        public override string ToString()
        {
            return "id：" + id + "\tt:" + t + "\tz:" + z + "\tn:" + n;
        }
    }


    public class StudentsInfo
    {
        public int code { get; set; }
        public string message { get; set; }
        public string description { get; set; }
        public string uuid { get; set; }
        public Result result { get; set; }


        public class Result
        {
            public int page { get; set; }
            public int per { get; set; }
            public int total { get; set; }
            public int max_page { get; set; }
            public Data_Struct data_struct { get; set; }
            public Datum[] data { get; set; }
        }

        public class Data_Struct
        {
            public string STUDENTCODE { get; set; }
            public string STUSEX { get; set; }
            public string MAJORNAME { get; set; }
            public string COLLEGECODE { get; set; }
            public string MAJORCODE { get; set; }
            public string CLASSCODE { get; set; }
            public string STUNAME { get; set; }
            public string GRADE { get; set; }
            public string COLLEGENAME { get; set; }
            public string XJZT { get; set; }
        }

        public class Datum
        {
            public string STUDENTCODE { get; set; }
            public string STUSEX { get; set; }
            public string MAJORNAME { get; set; }
            public string COLLEGECODE { get; set; }
            public string MAJORCODE { get; set; }
            public string CLASSCODE { get; set; }
            public string STUNAME { get; set; }
            public int GRADE { get; set; }
            public string COLLEGENAME { get; set; }
            public string XJZT { get; set; }

            public override string ToString()
            {
                return "姓名：" + STUNAME + "\t学号:" + STUDENTCODE;
            }
        }
    }

}

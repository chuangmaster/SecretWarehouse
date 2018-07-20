using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineBotProject.Infrastructure.MessageTemplate.TextMessage
{
    /// <summary>
    /// class GreetingTemplete
    /// </summary>
    public class GreetingTemplete
    {
        /// <summary>
        /// 歡迎訊息
        /// </summary>
        public static readonly string template = @"我們等你好久了❤️
秘密倉庫歡迎你！
#開箱分享
▪【秘密倉庫】
👉 https://www.secretwarehousetw.com/
#買賣分享交流區
▪ 社團【秘密倉庫】
👉 https://goo.gl/jEnRtM

＃精選好物
▪ 社團【秘密倉庫】選物市集
👉 https://goo.gl/9KDSuU
";

        public string GreetingHint = @"感謝您將【秘密倉庫】設為好友！(happy)
期待您跟我們分享有趣的新事物喔! 
臉書: https://www.facebook.com/groups/secretwarehouse/
萬一您覺得提醒的次數有點多，您可以在本畫面的聊天室設定選單中，將「提醒」的功能關掉喔！(ok)";
    }
}
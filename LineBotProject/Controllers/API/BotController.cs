using isRock.LineBot;
using LineBotProject.Infrastructure.MessageTemplate.FlexMessage;
using LineBotProject.Infrastructure.MessageTemplate.TextMessage;
using Service;
using Service.Parameters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace LineBotProject.Controllers.API
{
    public class BotController : LineWebHookControllerBase
    {
        readonly string UserID = "Your User ID";
        readonly UserService _UserService;
        //UserService 
        public BotController()
        {
            base.ChannelAccessToken = ConfigurationManager.AppSettings["ChannelAccessToken"];
            _UserService = new UserService();
        }
        [HttpPost]
        [Route("~/api/bot")]
        public IHttpActionResult BotService()
        {
            try
            {
                //取得Line Event
                var LineEvent = this.ReceivedMessage.events.FirstOrDefault();
                //配合Line verify 
                if (LineEvent.replyToken == "00000000000000000000000000000000") return Ok();

                var UserInfo = GetUserInfo(LineEvent.source.userId);
                if (LineEvent.type == "join" || LineEvent.type == "follow")
                {
                    var IsExist = _UserService.GetAll().Any(x => x.UserId == UserInfo.userId);
                    if (IsExist)
                    {
                        _UserService.Update(new UpdateUserParameter()
                        {
                            UserId = UserInfo.userId,
                            Name = UserInfo.displayName,
                            IsBlocked = false,
                        });
                    }
                    else
                    {
                        _UserService.Create(UserInfo.userId, UserInfo.displayName);
                    }
                    this.ReplyMessage(LineEvent.replyToken, GreetingTemplete.template);
                }

                if (LineEvent.type == "unfollow")
                {
                    _UserService.Update(new UpdateUserParameter()
                    {
                        UserId = UserInfo.userId,
                        Name = UserInfo.displayName,
                        IsBlocked = true,
                    });
                }

                if (LineEvent.type == "message")
                {
                    if (LineEvent.message.text == "test")
                    {
                        var sb = new StringBuilder();
                        sb.AppendLine($"ID:{LineEvent.source.userId}");
                        sb.AppendLine($"Echo Msg:{LineEvent.message.text}");
                        this.ReplyMessage(LineEvent.replyToken, sb.ToString());
                    }

                    if (LineEvent.message.text == "驗證")
                    {
                        var validateResult = _UserService.Create(UserInfo.userId, UserInfo.displayName);

                        this.ReplyMessage(LineEvent.replyToken, validateResult ? "驗證成功" : "驗證失敗");
                    }

                    if (LineEvent.message.text == "我要參加秘密倉庫沙龍") //收Flex Messages
                    {
                        var flexMsg = FlexMessages.SalonTemplate;
                        this.ReplyMessageWithJSON(LineEvent.replyToken, flexMsg);
                    }

                    //if (LineEvent.message.text == "text") //收到文字
                    //    this.ReplyMessage(LineEvent.replyToken, "你說了:" + LineEvent.message.text);

                    //if (LineEvent.message.text == "sticker") //收到貼圖
                    //    this.ReplyMessage(LineEvent.replyToken, 1, 2);
                }
            }
            catch (Exception ex)
            {
                //將錯誤資訊Push給 Admin
                this.PushMessage(UserID, ex.Message);
            }
            return Ok();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineBotProject.Infrastructure.MessageTemplate.FlexMessage
{
    /// <summary>
    /// class ShoppingFlexMessage
    /// </summary>
    public class ShoppingFlexMessage
    {
        public static readonly string Template = @"
[
    {
      ""type"": ""flex"",
      ""altText"": ""This is a Flex Message"",
      ""contents"": 
{
  ""type"": ""carousel"",
  ""contents"": [
    {
      ""type"": ""bubble"",
      ""hero"": {
        ""type"": ""image"",
        ""size"": ""full"",
        ""aspectRatio"": ""20:13"",
        ""aspectMode"": ""cover"",
        ""url"": ""https://scdn.line-apps.com/n/channel_devcenter/img/fx/01_5_carousel.png""
      },
      ""body"": {
        ""type"": ""box"",
        ""layout"": ""vertical"",
        ""spacing"": ""sm"",
        ""contents"": [
          {
            ""type"": ""text"",
            ""text"": ""Arm Chair, White"",
            ""wrap"": true,
            ""weight"": ""bold"",
            ""size"": ""xl""
          },
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""$49"",
                ""wrap"": true,
                ""weight"": ""bold"",
                ""size"": ""xl"",
                ""flex"": 0
              },
              {
                ""type"": ""text"",
                ""text"": "".99"",
                ""wrap"": true,
                ""weight"": ""bold"",
                ""size"": ""sm"",
                ""flex"": 0
              }
            ]
          }
        ]
      },
      ""footer"": {
        ""type"": ""box"",
        ""layout"": ""vertical"",
        ""spacing"": ""sm"",
        ""contents"": [
          {
            ""type"": ""button"",
            ""style"": ""primary"",
            ""action"": {
              ""type"": ""uri"",
              ""label"": ""Add to Cart"",
              ""uri"": ""https://linecorp.com""
            }
          },
          {
            ""type"": ""button"",
            ""action"": {
              ""type"": ""uri"",
              ""label"": ""Add to wishlist"",
              ""uri"": ""https://linecorp.com""
            }
          }
        ]
      }
    },
    {
      ""type"": ""bubble"",
      ""hero"": {
        ""type"": ""image"",
        ""size"": ""full"",
        ""aspectRatio"": ""20:13"",
        ""aspectMode"": ""cover"",
        ""url"": ""https://scdn.line-apps.com/n/channel_devcenter/img/fx/01_6_carousel.png""
      },
      ""body"": {
        ""type"": ""box"",
        ""layout"": ""vertical"",
        ""spacing"": ""sm"",
        ""contents"": [
          {
            ""type"": ""text"",
            ""text"": ""Metal Desk Lamp"",
            ""wrap"": true,
            ""weight"": ""bold"",
            ""size"": ""xl""
          },
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""flex"": 1,
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""$11"",
                ""wrap"": true,
                ""weight"": ""bold"",
                ""size"": ""xl"",
                ""flex"": 0
              },
              {
                ""type"": ""text"",
                ""text"": "".99"",
                ""wrap"": true,
                ""weight"": ""bold"",
                ""size"": ""sm"",
                ""flex"": 0
              }
            ]
          },
          {
            ""type"": ""text"",
            ""text"": ""Temporarily out of stock"",
            ""wrap"": true,
            ""size"": ""xxs"",
            ""margin"": ""md"",
            ""color"": ""#ff5551"",
            ""flex"": 0
          }
        ]
      },
      ""footer"": {
        ""type"": ""box"",
        ""layout"": ""vertical"",
        ""spacing"": ""sm"",
        ""contents"": [
          {
            ""type"": ""button"",
            ""flex"": 2,
            ""style"": ""primary"",
            ""color"": ""#aaaaaa"",
            ""action"": {
              ""type"": ""uri"",
              ""label"": ""我是縮址"",
              ""uri"": ""https://goo.gl/5cPe4v""
            }
          },
          {
            ""type"": ""button"",
            ""action"": {
              ""type"": ""uri"",
              ""label"": ""Add to wish list"",
              ""uri"": ""https://linecorp.com""
            }
          }
        ]
      }
    },
    {
      ""type"": ""bubble"",
      ""body"": {
        ""type"": ""box"",
        ""layout"": ""vertical"",
        ""spacing"": ""sm"",
        ""contents"": [
          {
            ""type"": ""button"",
            ""flex"": 1,
            ""gravity"": ""center"",
            ""action"": {
              ""type"": ""uri"",
              ""label"": ""See more"",
              ""uri"": ""https://linecorp.com""
            }
          }
        ]
      }
    }
  ]
}
    }
]
";
    }
}
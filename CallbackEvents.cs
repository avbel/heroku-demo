using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bandwidth.Net.Extra;
using Bandwidth.Net.Api;
using Bandwidth.Net;
using Microsoft.AspNetCore.Http;

namespace heroku_demo
{
    public static class CallbackEvents
    {
        public static readonly Dictionary<CallbackEventType, System.Func<CallbackEvent, HttpContext, Task>> Calls = new Dictionary<CallbackEventType, System.Func<CallbackEvent, HttpContext, Task>>
      {
          {CallbackEventType.Answer, async (data, context) =>
              {
                  if(data.To == (string)context.Items["PhoneNumber"])
                  {
                      var call = (ICall)context.RequestServices.GetService(typeof(ICall));
                      await call.SpeakSentenceAsync(data.CallId, "Not implemented yet");
                  }
              }
          }
      };

        public static readonly Dictionary<CallbackEventType, System.Func<CallbackEvent, HttpContext, Task>> Messages = new Dictionary<CallbackEventType, System.Func<CallbackEvent, HttpContext, Task>>
      {
          {CallbackEventType.Sms, async (data, context) =>
              {
                  if(data.To == (string)context.Items["PhoneNumber"] && data.Direction == MessageDirection.In)
                  {
                      var message = (IMessage)context.RequestServices.GetService(typeof(IMessage));
                      await message.SendAsync(new MessageData
                      {
                          From = data.To,
                          To = data.From,
                          Text = "Not implemented yet"
                      });
                  }
              }
          }
      };
    }
}

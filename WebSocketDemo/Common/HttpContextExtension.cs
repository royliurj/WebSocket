using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSocketDemo.Common
{
    public static class HttpContextExtension
    {
        public static void AcceptWebSocketRequest(this HttpContext context, WebSocketHandler handler)
        {
            context.AcceptWebSocketRequest(handler.ProcessRequest);
        }
    }
}
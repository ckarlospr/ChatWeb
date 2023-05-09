using ChatWS.Models.WS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChatWS.Controllers
{
    public class UserController : ApiController
    {
        public Reply HolaMundo()
        {
            Reply oReply = new Reply();
            oReply.result = 1;
            oReply.message = "Hola Mundo";


            return oReply;
        }
    }
}

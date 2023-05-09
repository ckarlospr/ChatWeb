using ChatWS.Models.ViewModel;
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
        [HttpGet]
        public Reply Get()
        {
            Reply oReply = new Reply();
            using (Models.ChatDBEntities1 db = new Models.ChatDBEntities1())
            {
                List<UserViewModel> lst = (from d in db.users
                                          select new UserViewModel
                                          {
                                              name = d.name,
                                              city = d.city
                                          }).ToList();
                oReply.result = 1;
                oReply.data = lst;
            }
            return oReply;
        }
    }
}

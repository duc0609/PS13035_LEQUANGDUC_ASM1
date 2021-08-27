using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PS13035_LEQUANGDUC_ASM1.Filters;
using PS13035_LEQUANGDUC_ASM1.Constant;



namespace PS13035_LEQUANGDUC_ASM1.Controllers
{
    [AuthenticationFilter]
    public abstract class BaseController : Controller
    {
        public BaseController()
        {
        }

        protected string GetUserName()
        {
            return HttpContext.Session.GetString(SessionKey.Nguoidung.UserName);
        }
        protected string GetFullName()
        {
            return HttpContext.Session.GetString(SessionKey.Nguoidung.FullName);
        }

        protected string GetKHEmail()
        {
            return HttpContext.Session.GetString(SessionKey.Khachhang.KH_Email);
        }
    }
}

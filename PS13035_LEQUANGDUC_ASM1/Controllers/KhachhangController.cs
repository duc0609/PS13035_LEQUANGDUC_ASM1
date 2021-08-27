using Microsoft.AspNetCore.Mvc;
using PS13035_LEQUANGDUC_ASM1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS13035_LEQUANGDUC_ASM1.Controllers
{
    public class KhachhangController : BaseController
    {
        private IKhachhangSvc _khachhangSvc;

        public KhachhangController (IKhachhangSvc khachhangSvc)

        {
            _khachhangSvc = khachhangSvc;
        }
        public ActionResult Index()
        {
            return View(_khachhangSvc.GetKhachhangAll());
        }
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}

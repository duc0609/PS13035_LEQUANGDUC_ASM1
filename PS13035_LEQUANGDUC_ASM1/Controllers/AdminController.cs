using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using PS13035_LEQUANGDUC_ASM1.Services;
using PS13035_LEQUANGDUC_ASM1.Constant;
using PS13035_LEQUANGDUC_ASM1.Models.ViewModels;
using PS13035_LEQUANGDUC_ASM1.Models;
using Newtonsoft.Json;

namespace PS13035_LEQUANGDUC_ASM1.Controllers
{
    public class AdminController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private INguoidungSvc _nguoidungSvc;
        public AdminController(IWebHostEnvironment webHostEnvironment, INguoidungSvc nguoidungSvc)
        {
            _webHostEnvironment = webHostEnvironment;
            _nguoidungSvc = nguoidungSvc;
        }
        public IActionResult Login (string returnUrl)
        {
            String userName = HttpContext.Session.GetString(SessionKey.Nguoidung.UserName);
            if (userName != null && userName != "")  // đã có session
            {
                return RedirectToAction("Index", "Home");
            }       
            ViewLogin login = new ViewLogin();
            login.ReturnUrl = returnUrl;
            return View(login);
        }
        public ActionResult Index()
        {
            return View();
        }
        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult login(ViewLogin viewLogin)
        {
            if (ModelState.IsValid)
            {
                Nguoidung nguoidung = _nguoidungSvc.Login(viewLogin);
                if(nguoidung != null)
                {
                    HttpContext.Session.SetString(SessionKey.Nguoidung.UserName, nguoidung.UserName);
                    HttpContext.Session.SetString(SessionKey.Nguoidung.FullName, nguoidung.FullName);
                    HttpContext.Session.SetString(SessionKey.Nguoidung.NguoidungContext,
                    JsonConvert.SerializeObject(nguoidung));
                    return RedirectToAction(nameof(HomeController.Index), "Admin");
                }


            }
            return View(viewLogin);


                }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout() {
            HttpContext.Session.Remove(SessionKey.Nguoidung.UserName);
            HttpContext.Session.Remove(SessionKey.Nguoidung.FullName);
            HttpContext.Session.Remove(SessionKey.Nguoidung.NguoidungContext);

            return RedirectToAction(nameof(HomeController.Index), "Admin");
        
        }
        

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

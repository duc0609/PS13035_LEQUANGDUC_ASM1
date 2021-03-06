using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PS13035_LEQUANGDUC_ASM1.Models;
using PS13035_LEQUANGDUC_ASM1.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using PS13035_LEQUANGDUC_ASM1.Helpers;


namespace PS13035_LEQUANGDUC_ASM1.Controllers
{

    public class MonanController : BaseController
    {
     
        // GET: MonanController
        private readonly IWebHostEnvironment _webHostEnvironment;
        private IMonAnSvc _monAnSvc;
        private IUploadHelper _uploadHelper;

        public MonanController (IWebHostEnvironment webHostEnvironment,IMonAnSvc monAnSvc, IUploadHelper uploadHelper)
        {
            _webHostEnvironment = webHostEnvironment;
            _monAnSvc = monAnSvc;
            _uploadHelper = uploadHelper;
        }
        public ActionResult Index()
        {
            return View(_monAnSvc.GetMonAnAll());
        }

        // GET: MonanController/Details/5
        public ActionResult Details(int id)
        {
            var monAn = _monAnSvc.GetMonAn(id);
            return View(monAn);
        }

        // GET: MonAnController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: MonAnController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MonAn monAn)
        {
            try
            {
                if (monAn.ImageFile != null)
                {
                    if (monAn.ImageFile.Length > 0)
                    {
                        string rootPath = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                        _uploadHelper.UploadImage(monAn.ImageFile, rootPath, "MonAn");
                        monAn.Hinh = monAn.ImageFile.FileName;
                    }
                }
                _monAnSvc.AddMonAn(monAn);
                return RedirectToAction(nameof(Details), new { id = monAn.MonanID });
            }
            catch
            {
                return View();
            }
        }

        // GET: MonanController/Edit/5
        public ActionResult Edit(int id)
        {
            {
                var monAn = _monAnSvc.GetMonAn(id);
                return View(monAn);
            }
        }

        // POST: MonanController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MonAn monAn)
        {
            string thumuccon = "Monan";
            try
            {
                if (ModelState.IsValid)
                {
                    if (monAn.ImageFile != null)
                    {
                        if (monAn.ImageFile.Length > 0)
                        {
                            string rootPath = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                            //_uploadHelper.RemoveImage(rootPath + @"\monan\" + monAn.Hinh);
                            _uploadHelper.UploadImage(monAn.ImageFile, rootPath, thumuccon);
                            monAn.Hinh = monAn.ImageFile.FileName;
                        }
                    }
                    _monAnSvc.EditMonAn(id, monAn);
                    return RedirectToAction(nameof(Details), new { id = monAn.MonanID });
                }
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }


        // GET: MonanController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MonanController/Delete/5
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

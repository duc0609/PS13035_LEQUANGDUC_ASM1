using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PS13035_LEQUANGDUC_ASM1.Models;
using PS13035_LEQUANGDUC_ASM1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS13035_LEQUANGDUC_ASM1.Controllers
{
    public class DonhangController : BaseController
    {
        private IDonhangSVC _donhangSVC;
        // GET: DonhangController
        public DonhangController (IDonhangSVC donhangSVC)
        {
            _donhangSVC = donhangSVC;
        }

        // GET: DonhangController/Details/5
        public ActionResult Index()
        {
            return View(_donhangSVC.GetDonhangAll());
        }

        // GET: DonhangController/Create
        public ActionResult Details( int id)
        {
            return View(_donhangSVC.GetDonhang(id));
        }

        // POST: DonhangController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: DonhangController/Edit/5
        public ActionResult Edit(int id)
        {
            var donhang = _donhangSVC.GetDonhang(id);
            return View(donhang);
        }

        // POST: DonhangController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Donhang donhang)

        {
            try
            {
                donhang.khachhang = null;
                _donhangSVC.editDonhang(id, donhang);
                return RedirectToAction(nameof(Details), new { id = donhang.DonhangID });
            }
            catch
            {
                return View();
            }
        }

        // GET: DonhangController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DonhangController/Delete/5
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

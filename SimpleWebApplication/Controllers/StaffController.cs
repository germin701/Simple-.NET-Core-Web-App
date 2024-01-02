using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SimpleWebApplication.Data;
using SimpleWebApplication.Interfaces.Manager;
using SimpleWebApplication.Manager;
using SimpleWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApplication.Controllers
{
    public class StaffController : Controller
    {
        private ApplicationDBContext _dBContext;
        private IStaffManager _staffManager;
        public StaffController(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext;
            _staffManager = new StaffManager(_dBContext);
        }
        public IActionResult Index(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                var staffs = _dBContext.Staff.FromSqlRaw("EXEC SearchStaff @SearchString", new SqlParameter("@SearchString", searchString)).ToList();
                return View(staffs);
            }

            var allstaffs = _dBContext.Staff.ToList();
            return View(allstaffs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Staff staff)
        {
            string msg = "";
            bool isSaved = _staffManager.Add(staff);
            if(isSaved)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.showAlert = true;
                msg = "Staff save failed.";
                ViewBag.alertMessage = msg;
            }
            
            return View();
        }

        public ActionResult Edit(int id)
        {
            var staff = _staffManager.GetById(id);
            if(staff==null)
            {
                return NotFound();
            }
            return View(staff);
        }

        [HttpPost]
        public ActionResult Edit(Staff staff)
        {
            bool isUpdated = _staffManager.Update(staff);
            if(isUpdated)
            {
                return RedirectToAction("Index");
            }
            return View(staff);
        }

        public ActionResult Details(int id)
        {
            var staff = _staffManager.GetById(id);
            if(staff==null)
            {
                return NotFound();
            }
            return View(staff);
        }

        public ActionResult Delete(int id)
        {
            var staff = _staffManager.GetById(id);
            if(staff==null)
            {
                return NotFound();
            }
            return View(staff);
        }

        [HttpPost]
        public ActionResult Delete(Staff staff)
        {
            bool isDelected = _staffManager.Delete(staff);
            if(isDelected)
            {
                return RedirectToAction("Index");
            }
            return View(staff);
        }
    }
}

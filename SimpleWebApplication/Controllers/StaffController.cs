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

            var allstaffs = _dBContext.Staff.FromSqlRaw("SELECT * FROM Staff").ToList();
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
            var sql = "INSERT INTO Staff (Name, Gender, Email, Phone, Address, Department, Salary) " +
              "VALUES (@Name, @Gender, @Email, @Phone, @Address, @Department, @Salary)";

            var parameters = new[]
            {
                new SqlParameter("@Name", staff.Name),
                new SqlParameter("@Gender", staff.Gender),
                new SqlParameter("@Email", staff.Email),
                new SqlParameter("@Phone", staff.Phone),
                new SqlParameter("@Address", staff.Address),
                new SqlParameter("@Department", staff.Department),
                new SqlParameter("@Salary", staff.Salary),
            };

            try
            {
                _dBContext.Database.ExecuteSqlRaw(sql, parameters);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.showAlert = true;
                msg = "Staff save failed. Error: " + ex.Message;
                ViewBag.alertMessage = msg;
                return View();
            }
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
            var sql = "UPDATE Staff SET Name = @Name, Gender = @Gender, Email = @Email, " +
              "Phone = @Phone, Address = @Address, Department = @Department, " + "Salary = @Salary WHERE Id = @Id";

            var parameters = new[]
            {
                new SqlParameter("@Id", staff.Id),
                new SqlParameter("@Name", staff.Name),
                new SqlParameter("@Gender", staff.Gender),
                new SqlParameter("@Email", staff.Email),
                new SqlParameter("@Phone", staff.Phone),
                new SqlParameter("@Address", staff.Address),
                new SqlParameter("@Department", staff.Department),
                new SqlParameter("@Salary", staff.Salary),
            };

            try
            {
                _dBContext.Database.ExecuteSqlRaw(sql, parameters);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.showAlert = true;
                ViewBag.alertMessage = "Staff update failed. Error: " + ex.Message;
                return View(staff);
            }
        }

        public ActionResult Details(int id)
        {
            var staff = _dBContext.Staff.FromSqlRaw($"SELECT * FROM Staff WHERE Id = {id}").FirstOrDefault();
            if (staff==null)
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
        public ActionResult DeleteConfirmed(int id)
        {
            /*bool isDelected = _staffManager.Delete(staff);
            if(isDelected)
            {
                return RedirectToAction("Index");
            }
            return View(staff);*/
            string sql = $"DELETE FROM Staff WHERE Id = {id}";

            try
            {
                _dBContext.Database.ExecuteSqlRaw(sql);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                ViewBag.showAlert = true;
                ViewBag.alertMessage = "Error deleting staff record.";
                return RedirectToAction("Index");
            }
        }
    }
}

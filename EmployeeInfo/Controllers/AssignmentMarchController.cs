using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeInfo.Data;
using EmployeeInfo.Data.Entity;
using EmployeeInfo.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeInfo.Controllers
{
    public class AssignmentMarchController : Controller
    {
        private readonly SBLDbContext _context;
        public AssignmentMarchController(SBLDbContext _context)
        {
            this._context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AssignmentMrachViewModel model)
        {
            AssignmentMarch customer = new AssignmentMarch
            {
                FristName = model.FristName,
                LesttName = model.LesttName,
                Email = model.Email,
                Subject = model.Subject,
                Massage = model.Massage,
            };
            _context.AssignmentMarchs.Add(customer);
            await _context.SaveChangesAsync();

            return View();
           
        }

        [HttpPost]
        public async Task<IActionResult> IndexSaveByAjaxFun(AssignmentMrachViewModel model)
        {
            string msg = "error";
            try
            {
                AssignmentMarch customer = new AssignmentMarch
                {
                    FristName = model.FristName,
                    LesttName = model.LesttName,
                    Email = model.Email,
                    Subject = model.Subject,
                    Massage = model.Massage,
                };
                _context.AssignmentMarchs.Add(customer);
                await _context.SaveChangesAsync();
                msg = "success";

            }
            catch (Exception e)
            {
                msg = "error";
                //throw e;
            }

            return Json(msg);

        }

    }
}
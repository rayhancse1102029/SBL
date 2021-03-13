using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeInfo.Data;
using EmployeeInfo.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeInfo.Controllers
{
    public class SBLCardController : Controller
    {
        private readonly SBLDbContext _context;
        public SBLCardController(SBLDbContext _context)
        {
            this._context = _context;
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MordernDesign()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MordernDesign(CustomerRequsition model)
        {
            string msg = "error";

            _context.CustomerRequsitions.Add(model);
            await _context.SaveChangesAsync();
            msg = "success";

            return View();
        }

    }
}
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
        public async Task<IActionResult> MordernDesign(SBLViewModel model)
        {
            
            CustomerRequsition customer = new CustomerRequsition
            {
                date =  model.date,
                requsetFor = model.requsetFor,
                addressType =  model.addressType,
                houseName =  model.houseName,
                designation = model.designation,
                house = model.house,
                flat = model.flat,
                floor = model.floor,
                road = model.road
            };

            _context.CustomerRequsitions.Add(customer);
            await _context.SaveChangesAsync();
           
            return View();
        }

    }
}
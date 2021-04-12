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
    public class BusTicketController : Controller
    {
        private readonly SBLDbContext _context;
        public BusTicketController(SBLDbContext _context)
        {
            this._context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(BusTicketViewModel model)
        {
            try
            {
                BusTicket customer = new BusTicket
                {
                    pname = model.pname,
                    paddress = model.paddress,
                    form = model.form,
                    to = model.to,
                    sitno = model.sitno,
                    amount = model.amount,
                    comment = model.comment,
                };
                _context.BusTickets.Add(customer);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IndexSaveByAjaxFun(BusTicketViewModel model)
        {
            string msg = "error";
            try
            {
                BusTicket customer = new BusTicket
                {
                    pname = model.pname,
                    paddress = model.paddress,
                    form = model.form,
                    to = model.to,
                    sitno = model.sitno,
                    amount = model.amount,
                    comment = model.comment,
                };
                _context.BusTickets.Add(customer);
                await _context.SaveChangesAsync();
                msg = "success";
            }
            catch (Exception e)
            {
                msg = "error";
            }

            return Json(msg);
        }
    }
}
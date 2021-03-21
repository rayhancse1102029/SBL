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
                road = model.road,
                village = model.village,
                thana = model.thana,
                district = model.district,
                mobileHome = model.mobileHome,
                mobileOffice = model.mobileOffice,
                mobile = model.mobile,
                creaditCard = model.creaditCard,
                lostCard = model.lostCard,
                closeCreditCardReason = model.closeCreditCardReason,
                IssueANewPIN = model.IssueANewPIN,
                LostChequeBookForm = model.LostChequeBookForm,
                LostChequeBookTo = model.LostChequeBookTo,
                LostChequeBookFor = model.LostChequeBookFor,
                LosUpdateDocument = model.LosUpdateDocument,
                Nid = model.Nid,
                Password = model.Password,
                etin = model.etin,
                LimitConversation = model.LimitConversation,
                formBDT = model.formBDT,
                toUSD = model.toUSD,
                formUSD = model.formUSD,
                toBDT = model.toBDT,
                AutoDebitInstruction = model.AutoDebitInstruction,
                accountNo = model.accountNo,
                BranchName = model.BranchName,
                AmountBDT_USD = model.AmountBDT_USD,
                EnhanceLimitCreditCard = model.EnhanceLimitCreditCard,
                BDT = model.BDT,
                Inword = model.Inword,
                Waive = model.Waive,
                Reason = model.Reason,
                signature = model.signature,
                NewSignature = model.NewSignature,
                OldSignature = model.OldSignature,
                ChangeEmail = model.ChangeEmail,
                FormMonthe = model.FormMonthe,
                ToMonth = model.ToMonth,
                certificate = model.certificate,
                service = model.service,
                others = model.others

            };

            _context.CustomerRequsitions.Add(customer);
            await _context.SaveChangesAsync();
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MordernDesign2(SBLViewModel model)
        {

            CustomerRequsition customer = new CustomerRequsition
            {
                date = model.date,
                requsetFor = model.requsetFor,
                addressType = model.addressType,
                houseName = model.houseName,
                designation = model.designation,
                house = model.house,
                flat = model.flat,
                floor = model.floor,
                road = model.road,
                village = model.village,
                thana = model.thana,
                district = model.district,
                mobileHome = model.mobileHome,
                mobileOffice = model.mobileOffice,
                mobile = model.mobile,
                creaditCard = model.creaditCard,
                lostCard = model.lostCard,
                closeCreditCardReason = model.closeCreditCardReason,
                IssueANewPIN = model.IssueANewPIN,
                LostChequeBookForm = model.LostChequeBookForm,
                LostChequeBookTo = model.LostChequeBookTo,
                LostChequeBookFor = model.LostChequeBookFor,
                LosUpdateDocument = model.LosUpdateDocument,
                Nid = model.Nid,
                Password = model.Password,
                etin = model.etin,
                LimitConversation = model.LimitConversation,
                formBDT = model.formBDT,
                toUSD = model.toUSD,
                formUSD = model.formUSD,
                toBDT = model.toBDT,
                AutoDebitInstruction = model.AutoDebitInstruction,
                accountNo = model.accountNo,
                BranchName = model.BranchName,
                AmountBDT_USD = model.AmountBDT_USD,
                EnhanceLimitCreditCard = model.EnhanceLimitCreditCard,
                BDT = model.BDT,
                Inword = model.Inword,
                Waive = model.Waive,
                Reason = model.Reason,
                signature = model.signature,
                NewSignature = model.NewSignature,
                OldSignature = model.OldSignature,
                ChangeEmail = model.ChangeEmail,
                FormMonthe = model.FormMonthe,
                ToMonth = model.ToMonth,
                certificate = model.certificate,
                service = model.service,
                others = model.others

            };

            _context.CustomerRequsitions.Add(customer);
            await _context.SaveChangesAsync();

            return View("MordernDesign");
            //return RedirectToAction("MordernDesign", "SBLCard");
        }


        [HttpPost]
        public async Task<IActionResult> AjaxSave(SBLViewModel model)
        {
            string msg = "error";

            try
            {
                CustomerRequsition customer = new CustomerRequsition
                {
                    date = model.date,
                    requsetFor = model.requsetFor,
                    addressType = model.addressType,
                    houseName = model.houseName,
                    designation = model.designation,
                    house = model.house,
                    flat = model.flat,
                    floor = model.floor,
                    road = model.road,
                    village = model.village,
                    thana = model.thana,
                    district = model.district,
                    mobileHome = model.mobileHome,
                    mobileOffice = model.mobileOffice,
                    mobile = model.mobile,
                    creaditCard = model.creaditCard,
                    lostCard = model.lostCard,
                    closeCreditCardReason = model.closeCreditCardReason,
                    IssueANewPIN = model.IssueANewPIN,
                    LostChequeBookForm = model.LostChequeBookForm,
                    LostChequeBookTo = model.LostChequeBookTo,
                    LostChequeBookFor = model.LostChequeBookFor,
                    LosUpdateDocument = model.LosUpdateDocument,
                    Nid = model.Nid,
                    Password = model.Password,
                    etin = model.etin,
                    LimitConversation = model.LimitConversation,
                    formBDT = model.formBDT,
                    toUSD = model.toUSD,
                    formUSD = model.formUSD,
                    toBDT = model.toBDT,
                    AutoDebitInstruction = model.AutoDebitInstruction,
                    accountNo = model.accountNo,
                    BranchName = model.BranchName,
                    AmountBDT_USD = model.AmountBDT_USD,
                    EnhanceLimitCreditCard = model.EnhanceLimitCreditCard,
                    BDT = model.BDT,
                    Inword = model.Inword,
                    Waive = model.Waive,
                    Reason = model.Reason,
                    signature = model.signature,
                    NewSignature = model.NewSignature,
                    OldSignature = model.OldSignature,
                    ChangeEmail = model.ChangeEmail,
                    FormMonthe = model.FormMonthe,
                    ToMonth = model.ToMonth,
                    certificate = model.certificate,
                    service = model.service,
                    others = model.others

                };

                _context.CustomerRequsitions.Add(customer);
                await _context.SaveChangesAsync();

                msg = "success";
            }
            catch (Exception e)
            {
                msg = "error";
            }

            return Json(msg);
            //return RedirectToAction("MordernDesign", "SBLCard");
        }

    }
}
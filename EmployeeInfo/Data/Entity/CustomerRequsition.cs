using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo.Data.Entity
{
    public class CustomerRequsition : Base
    {
        public DateTime? date { get; set; }
         //if 1 = Credit Card,
         //   2 = Debit Card,
         //   3 = Prepaid / Travel Card,
         //   4 = Virtual Card
        public int? requsetFor { get; set; } 
        // if 1 = Home, 2 = office
        public int? addressType { get; set; } 
        public string houseName { get; set; } 
        public string designation { get; set; } 
        public string house { get; set; } 
        public string flat { get; set; } 
        public string floor { get; set; } 
        public string road { get; set; } 
        public string village { get; set; } 
        public string thana { get; set; } 
        public string district { get; set; } 
        public string mobileHome { get; set; } 
        public string mobileOffice { get; set; } 
        public string mobile { get; set; }
        // if 1 = Active it , 2 = Re-issue / replace card (expired card / lost card)
        public int? creaditCard { get; set; }
        // if 1 = Block it , 2 = found it, so re-open / active it
        public int? lostCard { get; set; } 
        public string closeCreditCardReason { get; set; } 

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo.Models
{
    public class SBLViewModel
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
        // if 1 = Primary  card  , 2 = Supplementary card
        public int? IssueANewPIN { get; set; }
        // if 1 =Issue new book , 2 =  Active cheque book
        public int? ActiveChequeBook { get; set; }
        public DateTime leafForm { get; set; }
        public DateTime leafTo { get; set; }

        public DateTime? LostChequeBookForm { get; set; }
        public DateTime? LostChequeBookTo { get; set; }
        public int? LostChequeBookFor { get; set; } //if 1 = Block it  , 2 =  found it, so re-open / active it

        public int? LosUpdateDocument { get; set; } //if 1 =  NID , 2 = Passport , 3 = eTIN
        public string Nid { get; set; }
        public string Password { get; set; }
        public string etin { get; set; }
        //if 1 = formBDT To USD , 2 = formUSD to BDT
        public int? LimitConversation { get; set; }
        public string formBDT { get; set; }
        public string toUSD { get; set; }
        public string formUSD { get; set; }
        public string toBDT { get; set; }
        //if 1 =  Cancellation , 2 = Enrollment (minimum / full payment)
        public int? AutoDebitInstruction { get; set; }
        public string accountNo { get; set; }
        public string BranchName { get; set; }
        public string AmountBDT_USD { get; set; }
        //if 1 = Salary certificate , 2 = Bank statement , 3 = MICR cheque leaf
        public int? EnhanceLimitCreditCard { get; set; }
        public string BDT { get; set; }
        public string Inword { get; set; }
        //if 1 =  Late fees , 2 = Interest
        public int? Waive { get; set; }
        public string Reason { get; set; }
        //if 1 = New , 2 = Old
        public int? signature { get; set; }
        public string NewSignature { get; set; }
        public string OldSignature { get; set; }
        public string ChangeEmail { get; set; }
        public string FormMonthe { get; set; }
        public string ToMonth { get; set; }
        //if 1 = Passport Endorsement , 2 = Credit card certificate , 3 = No objection certificate , 4 = Endorsement certificate
        public int? certificate { get; set; }
        //if 1 = Active push pull service  , 2 = Active internet banking service , 3 = Hardware , 4 = Software , 5 = mobile Apps
        public int? service { get; set; }
        public string others { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    class SavingChequeService : ChequeBookService
    {
        public string IssueChequeBook()
        {
            return "Issue 5 leaf cheque book";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    class BusinessChequeService : ChequeBookService
    {
        public string IssueChequeBook()
        {
            return "Issue 50 leaf cheque book";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    class CurrentChequeService : ChequeBookService
    {
        public string IssueChequeBook()
        {
            return "Issue 25 leaf cheque book";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    public abstract class BankServices
    {
        public abstract CardService ProvideCard(CardTypes cardTypes);
        public abstract ChequeBookService ProvideChequeBook(AccountType accountType);
    }
}

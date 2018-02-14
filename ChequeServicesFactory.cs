using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    public class ChequeServicesFactory : BankServices
    {
        public override CardService ProvideCard(CardTypes cardTypes)
        {
            return null;
        }

        public override ChequeBookService ProvideChequeBook(AccountType accountType)
        {
            if(accountType == AccountType.Business)
            {
                return new BusinessChequeService();
            }
            else if (accountType == AccountType.Business)
            {
                return new CurrentChequeService();
            }
            else  
            {
                return new SavingChequeService();
            }
        }
    }
}

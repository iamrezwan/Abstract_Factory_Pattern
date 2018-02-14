using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    public class CardServicesFactory : BankServices
    {
        public override CardService ProvideCard(CardTypes cardTypes)
        {
            if (cardTypes == CardTypes.AMEX)
            {
                return new AmexCard();
            }
            else if (cardTypes == CardTypes.VISA)
            {
                return new VisaCard();
            }
            else  
            {
                return new MasterCard();
            }
        }

        public override ChequeBookService ProvideChequeBook(AccountType accountType)
        {
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    public class ServicesFactory
    {
        public static BankServices GetFactory(ServiceTypes serviceTypes)
        {
            if (serviceTypes == ServiceTypes.CardServices)
            {
                return new CardServicesFactory();
            }
            else
            {
                return new ChequeServicesFactory();
            }
        }
    }
}

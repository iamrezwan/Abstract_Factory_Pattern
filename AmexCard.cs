using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    public class AmexCard : CardService
    {
        public string IssueCard()
        {
            return "This Amex service providing Amex card";
        }
    }
}

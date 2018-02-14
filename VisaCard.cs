using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    public class VisaCard : CardService
    {
        public string IssueCard()
        {
            return "This Visa service providing Visa card";
        }
    }
}

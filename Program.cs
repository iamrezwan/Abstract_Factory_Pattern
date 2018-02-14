using System;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BankServices cardServices = ServicesFactory.GetFactory(ServiceTypes.CardServices);
            BankServices ChequeServices = ServicesFactory.GetFactory(ServiceTypes.ChequeServices);

            CardService amex = cardServices.ProvideCard(CardTypes.AMEX);
            CardService visa = cardServices.ProvideCard(CardTypes.VISA);
            CardService master = cardServices.ProvideCard(CardTypes.MasterCard);


            ChequeBookService businessAC = ChequeServices.ProvideChequeBook(AccountType.Business);
            ChequeBookService currentAC = ChequeServices.ProvideChequeBook(AccountType.Current);
            ChequeBookService savingAC = ChequeServices.ProvideChequeBook(AccountType.Savings);

            Console.WriteLine("--Issuing Cards");
            Console.WriteLine(amex.IssueCard());
            Console.WriteLine(visa.IssueCard());
            Console.WriteLine(master.IssueCard());

            Console.WriteLine("--Issuing Cheque books");
            Console.WriteLine(businessAC.IssueChequeBook());
            Console.WriteLine(currentAC.IssueChequeBook());
            Console.WriteLine(savingAC.IssueChequeBook());

            Console.ReadLine();
        }
    }
}

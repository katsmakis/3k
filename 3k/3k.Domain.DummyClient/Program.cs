using _3k.Domain.Interfaces.Repositories;
using _3k.Domain.Interfaces.Services;
using _3k.Infrastructure.Repositories;
using _3k.Infrastructure.Services;
using DryIoc;
using System.Data.Entity;

namespace _3k.Domain.DummyClient
{
    internal static class Program
    {
        private static void Main(string[] args)
        {



            var Container = new Container();

            Container.Register<DbContext, CustomerEntities>(Reuse.Singleton);
            Container.Register<IClientService, ClientService>(Reuse.Singleton);
            Container.Register<IFisikotherapeftisService, FisikotherapeftisService>(Reuse.Singleton);
            Container.Register<IGiatrosService, GiatrosService>(Reuse.Singleton);
            Container.Register<IAsthenisRepository, AsthenisRepository>(Reuse.Singleton);
            Container.Register<IFisikotherapeftisRepository, FisikotherapeftisRepository>(Reuse.Singleton);
            Container.Register<IGiatrosRepository, GiatrosRepository>(Reuse.Singleton);

            //var repo = new ClientRepository(cntx);
            //IEnumerable<Client> results = repo.GetClientByName("ΜΑΝΤΑΣ");
            //foreach (var item in results)
            //{
            //    System.Console.WriteLine(item.FirstName);
            //}

            //ExportService testExport = new ExportService(new ExportRepository(cntx));
            //File.WriteAllBytes("C:\\PROJECTS\\minit-one\\App\\MinitOne.Domain.Minit.DummyClient\\bin\\Debug\\export1.csv", (byte[])testExport.ExportAutoProductionDetail(new DateTime(2014,3,1),new DateTime(2014,3,31),"1460447"));

            //ΑLEX... ΑΝΘΥΠΟΤΕΚΝΑ!!! 
            //ΜΗΝ ΨΑΧΝΕΙΣ ΤΑ USING ΠΟΥ ΧΑΝΟΝΤΑΙ, ΣΤΑ ΕΧΩ ΣΕ COMMENTS
            //MinettaInsEntities cntx = new MinettaInsEntities();

            //var testPrint = new PrintingService(new PrintRepository(cntx), new AddonsDiscountsRepository(cntx),
            //    new SpecialAgreementsRepository(cntx), new ClientMinitRepository(cntx), new FinancialRepository(cntx),
            //    new GeneralParametersRepository(cntx),new LogManagerAdapter(), new InsuranceMinitRepository(cntx), 
            //    new ClientMinitRepository(cntx), new RenewalInsuranceMinitRepository(cntx), 
            //    new PricingService(new InsuranceMinitRepository(cntx),new CorePricingParametersRepository(cntx), new OfferInsuranceMinitRepository(cntx), new RenewalInsuranceMinitRepository(cntx), new PropertyPricingParametersService(new PropertyPricingParametersRepository(cntx)))
            //    ,new CommissionRepository(cntx));

            //File.WriteAllBytes("C:/Tests/paymentlist.pdf", (byte[])testPrint.PrintPaymentList(116707));
            //File.WriteAllBytes("C:/TestPrint/carContract.pdf", (byte[])testPrint.PrintOriginalContract("2010169","2010169"));
            //File.WriteAllBytes("C:/Tests/fireOffer.pdf", (byte[])testPrint.PrintFireOffer(249899, "George Nikolaropoulos","Agathoupoleos 58", "208672689", string.Empty, "gnikolaropoulos@gmail.com"));
            //File.WriteAllBytes("C:/TestPrint/carReceipt.pdf", (byte[])testPrint.PrintReceipt("1436994", "5880735"));
            //File.WriteAllBytes("C:/TestPrint/fireContract.pdf", (byte[])testPrint.PrintOriginalContract("60016", "60016"));
            //File.WriteAllBytes("C:/TestPrint/fireReceipt.pdf", (byte[])testPrint.PrintReceipt("60016", "60016"));
            //File.WriteAllBytes("C:/TestPrint/fireCopy.pdf", (byte[])testPrint.PrintContractCopy("60016", "60016"));
            //CustomerDetailsView testCustomer = new CustomerDetailsView();
            //testCustomer.FullName = "Νικολαρόπουλος Αλέξανδρος";
            //testCustomer.Address = "Αγαθουπόλεως 58";
            //testCustomer.Email = "al.nikolaropoulos@gmail.com";
            //testCustomer.SecondPhone = "210888887";
            //testCustomer.FirstPhone = "2108624333";

            //File.WriteAllBytes("C:/TestPrint/VehicleNotification.pdf", (byte[])testPrint.PrintPaymentNotice(50357871, false));
            //File.WriteAllBytes("C:/TestPrint/FireNotification.pdf", (byte[])testPrint.PrintPaymentNotice(50345419,true));
            //File.WriteAllBytes("C:/TestPrint/VehicleEndorsement.pdf", (byte[])testPrint.PrintVehicleEndorsement("2030604", "2334980"));
            // File.WriteAllBytes("C:/TestPrint/VehicleEndorsement.pdf", (byte[])testPrint.PrintPaymentNotice(50161279,true));

            //// File.WriteAllBytes("C:/TestPrint/VehicleEndorsement.pdf", (byte[])testPrint.PrintOriginalContract("63768", "125755"));
            // File.WriteAllBytes("C:/TestPrint/VehicleNotification.pdf", (byte[])testPrint.PrintPaymentNotice(50357871, false));
            // File.WriteAllBytes("C:/TestPrint/FireNotification.pdf", (byte[])testPrint.PrintPaymentNotice(50345419,true));
            // File.WriteAllBytes("C:/TestPrint/VehicleEndorsement.pdf", (byte[])testPrint.PrintOriginalContract("2040366", "2335262")); 

            //File.WriteAllBytes("C:/TestPrint/VehicleProposal.pdf", (byte[])testPrint.PrintVehicleOffer(217824, testCustomer));
        }
    }
}


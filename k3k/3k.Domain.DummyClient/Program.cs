using k3k.Domain.Interfaces.Repositories;
using k3k.Domain.Interfaces.Services;
using k3k.Infrastructure.Repositories;
using k3k.Infrastructure.Services;
using DryIoc;
using System.Data.Entity;

namespace k3k.Domain.DummyClient
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var Container = new Container();

            Container.Register<DbContext, CustomerEntities>(Reuse.Singleton);

            Container.Register<IClientService, ClientService>(Reuse.Singleton);
            Container.Register<IFinancialService, FinancialService>(Reuse.Singleton);
            Container.Register<IFisikotherapeftisService, FisikotherapeftisService>(Reuse.Singleton);
            Container.Register<IGiatrosService, GiatrosService>(Reuse.Singleton);
            Container.Register<IParapemptikoService, ParapemptikoService>(Reuse.Singleton);
            //Container.Register<ISinedriesService, SinedriesService>(Reuse.Singleton);

            Container.Register<IAsthenisRepository, AsthenisRepository>(Reuse.Singleton);
            Container.Register<IFinancialRepository, FinancialRepository>(Reuse.Singleton);
            Container.Register<IFisikotherapeftisRepository, FisikotherapeftisRepository>(Reuse.Singleton);
            Container.Register<IGiatrosRepository, GiatrosRepository>(Reuse.Singleton);
            Container.Register<IParapemptikoRepository, ParapemptikoRepository>(Reuse.Singleton);
            Container.Register<ISinedriesRepository, SinedriesRepository>(Reuse.Singleton);

            


        }
    }
}


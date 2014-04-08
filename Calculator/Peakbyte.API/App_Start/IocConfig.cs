using System.Web.Http;
using Peakbyte.Data;
using Peakbyte.Data.Contracts;
using Ninject;
using Peakbyte.Model;

namespace Peakbyte.API
{
    public class IocConfig
    {
        public static void RegisterIoc(HttpConfiguration config)
        {
            var kernel = new StandardKernel(); // Ninject IoC

            // These registrations are "per instance request".
            // See http://blog.bobcravens.com/2010/03/ninject-life-cycle-management-or-scoping/

            kernel.Bind<RepositoryFactories>().To<RepositoryFactories>()
                .InSingletonScope();

            kernel.Bind<IRepositoryProvider>().To<RepositoryProvider>();
            kernel.Bind<IPeakbyteUoW>().To<PeakbyteUoW>();
            kernel.Bind<IComputation>().To<BasicComputation>();

            // Tell WebApi how to use our Ninject IoC
            config.DependencyResolver = new NinjectDependencyResolver(kernel);
        }
    }
}
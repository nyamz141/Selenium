using System;
using DriverFramework.BrowserDrivers;
using DriverFramework.RetrieveDrivers;
using DriverWebTargetPages.Pages.CreateNewAccount;
using DriverWebTargetPages.Pages.HomePageModules;
using DriverWebTargetPages.Pages.Purchase;
using Microsoft.Extensions.DependencyInjection;

namespace DriverWebTargetPages
{
	public class Startup
	{
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IHomePage, HomePage>();
            services.AddScoped<IGetBrowserDriver, GetBrowserDriver>();
            services.AddScoped<IFetchBrowserDriver, FetchBrowserDriver>();
            services.AddScoped<IRegisterAccount, RegisterAccount>();
            services.AddScoped<IFlowerPurchase, FlowerPurchase>();
        }
    }
}


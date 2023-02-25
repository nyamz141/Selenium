using System;
using DriverFramework.BrowserDrivers;
using DriverFramework.RetrieveDrivers;
using DriverWebTargetPages.Pages.CreateNewAccount;
using DriverWebTargetPages.Pages.HomePageModules;
using DriverWebTargetPages.Pages.Purchase;
using Microsoft.Extensions.DependencyInjection;

namespace DriverWebTargetPagesTests
{
	public class Startup
	{
		public void COnfigureServices(IServiceCollection services)
		{
            services.AddScoped<IHomePage, HomePage>();
            services.AddScoped<IGetBrowserDriver, GetBrowserDriver>();
            services.AddScoped<IFetchBrowserDriver, FetchBrowserDriver>();
            services.AddScoped<IRegisterAccount, RegisterAccount>();
            services.AddScoped<IFlowerPurchase, FlowerPurchase>();
        }
	}
}


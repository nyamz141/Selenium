using System;
using DriverFramework.BrowserDrivers;
using DriverFramework.RetrieveDrivers;
using Microsoft.Extensions.DependencyInjection;

namespace DriverFramework
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddScoped<IGetBrowserDriver, GetBrowserDriver>();
            services.AddScoped<IFetchBrowserDriver, FetchBrowserDriver>();
        }
	}
}


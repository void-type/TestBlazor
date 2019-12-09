using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using PaymentCalculator.Model;
using VoidCore.Finance;

namespace TestBlazor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IFinancial, Financial>();
            services.AddSingleton<AmortizationCalculator>();
            services.AddSingleton<CalculateLoan.Handler>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}

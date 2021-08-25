using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditScore.DAL;
using CreditScore.Business;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AsynchronousProgramming
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddScoped<ICreditScoreBusiness, CreditScoreBusiness>();
            services.AddScoped<ICreditScoreService, CreditScoreService>();

            services.AddScoped<ICreditMix, CreditMix>();
            services.AddScoped<IAmountOwed, AmountOwed>();
            services.AddScoped<IGetPaymentHistory, GetPaymentHistory>();
            services.AddScoped<ILengthOfCreditHistory, LengthOfCreditHistory>();
            services.AddScoped<INewCredit, NewCredit>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger. json", "CSharp Programming");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}

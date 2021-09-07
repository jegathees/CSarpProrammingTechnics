using CreditScore.API.Helper;
using CreditScore.Business;
using CreditScore.CrossCuttings;
using CreditScore.DAL;
using CreditScore.DAL.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace AsynchronousProgramming
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration) => this.configuration = configuration;



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddScoped<ICreditScoreBusiness, CreditScoreBusiness>();
            services.AddScoped<ICreditScoreService, CreditScoreService>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<ICreditMix, CreditMix>();
            services.AddScoped<IAmountOwed, AmountOwed>();
            services.AddScoped<IGetPaymentHistory, GetPaymentHistory>();
            services.AddScoped<ILengthOfCreditHistory, LengthOfCreditHistory>();
            services.AddScoped<INewCredit, NewCredit>();
            services.Configure<AppSettings>(configuration)
                .AddScoped(c => c.GetRequiredService<IOptions<AppSettings>>().Value);
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
            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            // custom jwt auth middleware
            app.UseMiddleware<JwtMiddleware>();

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

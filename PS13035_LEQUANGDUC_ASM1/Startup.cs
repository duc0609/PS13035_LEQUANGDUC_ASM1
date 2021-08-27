using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PS13035_LEQUANGDUC_ASM1.Helpers;
using PS13035_LEQUANGDUC_ASM1.Models;
using PS13035_LEQUANGDUC_ASM1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS13035_LEQUANGDUC_ASM1
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
            services.AddDistributedMemoryCache();
            services.AddSession(option => { option.IdleTimeout = TimeSpan.FromMinutes(30); });
            services.AddControllersWithViews();

            services.AddDbContext<DataContext>(Options =>
            Options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IMonAnSvc, MonanSvc>();
            services.AddTransient<IUploadHelper, UploadHelper>();
            services.AddTransient<IMahoaHelper, MahoaHelper>();
            services.AddTransient<INguoidungSvc, NguoidungSvc>();
            services.AddTransient<IKhachhangSvc, KhachhangSvc>();

            services.AddTransient<IDonhangSVC, DonhangSVC>();

            services.AddTransient<IdonhangchitietSVC, donhangchitietSVC>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

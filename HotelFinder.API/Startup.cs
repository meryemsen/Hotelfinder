using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder.DataAcces.Abstract;
using HotelFinder.DataAcces.Concrate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HotelFinder.API
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
            services.AddRazorPages();
            services.AddControllers();
            services.AddSingleton<IRoomService, RoomManager>();
            services.AddSingleton<IRoomRepository, RoomRepository>(); 
            services.AddSingleton<IMenuService, MenuManager>();
            services.AddSingleton<IMenuRepository, MenuRepository>();
            services.AddSingleton<IActivityService, ActivityManager>();
            services.AddSingleton<IActivityRepository, ActivityRepository>();
            services.AddSwaggerDocument(config => {

                config.PostProcess = (doc =>
                {
                    doc.Info.Title = "All Hotela Api";
                    doc.Info.Version = "1.0.13"; ;
                    doc.Info.Contact = new NSwag.OpenApiContact()
                    {
                        Name = "meryem þen",
                        Url = "http:/youtube.com/c/meryemsen",
                        Email = "meri@meri.com"
                    };


                });
            });
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
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

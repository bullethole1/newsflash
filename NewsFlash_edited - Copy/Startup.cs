using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewsFlash_edited.Models.services;
using Microsoft.EntityFrameworkCore;

namespace NewsFlash_edited
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
            var UseDb = true;
            if (UseDb)
            {
                var connection = "Server=(localdb)\\MSSQLLocalDb;Database=Article;Trusted_Connection=True;MultipleActiveResultSets=true";
                services.AddDbContext<ArticleDbContext>(options => options.UseSqlServer(connection));
                services.AddScoped<IArticleService>(c => new DbArticleService(c.GetService<ArticleDbContext>()));
                services.AddScoped<ITagService>(d => new DbTagService(d.GetService<ArticleDbContext>()));
      }
            else
            {
                services.AddScoped<IArticleService>(c => new FakeArticleService());
            }
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}

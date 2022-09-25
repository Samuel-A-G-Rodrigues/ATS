using ATSRestApi.Infrastructure.CrossCuting.IOC;
using ATSRestApi.Infrastructure.Data;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace ATSRestApi.Api
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
      var connection = Configuration["SqlConnection:SqlConnectionString"];
      services.AddDbContext<SqlContext>(options => options.UseSqlServer(connection));
      services.AddControllers();
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
      //services.AddRazorPages();
      //Swagger
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Atra��o e Sele��o", Version = "v1" });
      });
    }

    public void ConfigureContainer(ContainerBuilder builder)
    {
      builder.RegisterModule(new ModuleIOC());
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      //else
      //{
      //  app.UseExceptionHandler("/Error");
      //  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
      //  app.UseHsts();
      //}

      //Swagger
      app.UseSwagger();
      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Atra��o e Sele��o");
      });

      app.UseHttpsRedirection();
      //app.UseStaticFiles();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}

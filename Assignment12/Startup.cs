using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Assignment12.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;

namespace Assignment12
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            //services中存放了一组对象，包括DbContext对象、Controller对象等,用于依赖注入
             services.AddDbContextPool<OrderContext>(options => options
                // 连接字符串"todoDatabase" 可以在appsetting.json中设置
                .UseMySql(Configuration.GetConnectionString("todoDatabase"), 
                    mySqlOptions => mySqlOptions
                    .ServerVersion(new Version(5, 7, 30), ServerType.MySql)
            ));
            services.AddControllers(); //创建控制器对象，创建时进行依赖注入
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env){
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage(); 

            app.UseHttpsRedirection(); //启动http到https的重定向
            app.UseRouting();  //将路由组件添加到app中
            app.UseAuthorization(); //将授权组件添加到app中
            app.UseEndpoints(endpoints =>{
                endpoints.MapControllers(); //启动映射，将url路由到控制器
            });            
        }
    }
}
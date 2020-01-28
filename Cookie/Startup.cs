using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Cookie
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            //app.Run(async (context) =>
            //{
            //    if (context.Request.Cookies.ContainsKey("name"))
            //    {
            //        string name = context.Request.Cookies["name"];
            //        await context.Response.WriteAsync($"Hello {name}!");
            //    }
            //    else
            //    {
            //        context.Response.Cookies.Append("name", "Tom");
            //        await context.Response.WriteAsync("Hello World!");
            //    }
            //});

            app.Run(async (context) =>
            {
                string login;
                if (context.Request.Cookies.TryGetValue("name", out login))
                {
                    await context.Response.WriteAsync($"Hello {login}!");
                }
                else
                {
                    context.Response.Cookies.Append("name", "Tom");
                    await context.Response.WriteAsync("Hello World!");
                }
            });
        }
    }
}

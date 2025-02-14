

using IVP_API.MiddleWare;

namespace IVP_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddTransient<IVPMiddleWare>();         //To register a new middleware class

            var app = builder.Build();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Use method called\n");
            //    await next();
            //    await context.Response.WriteAsync("Use method Ended\n");
            //});

            //app.Map("/khumar", customCode);
            //app.UseMiddleware<IVPMiddleWare>();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("New Use method called\n");
            //    await next();
            //    await context.Response.WriteAsync("New Use method Ended\n");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Run method called \n");
            //});

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

        //private static void customCode(IApplicationBuilder app)
        //{
        //    app.Use(async (context, next) =>
        //    {
        //        await context.Response.WriteAsync("Map Use method called\n");
        //        await next();
        //        await context.Response.WriteAsync("Map Use method Ended\n");
        //    });
        //}
    }
}

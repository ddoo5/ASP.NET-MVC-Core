using Microsoft.OpenApi.Models;
using WebApplication1.DB.Connections;
using WebApplication1.Services.Implimentations;
using WebApplication1.Services.Models;
using WebApplication1.HelperServices;



var builder = WebApplication.CreateBuilder(args);

#region Add base services to container

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

#endregion


#region Configure swagger

builder.Services.AddSwaggerGen( c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Contact = new OpenApiContact
        {
            Name = "DD",
            Email = "kritantablake@gmail.com"
        }
    });
});

#endregion


#region Add custom services

builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddSingleton<IGhostUser, GhostUser>();  //i think i tried all methods with autofac and this's best solution

builder.Services.AddSingleton<DBConnection>();

#endregion


#region Build

var app = builder.Build();

#endregion


#region Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

#endregion


#region Configure app

app.UseAuthorization();

app.MapControllers();

app.Run();

#endregion
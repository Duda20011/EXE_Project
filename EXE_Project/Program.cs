using Infrastructures;
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddInfrastructureServices(builder.Configuration);
    builder.Services.AddHttpContextAccessor();
    //builder.Services.AddWebAPIService();


}




var app = builder.Build();
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseCors(x => x.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
    app.UseHttpsRedirection();



    app.MapControllers();

    app.Run();
}
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//  https://www.youtube.com/watch?v=DMbPdGf6-rw
//  Web Socket 관련 CORS:access-control-allow-origin) 오류 문제 
//  https://developer.mozilla.org/ko/docs/Web/HTTP/CORS
builder.Services.AddCors(options => 
{
    options.AddPolicy(name: "AllowBlazorOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:5111", "https://localhost:44380");
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseCors("AllowBlazorOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();

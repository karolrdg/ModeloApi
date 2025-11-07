using Microsoft.EntityFrameworkCore;
using ModuloApi.Context;

var builder = WebApplication.CreateBuilder(args);

// Configura o DbContext com SQL Server
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"))
);



// Adiciona serviços
builder.Services.AddControllers();            // registra controllers
builder.Services.AddEndpointsApiExplorer();   // necessário para minimal APIs
builder.Services.AddSwaggerGen();             // habilita Swagger UI

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers(); // mapeia controllers como UsuarioController




app.Run();



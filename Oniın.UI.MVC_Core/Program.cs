using Microsoft.EntityFrameworkCore;
using Onion.UI.MVC_Core.UIMapper;
using Onion.ApplicationLayer.Mapper;
using Onion.ApplicationLayer.Services.IsletimSistemiService;
using Onion.ApplicationLayer.Services.LoginService;
using Onion.ApplicationLayer.Services.MarkaService;
using Onion.ApplicationLayer.Services.ModelService;
using Onion.ApplicationLayer.Services.TelefonService;
using Onion.CoreLayer.Models;
using Onion.CoreLayer.Repositories.Abstract;
using Onion.InfrastructureLayer;
using Onion.InfrastructureLayer.Repositories.Concretes;
using Onion.ApplicationLayer.Services.SepetService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Servisleri yaz
builder.Services.AddDbContext<TelefonDBContext>(x => x.UseSqlServer());
builder.Services.AddIdentity<Uye, Rol>(x => x.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<TelefonDBContext>()
                .AddRoles<Rol>();

//AutoMapper
builder.Services.AddAutoMapper(typeof(TelefonMapper),typeof(UserInterfacesMapper));

//Container vereceðim nesnelerin yaþam süresini ayarlamak için bunu yazýyoruz
//Tum servisler için yazacaðýz
builder.Services.AddTransient<ILoginService, LoginSerive>();

builder.Services.AddTransient<IMarkaRepository, MarkaRepostory>();
builder.Services.AddTransient<IMarkaService, MarkaService>();

builder.Services.AddTransient<IModelRepository, ModelRepository>();
builder.Services.AddTransient<IModelService, ModelService>();

builder.Services.AddTransient<IIsletimSistemiRepository, IsletimSistemiRepository>();
builder.Services.AddTransient<IIsletimSistemiService, IsletimSistemiService>();

builder.Services.AddTransient<ITelefonRepository, TelefonRepository>();
builder.Services.AddTransient<ITelefonService, TelefonService>();

builder.Services.AddTransient<ISepetRepository,SepetRepository>();
builder.Services.AddTransient<ISepetService, SepetService>();

var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();

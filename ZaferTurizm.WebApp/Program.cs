using ZaferTurizm.Business.Services;
using System.Diagnostics;
using ZaferTurizm.Business.Validators;
using ZaferTurizm.DataAccess;
using ZaferTurizm.Business.Services.Passenger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

Trace.Listeners.Add(new TextWriterTraceListener("error-logs.txt"));
Trace.AutoFlush = true;

var services = builder.Services;
services.AddTransient<IVehicleMakeService, VehicleMakeService>();
services.AddTransient<IVehicleModelService, VehicleModelService>();
services.AddTransient<IVehicleDefinitionService, VehicleDefinitionService>();
services.AddTransient<IVehicleService, VehicleService>();
services.AddTransient<IRouteService, RouteService>();
services.AddTransient<IBusTripService, BusTripService>();
services.AddTransient<ITicketService, TicketService>();
services.AddTransient<IPassengerService, PassengerService>();
services.AddTransient<BusTripValidator>();
services.AddTransient<VehicleModelValidator>();
services.AddTransient<VehicleMakeValidator>();
services.AddTransient(typeof(GenericValidator<>));
services.AddDbContext<TourDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

using Apex.GameZone.UI.Extensions.ServiceExtensions;
using Apex.GameZone.UI.Services.CommonIdentityServices;
using Apex.GameZone.UI.Services.CommonServices;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.RegisterServices();


builder.Services.AddHttpClient<ICommonService, CommonService>(c =>
{
    c.BaseAddress = builder.Configuration.GetValue<Uri>("Gateway:baseUrl");
    c.DefaultRequestHeaders.Add("Accept", "application/json");
});

builder.Services.AddHttpClient<ICommonIdentityService, CommonIdentityService>(c =>
{
    c.BaseAddress = builder.Configuration.GetValue<Uri>("Identity:baseUrl");
    c.DefaultRequestHeaders.Add("Accept", "application/json");
});

var app = builder.Build();

if (!app.Environment.IsDevelopment()) app.UseHsts();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
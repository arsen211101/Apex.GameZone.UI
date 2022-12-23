using Apex.GameZone.UI.Services.CommonServices;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var configuration = builder.Configuration;

builder.Services.AddHttpClient<ICommonService, CommonService>(c =>
{
    c.BaseAddress = configuration.GetValue<Uri>("Gateway:baseUrl");
    c.DefaultRequestHeaders.Add("Accept", "application/json");
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

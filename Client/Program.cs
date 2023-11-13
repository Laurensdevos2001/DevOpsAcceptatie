using Blazor.Analytics;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Oogarts.Admin.Pages.Diseases;
using Oogarts.Admin.Pages.Team;
using Oogarts.Client;
using Oogarts.Client.Shared.AppointmentComponents;
using Oogarts.Persistence;
using Oogarts.Shared.Appointments;
using Oogarts.Shared.Diseases;
using Oogarts.Shared.Staffs;
using Syncfusion.Blazor;
using Blazored.LocalStorage;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NHaF5cXmVCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdgWH9cdHVUQmVYUkd+WEE=");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddGoogleAnalytics("GTM-MJPD8HZP");
builder.Services.AddScoped<IStaffService, StaffService>();
builder.Services.AddScoped<IDiseaseService, DiseaseService>();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();
builder.Services.AddScoped<OogartsDbContext>();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddBlazoredLocalStorage();


await builder.Build().RunAsync();



using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Oogarts.Admin;
using Oogarts.Admin.Pages.Posts;
using Oogarts.Admin.Pages.Team;
using Oogarts.Persistence;
using Oogarts.Shared.Posts;
using Syncfusion.Blazor;
using Oogarts.Shared.Staffs;
using Oogarts.Shared.Job;
using Oogarts.Shared.Diseases;
using Oogarts.Admin.Pages.Diseases;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NHaF5cXmVCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdgWH9cdHVUQmVYUkd+WEE=");


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<IStaffService, StaffService>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IJobService, JobService>();
builder.Services.AddScoped<IDiseaseService, DiseaseService>();
builder.Services.AddScoped<OogartsDbContext>();
builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddSyncfusionBlazor();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

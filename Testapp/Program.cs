using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
using Intelizign.Net.ViewComponents.NavBarViewComponent;
using Microsoft.Extensions.FileProviders;
using  Microsoft.AspNetCore.Mvc.Razor;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var env = builder.Environment;

builder.Services.AddControllersWithViews();

// builder.Services.AddApplicationInsightsTelemetry();


// var moduleAssembly = typeof(NavBarViewComponent).GetTypeInfo().Assembly;

// var embeddedFileProvider = new EmbeddedFileProvider(
//     moduleAssembly,
//     "vLib"
// );
// builder.Services.Configure<MvcRazorRuntimeCompilationOptions>(o =>
// {                
//     o.FileProviders.Add(embeddedFileProvider);
// });
builder.Services.Configure<MvcRazorRuntimeCompilationOptions>(options =>
{
    options.FileProviders.Add(new EmbeddedFileProvider(typeof(NavBarViewComponent).Assembly));
});


var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// This method gets called by the runtime. Use this method to add services to the container.

app.UseHttpsRedirection();
app.UseStaticFiles();

// var viewsFileProvider = new ManifestEmbeddedFileProvider(
//     typeof(Program).Assembly,
//     "~/lib/vLib.dll");

// app.UseStaticFiles(new StaticFileOptions {
//     FileProvider = viewsFileProvider,
//     RequestPath = "~/Views/Home/Components/NavBar/Default.cshtml"
// });


app.UseRouting();

// app.UseApplicationInsightsRequestTelemetry();

// app.UseApplicationInsightsExceptionTelemetry();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

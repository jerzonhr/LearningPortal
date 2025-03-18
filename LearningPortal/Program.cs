using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using LearningPortal;
using LearningPortal.LearningApp;
using LearningPortal.Northwind;
using LearningPortal.Financial;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ILearningAppService, LearningAppService>();
builder.Services.AddScoped<INorthwindService, NorthwindService>();
builder.Services.AddScoped<IFinancialService, FinancialService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbCardModule),
        typeof(IgbButtonModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbRatingModule),
        typeof(IgbChipModule),
        typeof(IgbCheckboxModule),
        typeof(IgbAccordionModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbHierarchicalGridModule),
        typeof(IgbDataGridToolbarModule),
        typeof(IgbActionStripModule),
        typeof(IgbPivotDataSelector),
        typeof(IgbTabsModule)
    );
}
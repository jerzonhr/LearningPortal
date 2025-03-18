using Bunit;
using Microsoft.Extensions.DependencyInjection;
using LearningPortal.Pages;
using LearningPortal.Northwind;

namespace TestLearningPortal
{
  [Collection("LearningPortal")]
  public class TestProgress
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbHierarchicalGridModule),
        typeof(IgbDataGridToolbarModule),
        typeof(IgbActionStripModule));
      ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
      var componentUnderTest = ctx.RenderComponent<Progress>();
      Assert.NotNull(componentUnderTest);
    }
  }
}

using Bunit;
using Microsoft.Extensions.DependencyInjection;
using LearningPortal.Pages;

namespace TestLearningPortal
{
  [Collection("LearningPortal")]
  public class TestTasks
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbTabsModule),
        typeof(IgbExpansionPanelModule));
      var componentUnderTest = ctx.RenderComponent<Tasks>();
      Assert.NotNull(componentUnderTest);
    }
  }
}

using Bunit;
using Microsoft.Extensions.DependencyInjection;
using LearningPortal.Pages;
using LearningPortal.Financial;

namespace TestLearningPortal
{
  [Collection("LearningPortal")]
  public class TestProfile
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbPivotDataSelector));
      ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
      var componentUnderTest = ctx.RenderComponent<Profile>();
      Assert.NotNull(componentUnderTest);
    }
  }
}

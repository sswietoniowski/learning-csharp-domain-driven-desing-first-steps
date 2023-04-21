using JusticeApp.Investigation;

namespace JusticeApp.Tests.Investigation;

public class ThePreChargeDecisionServiceFixture
{
    public PreChargeDecisionService PreChargeDecisionService { get; }

    public ThePreChargeDecisionServiceFixture()
    {
        PreChargeDecisionService = new PreChargeDecisionService();
    }
}
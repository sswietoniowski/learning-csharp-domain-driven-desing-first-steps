using JusticeApp.Investigation;
using Xunit;

namespace JusticeApp.Tests.Investigation;

public class ThePreChargeDecisionService : IClassFixture<ThePreChargeDecisionServiceFixture>
{
    private readonly PreChargeDecisionService _thePps;

    public ThePreChargeDecisionService(ThePreChargeDecisionServiceFixture fixture)
    {
        _thePps = fixture.PreChargeDecisionService;
    }

    [Fact]
    public void ShouldCreateACaseWhenReceivingAPreChargeDecision()
    {
        PNCId pncId = new("1234-ESDT");
        Suspect suspect = new(CriminalOffence.CUTTING_AWAY_BUOYS_ETC);
        PoliceInvestigationDetails policeInvestigationDetails = new(pncId, suspect);

        PreChargeDecisionCase pcd = _thePps.ReceiveRequestForPreChargeDecision(policeInvestigationDetails);

        Assert.Equal(pncId, pcd.PNCId);
        Assert.Equal(policeInvestigationDetails.Suspects, pcd.Suspects);
    }
}

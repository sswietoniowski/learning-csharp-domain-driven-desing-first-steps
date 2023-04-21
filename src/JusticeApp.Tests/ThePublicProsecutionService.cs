using HarmelLaw.JusticeApp;
using Xunit;

namespace JusticeApp.Tests;

public class ThePublicProsecutionService : IClassFixture<ThePublicProsecutionServiceFixture>
{
    private readonly PublicProsecutionService _thePps;

    public ThePublicProsecutionService(ThePublicProsecutionServiceFixture fixture)
    {
        _thePps = fixture.PublicProsecutionService;
    }

    [Fact]
    public void ShouldCreateACaseWhenReceivingAPreChargeDecision()
    {
        PNCId pncId = new("1234-ESDT");
        Suspect suspect = new(CriminalOffence.CUTTING_AWAY_BUOYS_ETC);
        PoliceInvestigation policeInvestigation = new(pncId, suspect);

        CriminalCase criminalCase = _thePps.ReceiveRequestForPreChargeDecision(policeInvestigation);

        Assert.Equal(pncId, criminalCase.PNCId);
        Assert.Equal(policeInvestigation.Suspects, criminalCase.Suspects);
    }
}

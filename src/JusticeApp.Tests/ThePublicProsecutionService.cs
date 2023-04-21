using HarmelLaw.JusticeApp;
using Xunit;

namespace JusticeApp.Tests;

public class ThePublicProsecutionService
{
    private PublicProsecutionService _thePps;

    public ThePublicProsecutionService()
    {
        Setup();
    }

    public void Setup()
    {
        _thePps = new PublicProsecutionService();
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
using JusticeApp.Preparation;
using Xunit;

namespace JusticeApp.Tests.Preparation;

public class TheTrialPreparationService : IClassFixture<TheTrialPreparationServiceFixture>
{
    private readonly TrialPreparationService _thePps;

    public TheTrialPreparationService(TheTrialPreparationServiceFixture fixture)
    {
        _thePps = fixture.TrialPreparationService;
    }

    [Fact]
    public void ShouldCreateACriminalCaseWhenAPoliceCaseFileIsAccepted()
    {
        PNCId pncId = new("1234-ESDT");
        Defendant defendant = new Defendant();
        PoliceCaseFile policeCaseFile = new PoliceCaseFile(pncId, defendant);

        CriminalCase criminalCase = _thePps.AcceptCaseFile(policeCaseFile);

        Assert.Equal(pncId, criminalCase.PNCId);
        Assert.Equal(policeCaseFile.Defendants, criminalCase.Defendants);
    }
}

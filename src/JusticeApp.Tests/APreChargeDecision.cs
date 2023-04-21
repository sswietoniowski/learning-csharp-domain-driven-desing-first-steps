using HarmelLaw.JusticeApp;
using Xunit;

namespace JusticeApp.Tests;

public class APreChargeDecisionFixture
{
    public Suspect Suspect { get; }
    public PreChargeDecision PreChargeDecision { get; }
    public OffenceAdvice OffenceAdvice { get; }

    public APreChargeDecisionFixture()
    {
        Suspect = new Suspect(CriminalOffence.CUTTING_AWAY_BUOYS_ETC);
        PreChargeDecision = new PreChargeDecision();
        OffenceAdvice = new OffenceAdvice();
    }
}

public class APreChargeDecision : IClassFixture<APreChargeDecisionFixture>
{
    private readonly Suspect _suspect;
    private readonly PreChargeDecision _aPreChargeDecision;
    private readonly OffenceAdvice _offenceAdvice;

    public APreChargeDecision(APreChargeDecisionFixture fixture)
    {
        _suspect = fixture.Suspect;
        _aPreChargeDecision = fixture.PreChargeDecision;
        _offenceAdvice = fixture.OffenceAdvice;
    }

    [Fact]
    public void ShouldRecordAlternativeOffenceAdviceAgainstSuspects()
    {
        _aPreChargeDecision.RecordAlternativeOffenceAdvice(_suspect, _offenceAdvice);

        Assert.Equal(_offenceAdvice, _aPreChargeDecision.GetAlternativeOffenceAdvice(_suspect));
    }
}
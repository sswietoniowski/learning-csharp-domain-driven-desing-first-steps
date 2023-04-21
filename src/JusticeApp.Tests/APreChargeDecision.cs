using HarmelLaw.JusticeApp;
using Xunit;

namespace JusticeApp.Tests;

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
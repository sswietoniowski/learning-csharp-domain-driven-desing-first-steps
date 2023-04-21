using JusticeApp.Investigation;
using Xunit;

namespace JusticeApp.Tests.Investigation;

public class APreChargeDecisionCase : IClassFixture<APreChargeDecisionCaseFixture>
{
    private readonly Suspect _suspect;
    private readonly PreChargeDecisionCase _aPreChargeDecisionCase;
    private readonly OffenceAdvice _offenceAdvice;

    public APreChargeDecisionCase(APreChargeDecisionCaseFixture caseFixture)
    {
        _suspect = caseFixture.Suspect;
        _aPreChargeDecisionCase = caseFixture.PreChargeDecisionCase;
        _offenceAdvice = caseFixture.OffenceAdvice;
    }

    [Fact]
    public void ShouldRecordAlternativeOffenceAdviceAgainstSuspects()
    {
        _aPreChargeDecisionCase.RecordAlternativeOffenceAdvice(_suspect, _offenceAdvice);

        Assert.Equal(_offenceAdvice, _aPreChargeDecisionCase.GetOffenceAdviceFor(_suspect));
    }
}
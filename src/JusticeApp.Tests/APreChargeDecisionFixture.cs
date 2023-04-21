using JusticeApp.Investigation;

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
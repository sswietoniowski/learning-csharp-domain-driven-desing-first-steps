using System.Collections.Generic;
using JusticeApp.Investigation;

namespace JusticeApp.Tests.Investigation;

public class APreChargeDecisionCaseFixture
{
    public Suspect Suspect { get; }
    public PreChargeDecisionCase PreChargeDecisionCase { get; }
    public OffenceAdvice OffenceAdvice { get; }

    public APreChargeDecisionCaseFixture()
    {
        PNCId pncId = new PNCId("ANOTHER_PNC_ID");
        Suspect = new Suspect(CriminalOffence.CUTTING_AWAY_BUOYS_ETC);
        var suspects = new HashSet<Suspect>();
        PreChargeDecisionCase = new PreChargeDecisionCase(pncId, suspects);
        OffenceAdvice = new OffenceAdvice();
    }
}
using System.Collections.Generic;
using HarmelLaw.JusticeApp;
using JusticeApp.Investigation;

namespace JusticeApp.Tests.Investigation;

public class APreChargeDecisionFixture
{
    public Suspect Suspect { get; }
    public PreChargeDecision PreChargeDecision { get; }
    public OffenceAdvice OffenceAdvice { get; }

    public APreChargeDecisionFixture()
    {
        PNCId pncId = new PNCId("ANOTHER_PNC_ID");
        Suspect = new Suspect(CriminalOffence.CUTTING_AWAY_BUOYS_ETC);
        var suspects = new HashSet<Suspect>();
        PreChargeDecision = new PreChargeDecision(pncId, suspects);
        OffenceAdvice = new OffenceAdvice();
    }
}
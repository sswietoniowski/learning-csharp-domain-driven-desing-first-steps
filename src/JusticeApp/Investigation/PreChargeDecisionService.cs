using System.Collections.Generic;

namespace JusticeApp.Investigation;

public class PreChargeDecisionService
{
    public PreChargeDecisionCase ReceiveRequestForPreChargeDecision(
        PoliceInvestigationDetails policeInvestigationDetails)
    {
        return new PreChargeDecisionCase(policeInvestigationDetails.PNCId, policeInvestigationDetails.Suspects as ISet<Suspect>);
    }
}
using System.Collections.Generic;
using JusticeApp.Investigation;
using JusticeApp.Preparation;

namespace JusticeApp;

public class PublicProsecutionService
{
    public PreChargeDecisionCase ReceiveRequestForPreChargeDecision(PoliceInvestigationDetails policeInvestigationDetails)
    {
        return new PreChargeDecisionCase(policeInvestigationDetails.PNCId, policeInvestigationDetails.Suspects as ISet<Suspect>);
    }

    public CriminalCase AcceptCaseFile(PoliceCaseFile policeCaseFile)
    {
        return new CriminalCase(policeCaseFile.PNCId, policeCaseFile.Defendants);
    }
}
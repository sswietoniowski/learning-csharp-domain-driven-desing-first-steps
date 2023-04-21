using JusticeApp.Investigation;
using JusticeApp.Preparation;

namespace JusticeApp;

public class PublicProsecutionService
{
    public PreChargeDecisionCase ReceiveRequestForPreChargeDecision(PoliceInvestigation policeInvestigation)
    {
        return new PreChargeDecisionCase(policeInvestigation.PNCId, policeInvestigation.Suspects);
    }

    public CriminalCase AcceptCaseFile(PoliceCaseFile policeCaseFile)
    {
        return new CriminalCase(policeCaseFile.PNCId, policeCaseFile.Defendants);
    }
}
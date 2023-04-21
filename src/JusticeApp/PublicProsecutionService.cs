using JusticeApp.Investigation;
using JusticeApp.Preparation;

namespace JusticeApp;

public class PublicProsecutionService
{
    public PreChargeDecision ReceiveRequestForPreChargeDecision(PoliceInvestigation policeInvestigation)
    {
        return new PreChargeDecision(policeInvestigation.PNCId, policeInvestigation.Suspects);
    }

    public CriminalCase AcceptCaseFile(PoliceCaseFile policeCaseFile)
    {
        return new CriminalCase(policeCaseFile.PNCId, policeCaseFile.Defendants);
    }
}
using HarmelLaw.JusticeApp;

namespace JusticeApp;

public class PublicProsecutionService
{
    public CriminalCase ReceiveRequestForPreChargeDecision(PoliceInvestigation policeInvestigation)
    {
        return new CriminalCase(policeInvestigation.PNCId, policeInvestigation.Suspects);
    }
}
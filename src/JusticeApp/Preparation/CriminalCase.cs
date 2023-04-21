using System.Collections.Generic;

namespace JusticeApp.Preparation;

public class CriminalCase
{
    public PNCId PNCId { get; }
    public ISet<Defendant> Defendants { get; }


    public CriminalCase(PNCId pncId, ISet<Defendant> defendants)
    {
        PNCId = pncId;
        Defendants = defendants;
    }
}
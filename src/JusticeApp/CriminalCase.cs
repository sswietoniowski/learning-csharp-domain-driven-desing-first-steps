using System.Collections.Generic;
using System.Dynamic;
using JusticeApp;
using JusticeApp.Investigation;

namespace HarmelLaw.JusticeApp;

public class CriminalCase
{
    public PNCId PNCId { get; }
    public ISet<Suspect> Suspects { get; }
    public ISet<Defendant> Defendants { get; }


    public CriminalCase(PNCId pncId, ISet<Defendant> defendants)
    {
        PNCId = pncId;
        Defendants = defendants;
    }
}
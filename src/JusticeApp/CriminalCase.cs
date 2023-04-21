using System.Collections.Generic;
using System.Dynamic;
using JusticeApp.Investigation;

namespace HarmelLaw.JusticeApp;

public class CriminalCase
{
    public PNCId PNCId { get; }
    public ISet<Suspect> Suspects { get; }

    public CriminalCase(PNCId pncId, ISet<Suspect> suspects)
    {
        PNCId = pncId;
        Suspects = suspects;
    }
}
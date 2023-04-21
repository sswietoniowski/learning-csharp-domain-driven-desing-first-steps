using System;
using System.Collections.Generic;
using HarmelLaw.JusticeApp;

namespace JusticeApp.Investigation;

public class PoliceInvestigationDetails
{
    private readonly HashSet<Suspect> _suspects = new();
    public PNCId PNCId { get; }
    public IReadOnlySet<Suspect> Suspects => _suspects;

    public PoliceInvestigationDetails(PNCId pncId, Suspect suspect)
    {
        if (pncId == null) throw new ArgumentNullException("You must provide a PNC Id");
        if (suspect == null) throw new ArgumentNullException("You must provide a suspect");

        _suspects = new HashSet<Suspect>();

        PNCId = pncId;
        _suspects.Add(suspect);
    }
}
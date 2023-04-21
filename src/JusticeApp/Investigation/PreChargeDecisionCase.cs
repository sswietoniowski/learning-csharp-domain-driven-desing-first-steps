using HarmelLaw.JusticeApp;
using System.Collections.Generic;
using System.Linq;

namespace JusticeApp.Investigation;

public class PreChargeDecisionCase
{
    public PNCId PNCId { get; }
    private readonly Dictionary<Suspect, OffenceAdvice> _alternativeOffenceAdvice = new();

    public PreChargeDecisionCase(PNCId pncId, ISet<Suspect> suspects)
    {
        PNCId = pncId;
        foreach (var suspect in suspects)
        {
            _alternativeOffenceAdvice.Add(suspect, null);
        }
    }

    public void RecordAlternativeOffenceAdvice(Suspect suspect, OffenceAdvice offenceAdvice)
    {
        if (_alternativeOffenceAdvice.ContainsKey(suspect))
        {
            _alternativeOffenceAdvice[suspect] = offenceAdvice;
        }
        else
        {
            _alternativeOffenceAdvice.Add(suspect, offenceAdvice);
        }
    }

    public OffenceAdvice GetOffenceAdviceFor(Suspect suspect) => _alternativeOffenceAdvice[suspect];

    public ISet<Suspect> Suspects => _alternativeOffenceAdvice.Keys.ToHashSet();
}
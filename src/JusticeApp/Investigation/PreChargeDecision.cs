using System.Collections.Generic;

namespace JusticeApp.Investigation;

public class PreChargeDecision
{
    private readonly Dictionary<Suspect, OffenceAdvice> _alternativeOffenceAdvice = new();

    public PreChargeDecision()
    {
    }

    public void RecordAlternativeOffenceAdvice(Suspect suspect, OffenceAdvice offenceAdvice)
    {
        _alternativeOffenceAdvice.Add(suspect, offenceAdvice);
    }

    public OffenceAdvice GetOffenceAdviceFor(Suspect suspect) => _alternativeOffenceAdvice[suspect];
}
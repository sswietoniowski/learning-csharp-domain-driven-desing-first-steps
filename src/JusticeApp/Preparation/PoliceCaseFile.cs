using System.Collections.Generic;

namespace JusticeApp.Preparation;

public class PoliceCaseFile
{
    public PNCId PNCId { get; }
    public ISet<Defendant> Defendants { get; } = new HashSet<Defendant>();

    public PoliceCaseFile(PNCId pncId, Defendant defendant)
    {
        PNCId = pncId;
        Defendants.Add(defendant);
    }
}
namespace JusticeApp.Preparation
{
    public class TrialPreparationService
    {
        public CriminalCase AcceptCaseFile(PoliceCaseFile policeCaseFile)
        {
            return new CriminalCase(policeCaseFile.PNCId, policeCaseFile.Defendants);
        }
    }
}

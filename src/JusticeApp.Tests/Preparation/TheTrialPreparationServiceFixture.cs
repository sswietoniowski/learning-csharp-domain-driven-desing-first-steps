using JusticeApp.Preparation;

namespace JusticeApp.Tests.Preparation;

public class TheTrialPreparationServiceFixture
{
    public TrialPreparationService TrialPreparationService { get; }

    public TheTrialPreparationServiceFixture()
    {
        TrialPreparationService = new TrialPreparationService();
    }
}
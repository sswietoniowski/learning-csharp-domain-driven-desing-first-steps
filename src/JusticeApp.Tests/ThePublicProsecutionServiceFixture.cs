namespace JusticeApp.Tests;

public class ThePublicProsecutionServiceFixture
{
    public PublicProsecutionService PublicProsecutionService { get; }

    public ThePublicProsecutionServiceFixture()
    {
        PublicProsecutionService = new PublicProsecutionService();
    }
}
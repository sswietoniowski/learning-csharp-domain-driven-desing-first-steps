using System;
using HarmelLaw.JusticeApp;
using JusticeApp.Investigation;
using Xunit;

namespace JusticeApp.Tests.Investigation;

public class APoliceInvestigationDetails
{
    private PNCId _pncId;
    private Suspect _suspect;
    private PoliceInvestigationDetails _anInvestigationDetails;

    public APoliceInvestigationDetails()
    {
        // constructor runs before each test
        Setup();
    }

    private void Setup()
    {
        _pncId = new PNCId("1234-ESDT");
        _suspect = new Suspect(CriminalOffence.FALSE_ACCOUNTING);
        _anInvestigationDetails = new PoliceInvestigationDetails(_pncId, _suspect);
    }

    [Fact]
    public void MustHaveAPoliceNationalComputerId()
    {
        Assert.NotNull(_anInvestigationDetails.PNCId);
    }

    [Fact]
    public void CannotBeCreatedWithAnEmptyPoliceNationalComputerId()
    {
        Action action = () => new PoliceInvestigationDetails(null, _suspect);
        Exception exception = Assert.Throws<ArgumentNullException>(action);

        Assert.Contains("You must provide a PNC Id", exception.Message);
    }

    [Fact]
    public void CannotBeCreatedWithNoSuspect()
    {
        Action action = () => new PoliceInvestigationDetails(_pncId, null);
        Exception exception = Assert.Throws<ArgumentNullException>(action);

        Assert.Contains("You must provide a suspect", exception.Message);
    }
}
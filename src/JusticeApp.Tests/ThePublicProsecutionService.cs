﻿using HarmelLaw.JusticeApp;
using JusticeApp.Investigation;
using JusticeApp.Preparation;
using Xunit;

namespace JusticeApp.Tests;

public class ThePublicProsecutionService : IClassFixture<ThePublicProsecutionServiceFixture>
{
    private readonly PublicProsecutionService _thePps;

    public ThePublicProsecutionService(ThePublicProsecutionServiceFixture fixture)
    {
        _thePps = fixture.PublicProsecutionService;
    }

    [Fact]
    public void ShouldCreateACaseWhenReceivingAPreChargeDecision()
    {
        PNCId pncId = new("1234-ESDT");
        Suspect suspect = new(CriminalOffence.CUTTING_AWAY_BUOYS_ETC);
        PoliceInvestigation policeInvestigation = new(pncId, suspect);

        PreChargeDecision pcd = _thePps.ReceiveRequestForPreChargeDecision(policeInvestigation);

        Assert.Equal(pncId, pcd.PNCId);
        Assert.Equal(policeInvestigation.Suspects, pcd.Suspects);
    }

    [Fact]
    public void ShouldCreateACriminalCaseWhenAPoliceCaseFileIsAccepted()
    {
        PNCId pncId = new("1234-ESDT");
        Defendant defendant = new Defendant();
        PoliceCaseFile policeCaseFile = new PoliceCaseFile(pncId, defendant);

        CriminalCase criminalCase = _thePps.AcceptCaseFile(policeCaseFile);

        Assert.Equal(pncId, criminalCase.PNCId);
        Assert.Equal(policeCaseFile.Defendants, criminalCase.Defendants);
    }
}

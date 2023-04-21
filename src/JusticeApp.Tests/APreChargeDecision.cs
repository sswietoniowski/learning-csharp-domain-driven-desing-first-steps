using System;
using Xunit;

namespace HarmelLaw.JusticeApp.Tests
{
    public class APreChargeDecision
    {
        private PNCId _pncId;
        private Suspect _suspect;


        public APreChargeDecision()
        {
            // constructor runs before each test
            Setup();
        }

        private void Setup()
        {
        }

        [Fact]
        public void ShouldRecordAlternativeOffenceAdviceAgainstSuspects()
        {
            Suspect suspect = new Suspect(CriminalOffence.CUTTING_AWAY_BUOYS_ETC);
            PreChargeDecision aPreChargeDecision = new PreChargeDecision();
            OffenceAdvice offenceAdvice = new OffenceAdvice();

            aPreChargeDecision.RecordAlternativeOffenceAdvice(suspect, offenceAdvice);

            Assert.Equal(offenceAdvice, aPreChargeDecision.GetAlternativeOffenceAdvice(suspect));
        }
    }
}
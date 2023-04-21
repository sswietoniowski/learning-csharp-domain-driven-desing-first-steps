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
            _pncId = new PNCId("1234-ESDT");
            _suspect = new Suspect(CriminalOffence.FALSE_ACCOUNTING);
        }

        [Fact]
        public void ShouldRecordAlternativeOffenceAdviceAgainstSuspects()
        {
            Action action = () => new PreChargeDecision(_pncId, _suspect, null);
            Exception exception = Assert.Throws<ArgumentNullException>(action);

            Assert.Contains("You must provide an alternative offence advice", exception.Message);
        }
    }
}
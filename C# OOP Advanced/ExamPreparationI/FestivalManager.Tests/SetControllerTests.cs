namespace FestivalManager.Tests
{
    using FestivalManager.Core.Controllers;
    using FestivalManager.Core.Controllers.Contracts;
    using FestivalManager.Entities;
    using FestivalManager.Entities.Contracts;
    using FestivalManager.Entities.Instruments;
    using FestivalManager.Entities.Sets;
    using System;
    using NUnit.Framework;

    [TestFixture]
	public class SetControllerTests
    {
		[Test]
	    public void SetControllerShouldReturnFailMessage()
	    {
            IStage stage = new Stage();
            ISetController setController = new SetController(stage);

            ISet set = new Short("Set1");
            stage.AddSet(set);

            string actualResult = setController.PerformSets();
            string expectedResult = "1. Set1:\r\n-- Did not perform";

            Assert.That(actualResult, Is.EqualTo(expectedResult));
		}

        [Test]
        public void SetControllerShouldReturnSuccessMessage()
        {
            IStage stage = new Stage();
            ISetController setController = new SetController(stage);

            ISet set = new Short("Set1");
            IPerformer performer = new Performer("Pesho", 12); //need name and age
            performer.AddInstrument(new Guitar());
            set.AddPerformer(performer);

            ISong song = new Song("Song", new TimeSpan(0, 2, 30));

            set.AddSong(song);
            stage.AddSet(set);

            string expectedResult = "1. Set1:\r\n-- 1. Song (02:30)\r\n-- Set Successful";
            string actualResult = setController.PerformSets();

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void PerformSetsShouldDecreaseInstrumentWear()
        {
            IStage stage = new Stage();
            ISetController setController = new SetController(stage);

            ISet set = new Short("Set1");
            IPerformer performer = new Performer("Pesho", 12); //need name and age
            IInstrument instrument = new Guitar();
            performer.AddInstrument(instrument);
            set.AddPerformer(performer);

            ISong song = new Song("Song", new TimeSpan(0, 2, 30));

            set.AddSong(song);
            stage.AddSet(set);

            double instrumentWearBeforePerforming = instrument.Wear;

            setController.PerformSets();

            double instrumentAfterPerFormaing = instrument.Wear;

            Assert.That(instrumentAfterPerFormaing, Is.Not.EqualTo(instrumentWearBeforePerforming));
        }

	}
}
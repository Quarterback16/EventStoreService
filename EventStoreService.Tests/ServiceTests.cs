using System.Diagnostics.CodeAnalysis;

namespace EventStoreService.Tests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ServiceTests
    {
        private HsEventStore? _sut;

        [TestInitialize]
        public void Setup()
        {
            _sut = new HsEventStore(
                "l:\\apps\\dd\\gevents.json");
        }

        [TestMethod]
        public void Service_Instantiates_Ok()
        {
            Assert.IsNotNull(_sut);
        }

        [TestMethod]
        public void Service_ServesUpGameData_Ok()
        {
            var results = _sut?.Get<HsGamePlayedEvent>("game-played");
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Any());
        }
    }
}

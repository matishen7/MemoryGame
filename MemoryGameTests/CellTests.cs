using MemoryGame;

namespace MemoryGameTests
{
    public class CellTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Cell_SetImage_Should_Set_Valid_Image()
        {
            var cell = new Cell();
            cell.SetImage("Image1");
            Assert.That(cell.GetImage(), Is.EqualTo("Image1"));
        }

        [Test]
        public void Cell_SetAsFound_True()
        {
            var cell = new Cell();
            cell.SetAsFound();
            Assert.That(cell.IsFound(), Is.EqualTo(true));
        }

        [Test]
        public void Cell_SetAsFound_False()
        {
            var cell = new Cell();
            Assert.That(cell.IsFound(), Is.EqualTo(false));
        }
    }
}
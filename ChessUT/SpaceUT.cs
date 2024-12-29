namespace Chess.Tests
{
    using Chess;
    using Chess.Internal;
    using Chess.Tests.Mocks;

    [TestClass]
    public class SpaceUT
    {
        [TestMethod]
        [DataRow(-1, 0)]
        [DataRow(8, 0)]
        [DataRow(0, -1)]
        [DataRow(0, 8)]
        [ExpectedException(typeof(ChessException))]
        public void ConstructorException(int x, int y)
        {
            // Arrange, Act, Assert
            new Space((x, y)); // Expect this to throw.
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(7, 7)]
        public void ConstructorSuccess(int x, int y)
        {
            // Act
            var space = new Space((x, y));

            // Assert
            Assert.AreEqual(x, space.Coordinates.X);
            Assert.AreEqual(y, space.Coordinates.Y);
            Assert.IsNull(space.Piece);
        }

        [TestMethod]
        public void Piece()
        {
            // Arrange
            var pieceMock = new IPieceMock();
            var space = new Space((0, 0)); // Coordinates don't matter.
            
            // Act
            space.Piece = pieceMock;

            // Assert
            Assert.AreEqual(pieceMock, space.Piece);
        }
    }
}
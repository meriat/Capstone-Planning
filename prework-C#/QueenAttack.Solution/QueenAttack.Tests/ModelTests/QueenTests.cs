using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenTest
  {
    [TestMethod]
    public void CanAttack_SameCoordinatePair_true()
    {
      Queen testQueen = new Queen(2,4,2,4);
      Assert.AreEqual(true, testQueen.CanAttack());
    }
    [TestMethod]
    public void CanAttack_Horizontally_true()
    {
      Queen testQueen = new Queen(2,4,2,6);
      Assert.AreEqual(true, testQueen.CanAttack());
    }
    [TestMethod]
    public void CanAttack_Diagonally_true()
    {
      Queen testQueen = new Queen(2,4,6,4);
      Assert.AreEqual(true, testQueen.CanAttack());
    }
    [TestMethod]
    public void CanAttack_Vertically_true()
    {
      Queen testQueen = new Queen(2,1,1,2);
      Assert.AreEqual(true, testQueen.CanAttack());
    }
  }
}
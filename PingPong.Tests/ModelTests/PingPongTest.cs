using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong.Models;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongGeneratorTest
  {
    [TestMethod]
    public void GetInput_ReturnInput_Int()
    {
      //Arrange
      int userInput = 5;
      PingPongGenerator newPong = new PingPongGenerator(userInput);

      //Act
      int result = newPong.GetInput();

      //Assert
      Assert.AreEqual(userInput, result);
    }

    
  }
}

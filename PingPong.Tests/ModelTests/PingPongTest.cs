using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PingPong.Models;
using System;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongGeneratorTest : IDisposable
  {
    public void Dispose()
    {
      PingPongGenerator.ClearAll();
    }

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

    [TestMethod]
    public void CountInput_ReturnCountedInput_List()
    {
      //Arrange
      List<int> greatList = new List<int> {1, 2, 3, 4, 5};
      int userInput = 5;
      PingPongGenerator newPong = new PingPongGenerator(userInput);

      //Act
      List<int> result = newPong.CountInput(userInput);

      //Assert
      CollectionAssert.AreEqual(greatList, result);
    }

    [TestMethod]
    


  }
}

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
      List<int> result = newPong.CountInput(newPong.GetInput());

      //Assert
      CollectionAssert.AreEqual(greatList, result);
    }

    [TestMethod]
    //_Replace all numbers divisible by 3 with Ping_
    //output is a list of strings, so method will have to convert int to string
    public void ReplacePingPong_ReturnPing_List()
    {
      //Arrange
      int userInput = 5;
      PingPongGenerator newPingPong = new PingPongGenerator(userInput);
      List<string> pingPongList = new List<string> {"1", "2", "ping", "4", "pong"};
      List<int> origList = newPingPong.CountInput(newPingPong.GetInput());

      //Act
      List<string> result = newPingPong.ReplacePingPong(origList);

      //Assert
      CollectionAssert.AreEqual(pingPongList, result);
    }

    // [TestMethod]
    // _Replace all numbers divisible by 5 with Pong_
    // public void ReplaceDivThreeFive_ReturnPingPong_List()
    // {
    //   //Arrange
    //   int userInput = 15;
    //   PingPongGenerator newPong = new PingPongGenerator(userInput);
    //   List<string> pongList = new List<string> {"1", "2", "3", "4", "pong", ""};
    //   List<int> origList = newPong.CountInput(newPong.GetInput());
    //
    //   //Act
    //   List<string> result = newPong.ReplaceDivFive(origList);
    //
    //   //Assert
    //   CollectionAssert.AreEqual(pongList, result);
    // }

  }

}

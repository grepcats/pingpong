using System.Collections.Generic;
using System;

namespace PingPong.Models
{
  public class PingPongGenerator
  {
    private int _input;
    private static List<PingPongGenerator> _instances = new List<PingPongGenerator> {};

    public PingPongGenerator(int input)
    {
      _input = input;
      _instances.Add(this);
    }

    public int GetInput()
    {
      return _input;
    }

    public List<int> CountInput(int input)
    {
      List<int> userList = new List<int> ();
      for (int i = 1; i <= input; i++) {
        userList.Add(i);
      }
      return userList;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}

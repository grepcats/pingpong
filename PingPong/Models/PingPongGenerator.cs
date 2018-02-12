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

    public List<string> ReplacePingPong(List<int> intList)
    {
      List<string> convertedList = new List<string> {};
      for (int i = 0; i < intList.Count; i++) {
        if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
        {
          convertedList.Add("pingpong");
        }
        else if ((i + 1) % 3 == 0)
        {
          convertedList.Add("ping");
        }
        else if ((i + 1) % 5 == 0)
        {
          convertedList.Add("pong");
        }
        else
        {
          string conversion = intList[i].ToString();
          convertedList.Add(conversion);
        }

      }
      return convertedList;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    // public string GetEntry()
    // {
    //   return
    // }
  }
}

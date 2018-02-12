using System.Collections.Generic;

namespace PingPong.Models
{
  public class PingPongGenerator
  {
    private int _input;

    public PingPongGenerator(int input)
    {
      _input = input;
    }

    public int GetInput()
    {
      return _input;
    }
  }
}

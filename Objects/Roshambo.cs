using System;
using System.Collections.Generic;

namespace Roshambo.Objects
{
  public class Game
  {
    private int _player1Wins;
    private int _player2wins;
    private char[] _plays = new char[2];

    public Game(string input)
    {
      _plays = input.ToCharArray();
    }

    public string Shoot()
    {
      string result = "";
      if (_plays[0] == _plays[1])
      {
        result = "Draw";
      }
      return result;
    }
  }
}

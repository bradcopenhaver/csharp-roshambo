using System;
using System.Collections.Generic;

namespace Roshambo.Objects
{
  public class Game
  {
    private int _player1Wins;
    private int _player2wins;
    private string _p1Play;
    private string _p2Play;
    private char[] _plays = new char[2];

    private Dictionary<char, string> _playDefinitions = new Dictionary<char, string>() {{'q', "rock"}, {'w', "scissors"}, {'e', "paper"}, {'i', "rock"}, {'o', "scissors"}, {'p', "paper"}};

    public Game(string input)
    {
      _plays = input.ToCharArray();
    }

    public string Shoot()
    {
      if (_plays[0] == 'q' || _plays[0] == 'w' || _plays[0] == 'e')
      {
        _p1Play = _playDefinitions[_plays[0]];
        _p2Play = _playDefinitions[_plays[1]];
      }
      else
      {
        _p2Play = _playDefinitions[_plays[0]];
        _p1Play = _playDefinitions[_plays[1]];
      }

      if (_p1Play == _p2Play)
      {
        return "Draw";
      }
      else if(_p1Play == "rock" && _p2Play == "scissors" || _p1Play == "scissors" && _p2Play == "paper" || _p1Play == "paper" && _p2Play == "rock")
      {
        return "Player 1 Wins!";
      }
      else
      {
        return "Player 2 Wins!";
      }
    }
  }
}

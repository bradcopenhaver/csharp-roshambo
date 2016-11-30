using System;
using System.Collections.Generic;

namespace Roshambo.Objects
{
  public class Game
  {
    private static int _player1Wins = 0;
    private static int _player2wins = 0;
    private string _p1Play;
    private string _p2Play;
    private char[] _plays = new char[2];
    private string _outcome;

    private Dictionary<char, string> _playDefinitions = new Dictionary<char, string>() {{'q', "rock"}, {'w', "scissors"}, {'e', "paper"}, {'i', "rock"}, {'o', "scissors"}, {'p', "paper"}};

    public Game(string input)
    {
      _plays = input.ToCharArray();
    }

    public void Shoot()
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
        _outcome = "Draw";
      }
      else if(_p1Play == "rock" && _p2Play == "scissors" || _p1Play == "scissors" && _p2Play == "paper" || _p1Play == "paper" && _p2Play == "rock")
      {
        _player1Wins += 1;
        _outcome = "Player 1 Wins!";
      }
      else
      {
        _player2wins += 1;
        _outcome = "Player 2 Wins!";
      }
    }

    public string GetOutcome()
    {
      return _outcome;
    }

    public int GetPlayer1Count()
    {
      return _player1Wins;
    }

    public int GetPlayer2Count()
    {
      return _player2wins;
    }
  }
}

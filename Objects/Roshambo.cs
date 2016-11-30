using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
      if (ValidateInput() == true)
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
      else
      {
        _outcome = "Oops! Your input was invalid. Try again!";
      }
    }

    public bool ValidateInput()
    {
      if (_plays.Length == 2)
      {
        Match match1 = Regex.Match(_plays[0].ToString(), @"[qwe]");
        Match match2 = Regex.Match(_plays[1].ToString(), @"[iop]");
        Console.WriteLine(match1.Success);
        // // if (match1.Success && match2.Success || Regex.Matches(_plays[1].ToString(), @"\[qwe]\") && Regex.Matches(_plays[0].ToString(), @"\[iop]\"))
        // // {
        // //   return true;
        // }
        // else
        // {
          return false;
        // }
      }
      else
      {
        return false;
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

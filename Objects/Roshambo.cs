using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Roshambo.Objects
{
  public class Player
  {
    private string _playerNumber;
    private string _playerPlay;

    public Player(int playerNumber, string play)
    {
      _playerNumber = playerNumber;
      _playerPlay = playerPlay;
    }
  }


  public class Game
  {
    private static int _player1Wins = 0;
    private static int _player2wins = 0;
    private static int _player3wins = 0;
    private char[] _plays = new char[3];
    private string _outcome;

    private Dictionary<char, string> _playDefinitions = new Dictionary<char, string>() {{'q', "rock"}, {'w', "scissors"}, {'e', "paper"}, {'i', "rock"}, {'o', "scissors"}, {'p', "paper"}, {'v', "rock"}, {'b', "scissors"}, {'n', "paper"}};

    public Game(string input)
    {
      _plays = input.ToCharArray();
      Array.Sort(_plays, Compare);
    }

    public void Shoot(Player p1, Player p2)
    {
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



    public bool ValidateInput()
    {
      if (_plays.Length == 2)
      {
        Match match1 = Regex.Match(_plays[0].ToString(), @"[qwe]");
        Match match2 = Regex.Match(_plays[1].ToString(), @"[iop]");

        Match match3 = Regex.Match(_plays[1].ToString(), @"[qwe]");
        Match match4 = Regex.Match(_plays[0].ToString(), @"[iop]");

        if (match1.Success && match2.Success || match3.Success && match4.Success)
        {
          return true;
        }
        else
        {
          return false;
        }
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
    public int Compare(char x, char y)
    {
        var chars = "qweiopvbn";
        if (chars.IndexOf(x) < chars.IndexOf(y))
        {
          return -1;
        }
        return chars.IndexOf(x) > chars.IndexOf(y) ? 1 : 0;
    }
  }
}

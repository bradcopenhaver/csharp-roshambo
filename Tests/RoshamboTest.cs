using System;
using System.Collections.Generic;
using Xunit;
using Roshambo.Objects;

namespace Roshambo
{
  public class GameTest
  {
    [Fact]
    public void Shoot_Draw_true()
    {
      //Arrange
      Game testGame = new Game("qi");
      string expectedResult = "Draw";
      //Act
      testGame.Shoot();
      string result = testGame.GetOutcome();
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData("qo", "Player 1 Wins!")]
    [InlineData("wp", "Player 1 Wins!")]
    [InlineData("ei", "Player 1 Wins!")]
    [InlineData("wi", "Player 2 Wins!")]
    [InlineData("qp", "Player 2 Wins!")]
    [InlineData("eo", "Player 2 Wins!")]
    [InlineData("iw", "Player 2 Wins!")]
    [InlineData("pq", "Player 2 Wins!")]
    [InlineData("oe", "Player 2 Wins!")]
    [InlineData("oq", "Player 1 Wins!")]
    [InlineData("pw", "Player 1 Wins!")]
    [InlineData("ie", "Player 1 Wins!")]
    public void Contains(string input, string expectedResult)
    {
      //Arrange
      Game testGame = new Game(input);
      //Act
      testGame.Shoot();
      string result = testGame.GetOutcome();
      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}

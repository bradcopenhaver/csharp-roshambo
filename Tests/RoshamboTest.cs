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
      Game testGame = new Game("rr");
      string expectedResult = "Draw";
      //Act
      string result = testGame.Shoot();
      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}

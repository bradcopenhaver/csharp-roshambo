using Nancy;
using System.Collections.Generic;
using Roshambo.Objects;

namespace Roshambo
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["index.cshtml"];
      };
      Post["/result"] = _ =>{
        Game newGame = new Game(Request.Form["player-input"]);
        string result = newGame.Shoot();
        return View["index.cshtml", result];
      };
    }
  }
}

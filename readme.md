# osu!API
### A C# osu! API Wrapper

This is a simple API that provides an Interface for forming the requests for stats and info to the osu! servers. Models are also provided for easy Serialisation and accuracy calculators for osu! and osu!Taiko provided as a nice addon

## Usage

```
using DragonFruit.osu.API;
using DragonFruit.osu.API.Network;
using DragonFruit.osu.API.Models;
using System.Linq;

Auth.SetAPIKey("apikey goes here");

//form a request
var request = new RequestModel
{
  Name = "PaPaCurry",
  IsUserAnID = false
  //you can also have beatmaps and other stuff in here - the api key is auto added
};

var x = await Requests.Make<User>(Endpoints.UserInfo,request); //make the request and serialise it to the User model
Console.WriteLine(x.First().UserID); //print ID
```
//Chris Martinez
// 10/25/22
//Say Hello End Point - Challenge
// Peer Review: Arely Martinez - All the names are correct for each naming convention, like the controller name and the string correclate to the assignment.

using Microsoft.AspNetCore.Mvc;

namespace MartinezCSayHelloEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHolaController : ControllerBase
{
 [HttpGet]
 [Route("Hello/{name}")]

 public string SayHello(string name)
 {

  return $"What up {name}";

 }

}

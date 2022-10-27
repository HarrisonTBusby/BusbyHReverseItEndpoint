//Harrison Busby
//10/27/2022
//Reverse It Endpoint
//Peer reviewed by: Arely Martinez : The program worked as intended. My input was revered and I was shown my original input as well. 
//Harrison’s code was very neat, making it easy to read and understand what was going on.  
//Try adding in more in the return so the user knows what’s going on though. Like original output: and your output but reversed: … Overall looks good.




using Microsoft.AspNetCore.Mvc;

namespace BusbyHReverseItEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItController : ControllerBase
{

[HttpGet]
[Route("ReverseIt/{phrase}")]

public string ReverseIt(string phrase){

string reverse = "";

for(int i = phrase.Length -1; i >=0; i--){

    reverse = reverse + phrase[i];
}

return $"{phrase} | {reverse}";


}
}

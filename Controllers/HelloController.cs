using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {

        [HttpGet]

        public IActionResult CreateMessage()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='lang'>" +
                    "<option value=''>* Select One *</option>" +
                    "<option value='English'>English</option>" +
                    "<option value='Spanish'>Spanish</option>" +
                    "<option value='French'>French</option>" +
                    "<option value='German'>German</option>" +
                    "<option value='Japense'>Japense</option>" +
                "<input type='submit' value='Greet Me'/>" +
                "</form>";

            return Content(html, "text/html");
        }

        [HttpPost]
        public IActionResult Welcome(string name = "World", string lang = "English")
        {
            if (lang == "English")
            {
                return Content("<h1>Hello " + name + "!</h1>", "text/html");
            }
            else if (lang == "Spanish")
            {
                return Content("<h1>Hola " + name +"!</h1>", "text/html");
            }
            else if(lang == "French")
            {
                return Content("<h1>Bonjour " + name + "!</h1>", "text/html");
            }
            else if(lang == "German")
            {
                return Content("<h1>Hallo " + name + "!</h1>", "text/html");
            }
            else if (lang == "Japense")
            {
                return Content("<h1>Kon'nichiwa " + name + "!</h1>", "text/html");
            }
            else
            {
                return Content("<h1>Hello " + name + "!</h1>", "text/html");
            }
        }
    }
}

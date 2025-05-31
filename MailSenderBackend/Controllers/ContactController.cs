using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class ContactController : Controller
{
    [HttpPost("/sendmail")]
    public async Task<IActionResult> SendMail([FromForm] ContactFormModel model)
    {
        if (!ModelState.IsValid) return BadRequest("Invalid data");
        
        await MailService.SendMailAsync(model.Name, model.Email, model.Subject, model.Message);
        return Ok("Email sent successfully");
    }
}

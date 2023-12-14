using Microsoft.AspNetCore.Mvc;
using MindPlusForm.Contracts.Repository;
using MindPlusForm.Repository;

namespace MindPlusForm.Controllers
{
    [ApiController]
    [Route("employee/login")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository LoginRepository;

        public LoginController(ILoginRepository _loginRepository)
        {
            LoginRepository = _loginRepository;
        }


        [HttpGet("Authentication")]
        public async Task<IActionResult> LoginAuthetication(string email, string password)
        {
            return Ok(await LoginRepository.LoginAuthentication(email, password));
        }
    }
}

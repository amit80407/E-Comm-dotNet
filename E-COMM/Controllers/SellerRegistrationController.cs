using E_COMM.Models;
using E_COMM.Repository;
using Microsoft.AspNetCore.Mvc;

namespace E_COMM.Controllers
{
    [ApiController]
    public class SellerRegistrationController : ControllerBase
    {
       
        private readonly IRegistration _registration;
        public SellerRegistrationController(IRegistration registration)
        {
            _registration = registration;
        }

        [HttpPost]
        [Route("userRegistration")]
        public IActionResult userRegistration(SellerRegistration userdata)
        {
            bool check = _registration.UserRegistration(userdata);
            if(check==true)
            {
                return Ok(new { message = "inserted" });
            }
            else
            {
                return Ok(new { message = "notinserted" });
            }
        }
    }
}
